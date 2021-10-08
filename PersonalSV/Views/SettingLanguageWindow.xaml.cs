using System.Windows;
using System.Threading;

using PersonalSV.Helpers;
using PersonalSV.Models;

namespace PersonalSV.Views
{
    /// <summary>
    /// Interaction logic for SettingLanguageWindow.xaml
    /// </summary>
    public partial class SettingLanguageWindow : Window
    {
        public SettingLanguageWindow()
        {
            InitializeComponent();
        }

        private void radEnglish_Click(object sender, RoutedEventArgs e)
        {
            LanguageHelper.SetLanguageDictionary(EnumLanguage.English);
            this.InitializeComponent();
            Thread.Sleep(1500);
            this.Close();
        }

        private void radVietnamese_Click(object sender, RoutedEventArgs e)
        {
            LanguageHelper.SetLanguageDictionary(EnumLanguage.VietNamese);
            this.InitializeComponent();
            Thread.Sleep(1500);
            this.Close();
        }
    }
}
