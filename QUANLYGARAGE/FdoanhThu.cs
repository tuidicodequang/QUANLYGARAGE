
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace DashboardApp
{
    public partial class FdoanhThu : Form
    {
        //Fields
        public FdoanhThu()
        {
            InitializeComponent();
        }


        private void FdoanhThu_Load(object sender, EventArgs e)
        {
            SqlDataReader reader;
            List<KeyValuePair<string, int>> TopProductsList = new List<KeyValuePair<string, int>>();
            string connectionString = DataProvider.Instance.connectionString;

            string query = @"select top 5 P.TenSP, sum(SanPhamDuocMua.SoLuong) as Q
                                            from SanPhamDuocMua
                                            inner join SanPham P on P.MaSP = SanPhamDuocMua.MaSP
                                            inner
                                            join [HoaDon] O on O.MaHD = SanPhamDuocMua.MaHD
                                            group by P.TenSP
                                            order by Q desc ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open(); // Mở kết nối
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TopProductsList.Add(
                        new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                }
                reader.Close(); // Đóng SqlDataReader sau khi sử dụng dữ liệu

                // Gán dữ liệu vào chartTopProducts
                chartTopProducts.DataSource = TopProductsList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();
            }

        }
    }
}
