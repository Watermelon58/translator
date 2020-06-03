using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TranslatorUI.Pages;

namespace TranslatorUI.Windows
{
    /// <summary>
    /// LogInPage.xaml 的交互逻辑
    /// </summary>
    public partial class LogInWindow : Window
    {
        public bool IsLogIn { get; set; }

        public LogInWindow()
        {
            InitializeComponent();
        }

        private void SignUp_btn_Click(object sender, RoutedEventArgs e)
        {
            SignUpWindow signUp = new SignUpWindow();
            signUp.ShowDialog();
        }

        private void LogIn_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
