using PersonalSV.Controllers;
using PersonalSV.Models;
using PersonalSV.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;
using Excel = Microsoft.Office.Interop.Excel;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for TestCovidCreateTestTermWindow.xaml
    /// </summary>
    public partial class TestCovidCreateTestTermWindow : Window
    {
        List<EmployeeModel> employeeList;
        List<EmployeeModel> employeeOriginList;
        List<TestRandomModel> testRandomList;
        private List<TestRandomModel> testRandomFromExcelList;
        private PrivateDefineModel defModel;
        BackgroundWorker bwLoad;
        BackgroundWorker bwInsert;
        BackgroundWorker bwReadExcel;
        private string filePath = "";
        public TestCovidCreateTestTermWindow()
        {
            employeeList = new List<EmployeeModel>();
            defModel = new PrivateDefineModel();
            testRandomList = new List<TestRandomModel>();
            testRandomFromExcelList = new List<TestRandomModel>();

            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            bwInsert = new BackgroundWorker();
            bwInsert.DoWork += BwInsert_DoWork;
            bwInsert.RunWorkerCompleted += BwInsert_RunWorkerCompleted;

            bwReadExcel = new BackgroundWorker();
            bwReadExcel.DoWork += BwReadExcel_DoWork;
            bwReadExcel.RunWorkerCompleted += BwReadExcel_RunWorkerCompleted;

            InitializeComponent();
        }

        private void BwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            btnCreate.IsEnabled = true;
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                defModel = CommonController.GetDefineProps();
                employeeList = EmployeeController.GetAvailableForTestCovid();
                employeeOriginList = employeeList.ToList();
                testRandomList = TestRandomController.GetAll();
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message.ToString());
                }));
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            List<TestRandomModel> testRandomCreateList = new List<TestRandomModel>();
            var createdDate = dpTestDate.SelectedDate.Value.Date;

            var testTime = txtTestTime.Text.Trim().ToString();
            var workTime = txtWorkTime.Text.Trim().ToString();

            var totalEmp = employeeList.Count();
            var randomRate = 0;
            Int32.TryParse(txtRandomRate.Text.Trim().ToString(), out randomRate);
            if (randomRate == 0)
            {
                MessageBox.Show(string.Format("Random Rate is invalid !"), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                txtRandomRate.Focus();
                txtRandomRate.SelectAll();
                return;
            }

            var requestNumber = (int)(randomRate * totalEmp / 100);

            var dateListInTestProcess = testRandomList.Where(w => !w.Status.Equals("Plan")).Select(s => s.TestDate).Distinct().ToList();
            var dateListTotal = testRandomList.Select(s => s.TestDate).Distinct().ToList();
            dateListTotal.RemoveAll(r => dateListInTestProcess.Contains(r));

            var empListInPlanNow = testRandomList.Where(w => dateListTotal.Contains(w.TestDate)).Select(s => s.EmployeeCode).Distinct().ToList();
            var empsListReadyToPlan = employeeList.Where(w => !empListInPlanNow.Contains(w.EmployeeCode)).ToList();

            var employeeCreatePlanList = new List<EmployeeModel>();

            if (empsListReadyToPlan.Count() >= requestNumber)
            {
                employeeCreatePlanList = empsListReadyToPlan.OrderBy(o => Guid.NewGuid()).Take(requestNumber).ToList();
            }
            else
            {
                employeeCreatePlanList.AddRange(empsListReadyToPlan);
                var empListCreatedPlanList = employeeCreatePlanList.Select(s => s.EmployeeCode).Distinct().ToList();
                var empListReadyToPlan = employeeList.Where(w => !empListCreatedPlanList.Contains(w.EmployeeCode)).ToList();

                var requestRemain = requestNumber - employeeCreatePlanList.Count();
                employeeCreatePlanList.AddRange(empListReadyToPlan.OrderBy(o => Guid.NewGuid()).Take(requestRemain).ToList());
            }

            foreach (var emp in employeeCreatePlanList)
            {
                var randomInsert = new TestRandomModel
                {
                    Id = Guid.NewGuid().ToString(),
                    EmployeeCode = emp.EmployeeCode,
                    TestDate = createdDate,
                    Term = 1,
                    Round = 1,
                    Result = "",
                    PersonConfirm = "",
                    Remark = "",
                    TimeIn = "",
                    TimeOut = "",
                    Status = "Plan",
                    TestTime = testTime,
                    WorkTime = workTime,
                    EmployeeID = emp.EmployeeID,
                    EmployeeName = emp.EmployeeName,
                    DepartmentName = emp.DepartmentName,
                };
                testRandomCreateList.Add(randomInsert);
            }

            dgRandomList.ItemsSource = testRandomCreateList;
            dgRandomList.Items.Refresh();
        }

        private void hlViewWorkerList_Click(object sender, RoutedEventArgs e)
        {
            TestRandomViewEmployeeListWindow window = new TestRandomViewEmployeeListWindow(employeeOriginList);
            window.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (dgRandomList.ItemsSource == null)
                return;
            var insertList = dgRandomList.ItemsSource.OfType<TestRandomModel>().ToList();
            if (bwInsert.IsBusy == false && insertList.Count() > 0)
            {
                this.Cursor = Cursors.Wait;
                bwInsert.RunWorkerAsync(insertList);
            }
        }
        private void BwInsert_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            if ((bool)e.Result)
            {
                MessageBox.Show("Saved !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BwInsert_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = true;
                var source = e.Argument as List<TestRandomModel>;
                foreach (var item in source)
                {
                    var testPlan = new WorkListModel
                    {
                        EmployeeID = item.EmployeeID,
                        TestDate = item.TestDate,
                        TestTime = item.TestTime,
                        WorkTime = item.WorkTime,
                        TestStatus = 0,
                        Remarks = item.Remark
                    };

                    //TestRandomController.Insert(item);

                    WorkListController.Insert(testPlan);
                    testRandomList.Add(item);
                    Dispatcher.Invoke(new Action(() =>
                    {
                        dgRandomList.SelectedItem = item;
                        dgRandomList.ScrollIntoView(item);
                    }));
                }
            }
            catch (Exception ex)
            {
                e.Result = false;
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.Message.ToString());
                }));
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dpTestDate.SelectedDate = DateTime.Now;
            if (bwLoad.IsBusy == false)
            {
                this.Cursor = Cursors.Wait;
                bwLoad.RunWorkerAsync();
            }
        }
        private void dgRandomList_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void hlTestPlanlist_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                testRandomList = TestRandomController.GetAll();
                foreach (var item in testRandomList)
                {
                    var empByCode = employeeOriginList.FirstOrDefault(f => f.EmployeeCode == item.EmployeeCode);
                    if (empByCode != null)
                    {
                        item.EmployeeID = empByCode.EmployeeID;
                        item.EmployeeName = empByCode.EmployeeName;
                        item.DepartmentName = empByCode.DepartmentName;
                    }
                }
                testRandomList = testRandomList.OrderByDescending(o => o.TestDate).ThenBy(th => th.DepartmentName).ThenBy(th => th.EmployeeID).ToList();
                TestCovidCovidTestPlanWindow window = new TestCovidCovidTestPlanWindow(testRandomList);
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnAddWorkerId_Click(object sender, RoutedEventArgs e)
        {
            var createdDate = dpTestDate.SelectedDate.Value.Date;
            var currentList = dgRandomList.ItemsSource != null ? dgRandomList.ItemsSource.OfType<TestRandomModel>().ToList() : new List<TestRandomModel>();
            var testTime = txtTestTime.Text.Trim().ToString();
            var workTime = txtWorkTime.Text.Trim().ToString();
            
            var workerIdAdd = txtWorkerId.Text.Trim().ToUpper().ToString();
            if (String.IsNullOrEmpty(workerIdAdd))
            {
                MessageBox.Show("WokerId is empty !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            var workerById = employeeList.Where(w => w.EmployeeID == workerIdAdd || w.EmployeeCode == workerIdAdd).FirstOrDefault();
            if (workerById == null)
            {
                MessageBox.Show("Worker Not Found !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                TxtWorkerIdDefault();
                return;
            }

            var workerHasTestPlanCheck = currentList.Where(w => w.EmployeeCode == workerById.EmployeeCode && w.TestDate == createdDate).FirstOrDefault();
            if (workerHasTestPlanCheck !=null)
            {
                MessageBox.Show("Already Exist !\nĐã tồn tại !", this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
                dgRandomList.SelectedItem = workerHasTestPlanCheck;
                dgRandomList.ScrollIntoView(workerHasTestPlanCheck);

                TxtWorkerIdDefault();
                return;
            }

            var newTestAddByManual = new TestRandomModel
            {
                Id = Guid.NewGuid().ToString(),
                EmployeeCode = workerById.EmployeeCode,
                TestDate = createdDate,
                Term = 0,
                Round = 0,
                Result = "",
                PersonConfirm = "",
                Remark = "",
                TimeIn = "",
                TimeOut = "",
                Status = "Plan",
                TestTime = testTime, 
                WorkTime = workTime,
                EmployeeID = workerById.EmployeeID,
                EmployeeName = workerById.EmployeeName,
                DepartmentName = workerById.DepartmentName,
                //AddByManual = true,
            };

            currentList.Add(newTestAddByManual);

            dgRandomList.ItemsSource = currentList;
            dgRandomList.Items.Refresh();
            dgRandomList.SelectedItem = newTestAddByManual;
            dgRandomList.ScrollIntoView(newTestAddByManual);

            TxtWorkerIdDefault();
        }

        private void TxtWorkerIdDefault()
        {
            txtWorkerId.Focus();
            txtWorkerId.SelectAll();
        }

        private void txtWorkerId_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            btnAddWorkerId.IsDefault = true;
        }

        private void btnImportExcel_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Title = "Import Covid Test Plan";
            openFileDialog.Filter = "EXCEL Files (*.xls, *.xlsx)|*.xls;*.xlsx";
            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                if (bwLoad.IsBusy == false)
                {
                    testRandomFromExcelList.Clear();
                    this.Cursor = Cursors.Wait;
                    bwReadExcel.RunWorkerAsync();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void BwReadExcel_DoWork(object sender, DoWorkEventArgs e)
        {
            Excel.Application excelApplication = new Excel.Application();
            Excel.Workbook excelWorkbook = excelApplication.Workbooks.Open(filePath);
            //excelApplication.Visible = true;
            Excel.Worksheet excelWorksheet;
            Excel.Range excelRange;
            try
            {
                excelWorksheet = (Excel.Worksheet)excelWorkbook.Worksheets[1];
                excelRange = excelWorksheet.UsedRange;
                for (int i = 2; i <= excelRange.Rows.Count; i++)
                {
                    var workerId = (excelRange.Cells[i, 1] as Excel.Range).Value2;
                    if (workerId != null)
                    {
                        var empByWorkerId = employeeOriginList.FirstOrDefault(f => f.EmployeeID == workerId.ToString());
                        
                        if (empByWorkerId == null)
                            continue;
                        var testModel = new TestRandomModel
                        {
                            Id = Guid.NewGuid().ToString(),
                            EmployeeCode = empByWorkerId.EmployeeCode,

                            Term = 0,
                            Round = 0,
                            Result = "",
                            PersonConfirm = "",
                            Remark = "",
                            TimeIn = "",
                            TimeOut = "",
                            Status = "Plan",

                            EmployeeID = empByWorkerId.EmployeeID,
                            EmployeeName = empByWorkerId.EmployeeName,
                            DepartmentName = empByWorkerId.DepartmentName,
                        };

                        double testDateDouble = 0;
                        Double.TryParse((excelRange.Cells[i, 5] as Excel.Range).Value2.ToString(), out testDateDouble);
                        DateTime testDate = DateTime.FromOADate(testDateDouble);

                        var testTime = (excelRange.Cells[i, 6] as Excel.Range).Value2;
                        var workTime = (excelRange.Cells[i, 7] as Excel.Range).Value2;
                        var remark = (excelRange.Cells[i, 8] as Excel.Range).Value2;

                        testModel.TestDate = testDate;
                        testModel.TestTime = testTime;
                        testModel.WorkTime = workTime;
                        testModel.Remark = remark;

                        testRandomFromExcelList.Add(testModel);
                    }
                }
            }
            catch (Exception ex)
            {
                Dispatcher.Invoke(new Action(() =>
                {
                    MessageBox.Show(ex.InnerException.Message).ToString();
                    testRandomFromExcelList.Clear();
                }));
            }
            finally
            {
                excelWorkbook.Close(false, Missing.Value, Missing.Value);
                excelApplication.Quit();
            }

        }
        private void BwReadExcel_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Cursor = null;
            if (testRandomFromExcelList.Count() > 0)
            {
                dgRandomList.ItemsSource = testRandomFromExcelList;
                dgRandomList.Items.Refresh();
                MessageBox.Show(string.Format("Read Completed. {0} Records", testRandomFromExcelList.Count()), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {            
            if (dgRandomList.Items == null)
                return;

            var dateDelete = dpTestDate.SelectedDate.Value.Date;
            if (MessageBox.Show(string.Format("Confirm Delete Covid Test Plan on: {0:dd/MM/yyyy}?\nXác nhận xóa TestPlan ngày", dateDelete),
                                       this.Title, MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
            {
                return;
            }

            var deleteItems = dgRandomList.ItemsSource.OfType<TestRandomModel>().ToList();
            try
            {
                foreach (var item in deleteItems)
                {
                    TestRandomController.DeleteByEmpCodeByDate(item);
                    testRandomList.RemoveAll(r => r.EmployeeCode == item.EmployeeCode && r.TestDate == item.TestDate);
                }
                dgRandomList.ItemsSource = null;
                MessageBox.Show(string.Format("Deleted {0} Records !", deleteItems.Count()), this.Title, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message.ToString());
            }
        }

        private void miRemove_Click(object sender, RoutedEventArgs e)
        {
            if (dgRandomList.ItemsSource == null)
                return;

            var itemsRemove = dgRandomList.SelectedItems.OfType<TestRandomModel>().ToList();
            if (MessageBox.Show(string.Format("Confirm Remove {0} items?", itemsRemove.Count()),
                                       this.Title, MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
            {
                return;
            }

            var totalList = dgRandomList.ItemsSource.OfType<TestRandomModel>().ToList();
            foreach(var item in itemsRemove)
            {
                totalList.Remove(item);
            }

            dgRandomList.ItemsSource = totalList;
            dgRandomList.Items.Refresh();
        }
    }
}
