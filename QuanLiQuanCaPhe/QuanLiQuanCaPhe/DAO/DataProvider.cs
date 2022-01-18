using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanCaPhe.DAO
{
    public class DataProvider
    {
        private static DataProvider? instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }

            private set => instance = value;
        }

        private string connectionString = "Data Source=PENNY;Initial Catalog=QuanLiCaPhe;Integrated Security=True;TrustServerCertificate=True";

        public DataTable ExcuteQuery(string query, object[]? parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            int v = i++;
                        }
                    }
                }


                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dt);

                connection.Close();
            }

            return dt;

        }

        public int ExcuteNonQuery(string query, object[]? parameter = null)
        {
            int dt = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = command.ExecuteNonQuery();

                connection.Close();
            }

            return dt;
        }

        internal DataTable ExecuteQuery(string query)
        {
            throw new NotImplementedException();
        }

        public object ExecuteScalar(string query, object[]? parameter = null)
        {
            object dt = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                dt = command.ExecuteScalar();

                connection.Close();
            }

            return dt;
        }
    }
}

