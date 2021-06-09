using System;

namespace Bai_3._0_keThua
{
    public class SinhVien1
    {
        private string ten;
        private string ho;
        private string tenDem;
        private string sdt;
        private string email;
        private string msv;
        private double diemJava;
        private double diemCsharp;


        public SinhVien1()
        {

        }

        public SinhVien1(string ten, string ho, string tenDem, string sdt, string email, string msv, double diemJava, double diemCsharp)
        {
            this.ten = ten;
            this.ho = ho;
            this.tenDem = tenDem;
            this.sdt = sdt;
            this.email = email;
            this.msv = msv;
            this.diemJava = diemJava;
            this.diemCsharp = diemCsharp;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Msv
        {
            get => msv;
            set => msv = value;
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

        public void Inra()
        {
            Console.WriteLine(" 1. Họ Tên: {0} \n" +
                              " 2. số Điện thoại: {1} \n" +
                              " 3. email: {2} \n" +
                              " 4. Mã SV: {3} \n" +
                              " 4. điểm JaVa: {4} \n" +
                              " 5. diem c#1: {5}",(Ho+tenDem+ten),sdt,email,msv,diemJava,diemCsharp);
        }
    }
}