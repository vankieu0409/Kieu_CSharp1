using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAI_3._1_LINQ_CoBan
{
    class SinhVien
    {
        private string ten;
        private string msv;
        private int ns;
        private double diemCsharp;

        public SinhVien()
        {

        }

        public SinhVien(string ten, string msv, int ns, double diemCsharp)
        {
            this.ten = ten;
            this.msv = msv;
            this.ns = ns;
            this.diemCsharp = diemCsharp;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public int Ns
        {
            get => ns;
            set => ns = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine("Tên: {0} Mã SV: {1} Năm Sinh: {2} Điểm C#1: {3} ", ten, msv, ns, diemCsharp);
        }
    }
}