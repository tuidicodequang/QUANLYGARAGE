﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYGARAGE
{
    public class KhachHang
    {
        string username;
        string makh;
        string hoten;
        string gioitinh;
        DateTime ngaysinh;
        string matkhau;
        string diachi;
        string sdt;

        public string Username { get => username; set => username = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public KhachHang() { }
        public KhachHang(string username, string makh, string hoten, string gioitinh, DateTime ngaysinh, string matkhau, string diachi, string sdt)
        {
            Username = username;
            Makh = makh;
            Hoten = hoten;
            this.gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
            Matkhau = matkhau;
            Diachi = diachi;
            Sdt = sdt;
            Username = username;
        }
    }
}
