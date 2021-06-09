using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace on
{
    public class GiaoVien
    {
        private int id;
        private string ten;
        private double soGiowDay;

        public GiaoVien()
        {
            
        }

        public GiaoVien(int id, string ten, double soGiowDay)
        {
            this.id = id;
            this.ten = ten;
            this.soGiowDay = soGiowDay;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public double SoGiowDay
        {
            get => soGiowDay;
            set => soGiowDay = value;
        }

        public void inThongTin()
        {
            Console.WriteLine(" ID: {0}\n" +
                              " Tên: {1}\n" +
                              " Số giờ dạy: {2}\n",id,ten,soGiowDay);
        }
    }
}