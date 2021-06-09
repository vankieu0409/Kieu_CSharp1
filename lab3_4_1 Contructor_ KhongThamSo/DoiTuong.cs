using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4_1
{
    class DoiTuong
    {
        private string ten;
        private string ma;
        private double diemJava;
        private double diemCsharp;

        public DoiTuong()
        {
            
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

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }

        public void inRa()
        {
            Console.WriteLine($"ten: {ten} | MaSV: {ma} | diemJV: {diemJava} | Điểm C#1: {diemCsharp}");
        }
    }
}
