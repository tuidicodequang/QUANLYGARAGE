using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYGARAGE
{
    public class SanPham
    {
        string masp;
        string tensp;
        string mau;
        string hang;
        long gia;

        public string MaSP { get => masp; set => masp = value; }
        public string Tensp { get => tensp; set => tensp = value; }

        public string Mau { get => mau; set => mau = value; }

        public string Hang { get => hang; set => hang = value; }

        public long Gia { get => gia; set => gia = value; }

        public SanPham() { }

        public SanPham(string masp,string tensp,string hang,string mau,long gia)
        {
            this.masp = masp;
            this.tensp = tensp;
            this.hang = hang;
            this.mau = mau;
            this.gia = gia;
        }
    }
}
