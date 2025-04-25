using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSDLDotNetLearning.ConsoleApp;

internal class HomeworkService
{
    private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder
    {
        DataSource = "SANDAR\\MSSQLSERVER2022",
        InitialCatalog = "SSDLDotNetLearning",
        UserID = "sa",
        Password = "admin123!",
        TrustServerCertificate = true
    };

    public void Read()
    {
        SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        string query = "select * from Tbl_Homework";
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);

        connection.Close();

        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
        //    DataRow dr = dt.Rows[i];

        //    Console.WriteLine(dr["No"]);
        //    Console.WriteLine(dr["Name"]);
        //    Console.WriteLine(dr["GitHubUserName"]);
        //    Console.WriteLine("------------------------------");
        //}

        foreach (DataRow dr in dt.Rows)
        {
            Console.WriteLine(dr["No"]);
            Console.WriteLine(dr["Name"]);
            Console.WriteLine(dr["GitHubUserName"]);
            Console.WriteLine("------------------------------");
        }
    }

    public void Detail(int no)
    {
        SqlConnection connection = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
        connection.Open();

        string query = $"select * from Tbl_Homework where No = {no}";
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
        DataTable dt = new DataTable();
        dataAdapter.Fill(dt);

        connection.Close();

        foreach (DataRow dr in dt.Rows)
        {
            Console.WriteLine(dr["No"]);
            Console.WriteLine(dr["Name"]);
            Console.WriteLine(dr["GitHubUserName"]);
            Console.WriteLine("------------------------------");
        }
    }
}
