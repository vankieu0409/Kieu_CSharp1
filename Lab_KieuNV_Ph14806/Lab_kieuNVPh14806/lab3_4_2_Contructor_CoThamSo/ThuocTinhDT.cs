using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4_2_Contructor_CoThamSo
{
    class ThuocTinhDT
    {
        private int id;
        private double luong;
        private string ten;
        private bool trangThai;

        public ThuocTinhDT()
        {
            
        }
        public ThuocTinhDT(int id, double luong, string ten, bool trangThai)
        {
            this.id = id;
            this.luong = luong;
            this.ten = ten;
            this.trangThai = trangThai;
        }


        public int Id
        {
            get => id;
            set => id = value;
        }

        public double Luong
        {
            get => luong;
            set => luong = value;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public bool TrangThai
        {
            get => trangThai;
            set => trangThai = value;
        }

        public void inRa()
        {
            Console.WriteLine($" Tên: {ten} | ID: {id} | Lương: {luong} | Trạng Thái: {trangThai} ");
        }
    }
}
