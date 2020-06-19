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

namespace TranslatorUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public Frame MainFrame => mainFrame;

        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Navigate(new Uri("Pages/TransPage.xaml",UriKind.Relative));
        }

        private void btnNav_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            mainFrame.Navigate(new Uri("Pages/"+btn.Tag.ToString() + ".xaml", UriKind.Relative));
        }

        public void ToCommu()
        {
            mainFrame.Navigate(new Uri("Pages/CommunityPage.xaml", UriKind.Relative));
        }
    }

}
