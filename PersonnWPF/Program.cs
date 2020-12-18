using System;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;


namespace UserDetails
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //take user info and put in text file.
    //        Console.WriteLine(" Enter First Name and Last Name: ");
    //        string userInfo = Console.ReadLine();
    //        Console.WriteLine("Username is: " + userInfo);
    //        string text = userInfo;
    //        System.IO.File.WriteAllText(@"C:\Users\Public\Downloads\UserInfo.txt", text);

    //        //read the data in the text file
    //        string txt = System.IO.File.ReadAllText(@"C:\Users\Public\Downloads\UserInfo.txt");
    //        Console.WriteLine(txt);


    //        //excel work
    //        PersonInfo pi = new PersonInfo();
    //        pi.getinfo(); //create excel with user info inputed 
    //        readxl rxl = new readxl(); //read the data from the user info
    //        rxl.readXLS(@"C:\Users\Public\Downloads\UserInfo.xlsx");


    //        //read data from sql database
    //        string constring = @"Data Source = STU - GJHLMQ2\SQLEXPRESS; Initial Catalog = NABA; Integrated Security = True";
    //        SqlConnection conn = new SqlConnection(constring);
    //        conn.Open();
    //        SqlCommand cmd = new SqlCommand("SELECT * FROM PERSON", conn);
    //        cmd.CommandType = System.Data.CommandType.Text;
    //        SqlDataAdapter da = new SqlDataAdapter(cmd);
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        conn.Close();



    //    }


    //}

}
    


