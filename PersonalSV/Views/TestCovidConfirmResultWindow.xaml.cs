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
    /// Interaction logic for TestCovidConfirmResultWindow.xaml
    /// </summary>
    public partial class TestCovidConfirmResultWindow : Window
    {
        BackgroundWorker bwLoad;
        BackgroundWorker bwSave;
        BackgroundWorker bwDateChange;
        private string lblResourceHeader = "";
        List<EmployeeModel> employeeList;
        private DateTime dateConfirm = DateTime.Now.Date;

        WorkListModel workerTestToday;
        List<WorkListModel> testListByDate;
        private PrivateDefineModel def;
        List<string> results;
        public TestCovidConfirmResultWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            bwSave = new BackgroundWorker();
            bwSave.DoWork += BwSave_DoWork;
            bwSave.RunWorkerCompleted += BwSave_RunWorkerCompleted;

            bwDateChange = new BackgroundWorker();
            bwDateChange.DoWork += BwDateChange_DoWork;
            bwDateChange.RunWorkerCompleted += BwDateChange_RunWorkerCompleted;

            lblResourceHeader = LanguageHelper.GetStringFromResource("confirmTestResultHeader");

            employeeList = new List<EmployeeModel>();

            workerTestToday = new WorkListModel();
            testListByDate = new List<WorkListModel>();
            def = new PrivateDefineModel();
            results = new List<string>();

            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            var ui = brDisplay.DataContext as ConfirmResultInfo;
            if (ui == null)
                return;

            var updateWorkerTestToDay = workerTestToday;
            if (bwSave.IsBusy == false && updateWorkerTestToDay != null)
            {
                workerTestToday.TestStatus = cboResult.SelectedIndex;

                this.Cursor = Cursors.Wait;
                btnSave.IsEnabled = false;
                bwSave.RunWorkerAsync(updateWorkerTestToDay);
            }
        }
        
        private void BwSave_DoWork(object sender, DoWorkEventArgs e)
        {
            var workerTestUpdateModel = e.Argument as WorkListModel;
            try
            {
                WorkListController.Insert_2(workerTestUpdateModel);
                // F1 Case
                if (workerTestUpdateModel.TestStatus == 3)
                {
                    // Create TestSchedule for next 3 days
                    var f1NextTestDate = dateConfirm.AddDays(def.F1Round);
                    for (double r = 1; r <= def.F1Schedule; r++)
                    {
                        f1NextTestDate = f1NextTestDate.AddDays(1);
                        if (f1NextTestDate.DayOfWeek == DayOfWeek.Sunday)
                            f1NextTestDate= f1NextTestDate.AddDays(1);

                        workerTestUpdateModel.TestDate = f1NextTestDate;
                        workerTestUpdateModel.Remarks = "F1 Schedule";
                        workerTestUpdateModel.TestTime = "07:30F1";
                        workerTestUpdateModel.TestStatus = 0;

                        WorkListController.Insert_2(workerTestUpdateModel);
                    }
                }
                testListByDate = WorkListController.GetByDate(dateConfirm);
                e.Result = true;
            }
            catch (Exception ex)
            {
                e.Result = false;
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.InnerException.Message.ToString());
                }));
            }
        }
        
        private void BwSave_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result)
            {
                MessageBox.Show("Successful !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            this.Cursor = null;
            SetTxtDefault();
            btnSave.IsEnabled = true;
            DoCounter(testListByDate);
            ClearUI();
        }
        
        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            txtCardId.IsEnabled = true;

            SetTxtDefault();
            btnSave.IsEnabled = true;
            if (def.Results.Contains(","))
            {
                foreach (var x in def.Results.Split(','))
                {
                    results.Add(x.Trim());
                }
            }
            cboResult.ItemsSource = results;
            cboResult.SelectedItem = results[0];

            DoCounter(testListByDate);
            dpConfirmDate.SelectedDate = dateConfirm;
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetForScan();
                def = CommonController.GetDefineProps();
                testListByDate = WorkListController.GetByDate(dateConfirm);
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.InnerException.Message.ToString());
                }));
            }
        }

        private void txtCardId_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ClearUI();
                string findWhat = txtCardId.Text.Trim().ToUpper().ToString();
                var empByCode = employeeList.FirstOrDefault(f => f.EmployeeCode.Trim().ToUpper() == findWhat
                                                            || f.EmployeeID.Trim().ToUpper() == findWhat);
                if (empByCode != null)
                {
                    try
                    {
                        workerTestToday = WorkListController.GetByEmpId(empByCode.EmployeeID).Where(w => w.TestDate == dateConfirm).FirstOrDefault();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.Message.ToString());
                        return;
                    }

                    var testDate = dateConfirm;
                    if (workerTestToday != null)
                    {
                        testDate = workerTestToday.TestDate;
                        if (workerTestToday.TestStatus == 0)
                            cboResult.SelectedItem = results[0];
                        else if (workerTestToday.TestStatus == 1)
                            cboResult.SelectedItem = results[1];
                        else if (workerTestToday.TestStatus == 2)
                            cboResult.SelectedItem = results[2];
                        else if (workerTestToday.TestStatus == 3)
                            cboResult.SelectedItem = results[3];
                        else
                            cboResult.SelectedItem = results[4];
                    }
                    else
                    {
                        workerTestToday = new WorkListModel
                        {
                            EmployeeID = empByCode.EmployeeID,
                            TestDate = dateConfirm,
                            TestStatus = 0,
                            TestTime = "",
                            WorkTime = "",
                            Remarks = "",
                        };
                    }

                    var confirmResultInfo = new ConfirmResultInfo
                    {
                        Id = Guid.NewGuid().ToString(),
                        EmployeeName = empByCode.EmployeeName,
                        EmployeeCode = empByCode.EmployeeCode,
                        EmployeeID = empByCode.EmployeeID,
                        DepartmentName = empByCode.DepartmentName,
                        TestDate = string.Format("{0:dd/MM/yyyy}", testDate),
                        TestTime = workerTestToday.TestTime,
                        Remarks =  workerTestToday.Remarks
                    };
                    brDisplay.DataContext = confirmResultInfo;
                }
                else
                {
                    MessageBox.Show("Worker Not Found !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                }
                SetTxtDefault();
            }
        }

        private void ClearUI()
        {
            brDisplay.DataContext = null;
            brDisplay.Background = Brushes.WhiteSmoke;

            cboResult.ItemsSource = results;
            cboResult.SelectedItem = results[0];
            txtConfirmBy.Text = "";
            txtRemark.Text = "";
            txtCardId.Focus();
        }
        
        private void txtCardId_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtCardId.SelectAll();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bwLoad.IsBusy == false)
            {
                lblHeader.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblResourceHeader, dateConfirm);
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }
        
        private void SetTxtDefault()
        {
            txtCardId.SelectAll();
            txtCardId.Focus();
        }
        
        private void DoCounter(List<WorkListModel> testListToDay)
        {
            lblConfirmed.Text = "";
            lblTotalCheckIn.Text = "";

            int confirmed = testListToDay.Where(w => w.TestStatus != 0).Select(s => s.EmployeeID).Distinct().ToList().Count();
            lblConfirmed.Text = string.Format("Total: {0}", testListToDay.Select(s => s.EmployeeID).Distinct().ToList().Count());
            lblTotalCheckIn.Text = string.Format("Confirmed: {0}", confirmed);
        }

        private class ConfirmResultInfo
        {
            public string Id { get; set; }
            public string EmployeeName { get; set; }
            public string EmployeeCode { get; set; }
            public string EmployeeID { get; set; }
            public string DepartmentName { get; set; }
            public string TestDate { get; set; }
            public string TestTime { get; set; }
            public string Remarks { get; set; }
        }

        private void dpConfirmDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dateConfirm = dpConfirmDate.SelectedDate.Value.Date;
            if (dateConfirm > DateTime.Now.Date)
            {
                MessageBox.Show("Can not select a date grather than today. Please try again !\nKhông chọn được ngày lớn hơn ngày hôm nay !", this.Title, MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            if (bwDateChange.IsBusy == false && this.IsLoaded)
            {
                dateConfirm = dpConfirmDate.SelectedDate.Value.Date;
                if (dateConfirm > DateTime.Now.Date)
                    return;

                dpConfirmDate.IsEnabled = false;
                lblHeader.Text = string.Format("{0}: {1:dd/MM/yyyy}", lblResourceHeader, dateConfirm);
                this.Cursor = Cursors.Wait;
                bwDateChange.RunWorkerAsync();
            }
        }
        private void BwDateChange_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            dpConfirmDate.IsEnabled = true;
            cbChangeConfirmDate.IsChecked = false;
            ClearUI();
        }

        private void BwDateChange_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                employeeList = EmployeeController.GetForScan();
                testListByDate = WorkListController.GetByDate(dateConfirm);
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.InnerException.Message.ToString());
                }));
            }
        }
        private void cbChangeConfirmDate_Checked(object sender, RoutedEventArgs e)
        {
            dpConfirmDate.Visibility = Visibility.Visible;
        }

        private void cbChangeConfirmDate_Unchecked(object sender, RoutedEventArgs e)
        {
            dpConfirmDate.Visibility = Visibility.Collapsed;
        }

        private void cboResult_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            brDisplay.Background = Brushes.WhiteSmoke;
            var x = cboResult.SelectedIndex;
            if (x == 1)
            {
                brDisplay.Background = Brushes.Green;
            }
            if (x == 2 || x == 3)
            {
                brDisplay.Background = Brushes.Red;
            }
        }
    }
}
