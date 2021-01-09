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
using System.Windows.Shapes;

namespace MarchProject
{
    /// <summary>
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
            AdminFrame.Navigate(new PageAdminMain());
            
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = new PageAdminAdd();
        }

        private void Button_Click_Main(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = new PageAdminMain();
        }


        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_Out(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_LinkUsers(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = new PageAdminLink();
        }
    }
}
