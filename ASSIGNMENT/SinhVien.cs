using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    class SinhVien
    {
        private string hoVaTen;
        private double diem;
        private string email;

        public SinhVien()
        {
                
        }

        public SinhVien(string hoVaTen, double diem, string email)
        {
            this.hoVaTen = hoVaTen;
            this.diem = diem;
            this.email = email;
        }

        public string HoVaTen
        {
            get => hoVaTen;
            set => hoVaTen = value;
        }

        public double Diem
        {
            get => diem;
            set => diem = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public void inRaManHinh()
        {
            Console.WriteLine("ho va ten: "+hoVaTen +"\n"+ "Diem: "+diem + "\n"+"email: "+email);
        }
    }
}
