using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYGARAGE
{
    internal class Connection
    {
        public static string stringConnection = @"Data Source=DESKTOP-6ABDHJO\SQLEXPRESS;Initial Catalog=QuanLyOTo;Integrated Security=True";// Tao sever sau
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
