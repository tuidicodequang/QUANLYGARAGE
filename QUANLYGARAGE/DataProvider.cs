using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataProvider
    {

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            set { instance = value; }
        }
        private DataProvider() { }


        string connectionString = @"Data Source=DESKTOP-6ABDHJO\SQLEXPRESS;Initial Catalog=QuanLyOTo;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] parameter = null)//tạo ra 1 bảng dùng query
        {
            DataTable data = new DataTable();
            try
            {
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

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            return data;
        }
        /*public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            try
            {
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

                    data = command.ExecuteNonQuery();
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            return data;
        }*/

        public object ExcuteScalar(string query, object[] parameter = null)//tạo ra 1 bảng dùng query
        {
            object data = 0;
            try
            {
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

                    data = command.ExecuteScalar();
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            return data;
        }
    }
}
