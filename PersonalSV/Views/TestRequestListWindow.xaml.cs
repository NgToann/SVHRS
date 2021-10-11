using PersonalSV.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for TestRequestListWindow.xaml
    /// </summary>
    public partial class TestRequestListWindow : Window
    {
        List<EmployeeModel> sources;
        public TestRequestListWindow(List<EmployeeModel> sources)
        {
            this.sources = sources;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dgTestRequest.ItemsSource = sources;
            dgTestRequest.Items.Refresh();
        }

        private void dgTestRequest_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }
    }
}
