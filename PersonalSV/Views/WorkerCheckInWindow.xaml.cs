using PersonalSV.Controllers;
using PersonalSV.Helpers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for WorkerCheckInWindow.xaml
    /// </summary>
    public partial class WorkerCheckInWindow : Window
    {
        BackgroundWorker bwLoad;
        List<EmployeeModel> employeeList;

        private string lblResourceNotFound = "", lblNotExitsInWorkList = "", lblNotAllowed = "", lblNotExistInTestList = "";
        private string lblInfoTestDate = "", lblInfoTotalWorkList = "", lblInfoScanned = "", lblInfoRatio = "";
        private string lblNextTestDate = "", lblTestTime = "", lblWorkTime = "", lblGetInQueue = "", lblDidNotCompleted = "", lblNotInTestTime = "", lblTestMessage = "";

        private PrivateDefineModel defModel;
        private List<WorkListModel> workList;
        private List<WorkListModel> workListAll;
        private List<WorkerCheckInModel> workerCheckInList;

        private LinearGradientBrush greenYellowColor = new LinearGradientBrush();

        private DateTime toDay = DateTime.Now.Date;
        private DateTime dtDefault = new DateTime(2000, 1, 1);
        private string afternoonStone = "";
        private MediaPlayer mediaAlarm;
        public WorkerCheckInWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            defModel = new PrivateDefineModel();
            employeeList = new List<EmployeeModel>();
            workList = new List<WorkListModel>();
            workListAll = new List<WorkListModel>();
            workerCheckInList = new List<WorkerCheckInModel>();

            lblResourceNotFound     = LanguageHelper.GetStringFromResource("messageNotFound");
            lblNotExitsInWorkList   = LanguageHelper.GetStringFromResource("workerCheckInMessageNotPriority");
            lblNotAllowed           = LanguageHelper.GetStringFromResource("workerCheckInMessageNotAllowed");
            lblNotExistInTestList   = LanguageHelper.GetStringFromResource("workerCheckInMessageNotExistInTestList");

            lblInfoTestDate         = LanguageHelper.GetStringFromResource("workerCheckInStatisticsTestDate");
            lblInfoTotalWorkList    = LanguageHelper.GetStringFromResource("workerCheckInStatisticsTotalWorkList");
            lblInfoScanned          = LanguageHelper.GetStringFromResource("workerCheckInStatisticsCurrentScan");
            lblInfoRatio            = LanguageHelper.GetStringFromResource("workerCheckInStatisticsRatio");

            lblNextTestDate         = LanguageHelper.GetStringFromResource("workerCheckInLblNextTestDate");
            lblTestTime             = LanguageHelper.GetStringFromResource("workerCheckInLblTestTime");
            lblWorkTime             = LanguageHelper.GetStringFromResource("workerCheckInLblWorkTime");
            lblGetInQueue           = LanguageHelper.GetStringFromResource("workerCheckInLblGetInQueue");
            lblDidNotCompleted      = LanguageHelper.GetStringFromResource("workerCheckInMessageNotYetCompleteCovidTest");
            lblNotInTestTime        = LanguageHelper.GetStringFromResource("workerCheckInMessageNotInTestTime");

            greenYellowColor        = (LinearGradientBrush)TryFindResource("AlertGreenYellow");

            InitializeComponent();
        }
        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            DoStatistics(workListAll, workerCheckInList);

            txtCardId.IsEnabled = true;
            SetTxtDefault();
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetForScan();
                workListAll = WorkListController.Get();
                workerCheckInList = WorkerCheckInController.GetByDate(toDay);
                defModel = CommonController.GetDefineProps();

                afternoonStone = defModel.AfternoonStone;
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message.ToString());
                }));
            }
        }    
        
        private void txtCardId_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            lblTestMessage = lblGetInQueue;
            var currentTime = string.Format("{0:HH:mm}", DateTime.Now);
            grDisplay.DataContext = null;
            this.Background = Brushes.WhiteSmoke;
            brDisplay.Background = Brushes.WhiteSmoke;
            var timeInSourceList = new List<SourceModel>();
            var todayBeforeWeek = toDay.AddDays(-7);
            if (e.Key == Key.Enter)
            {
                // get worker by cardid
                string scanWhat = txtCardId.Text.Trim().ToUpper().ToString();
                var empById = employeeList.FirstOrDefault(f => f.EmployeeCode.Trim().ToUpper().ToString() == scanWhat);
                if (empById != null)
                {
                    try
                    {
                        timeInSourceList = SourceController.SelectSourceByEmpCodeFromTo(empById.EmployeeCode, todayBeforeWeek, toDay.AddDays(-1)).OrderByDescending(o => o.SourceDate).ToList();
                        workList = WorkListController.GetByEmpId(empById.EmployeeID);
                        defModel = CommonController.GetDefineProps();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        SetTxtDefault();
                        return;
                    }
                    // Check in worklist
                    if (workList.Count() > 0)
                    {
                        var testToday   = workList.Where(w => w.TestDate == toDay && string.IsNullOrEmpty(w.Remarks)).ToList();
                        var testNextDay = workList.Where(w => w.TestDate > toDay).ToList();
                        var testBefore  = workList.Where(w => w.TestDate < toDay).ToList();

                        // Check Absent Yesterday
                        var yesterday = toDay.AddDays(-1);
                        var timeInYesterDay = timeInSourceList.Where(w => w.SourceDate == yesterday).ToList();
                        if (timeInYesterDay.Count() == 0 && yesterday.DayOfWeek == DayOfWeek.Sunday)
                        {
                            yesterday = toDay.AddDays(-1);
                            timeInYesterDay = timeInSourceList.Where(w => w.SourceDate == yesterday).ToList();
                        }

                        // Morning
                        if (String.Compare(currentTime, afternoonStone) < 1)
                        {
                            if (testToday.Count() > 0)
                            {
                                CheckWorkerTestToday(testToday, empById, testBefore);
                            }
                            else if (timeInSourceList.Count() > 0 && timeInYesterDay.Count == 0)
                            {
                                CheckWorkerAbsentYesterday(empById, timeInSourceList);
                            }
                            else if (testBefore.Count() > 0)
                            {
                                CheckWorkerTestBeforeToday(testBefore, empById);
                            }
                        }
                        // Afternoon
                        else
                        {
                            if (testToday.Count() > 0)
                            {
                                CheckWorkerTestToday(testToday, empById, testBefore);
                            }
                            else if (timeInSourceList.Count() > 0 && timeInYesterDay.Count == 0)
                            {
                                CheckWorkerAbsentYesterday(empById, timeInSourceList);
                            }
                            else if (testNextDay.Count() > 0)
                            {
                                var workerTestNextDay = testNextDay.FirstOrDefault();
                                if (string.Compare(workerTestNextDay.TestTime, "12:00") < 1)
                                    brDisplay.Background = Brushes.Yellow;
                                else
                                    brDisplay.Background = greenYellowColor;

                                string nextTestDay = string.Format("{0}: {1:dd/MM/yyyy}", lblNextTestDate, workerTestNextDay.TestDate);
                                var testTime = String.Format("{0}: {1}", lblTestTime, workerTestNextDay.TestTime);
                                var workTime = string.IsNullOrEmpty(workerTestNextDay.WorkTime) == false ? String.Format("{0}: {1}", lblWorkTime, workerTestNextDay.WorkTime) : "";
                                AddRecord(empById, workerTestNextDay, nextTestDay, false, false, testTime, workTime, false);
                            }
                            else if (testBefore.Count() > 0)
                            {
                                CheckWorkerTestBeforeToday(testBefore, empById);
                            }
                        }

                        DoStatistics(workListAll, workerCheckInList);
                    }
                    else
                    {
                        AlertScan(lblNotExitsInWorkList, Brushes.Red, empById);
                        playAlarmSound();
                    }
                }
                else
                {
                    var notFound = new CheckInInfoDisplay
                    {
                        EmployeeDisplay = scanWhat,
                        NextTestDate = lblResourceNotFound
                    };
                    grDisplay.DataContext = notFound;
                    SetTxtDefault();
                }
            }
        }

        private void CheckWorkerAbsentYesterday(EmployeeModel empById, List<SourceModel> timeInList)
        {
            var workDayNearest = timeInList.Max(m => m.SourceDate);
            var absentDay = workDayNearest.AddDays(1);
            if (absentDay.DayOfWeek == DayOfWeek.Sunday)
                absentDay = workDayNearest.AddDays(1);

            var insertItem = new WorkListModel
            {
                EmployeeID = empById.EmployeeID,
                TestDate = toDay,
                TestStatus = 0,
                TestTime = "",
                WorkTime = "",
                Remarks = string.Format("absent {0:dd/MM/yyyy}", absentDay)
            };
            // Add to Worklist
            try
            {
                WorkListController.Insert(insertItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message.ToString());
                SetTxtDefault();
            }
            string testTime = string.Format("KHÔNG ĐI LÀM NGÀY: {0:dd/MM/yyyy}", absentDay);
            string nextTestDate = String.Format("{0}",lblTestMessage);
            AddRecord(empById, null, nextTestDate, false, false, "", testTime, true);
        }
        private void CheckWorkerTestToday(List<WorkListModel> testToday, EmployeeModel empById, List<WorkListModel> testBeforeToday)
        {
            var workerTestToday = testToday.FirstOrDefault();
            if (workerTestToday.TestStatus == 0)
            {
                string workTime = "";
                if (testBeforeToday.Count() == 0)
                    brDisplay.Background = Brushes.Yellow;
                else if (string.Compare(workerTestToday.TestTime, "12:00") < 1)
                    brDisplay.Background = Brushes.Yellow;
                else
                {
                    workTime = string.IsNullOrEmpty(workerTestToday.WorkTime) == false ? String.Format("{0}: {1}", lblWorkTime, workerTestToday.WorkTime) : "";
                    brDisplay.Background = greenYellowColor;
                }

                // Do Alarm Sound
                var alarmStone = string.Format("{0:HH:mm}", DateTime.Now.AddMinutes(defModel.AlarmMinutes));
                if (!string.IsNullOrEmpty(workerTestToday.TestTime))
                {
                    if (string.Compare(alarmStone, workerTestToday.TestTime) < 0)
                    {
                        lblTestMessage = string.Format("{0} ({1})", lblNotInTestTime, workerTestToday.TestTime);
                        playAlarmSound();
                        AlertScan(lblTestMessage, Brushes.Yellow, empById);
                        return;
                    }
                }

                var testTime = String.Format("{0}: {1}", lblTestTime, workerTestToday.TestTime);
                AddRecord(empById, workerTestToday, "", true, false, testTime, workTime, false);
            }
            else if (workerTestToday.TestStatus == 1)
            {
                brDisplay.Background = Brushes.Green;
                AddRecord(empById, null, "", false, true, "", "", false);
            }
            else if (workerTestToday.TestStatus >= 2)
            {
                AlertScan(lblNotAllowed, Brushes.Red, empById);
                playAlarmSound();
            }
        }

        private void CheckWorkerTestBeforeToday(List<WorkListModel> testBefore, EmployeeModel empById)
        {
            var workerTestLatest = testBefore.OrderBy(o => o.TestDate).LastOrDefault();
            if (workerTestLatest.TestStatus == 0)
            {
                brDisplay.Background = Brushes.Yellow;
                string didNotCompleteTest = string.Format("{0}: {1:dd/MM/yyyy}", lblDidNotCompleted, workerTestLatest.TestDate);
                AlertScan(didNotCompleteTest, Brushes.Yellow, empById);
            }
            else if (workerTestLatest.TestStatus == 1)
            {
                brDisplay.Background = Brushes.Green;
                AddRecord(empById, null, "", false, true, "", "", false);
            }
            else if (workerTestLatest.TestStatus >= 2)
            {
                AlertScan(lblNotAllowed, Brushes.Red, empById);
                playAlarmSound();
            }
        }
        
        private void AddRecord(EmployeeModel empById, WorkListModel WorkListNextTestById, string nextTestDay, bool getInQueue, bool welcome, string testTime, string workTime, bool absentYesterday)
        {
            var record = new WorkerCheckInModel()
            {
                Id = Guid.NewGuid().ToString(),
                EmployeeCode = empById.EmployeeCode,
                EmployeeID = empById.EmployeeID,
                EmployeeName = empById.EmployeeName,
                DepartmentName = empById.DepartmentName,
                CheckType = 0,
                CheckInDate = DateTime.Now,
                RecordTime = String.Format("{0:HH:mm}", DateTime.Now)
            };

            try
            {   
                if (getInQueue && !string.IsNullOrEmpty(testTime))
                {
                    nextTestDay = lblTestMessage;
                }

                var addInfoDisplay = new CheckInInfoDisplay
                {
                    EmployeeDisplay = String.Format("{0} - {1}", empById.EmployeeName, empById.EmployeeID),
                    DepartmentName = empById.DepartmentName,
                    RecordTime = String.Format("Time: {0}", record.RecordTime),
                    NextTestDate = nextTestDay,
                    WorkTime = workTime,
                    TestTime = testTime,
                };

                if(welcome)
                {
                    addInfoDisplay = new CheckInInfoDisplay
                    {
                        EmployeeDisplay = empById.EmployeeName,
                        DepartmentName = empById.EmployeeID,
                        RecordTime = empById.DepartmentName,
                        TestTime = String.Format("Time: {0}", record.RecordTime),
                    };
                }

                if (absentYesterday)
                {
                    brDisplay.Background = Brushes.Red;
                    addInfoDisplay.Foreground = Brushes.Yellow;
                    addInfoDisplay.TestTime = workTime;
                    addInfoDisplay.WorkTime = "YÊU CẦU TEST THÊM";
                }

                grDisplay.DataContext = addInfoDisplay;
                WorkerCheckInController.Insert(record);
                workerCheckInList.Add(record);

                SetTxtDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                SetTxtDefault();
            }
        }
        
        private void DoStatistics(List<WorkListModel> workListAll, List<WorkerCheckInModel> workerCheckInList)
        {
            var totalWorker = workListAll.Select(s => s.EmployeeID).Distinct().ToList().Count();
            var totalCheckedIn = workerCheckInList.Where(w => !string.IsNullOrEmpty(w.RecordTime) && w.CheckType == 0).Select(s => s.EmployeeCode).Distinct().ToList().Count();
            double percent = 0;
            if (totalWorker != 0)
            {
                percent = Math.Round(((double)totalCheckedIn / (double)totalWorker * 100), 1);
            }

            var displayModel = new CheckInStatistics
            {
                TestDate = string.Format("{0}: {1:dd/MM/yyyy}", lblInfoTestDate, toDay),
                TotalWorkList = string.Format("{0}: {1}", lblInfoTotalWorkList, totalWorker),
                Scanned = string.Format("{0}: {1} / {2}", lblInfoScanned, totalCheckedIn, totalWorker),
                Ratio = string.Format("{0}: {1} %", lblInfoRatio, percent)
            };

            grStatistics.DataContext = null;
            grStatistics.DataContext = displayModel;
        }

        private void AlertScan(string msg, SolidColorBrush color ,EmployeeModel empById)
        {
            brDisplay.Background = color;
            var alert = new CheckInInfoDisplay
            {
                //EmployeeDisplay = String.Format("{0} - {1}", empById.EmployeeName, empById.EmployeeID),
                EmployeeDisplay = empById.EmployeeName,
                DepartmentName = empById.EmployeeID,
                RecordTime = empById.DepartmentName,
                //RecordTime = msg
                WorkTime = msg,
                Foreground = Brushes.Black,
            };
            grDisplay.DataContext = alert;
            SetTxtDefault();
        }

        private void SetTxtDefault()
        {
            txtCardId.SelectAll();
            txtCardId.Focus();
        }

        private void playAlarmSound()
        {
            try
            {
                mediaAlarm = new MediaPlayer();
                mediaAlarm.Open(new Uri(@"Reports/alarm.mp3", UriKind.Relative));
                if (mediaAlarm.Source != null)
                    mediaAlarm.Play();
            }
            catch
            {
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //
            string lblResourceTitle = LanguageHelper.GetStringFromResource("workerCheckInTitle");
            tblTitle.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblResourceTitle, DateTime.Now);
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }

        private void dgWorkerCheckIn_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void txtCardId_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtCardId.SelectAll();
        }
        
        private class CheckInStatistics
        {
            public string TestDate { get; set; }
            public string TotalWorkList { get; set; }
            public string Scanned { get; set; }
            public string Ratio { get; set; }
        }
        
        private class CheckInInfoDisplay
        {
            public string EmployeeDisplay { get; set; }
            public string DepartmentName { get; set; }
            public string RecordTime { get; set; }
            public string NextTestDate { get; set; }
            public string WorkTime { get; set; }
            public string TestTime { get; set; }
            public string NextDayInfo { get; set; }

            public SolidColorBrush Foreground { get; set; } = Brushes.Black;
        }
    }
}
