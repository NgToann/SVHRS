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
    /// Interaction logic for WorkerCheckInReportWindow.xaml
    /// </summary>
    public partial class WorkerCheckInReportWindow : Window
    {
        List<WorkerCheckInModel> sources;
        List<EmployeeModel> employeeList;
        BackgroundWorker bwLoad;
        List<WorkListModel> workList;
        private int checkType = 2;
        public WorkerCheckInReportWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            sources = new List<WorkerCheckInModel>();
            employeeList = new List<EmployeeModel>();
            workList = new List<WorkListModel>();

            InitializeComponent();
        }

        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            btnPreview.IsEnabled = true;
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sources = WorkerCheckInController.Get();
                employeeList = EmployeeController.GetAvailable();
                workList = WorkListController.Get();
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message.ToString());
                }));
            }
        }

        private void dgReport_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sources = WorkerCheckInController.Get();
                workList = WorkListController.Get();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            FilterData();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
            dpFilterDate.SelectedDate = DateTime.Now.Date;
            dpFilterDateTo.SelectedDate = DateTime.Now.Date;
        }

        private void FilterData()
        {
            var findWhat = txtFindWhat.Text.Trim().ToUpper().ToString();

            var dateFrom = dpFilterDate.SelectedDate.Value;
            var dateTo = dpFilterDateTo.SelectedDate.Value;

            var workListByTime = workList.Where(w => w.TestDate >= dateFrom && w.TestDate <= dateTo).ToList();
            var dateList = workListByTime.Select(s => s.TestDate.Date).Distinct().ToList();
            List<DisplayDataModel> dataList = new List<DisplayDataModel>();
            foreach (var date in dateList)
            {
                var workListByDate = workListByTime.Where(w => w.TestDate == date).ToList();
                var empIds = workListByDate.Select(s => s.EmployeeID).Distinct().ToList();
                foreach (var empId in empIds)
                {
                    var workListByEmpId = workListByDate.FirstOrDefault(f => f.EmployeeID == empId);
                    var employeeById = employeeList.FirstOrDefault(f => f.EmployeeID.Trim().ToLower().ToString() == empId.Trim().ToLower().ToString());
                    var workerCheckByEmpIdByDate = sources.Where(w => w.CheckInDate == date && w.EmployeeCode == employeeById.EmployeeCode);
                    var timeInRecords = workerCheckByEmpIdByDate.Where(w => w.CheckType == 0).ToList();
                    var timeOutRecords = workerCheckByEmpIdByDate.Where(w => w.CheckType == 1).ToList();
                    string timeIn = timeInRecords.Count() > 0 ? timeInRecords.Max(m => m.RecordTime) : "";
                    string timeOut = timeOutRecords.Count() > 0 ? timeOutRecords.Max(m => m.RecordTime) : "";

                    if (employeeById == null)
                        continue;

                    var displayModel = new DisplayDataModel
                    {
                        EmployeeID = employeeById.EmployeeID,
                        EmployeeCode = employeeById.EmployeeCode,
                        EmployeeName = employeeById.EmployeeName,
                        DepartmentName = employeeById.DepartmentName,
                        TestDate = date,
                        TestStatus = workListByEmpId.TestStatus,
                        TimeIn=timeIn,
                        TimeOut=timeOut
                    };
                    dataList.Add(displayModel);
                }
            }
            dataList = dataList.OrderBy(o => o.TestDate).ThenBy(th => th.DepartmentName).ThenBy(th => th.EmployeeID).ToList();

            

            if (!string.IsNullOrEmpty(findWhat))
            {
                dataList = dataList.Where(w => w.EmployeeCode == findWhat || w.EmployeeID.Trim().ToUpper() == findWhat).ToList();
                
            }
            dgReport.ItemsSource = dataList;
            dgReport.Items.Refresh();
        }
        private void txtFindWhat_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                FilterData();
            }
        }
        
        private class DisplayDataModel
        {
            public string EmployeeCode { get; set; }
            public string EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public DateTime TestDate { get; set; }
            public string DepartmentName { get; set; }
            public string TimeIn { get; set; }
            public string TimeOut { get; set; }
            public int TestStatus { get; set; }

        }
    }
}
