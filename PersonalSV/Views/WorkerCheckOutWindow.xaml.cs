using PersonalSV.Controllers;
using PersonalSV.Helpers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for WorkerCheckOutWindow.xaml
    /// </summary>
    public partial class WorkerCheckOutWindow : Window
    {
        BackgroundWorker bwLoad;
        List<EmployeeModel> employeeList;
        private List<WorkerCheckInModel> workerCheckInList;
        private List<WorkListModel> workListByIdToDay;
        private List<WorkListModel> workListByDate;

        private string lblResourceNotFound = "", lblDoNotCheckIn = "", lblNotExistInWorkList = "";
        private string lblInfoTestDate = "", lblInfoCheckIn = "", lblInfoCheckOut = "";

        string lblMainHeader = "";

        private DateTime toDay = DateTime.Now.Date;
        
        public WorkerCheckOutWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;
            
            employeeList = new List<EmployeeModel>();
            workerCheckInList = new List<WorkerCheckInModel>();
            workListByIdToDay = new List<WorkListModel>();
            workListByDate = new List<WorkListModel>();

            lblMainHeader = LanguageHelper.GetStringFromResource("workerCheckOutTitle");

            lblResourceNotFound = LanguageHelper.GetStringFromResource("messageNotFound");
            lblDoNotCheckIn = LanguageHelper.GetStringFromResource("workerCheckOutMessageDoNotCheckIn");
            lblInfoTestDate = LanguageHelper.GetStringFromResource("workerCheckOutStatisticsCheckOutDate");
            lblInfoCheckIn = LanguageHelper.GetStringFromResource("workerCheckOutStatisticsCheckIn");
            lblInfoCheckOut = LanguageHelper.GetStringFromResource("workerCheckOutStatisticsCheckOut");

            lblNotExistInWorkList = LanguageHelper.GetStringFromResource("workerCheckInMessageNotExistInTestList");

            InitializeComponent();
        }

        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;

            DoStatistics(workerCheckInList);
            txtCardId.IsEnabled = true;
            SetTxtDefault();
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetForScan();
                workerCheckInList = WorkerCheckInController.GetByDate(toDay);
                workListByDate = WorkListController.GetByDate(toDay);
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
            brDisplay.Background = Brushes.WhiteSmoke;
            toDay = DateTime.Now.Date;
            // Refresh Main Header
            tblTitle.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblMainHeader, toDay);

            if (e.Key == Key.Enter)
            {
                // get worker by cardid
                string scanWhat = txtCardId.Text.Trim().ToUpper().ToString();
                var empById = employeeList.FirstOrDefault(f => f.EmployeeCode == scanWhat);
                if (empById != null)
                {
                    try
                    {
                        workListByIdToDay = WorkListController.GetByEmpId(empById.EmployeeID).Where(w => w.TestDate == toDay).ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                        SetTxtDefault();
                        return;
                    }

                    // Check In or Not
                    var checkInByEmpCode = workerCheckInList.Where(w => w.EmployeeCode == empById.EmployeeCode && !String.IsNullOrEmpty(w.RecordTime) && w.CheckType == 0).ToList();
                    if (checkInByEmpCode.Count() != 0 && workListByIdToDay.Count() > 0)
                    {
                        AddRecord(empById);
                    }
                    else
                    {
                        if (workListByIdToDay.Count() == 0)
                        {
                            string notExistInWorklist = string.Format("{0}: {1:dd/MM/yyyy}", lblNotExistInWorkList, toDay);
                            AlertCheckOut(notExistInWorklist, Brushes.Yellow, empById);
                        }
                        else
                        {
                            string alertDoNotCheckIn = string.Format("{0}: {1:dd/MM/yyyy}", lblDoNotCheckIn, toDay);
                            AlertCheckOut(alertDoNotCheckIn, Brushes.Yellow, empById);
                        }

                    }

                    DoStatistics(workerCheckInList);
                }
                else
                {
                    var notFound = new WorkerCheckInModel
                    {
                        EmployeeName = scanWhat,
                        RecordTime = lblResourceNotFound,
                    };
                    grDisplay.DataContext = notFound;
                    SetTxtDefault();
                }
            }
        }
        private void AlertCheckOut(string msg, SolidColorBrush color, EmployeeModel empById)
        {
            brDisplay.Background = color;
            var alertDisplay = new WorkerCheckInModel
            {
                EmployeeName = empById.EmployeeName,
                EmployeeID = empById.EmployeeID,
                RecordTime = msg
            };
            grDisplay.DataContext = alertDisplay;
            SetTxtDefault();
        }
        private void AddRecord(EmployeeModel empById)
        {
            var record = new WorkerCheckInModel()
            {
                Id              = Guid.NewGuid().ToString(),
                EmployeeCode    = empById.EmployeeCode,
                EmployeeID      = empById.EmployeeID,
                EmployeeName    = empById.EmployeeName,
                DepartmentName  = empById.DepartmentName,
                CheckType       = 1,
                CheckInDate     = DateTime.Now,
                RecordTime      = String.Format("{0:HH:mm}", DateTime.Now),
                Foreground      = Brushes.DarkGreen
            };

            try
            {
                WorkerCheckInController.Insert(record);
                workerCheckInList = WorkerCheckInController.GetByDate(toDay);

                var workerTestOKToday = new WorkListModel
                {
                    EmployeeID = record.EmployeeID,
                    TestDate = DateTime.Now.Date,
                    TestStatus = 1,
                };
                WorkListController.UpdateTestStatus(workerTestOKToday);

                grDisplay.DataContext = record;
                SetTxtDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                SetTxtDefault();
            }
        }

        private void DoStatistics(List<WorkerCheckInModel> workerCheckInList)
        {
            var workListIdToday = workListByDate.Select(s => s.EmployeeID).Distinct().ToList();
            var employeeByWorkListToday = employeeList.Where(w => workListIdToday.Contains(w.EmployeeID)).Select(s => s.EmployeeCode).Distinct().ToList();
            var totalCheckedIn = workerCheckInList.Where(w => !string.IsNullOrEmpty(w.RecordTime) && w.CheckType == 0
                                                            && employeeByWorkListToday.Contains(w.EmployeeCode)).Select(s => s.EmployeeCode).Distinct().ToList().Count();
            var totalCheckedOut = workerCheckInList.Where(w => !string.IsNullOrEmpty(w.RecordTime) && w.CheckType == 1).Select(s => s.EmployeeCode).Distinct().ToList().Count();

            var displayModel = new CheckOutStatistics
            {
                TestDate = string.Format("{0}: {1:dd/MM/yyyy}", lblInfoTestDate, toDay),
                CheckIn = string.Format("{0}: {1}", lblInfoCheckIn, totalCheckedIn),
                CheckOut = string.Format("{0}: {1} / {2}", lblInfoCheckOut, totalCheckedOut, totalCheckedIn)
            };

            grStatistics.DataContext = null;
            grStatistics.DataContext = displayModel;
        }

        private void SetTxtDefault()
        {
            txtCardId.SelectAll();
            txtCardId.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tblTitle.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblMainHeader, toDay);
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }

        private void txtCardId_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtCardId.SelectAll();
        }
        private class CheckOutStatistics
        {
            public string TestDate { get; set; }
            public string CheckIn { get; set; }
            public string CheckOut { get; set; }
        }
    }
}

