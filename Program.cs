using chuong3_part1_baitap6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN_C3_B6_C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Bài tập 6");
            DanhSachSinhVien abc = new DanhSachSinhVien();
            abc.nhap();
            abc.sapxep();
            abc.xuat();
            abc.Diemlonhon();
            Console.ReadLine();
        }
    }
}
