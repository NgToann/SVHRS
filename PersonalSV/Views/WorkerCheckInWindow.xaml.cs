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
        List<WorkerCheckInModel> sources;
        List<WorkerCheckInModel> checkOutList;
        List<EmployeeModel> employeeList;
        private string lblResourceNotFound = "", lblNotYetCheckOut="", lblNotExitsInWorkList="", lblNotAllowed="", lblDoTheTestCovidAlert="", lblNotExistInTestList = "";
        private PrivateDefineModel defineModel;
        private List<WorkerPriorityModel> workerPriorityList;
        private List<WorkerF0Model> workerF0List;

        private List<WorkListModel> workList;
        private DateTime today = DateTime.Now.Date;
        public WorkerCheckInWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            sources = new List<WorkerCheckInModel>();
            employeeList = new List<EmployeeModel>();
            lblResourceNotFound = LanguageHelper.GetStringFromResource("messageNotFound");
            lblNotExitsInWorkList = LanguageHelper.GetStringFromResource("workerCheckInMessageNotPriority");
            lblNotYetCheckOut = LanguageHelper.GetStringFromResource("workerCheckInLblNotYetCheckOut");
            lblNotAllowed = LanguageHelper.GetStringFromResource("workerCheckInMessageNotAllowed");
            lblDoTheTestCovidAlert = LanguageHelper.GetStringFromResource("workerCheckInMessageDoTheCovidTest");
            lblNotExistInTestList = LanguageHelper.GetStringFromResource("workerCheckInMessageNotExistInTestList");

            defineModel = new PrivateDefineModel();
            workerPriorityList = new List<WorkerPriorityModel>();
            workerF0List = new List<WorkerF0Model>();
            workList = new List<WorkListModel>();

            checkOutList = new List<WorkerCheckInModel>();
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
            // display sources today
            var displayList = sources.Where(w => w.CheckInDate == DateTime.Now.Date).ToList();
            dgWorkerCheckIn.ItemsSource = displayList;
            CountTotal(displayList);

            txtCardId.IsEnabled = true;
            SetTxtDefault();
        }

        private void BwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                defineModel = CommonController.GetDefineProps();
                workerPriorityList = CommonController.GetWorkerPriorityList();
                workerF0List = CommonController.GetWorkerF0();
                employeeList = EmployeeController.GetAvailable();
                sources = WorkerCheckInController.Get();
                workList = WorkListController.Get();

                checkOutList = sources.Where(w => w.CheckInDate == defineModel.StartDateScanWorkerCheckIn && w.CheckType == 1).ToList();
                foreach (var item in sources)
                {
                    var empById = employeeList.FirstOrDefault(f => f.EmployeeCode == item.EmployeeCode);
                    if (empById != null)
                    {
                        item.EmployeeID = empById.EmployeeID;
                        item.EmployeeName = empById.EmployeeName;
                        item.DepartmentName = empById.DepartmentName;
                    }
                }
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
                    // Check in worklist
                    var workListByEmpId = workList.Where(w => w.EmployeeID.Trim().ToLower().ToString() == empById.EmployeeID.Trim().ToLower().ToString()).ToList();
                    if (workListByEmpId.Count() > 0)
                    {
                        var workListToday = workList.Where(w => w.TestDate == today).ToList();
                        // check status today
                        var workerWithStatus0 = workListToday.Where(w => w.EmployeeID.Trim().ToLower().ToString() == empById.EmployeeID.Trim().ToLower().ToString()).ToList();
                        if (workerWithStatus0.Count() > 0)
                        {
                            brDisplay.Background = Brushes.Yellow;
                            AddRecord(empById);
                        }
                        else
                        {
                            var workerHasStatusBeforeToday = workList.Where(w => w.TestDate < today && w.EmployeeID.Trim().ToLower().ToString() == empById.EmployeeID.Trim().ToLower().ToString())
                                                                        .OrderBy(o => o.TestDate).LastOrDefault();
                            if (workerHasStatusBeforeToday != null)
                            {
                                if (workerHasStatusBeforeToday.TestStatus == 2)
                                {
                                    brDisplay.Background = Brushes.Red;
                                    var notAllowedAlert = new WorkerCheckInModel
                                    {
                                        EmployeeName = empById.EmployeeName,
                                        EmployeeID = empById.EmployeeID,
                                        RecordTime = lblNotAllowed
                                    };
                                    grDisplay.DataContext = notAllowedAlert;
                                    SetTxtDefault();
                                }
                                else if (workerHasStatusBeforeToday.TestStatus == 1)
                                {
                                    brDisplay.Background = Brushes.Green;
                                    AddRecord(empById);
                                }
                                else if (workerHasStatusBeforeToday.TestStatus == 0)
                                {
                                    brDisplay.Background = Brushes.Red;
                                    var notExistInWorkList = new WorkerCheckInModel
                                    {
                                        EmployeeName = empById.EmployeeName,
                                        EmployeeID = empById.EmployeeID,
                                        RecordTime = string.Format("{0} - {1:dd/MM/yyyy}", lblNotExistInTestList, today)
                                    };
                                    grDisplay.DataContext = notExistInWorkList;
                                    SetTxtDefault();
                                }
                            }
                        }
                    }
                    else
                    {
                        brDisplay.Background = Brushes.Red;
                        var notExistInWorkList = new WorkerCheckInModel
                        {
                            EmployeeName = empById.EmployeeName,
                            EmployeeID = empById.EmployeeID,
                            RecordTime = lblNotExitsInWorkList
                        };
                        grDisplay.DataContext = notExistInWorkList;
                        SetTxtDefault();
                    }

                    //// check priority exist
                    //var priorityById = workerPriorityList.Where(w => w.EmployeeID.Trim().ToLower().ToString() == empById.EmployeeID.Trim().ToLower().ToString()).ToList();

                    //// check is FO
                    //var isF0 = workerF0List.Where(w => w.EmployeeID.Trim().ToLower().ToString() == empById.EmployeeID.Trim().ToLower().ToString()).ToList();

                    //if (priorityById.Count() == 0)
                    //{
                    //    brDisplay.Background = Brushes.Red;

                    //    var notPriority = new WorkerCheckInModel
                    //    {
                    //        EmployeeName = empById.EmployeeName,
                    //        EmployeeID = empById.EmployeeID,
                    //        RecordTime = lblNotPriorityAlert
                    //    };
                    //    grDisplay.DataContext = notPriority;

                    //    SetTxtDefault();
                    //}
                    //else if (isF0.Count() > 0)
                    //{
                    //    brDisplay.Background = Brushes.Red;

                    //    var isF0Alert = new WorkerCheckInModel
                    //    {
                    //        EmployeeName = empById.EmployeeName,
                    //        EmployeeID = empById.EmployeeID,
                    //        RecordTime = lblF0Alert
                    //    };
                    //    grDisplay.DataContext = isF0Alert;

                    //    SetTxtDefault();
                    //}
                    //else
                    //{
                    //    // check worker has checked out on the first date.
                    //    var checkOutById = checkOutList.Where(w => w.EmployeeCode == empById.EmployeeCode).ToList();
                    //    if (checkOutById.Count() > 0 || defineModel.StartDateScanWorkerCheckIn.Date == DateTime.Now.Date)
                    //    {
                    //        AddRecord(empById);
                    //    }
                    //    // Alert message
                    //    else
                    //    {
                    //        brDisplay.Background = Brushes.Yellow;
                    //        var notCheckOut = new WorkerCheckInModel
                    //        {
                    //            EmployeeName = empById.EmployeeName,
                    //            EmployeeID = empById.EmployeeID,
                    //            RecordTime = String.Format("{0} {1:dd/MM/yyyy}", lblNotYetCheckOut, defineModel.StartDateScanWorkerCheckIn)
                    //        };
                    //        grDisplay.DataContext = notCheckOut;
                    //        SetTxtDefault();
                    //    }
                    //}
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
            }
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
                sources.Add(record);

                dgWorkerCheckIn.ItemsSource = sources;
                dgWorkerCheckIn.Items.Refresh();
                dgWorkerCheckIn.SelectedItem = record;
                dgWorkerCheckIn.ScrollIntoView(record);

                CountTotal(sources);

                SetTxtDefault();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                SetTxtDefault();
            }
        }
        private void CountTotal(List<WorkerCheckInModel> sources)
        {
            lblTotal.Text = "";
            if (sources.Count()>0)
            {
                var totalWorker = sources.Select(s => s.EmployeeCode).Distinct().ToList();
                lblTotal.Text = string.Format("Total: {0}", totalWorker.Count());
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

        private void miRemove_Click(object sender, RoutedEventArgs e)
        {
            var items = dgWorkerCheckIn.SelectedItems.OfType<WorkerCheckInModel>().ToList();
            if (items.Count() > 0 && dgWorkerCheckIn.ItemsSource != null)
            {
                string msgConfirmDelete = LanguageHelper.GetStringFromResource("messageConfirmDelete");
                if (MessageBox.Show(msgConfirmDelete, this.Title, MessageBoxButton.OKCancel, MessageBoxImage.Question) != MessageBoxResult.OK)
                {
                    return;
                }
                else
                {
                    var idsRemove = items.Select(s => s.Id).Distinct().ToList();
                    var sources = dgWorkerCheckIn.ItemsSource.OfType<WorkerCheckInModel>().ToList();

                    try
                    {
                        foreach (var id in idsRemove)
                        {
                            WorkerCheckInController.Delete(id);
                        }
                        var sourcesAfterRemove = sources.RemoveAll(r => idsRemove.Contains(r.Id));

                        dgWorkerCheckIn.ItemsSource = sources;
                        dgWorkerCheckIn.Items.Refresh();
                        CountTotal(sources);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                    
                }
            }
        }

        private void txtCardId_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtCardId.SelectAll();
        }
    }
}
