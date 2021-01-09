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
    /// Логика взаимодействия для WindowManager.xaml
    /// </summary>
    public partial class WindowManager : Window
    {
        public WindowManager()
        {
            InitializeComponent();
            ManagerFrame.Navigate(new PageManagerMain());
        }




        private void Button_Click_Main(object sender, RoutedEventArgs e)
        {
            ManagerFrame.Content = new PageManagerMain();
        }

        private void Button_Click_AddOtchet(object sender, RoutedEventArgs e)
        {
            ManagerFrame.Content = new PageManagerAdd();
        }

        private void Button_Click_LinkOtchet(object sender, RoutedEventArgs e)
        {
            ManagerFrame.Content = new PageManagerLink();
        }

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void Button_Click_Out(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
