using System;

namespace kt_thu_lab78
{
    public class SinhVien
    {
        private int msv;
        private string ten;
        private int namSinh;

        public SinhVien()
        {
            
        }

        public SinhVien(int msv, string ten, int namSinh)
        {
            this.msv = msv;
            this.ten = ten;
            this.namSinh = namSinh;
        }

        public int Msv
        {
            get => msv;
            set => msv = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public int NamSinh
        {
            get => namSinh;
            set => namSinh = value;
        }

        public virtual void inThongTin()
        {
            Console.WriteLine(" 1. Mã SV: PH{0}\n" +
                              " 2. Tên: {1}\n" +
                              " 3. Năm Sinh : {2}", msv,ten,namSinh);
        }
    }
}