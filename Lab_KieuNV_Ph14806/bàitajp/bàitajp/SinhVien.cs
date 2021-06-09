using System;

namespace bàitajp
{
    public class SinhVien
    {
        private string ten;
        private string ma;
        private double diemCsharp;

        public SinhVien()
        {

        }    
        public SinhVien(string ten, string ma, double diemCsharp)
        {
            this.ten = ten;
            this.ma = ma;
            this.diemCsharp = diemCsharp;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ma
        {
            get => ma;
            set => ma = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public void InRaMaHinh()
        {
            Console.WriteLine("1. tên: {0}\n" +
                              "2. ma: {1}\n" +
                              "3. diemc#1: {2}", ten, ma, diemCsharp);
        }
    }
}