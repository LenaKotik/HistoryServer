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
        public static List<Student> online = new List<Student>();
#nullable enable
        public static Student? GetById(int id)
        {
            foreach (Student s in online)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }
        private static readonly string connString = "Data Source=historyserver.database.windows.net;Initial Catalog=mydb;User ID=LenaKotik;Password=Poland2104";
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
                        DoubleEncoding decoder = new DoubleEncoding(); 
                        Student s = new Student();
                        s.Id = (int)reader["id"];
                        s.Name = decoder.Decode((string)reader["name"]);
                        s.Date = (DateTime)reader["date"];
                        s.Result = (int)reader["result"];
                        students.Add(s);
                    }
                    connection.Close();
                    return students;
                }
            }
        }
        public static void Send(int id)
        {
#pragma warning disable
            try
            {
                Student s = GetById(id);
                Send(s.Name, s.Result);
                s.IsSent = true;
            }
            finally
            {}
#pragma warning restore
        }
        public static void Clean()
        {
            foreach (Student s in online)
            {
                if ((s.Date.Date != DateTime.Today || s.IsSent) && online.Contains(s))
                {
                    online.Remove(s);
                }
            }
        }
        async public static void Send(string name, int result)
        {
            DoubleEncoding encoder = new DoubleEncoding();
            string encname = encoder.Encode(name);
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string query = $"INSERT INTO Students VALUES ('{encname}', SYSDATETIME(), {Math.Round(result/(float)Questions.Score*100, MidpointRounding.ToPositiveInfinity)});";
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
