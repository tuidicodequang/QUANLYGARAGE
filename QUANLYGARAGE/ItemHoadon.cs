using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYGARAGE
{
    public class ItemHoadon
    {
        string maSP;
        string tenSP;
        string mau;
        int count;
        long gia;

        long tonggia;
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }

        public string Mau { get => mau; set => mau = value; }
        public int Count { get => count; set => count = value; }

        public long Gia { get => gia; set => gia = value; }

        public long TongGia { get => tonggia; set => tonggia = value; }

    }
}
