using System;
using System.Collections.Generic;

namespace _2._6_OOP__lLapTrinhHuongDoiTuong
{
    public class ServiceGiaoVien
    {
        private List<GiaoVien> _lstGiaoVien;
        private GiaoVien giaoVien;

        public ServiceGiaoVien()
        {
            _lstGiaoVien=new List<GiaoVien>();
        }

        public void InRamanHinh()
        {
            foreach (var x in _lstGiaoVien)
            {
                x.inRamanHinh();
            }
        }

        public void AddGiaoVien()
        {
            int soLuongGiaoVien;
            Console.WriteLine(" mời bạn nhập số Lượng Giáo viên: ");
            soLuongGiaoVien=Convert.ToInt16(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < soLuongGiaoVien; i++)
            {
                giaoVien = new GiaoVien();
                giaoVien.MaGv = a++;
                Console.WriteLine(" mời bạn nhập họ giáo viên: ");
                giaoVien.Ho = Console.ReadLine();
                Console.WriteLine(" mời bạn nhập tên đệm giáo viên: ");
                giaoVien.TenDem = Console.ReadLine();
                Console.WriteLine(" mời bạn nhập tên giáo viên: ");
                giaoVien.Tengv = Console.ReadLine();
                Console.WriteLine(" mời bạn nhập Email giáo viên: ");
                giaoVien.Email3 = Console.ReadLine();
            }

        }
    }
}