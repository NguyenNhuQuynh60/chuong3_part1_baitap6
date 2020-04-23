using System;
using System.Collections.Generic;
using System.Text;

namespace BTVN_C3_B6_C1
{
    class SinhVien
    {
        private string MSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;

      
        public string msv
        {
            get { return MSV; }
            set { MSV = value; }
        }
        public double DiemTb
        {
            get { return DiemTB; }
            set
            {
                DiemTB = value;
            }
        }
        public SinhVien()
        {
            MSV = "";
            HoTen = "";
            NamSinh = 2000;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }
        public SinhVien(string HoTen, int NamSinh, double DiemLapTrinh, double DiemCSDL, string QueQuan )
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = this.DiemCSDL;
        }
        public void Nhap()
        {
            Console.WriteLine("Hãy Nhập mã sinh viên: ");
            MSV = Console.ReadLine();
            Console.WriteLine("Hãy Nhập họ và tên sinh viên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Nhập điểm Lập trình = ");
            DiemLapTrinh = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm CSDL= ");
            DiemCSDL = double.Parse(Console.ReadLine());
     
        }
        public void TinhDiemTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }
        public void Diemhon8()
        {
            if (DiemTB > 8)
                Console.WriteLine("sinh vien do la:" + HoTen);
        }
        public void xuat()
        {
            Console.WriteLine(" Thông tin sinh viên là:");
            Console.WriteLine("  Mã sinh viên: {0}",MSV);
            Console.WriteLine("  Họ và Tên: {0}",HoTen);
            Console.WriteLine("  Năm Sinh: {0}",NamSinh);
            Console.WriteLine("  Điểm lập trình = {0} ,\t Điểm CSDL = {1}", DiemLapTrinh, DiemCSDL);
            Console.WriteLine("  Điểm trung bình = {0}", DiemTB);
        }
    }
}
