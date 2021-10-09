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
        private string lblResourceNotFound = "", lblNotYetCheckOut="";
        private PrivateDefineModel defineModel;
        public WorkerCheckInWindow()
        {
            bwLoad = new BackgroundWorker();
            bwLoad.DoWork += BwLoad_DoWork;
            bwLoad.RunWorkerCompleted += BwLoad_RunWorkerCompleted;

            sources = new List<WorkerCheckInModel>();
            employeeList = new List<EmployeeModel>();
            lblResourceNotFound = LanguageHelper.GetStringFromResource("messageNotFound");
            lblNotYetCheckOut = LanguageHelper.GetStringFromResource("workerCheckInLblNotYetCheckOut");
            defineModel = new PrivateDefineModel();

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
            defineModel = CommonController.GetDefineProps();
            employeeList = EmployeeController.GetAvailable();
            sources = WorkerCheckInController.Get();
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
                    // check worker has checked out on the first date.
                    var checkOutById = checkOutList.Where(w => w.EmployeeCode == empById.EmployeeCode).ToList();
                    if (checkOutById.Count() > 0 || defineModel.StartDateScanWorkerCheckIn.Date == DateTime.Now.Date)
                    { 
                        AddRecord(empById);
                    }
                    // Alert message
                    else
                    {
                        this.Background = Brushes.Yellow;
                        brDisplay.Background = Brushes.Yellow;
                        var notCheckOut = new WorkerCheckInModel
                        {
                            EmployeeName = empById.EmployeeName,
                            EmployeeID = empById.EmployeeID,
                            RecordTime = String.Format("{0} {1:dd/MM/yyyy}", lblNotYetCheckOut, defineModel.StartDateScanWorkerCheckIn)
                        };
                        grDisplay.DataContext = notCheckOut;
                        SetTxtDefault();
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
                RecordTime = String.Format("{0:hh:mm}", DateTime.Now)
            };

            try
            {
                grDisplay.DataContext = record;
                brDisplay.Background = Brushes.Green;
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
