using System;
using System.Windows;
using UserDetails;

namespace PersonnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dc = new DataClasses1DataContext(Properties.Settings.Default.NABAConnectionString);

        public MainWindow()
        {
            InitializeComponent();
            if (dc.DatabaseExists())
            {

               DataG.ItemsSource = dc.Persons;
            }
            //SqlConnection thisConnection = new SqlConnection(@"Server=(local);Database=NABA;Trusted_Connection=Yes;");
            //thisConnection.Open();

            //string Get_Data = "SELECT * FROM Person";

            //SqlCommand cmd = thisConnection.CreateCommand();
            //cmd.CommandText = Get_Data;

            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("Person");
            //sda.Fill(dt);

            //dataGridd.ItemsSource = dt.DefaultView;

        }

        private void SaveButton_Click_1(object sender, RoutedEventArgs e)
        {
            dc.SubmitChanges();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textFileCB.IsChecked == true)
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

    }
}
