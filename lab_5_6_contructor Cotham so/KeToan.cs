using System;

namespace lab_5_6_contructor_Khongtham_so
{
    public class KeToan
    {
        private string ten;
        private string Id;
        private double luong;
        private bool trangThai;

        public KeToan()
        {
            
        }

        public KeToan(string ten, string id, double luong, bool trangThai)
        {
            this.ten = ten;
            Id = id;
            this.luong = luong;
            this.trangThai = trangThai;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Id1
        {
            get => Id;
            set => Id = value;
        }

        public double Luong
        {
            get => luong;
            set => luong = value;
        }

        public bool TrangThai
        {
            get => trangThai;
            set => trangThai = value;
        }

        public void inRa()
        {
            Console.WriteLine(" tên: {0}\n" +
                              " ID: {1}\n" +
                              " Lương: {2}\n" +
                              " Trạng thái: {3}", ten, Id, luong,trangThai?"Đã trả Lương":"chưa Trả Lương");
        }
    }
}