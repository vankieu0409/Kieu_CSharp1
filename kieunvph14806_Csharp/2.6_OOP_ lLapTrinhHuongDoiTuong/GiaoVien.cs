using System;

namespace _2._6_OOP__lLapTrinhHuongDoiTuong
{
    public class GiaoVien
    {
        private string tengv;
        private string tenDem;
        private string ho;
        private int maGv;
        private string Email1;
        private string Email2;
        private string sdt;
        private int soGioDay;
        private string chucVu;

        public GiaoVien()
        {
            
        }

        public GiaoVien(string tengv, string tenDem, string ho, int maGv, string email1, string email2, string sdt, int soGioDay, string chucVu)
        {
            this.tengv = tengv;
            this.tenDem = tenDem;
            this.ho = ho;
            this.maGv = maGv;
            Email1 = email1;
            Email2 = email2;
            this.sdt = sdt;
            this.soGioDay = soGioDay;
            this.chucVu = chucVu;
        }

        public string Tengv
        {
            get => tengv;
            set => tengv = value;
        }

        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public int MaGv
        {
            get => maGv;
            set => maGv = value;
        }

        public string Email3
        {
            get => Email1;
            set => Email1 = value;
        }

        public string Email4
        {
            get => Email2;
            set => Email2 = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public int SoGioDay
        {
            get => soGioDay;
            set => soGioDay = value;
        }

        public string ChucVu
        {
            get => chucVu;
            set => chucVu = value;
        }

        public void inRamanHinh()
        {
            Console.WriteLine( $" Họ Tên Giáo Viên: {Ho+" "+ tenDem+" "+ tengv} \n" +
                               $" Mã Giáo viên: {MaGv}\n" +
                               $" Email:{Email1 +"\n"+ Email2}\n" +
                               $" Số Điện thoại: {sdt}\n" +
                               $" Số Giờ Dạy: {soGioDay}");
        }
    }
}