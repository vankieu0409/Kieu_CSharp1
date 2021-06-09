using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6_OOP__lLapTrinhHuongDoiTuong
{
    // Meo(Ten, Tuoi, DiaChi, GioiTinh, NgaySinh)
    class Meo
    {
        private string name;
        private int age;
        private string address;
        private string sex;
        private string dateOfBrith;

        public Meo()
        {
            Console.WriteLine(" he lô");
        }

        public Meo(string name, int age, string address, string sex, string dateOfBrith)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.sex = sex;
            this.dateOfBrith = dateOfBrith;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Sex
        {
            get => sex;
            set => sex = value;
        }

        public string DateOfBrith
        {
            get => dateOfBrith;
            set => dateOfBrith = value;
        }

        public void information()
        {
            Console.WriteLine("{0} | {1} | {2} | {3} | {4}",name,age,address,sex,dateOfBrith);
        }
    }
}
