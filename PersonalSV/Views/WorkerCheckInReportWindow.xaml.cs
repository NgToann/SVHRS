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
        private int checkType = 2;
        public WorkerCheckInReportWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork; ;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted; ;
            sources = new List<WorkerCheckInModel>();
            employeeList = new List<EmployeeModel>();
            InitializeComponent();
        }

        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            btnPreview.IsEnabled = true;
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            sources = WorkerCheckInController.Get();
            employeeList = EmployeeController.GetAvailable();
            foreach (var item in sources)
            {
                var empById = employeeList.FirstOrDefault(f => f.EmployeeCode == item.EmployeeCode);
                if (empById != null)
                {
                    item.EmployeeID = empById.EmployeeID;
                    item.EmployeeName = empById.EmployeeName;
                    item.DepartmentName = empById.DepartmentName;
                    item.CheckTypeDisplay = item.CheckType == 0 ? "In" : "Out";
                }
            }
        }

        private void dgReport_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void radCheckIn_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded)
            {
                checkType = 0;
                FilterData();
            }
        }

        private void radAll_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded)
            {
                checkType = 2;
                FilterData();
            }
        }

        private void radCheckOut_Checked(object sender, RoutedEventArgs e)
        {
            if (this.IsLoaded)
            {
                checkType = 1;
                FilterData();
            }
        }

        private void btnPreview_Click(object sender, RoutedEventArgs e)
        {
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
            List<WorkerCheckInModel> dislpayList = new List<WorkerCheckInModel>();
            var findWhat = txtFindWhat.Text.Trim().ToUpper().ToString();

            var dateFrom = dpFilterDate.SelectedDate.Value;
            var dateTo = dpFilterDateTo.SelectedDate.Value;
            dislpayList = sources.Where(w => w.CheckInDate >= dateFrom && w.CheckInDate <= dateTo).OrderBy(o => o.CheckInDate).ThenBy(th => th.DepartmentName).ThenBy(th => th.EmployeeID).ThenBy(th => th.RecordTime).ToList();

            if (!string.IsNullOrEmpty(findWhat))
            {
                dislpayList = dislpayList.Where(w => w.EmployeeCode == findWhat || w.EmployeeID.Trim().ToUpper() == findWhat).ToList();
                if (checkType != 2)
                {
                    dislpayList = dislpayList.Where(w => w.CheckType == checkType).ToList();
                }
            }
            else if (checkType != 2)
            {
                dislpayList = dislpayList.Where(w => w.CheckType == checkType).ToList();
            }

            dgReport.ItemsSource = dislpayList;
            dgReport.Items.Refresh();
            if (dislpayList.Count() > 0)
            {
                var totalWorker = dislpayList.Select(s => s.EmployeeCode).Distinct().ToList().Count();
                lblTotalWorker.Visibility = Visibility.Visible;
                lblTotalWorker.Text = String.Format("Total: {0}", totalWorker);
            }
            else
            {
                lblTotalWorker.Visibility = Visibility.Collapsed;
                lblTotalWorker.Text = "";
            }
        }
        private void txtFindWhat_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                FilterData();
            }
        }
    }
}
