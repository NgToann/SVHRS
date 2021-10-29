using PersonalSV.Controllers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using EXCEL = Microsoft.Office.Interop.Excel;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for WorkerCheckInReportWindow.xaml
    /// </summary>
    public partial class WorkerCheckInReportWindow : Window
    {
        List<WorkerCheckInModel> checkInList;
        List<EmployeeModel> employeeList;
        BackgroundWorker bwLoad;
        BackgroundWorker bwExportExcel;
        List<WorkListModel> workListAll;
        public WorkerCheckInReportWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            bwExportExcel = new BackgroundWorker();
            bwExportExcel.DoWork += BwExportExcel_DoWork;
            bwExportExcel.RunWorkerCompleted += BwExportExcel_RunWorkerCompleted;

            checkInList = new List<WorkerCheckInModel>();
            employeeList = new List<EmployeeModel>();
            workListAll = new List<WorkListModel>();

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
                employeeList = EmployeeController.GetForScan();
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
                var findWhat = txtFindWhat.Text.Trim().ToUpper().ToString();
                var dateSearch = dpFilterDate.SelectedDate.Value;
                if (!string.IsNullOrEmpty(findWhat))
                {
                    var empByFindWhat = employeeList.Where(w => w.EmployeeCode.Trim().ToUpper() == findWhat || w.EmployeeID.Trim().ToUpper().ToString() == findWhat).FirstOrDefault();
                    if (empByFindWhat != null)
                    {
                        workListAll = WorkListController.GetByEmpId(empByFindWhat.EmployeeID);
                        checkInList = WorkerCheckInController.GetByEmpCode(empByFindWhat.EmployeeCode);
                        FilterData(dateSearch, true);
                    }
                    else
                    {
                        MessageBox.Show("Not Found !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                        return;
                    }
                }
                else
                {
                    workListAll = WorkListController.Get();
                    checkInList = WorkerCheckInController.GetByDate(dateSearch);
                    FilterData(dateSearch, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
            dpFilterDate.SelectedDate = DateTime.Now.Date;
        }

        private void FilterData(DateTime dateSearch, bool isSearched)
        {            
            List<DisplayDataModel> dataList = new List<DisplayDataModel>();

            if (!isSearched)
            {

                var empCodeByCheckInListByDate = checkInList.Select(s => s.EmployeeCode).Distinct().ToList();
                var empIdsFromWorkerCheckInByDate = employeeList.Where(w => empCodeByCheckInListByDate.Contains(w.EmployeeCode)).Select(s => s.EmployeeID).Distinct().ToList();

                var workListByDate = workListAll.Where(w => w.TestDate == dateSearch).ToList();

                var empIdsFromWorkListByDate = workListByDate.Select(s => s.EmployeeID).Distinct().ToList();

                var workerIdList = new List<string>();
                workerIdList.AddRange(empIdsFromWorkerCheckInByDate);
                workerIdList.AddRange(empIdsFromWorkListByDate);
                workerIdList = workerIdList.Select(s => s).Distinct().ToList();

                foreach (var workerId in workerIdList)
                {
                    var empById = employeeList.FirstOrDefault(f => f.EmployeeID.Trim().ToLower().ToString() == workerId.Trim().ToLower().ToString());
                    if (empById != null)
                    {
                        var workListByWorkerIdByDateLatestList = workListAll.Where(w => w.EmployeeID == workerId && w.TestDate <= dateSearch).ToList();
                        var workerTestStatus = new WorkListModel();
                        if (workListByWorkerIdByDateLatestList.Count() > 0)
                        {
                            workerTestStatus = workListByWorkerIdByDateLatestList.OrderBy(o => o.TestDate).LastOrDefault();
                        }

                        string timeIn = "", timeOut = "";
                        var checkInListByWorkerIdByDate = checkInList.Where(w => w.EmployeeCode == empById.EmployeeCode).ToList();
                        if (checkInListByWorkerIdByDate.Count() > 0)
                        {
                            timeIn = checkInListByWorkerIdByDate.Where(w => w.CheckType == 0).Min(m => m.RecordTime);
                            timeOut = checkInListByWorkerIdByDate.Where(w => w.CheckType == 1).Max(m => m.RecordTime);
                        }

                        var displayModel = new DisplayDataModel
                        {
                            EmployeeID = empById.EmployeeID,
                            EmployeeCode = empById.EmployeeCode,
                            EmployeeName = empById.EmployeeName,
                            DepartmentName = empById.DepartmentName,
                            TestDate = dateSearch,
                            TestStatus = workerTestStatus != null ? workerTestStatus.TestStatus : 0,
                            TimeIn = timeIn,
                            TimeOut = timeOut
                        };
                        dataList.Add(displayModel);
                    }
                }
            }
            else
            {
                var dateList = workListAll.Select(s => s.TestDate).Distinct().OrderBy(o => o).ToList();
                foreach (var date in dateList)
                {
                    var workListByDate = workListAll.FirstOrDefault(f => f.TestDate == date);
                    var empByWorkerId = employeeList.FirstOrDefault(f => f.EmployeeID == workListByDate.EmployeeID);
                    if (empByWorkerId != null)
                    {
                        string timeIn = "", timeOut = "";
                        var checkInListByWorkerIdByDate = checkInList.Where(w => w.EmployeeCode == empByWorkerId.EmployeeCode && w.CheckInDate == date).ToList();
                        if (checkInListByWorkerIdByDate.Count() > 0)
                        {
                            timeIn = checkInListByWorkerIdByDate.Where(w => w.CheckType == 0).Min(m => m.RecordTime);
                            timeOut = checkInListByWorkerIdByDate.Where(w => w.CheckType == 1).Max(m => m.RecordTime);
                        }

                        var displayModel = new DisplayDataModel
                        {
                            EmployeeID = empByWorkerId.EmployeeID,
                            EmployeeCode = empByWorkerId.EmployeeCode,
                            EmployeeName = empByWorkerId.EmployeeName,
                            DepartmentName = empByWorkerId.DepartmentName,
                            TestDate = date,
                            TestStatus = workListByDate.TestStatus,
                            TimeIn = timeIn,
                            TimeOut = timeOut
                        };
                        dataList.Add(displayModel);
                    }
                }
            }
            
            dataList = dataList.OrderBy(o => o.TestDate).ThenBy(th => th.DepartmentName).ThenBy(th => th.EmployeeID).ToList();

            dgReport.ItemsSource = dataList;
            dgReport.Items.Refresh();
        }
        
        private void txtFindWhat_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            btnPreview.IsDefault = true;
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

        private void btnExportExcel_Click(object sender, RoutedEventArgs e)
        {
            if (dgReport.ItemsSource == null)
                return;

            if (bwExportExcel.IsBusy == false)
            {
                var sources = dgReport.ItemsSource.OfType<DisplayDataModel>().ToList();
                btnExportExcel.IsEnabled = false;
                this.Cursor = Cursors.Wait;
                bwExportExcel.RunWorkerAsync(sources);
            }
        }


        private void BwExportExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            EXCEL._Application excel = new Microsoft.Office.Interop.Excel.Application();
            EXCEL._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            EXCEL._Worksheet worksheet = null;

            var sources = e.Argument as List<DisplayDataModel>;

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Cells.HorizontalAlignment = EXCEL.XlHAlign.xlHAlignCenter;
                worksheet.Cells.Font.Name = "Arial";
                worksheet.Cells.Font.Size = 10;
                string reportName = String.Format("CheckInReport{0:ddMMyyyy}", DateTime.Now.Date);
                worksheet.Name = reportName;

                worksheet.Cells.Rows[1].Font.Size = 11;
                worksheet.Cells.Rows[1].Font.FontStyle = "Bold";

                var headerList = new List<String>();
                headerList.Add("EmployeeCode");
                headerList.Add("EmployeeID");
                headerList.Add("FullName");
                headerList.Add("Department(Line)");
                headerList.Add("Date");
                headerList.Add("TimeIn");
                headerList.Add("TimeOut");
                headerList.Add("Status");

                for (int i = 0; i < headerList.Count(); i++)
                {
                    worksheet.Cells[1, i + 1] = headerList[i];
                }
                int rowIndex = 2;
                foreach (var item in sources)
                {
                    worksheet.Cells[rowIndex, 1] = String.Format("'{0}", item.EmployeeCode);
                    worksheet.Cells[rowIndex, 2] = item.EmployeeID;
                    worksheet.Cells[rowIndex, 3] = item.EmployeeName;
                    worksheet.Cells[rowIndex, 4] = item.DepartmentName;
                    worksheet.Cells[rowIndex, 5] = item.TestDate;
                    worksheet.Cells[rowIndex, 6] = item.TimeIn;
                    worksheet.Cells[rowIndex, 7] = item.TimeOut;
                    worksheet.Cells[rowIndex, 8] = item.TestStatus;

                    rowIndex++;
                    Dispatcher.Invoke(new Action(() => {
                        dgReport.SelectedItem = item;
                        dgReport.ScrollIntoView(item);
                    }));
                }
                worksheet.Cells.Rows[1].Font.FontStyle = "Bold";

                Dispatcher.Invoke(new Action(() =>
                {
                    if (workbook != null)
                    {
                        var sfd = new System.Windows.Forms.SaveFileDialog();
                        sfd.Title = "SV-HRS Export Excel File";
                        sfd.Filter = "Excel Documents (*.xls)|*.xls|Excel Documents (*.xlsx)|*.xlsx";
                        sfd.FilterIndex = 2;
                        sfd.FileName = reportName;
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("Export Successful !", "SV-HRS Export Excel File", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                }));
            }
            catch (System.Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message, "SV-HRS Export Excel File", MessageBoxButton.OK, MessageBoxImage.Error);
                }));
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;
            }
        }
        private void BwExportExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            btnExportExcel.IsEnabled = true;
        }
    }
}
