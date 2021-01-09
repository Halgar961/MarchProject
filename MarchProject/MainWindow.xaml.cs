using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarchProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public DataTable Select(string selectSQL) // функция подключения к базе данных и обработка запросов
        {
            DataTable dataTable = new DataTable("dataBase"); // создаём таблицу в приложении
                                                             // подключаемся к базе данных
            SqlConnection sqlConnection = new SqlConnection(@"server=DESKTOP-6F6G93E\SQLEXPRESS;Trusted_Connection=Yes;DataBase=Marchdb;");
            sqlConnection.Open(); // открываем базу данных
            SqlCommand sqlCommand = sqlConnection.CreateCommand(); // создаём команду
            sqlCommand.CommandText = selectSQL; // присваиваем команде текст
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); // создаём обработчик
            sqlDataAdapter.Fill(dataTable); // возращаем таблицу с результатом
            return dataTable;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt_user = Select("SELECT * FROM [dbo].[Users] WHERE [login] = '" + login.Text + "' AND [password] = '" + password.Password + "'");
            if (dt_user.Rows.Count > 0)              
            {
                if (login.Text == "Admin")
                {
                    Button_Click_Admin();
                }
                if (login.Text == "BuhgalterPRO")
                {
                    Button_Click_Buhgalter();
                }
                if (login.Text == "ManagerPRO")
                {
                    Button_Click_Manager();
                }
            }
        }
       
        private void Button_Click_Admin()
        {
            WindowAdmin windowAdmin = new WindowAdmin();
            windowAdmin.Show();
        }
        private void Button_Click_Buhgalter()
        {
            WindowBuhgalter windowBuhgalter = new WindowBuhgalter();
            windowBuhgalter.Show();
        }

        private void Button_Click_Manager()
        {
            WindowManager windowManager = new WindowManager();
            windowManager.Show();
        }
    }
}
