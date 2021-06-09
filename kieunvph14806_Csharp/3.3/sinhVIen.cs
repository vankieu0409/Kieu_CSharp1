using System;

namespace _3._3
{
    public class SinhVien
    {

        private string ten;
        private string ma;
        private double diemJava;
        private double diemCSharp;

        public SinhVien()
        {

        }

        public SinhVien(string ten, string ma, double diemJava, double diemCSharp)
        {
            this.ten = ten;
            this.ma = ma;
            this.diemJava = diemJava;
            this.diemCSharp = diemCSharp;
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

        public double DiemJava
        {
            get => diemJava;
            set => diemJava = value;
        }

        public double DiemCSharp
        {
            get => diemCSharp;
            set => diemCSharp = value;
        }

        public void inRA()
        {
            Console.WriteLine(" Tên: {0} \n" +
                              " Mã SV: {1} \n" +
                              " diem JAVA: {2} \n" +
                              " Điểm C#1: {3} \n", ten, ma, diemJava, diemCSharp);
        }
    }
}