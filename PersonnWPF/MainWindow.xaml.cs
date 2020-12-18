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
using System.Data.OleDb;
using System.Data;
using System.Collections;
using UserDetails;
using System.Data.SqlClient;
using System;

namespace PersonnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();    
            SqlConnection thisConnection = new SqlConnection(@"Server=(local);Database=NABA;Trusted_Connection=Yes;");
            thisConnection.Open();

            string Get_Data = "SELECT * FROM Persons";

            SqlCommand cmd = thisConnection.CreateCommand();
            cmd.CommandText = Get_Data;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Persons");
            sda.Fill(dt);

            dataGridd.ItemsSource = dt.DefaultView;
        }

        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(textFileCB.IsChecked == true)
            {
                string txtName = "UserInfo.txt";
                string txtPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\", txtName);
                PersonInfo PI = new PersonInfo();
                PI.ReadContent(TextBox1, txtPath);
            }

            if (ExcelFileCB.IsChecked == true)
            {
                string ExcelName = "UserInfo.xlsx";
                string ExcelPath = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\", ExcelName);
                readxl RX = new readxl();
                RX.readXLS(TextBox1, ExcelPath);

            }
        }
        //private void SaveButton_Click(object sender, RoutedEventArgs e)
        //{
        //   dt.SubmitChanges();
        //}
    }
}
