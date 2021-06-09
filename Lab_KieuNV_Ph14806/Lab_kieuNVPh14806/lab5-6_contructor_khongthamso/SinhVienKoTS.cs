using System;

namespace lab5_6_contructor_khongthamso
{
    public class SinhVienKoTS
    {
        private string ten;
        private string ma;
        private double java;
        private double cSharp;

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

        public double Java
        {
            get => java;
            set => java = value;
        }

        public double CSharp
        {
            get => cSharp;
            set => cSharp = value;
        }

        public void InRaManHinh()
        {
            Console.WriteLine(" Tên: {0}\n" +
                              " MaSV: {1}\n" +
                              " Điểm Java: {2}\n" +
                              " Điểm C#: {3}",ten,ma,java,cSharp);
        }
    }
}