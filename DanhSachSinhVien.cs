using BTVN_C3_B6_C1;
using System;
using System.Collections.Generic;
using System.Text;

namespace chuong3_part1_baitap6
{
    class DanhSachSinhVien
    {
        private int n;
        private SinhVien[] DS;

        public void nhap()
        {
            Console.WriteLine("Hay nhap sinh vien trong danh sach");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tin sinh vien thu:" + i);
                DS[i] = new SinhVien();
                DS[i].Nhap();
                DS[i].TinhDiemTB();
            }
        }
        public void xuat()
        {
            Console.WriteLine("Thong tin sinh vien la:");
            if (DS != null && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    DS[i].xuat();
                }
            }
        }
        public void sapxep()
        {
            Console.WriteLine("Danh sach sinh vien duoc sap xep la:");
            for (int i=0;i<n-1;i++)
                for (int j = i + 1; j < n; j++)
                {
                    if(string.Compare(DS[i].msv, DS[j].msv, true) > 0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
        }
        public void Diemlonhon()
        {
            Console.WriteLine("Sinh vien cos diem trung binh tren 8 la:");
            
                for (int i = 0; i<n; i++)
            {
                if(DS[i].DiemTb > 8)
                {
                    DS[i].xuat();
                }
            }
            
        }
    }
}
