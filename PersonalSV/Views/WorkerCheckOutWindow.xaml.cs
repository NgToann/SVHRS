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
    /// Interaction logic for WorkerCheckOutWindow.xaml
    /// </summary>
    public partial class WorkerCheckOutWindow : Window
    {
        DispatcherTimer clock;
        BackgroundWorker bwLoad;
        List<EmployeeModel> employeeList;
        List<WorkListModel> workList;
        private string lblResourceNotFound = "", lblNotExistInWorkListAlert = "", lblDoNotScan="";
        private DateTime toDay = DateTime.Now.Date;
        
        public WorkerCheckOutWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            
            employeeList = new List<EmployeeModel>();
            workList = new List<WorkListModel>();

            lblResourceNotFound = LanguageHelper.GetStringFromResource("messageNotFound");
            lblNotExistInWorkListAlert = LanguageHelper.GetStringFromResource("workerCheckInMessageNotPriority");
            lblDoNotScan = LanguageHelper.GetStringFromResource("workerCheckOutMessageDoNotScan");
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
            txtCardId.IsEnabled = true;
            SetTxtDefault();
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetAvailable();
                //workList = WorkListController.Get();
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        SetTxtDefault();
                        return;
                    }

                    var workListToDayByEmpId = workList.Where(w => w.TestDate == toDay).ToList();
                    if (workListToDayByEmpId.Count == 0)
                    {
                        brDisplay.Background = Brushes.Yellow;
                        var notExistInWorkList = new WorkerCheckInModel
                        {
                            EmployeeName = empById.EmployeeName,
                            EmployeeID = empById.EmployeeID,
                            RecordTime = string.Format("{0} {1:dd/MM/yyyy}", lblDoNotScan, toDay)
                        };
                        grDisplay.DataContext = notExistInWorkList;
                        SetTxtDefault();
                    }
                    else
                    {
                        AddRecord(empById);
                    }
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
        private void AddRecord(EmployeeModel empById)
        {
            var record = new WorkerCheckInModel()
            {
                Id = Guid.NewGuid().ToString(),
                EmployeeCode = empById.EmployeeCode,
                EmployeeID = empById.EmployeeID,
                EmployeeName = empById.EmployeeName,
                DepartmentName = empById.DepartmentName,
                CheckType = 1,
                CheckInDate = DateTime.Now,
                RecordTime = String.Format("{0:HH:mm}", DateTime.Now)
            };

            try
            {
                grDisplay.DataContext = record;
                //brDisplay.Background = Brushes.LightGreen;

                WorkerCheckInController.Insert(record);
                var workListModelUpdate = new WorkListModel
                {
                    EmployeeID = record.EmployeeID,
                    TestDate = DateTime.Now.Date,
                    TestStatus = 1
                };
                WorkListController.UpdateTestStatus(workListModelUpdate);
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
            string lblResourceTitle = LanguageHelper.GetStringFromResource("workerCheckOutTitle");
            tblTitle.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblResourceTitle, DateTime.Now);
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
    }
}

