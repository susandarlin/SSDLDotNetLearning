using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
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
    }
}
