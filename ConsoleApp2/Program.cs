using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"DataSource=(local)\ANDRIANNA\SQLExpress;
                                       Initial Catalog = database;
                                        Intergrated Security = True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                connectionString.Open();
            }
            catch (SqlException se)
            {
                WriteLine("Error" + se.Message);
            }
            SqlCommand command = new SqlCommand("CREATE TABLE gruppa" + "(id int not null," + "personName varchar(200) not null", sqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                WriteLine("Error.");
                return;
            }
            WriteLine("Successful.");
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
    }
}
