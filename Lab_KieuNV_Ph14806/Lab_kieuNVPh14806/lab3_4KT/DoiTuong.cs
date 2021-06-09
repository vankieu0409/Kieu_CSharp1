using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4KT
{
    class DoiTuong
    {
        private string ten;
        private string msv;
        private double java;
        private double csharp;

        public DoiTuong()
        {
            
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

        public double Java
        {
            get => java;
            set => java = value;
        }

        public double Csharp
        {
            get => csharp;
            set => csharp = value;
        }

        public void inRa()
        {
            Console.WriteLine(" Danh sách SV\n" +
                              " 1 ten: {0}\n" +
                              " 2. MSA: {1}\n" +
                              " 3. Điểm JaVa: {2}\n" +
                              " 4. ĐIểm C#: {3}",ten,msv,java,Csharp);
        }
    }
}
