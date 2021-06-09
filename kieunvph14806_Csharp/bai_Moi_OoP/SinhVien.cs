using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace bai_Moi_OoP
{
    class SinhVien
    {
        public string name;
        public string msv;
        public int ns;
        public double diemCsharp;

        public SinhVien()
        {

        }
        public SinhVien(string name, string msv, int ns, double diemCsharp)
        {
            this.name = name;
            this.msv = msv;
            this.ns = ns;
            this.diemCsharp = diemCsharp;
        }

        public string Name
        {
            get => name;
            set => name = value;
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


        public void InraManHinh()
        {
            Console.WriteLine(" Tên: {0} \n" +
                              " Mã SV: {1} \n" +
                              " Năm sinh: {2} \n" +
                              " Điểm C#1: {3} \n",name,msv,ns,diemCsharp);
        }
    }
}
