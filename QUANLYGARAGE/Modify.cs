using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYGARAGE
{
    internal class Modify
    {
        SqlDataAdapter dataAdapter;//se truy xuat du lieu vao bang
        public Modify() { }
        public DataTable getNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM NhanVien";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


        
    }
}
