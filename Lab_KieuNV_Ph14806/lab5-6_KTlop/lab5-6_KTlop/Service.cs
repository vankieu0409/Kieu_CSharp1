using System;
using System.Collections.Generic;

namespace lab5_6_KTlop
{
    public class Service
    {
        private List<DoiTuong> _lstDoiTuongs;
        private DoiTuong sv, sv1, sv2, sv3, sv4, sv5;
        private string input;

        public Service()
        {
            _lstDoiTuongs = new List<DoiTuong>();
            sv = new DoiTuong();
            sv.Ten = "Kieu";
            sv.Ma = "1";
            sv.Java = 1;
            sv.CSharp = 1;
            _lstDoiTuongs.Add(sv);

            sv1 = new DoiTuong();
            sv1.Ten = "kk";
            sv1.Ma = "3";
            sv1.Java = 2;
            sv1.CSharp = 1;
            _lstDoiTuongs.Add(sv1);

            sv2 = new DoiTuong();
            sv2.Ten = "bb";
            sv2.Ma = "4";
            sv2.Java = 3;
            sv2.CSharp = 1;
            _lstDoiTuongs.Add(sv2);

            sv3 = new DoiTuong();
            sv3.Ten = "bb";
            sv3.Ma = "2";
            sv3.Java = 4;
            sv3.CSharp = 1;
            _lstDoiTuongs.Add(sv3);

            sv4 = new DoiTuong();
            sv4.Ten = "bb";
            sv4.Ma = "5";
            sv4.Java = 5;
            sv4.CSharp = 1;
            _lstDoiTuongs.Add(sv4);
            
        }

      

        public void timkiem()
        {
            Console.Write(" mời bạn nhập mã: ");
            input = Console.ReadLine();
            int lstemp = getIndex(input);
            if (lstemp == -1)
            {
                Console.WriteLine(" mã sinh viên bạn tìm không có");
            }
            _lstDoiTuongs[lstemp].inra();
        }

        public void Sapxep()
        {
            _lstDoiTuongs.Sort((a,b)=>a.Java.CompareTo(b.Java));
        }

        public void xuat()
        {
            foreach (var VARIABLE in _lstDoiTuongs)
            {
                VARIABLE.inra();
                Console.WriteLine("-------" +
                                  "\n" +
                                  "\n");
            }
        }
     

        private int getIndex(String msv)
        {
            for (int i = 0; i < _lstDoiTuongs.Count; i++)
            {
                if (_lstDoiTuongs[i].Ma==msv)
                {
                    return i;
                }

            }

            return -1;
        }
    }
}