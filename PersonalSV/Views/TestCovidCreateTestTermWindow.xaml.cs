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
    /// Interaction logic for TestCovidCreateTestTermWindow.xaml
    /// </summary>
    public partial class TestCovidCreateTestTermWindow : Window
    {
        List<EmployeeModel> employeeList;
        List<EmployeeModel> employeeOriginList;
        List<TestRandomModel> testRandomList;
        private PrivateDefineModel defModel;
        BackgroundWorker bwLoad;
        public TestCovidCreateTestTermWindow()
        {
            employeeList = new List<EmployeeModel>();
            defModel = new PrivateDefineModel();
            testRandomList = new List<TestRandomModel>();

            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

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
            List<TestRandomModel> randomCreateList = new List<TestRandomModel>();
            var createdDate = dpTestDate.SelectedDate.Value;

            int randomPercent = defModel.TestRandomRatio != 0 ? defModel.TestRandomRatio : 20;
            var totalEmp = employeeList.Count();
            var requestNumber = (int)(randomPercent * totalEmp / 100);

            // For the first time
            if (testRandomList.Count() == 0)
            {
                var randomEmployeeList = employeeList.OrderBy(o => Guid.NewGuid()).Take(requestNumber).ToList();
                foreach (var emp in randomEmployeeList)
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
                        Status = "Queue",
                        EmployeeID = emp.EmployeeID,
                        EmployeeName = emp.EmployeeName,
                        DepartmentName = emp.DepartmentName
                    };
                    randomCreateList.Add(randomInsert);
                }
                dgRandomList.ItemsSource = randomCreateList;
                dgRandomList.Items.Refresh();
            }
            // Next time
            else
            {

            }
        }

        private void hlViewWorkerList_Click(object sender, RoutedEventArgs e)
        {
            TestRandomViewEmployeeListWindow window = new TestRandomViewEmployeeListWindow(employeeOriginList);
            window.Show();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

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
    }
}
