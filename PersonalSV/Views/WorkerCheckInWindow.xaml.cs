using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using PersonalSV.Controllers;
using PersonalSV.Helpers;
using PersonalSV.Models;
using PersonalSV.ViewModels;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for WorkerCheckInWindow.xaml
    /// </summary>
    public partial class WorkerCheckInWindow : Window
    {
        DispatcherTimer clock;
        BackgroundWorker bwLoad;
        List<EmployeeModel> employeeList;

        private string lblResourceNotFound = "", lblNotExitsInWorkList = "", lblNotAllowed = "", lblNotExistInTestList = "";
        private string lblInfoTestDate = "", lblInfoTotalWorkList = "", lblInfoScanned = "", lblInfoRatio = "";
        

        private List<WorkListModel> workList;
        private List<WorkListModel> workListStatistics;
        private List<WorkerCheckInModel> workerCheckInList;

        private DateTime toDay = DateTime.Now.Date;
        public WorkerCheckInWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            employeeList = new List<EmployeeModel>();
            workList = new List<WorkListModel>();
            workListStatistics = new List<WorkListModel>();
            workerCheckInList = new List<WorkerCheckInModel>();

            lblResourceNotFound = LanguageHelper.GetStringFromResource("messageNotFound");
            lblNotExitsInWorkList = LanguageHelper.GetStringFromResource("workerCheckInMessageNotPriority");
            lblNotAllowed = LanguageHelper.GetStringFromResource("workerCheckInMessageNotAllowed");
            lblNotExistInTestList = LanguageHelper.GetStringFromResource("workerCheckInMessageNotExistInTestList");

            lblInfoTestDate = LanguageHelper.GetStringFromResource("workerCheckInStatisticsTestDate");
            lblInfoTotalWorkList = LanguageHelper.GetStringFromResource("workerCheckInStatisticsTotalWorkList");
            lblInfoScanned = LanguageHelper.GetStringFromResource("workerCheckInStatisticsCurrentScan");
            lblInfoRatio = LanguageHelper.GetStringFromResource("workerCheckInStatisticsRatio");


            clock = new DispatcherTimer();
            clock.Tick += Clock_Tick;
            clock.Start();

            InitializeComponent();
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            Dispatcher.Invoke(new Action(() => {
                lblClock.Text = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            }));
        }
        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            DoStatistics(workListStatistics, workerCheckInList);

            txtCardId.IsEnabled = true;
            SetTxtDefault();
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetAvailable();
                
                workListStatistics = WorkListController.GetByDate(toDay);
                workerCheckInList = WorkerCheckInController.GetByDate(toDay);
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
            grDisplay.DataContext = null;
            this.Background = Brushes.WhiteSmoke; 
            brDisplay.Background = Brushes.WhiteSmoke;

            if (e.Key == Key.Enter)
            {
                // get worker by cardid
                string scanWhat = txtCardId.Text.Trim().ToUpper().ToString();
                var empById = employeeList.FirstOrDefault(f => f.EmployeeCode == scanWhat);
                if (empById != null)
                {
                    try
                    {
                        workList = WorkListController.GetByEmpId(empById.EmployeeID);
                        workListStatistics = WorkListController.GetByDate(toDay);
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
                        var workListToday = workList.Where(w => w.TestDate == toDay).ToList();
                        // Check Worker in worklist today
                        if (workListToday.Count() > 0)
                        {
                            // Check Status
                            var workerWithStatusToDay = workListToday.FirstOrDefault();
                            if (workerWithStatusToDay != null)
                            {
                                if (workerWithStatusToDay.TestStatus == 2)
                                {
                                    AlertScan(lblNotAllowed, Brushes.Red, empById);
                                }
                                else if (workerWithStatusToDay.TestStatus == 1)
                                {
                                    brDisplay.Background = Brushes.Green;
                                    AddRecord(empById);
                                }
                                else if (workerWithStatusToDay.TestStatus == 0)
                                {
                                    brDisplay.Background = Brushes.Yellow;
                                    AddRecord(empById);
                                }
                            }
                        }
                        // Check History Nearest
                        else
                        {
                            // Check Status
                            var workerWithStatusHistory = workList.Where(w => w.TestDate < toDay).OrderBy(o => o.TestDate).LastOrDefault();
                            if (workerWithStatusHistory != null)
                            {
                                if (workerWithStatusHistory.TestStatus == 2)
                                {
                                    AlertScan(lblNotAllowed, Brushes.Red, empById);
                                }
                                else if (workerWithStatusHistory.TestStatus == 1)
                                {
                                    brDisplay.Background = Brushes.Green;
                                    AddRecord(empById);
                                }
                                else if (workerWithStatusHistory.TestStatus == 0)
                                {
                                    string msgNotExistInWorkListToday = string.Format("{0} - {1:dd/MM/yyyy}", lblNotExistInTestList, toDay);
                                    AlertScan(msgNotExistInWorkListToday, Brushes.Red, empById);
                                }
                            }
                            else
                            {
                                string msgNotExistInWorkListToday = string.Format("{0} - {1:dd/MM/yyyy}", lblNotExistInTestList, toDay);
                                AlertScan(msgNotExistInWorkListToday, Brushes.Red, empById);
                            }
                        }

                        DoStatistics(workListStatistics, workerCheckInList);
                    }
                    else
                    {
                        AlertScan(lblNotExitsInWorkList, Brushes.Red, empById);
                    }                   
                }
                else
                {
                    var notFound = new WorkerCheckInModel
                    {
                        EmployeeName = scanWhat,
                        RecordTime = lblResourceNotFound
                    };
                    grDisplay.DataContext = notFound;
                    SetTxtDefault();
                }
                
                // Refresh Counter
            }
        }

        private void DoStatistics(List<WorkListModel> workListStatistics, List<WorkerCheckInModel> workerCheckInList)
        {
            var totalWorker = workListStatistics.Select(s => s.EmployeeID).Distinct().ToList().Count();
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
            var alert = new WorkerCheckInModel
            {
                EmployeeName = empById.EmployeeName,
                EmployeeID = empById.EmployeeID,
                RecordTime = msg
            };
            grDisplay.DataContext = alert;
            SetTxtDefault();
        }
        
        private void AddRecord( EmployeeModel empById)
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
                grDisplay.DataContext = record;
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

        private void SetTxtDefault()
        {
            txtCardId.SelectAll();
            txtCardId.Focus();
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
    }
}
