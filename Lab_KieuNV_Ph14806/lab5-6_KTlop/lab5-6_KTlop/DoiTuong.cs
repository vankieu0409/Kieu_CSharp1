using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_6_KTlop
{
    class DoiTuong
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

        public void inra()
        {
            Console.WriteLine(" tên: {0}\n" +
                              " maSV: {1}\n" +
                              " Điểm Java: {2}\n" +
                              " Điểm CSharp: {3}",ten,ma,java,cSharp);
        }
    }
}
