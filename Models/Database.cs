using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Security;

namespace HistoryServer.Models
{
    public static class Database
    {
        public static int result;
        private static readonly string connString = "Data Source=historyserver.database.windows.net;Initial Catalog=mydb;User ID=LenaKotik;Password=Poland2104";
        private static SecureString Password
        {
            get
            {
                SecureString pw = new SecureString();
                foreach (char ch in "Poland2104")
                {
                    pw.AppendChar(ch);
                }
                pw.MakeReadOnly();
                return pw;
            }
        }
        async public static Task<List<Student>> RequestTable()
        {
            List<Student> students = new List<Student>();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = "SELECT * FROM Students ORDER BY result DESC;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = await cmd.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        Student s = new Student();
                        s.Id = (int)reader["id"];
                        s.Name = (string)reader["name"];
                        s.Date = (DateTime)reader["date"];
                        s.Result = (int)reader["result"];
                        students.Add(s);
                    }
                    connection.Close();
                    return students;
                }
            }
        }
        async public static void Send(string name, int result)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = $"INSERT INTO Students VALUES ('{name}', SYSDATETIME(), {result});";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    await cmd.ExecuteNonQueryAsync();
                    connection.Close();
                }
            }
        }
    }
}
