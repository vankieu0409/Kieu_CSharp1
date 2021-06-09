using System;
using System.Collections.Generic;

namespace on
{
    public class QLGV
    {
        private List<GiaoVien> _lstGiaoViens;
        private GiaoVien gv;
        private string input;

        public QLGV()
        {
            _lstGiaoViens = new List<GiaoVien>();
        }

        public void Nhap()
        {
            do
            {
                int sl;
                Console.Write(" MỜi bạn nhập số Lượng Vào Danh Sách: ");
                sl = Int16.Parse(Console.ReadLine());
                for (int i = 0; i < sl; i++)
                {
                    gv = new GiaoVien();

                    Console.Write(" Mời bạn Nhập ID: ");
                    gv.Id = Int32.Parse(Console.ReadLine());
                    Console.Write(" Mời bạn Nhập tên Của GV: ");
                    gv.Ten = (Console.ReadLine());
                    Console.Write(" Mời bạn Nhập Số Giờ Dạy: ");
                    gv.SoGiowDay = double.Parse(Console.ReadLine());

                    _lstGiaoViens.Add(gv);
                }

                Console.WriteLine(" bạn có muốn nhập thêm: \n" +
                                  " có : c\n" +
                                  " Không: k\n");
                input = Console.ReadLine();

            } while (!(input == "k"));
        }

        public void Xuat()
        {
            foreach (var VARIABLE in _lstGiaoViens)
            {
                VARIABLE.inThongTin();
            }
        }

        public void DSGiaoVienhown21gioday()
        {
            for (int i = 0; i < _lstGiaoViens.Count; i++)
            {
                if (_lstGiaoViens[i].SoGiowDay > 50)
                {
                    _lstGiaoViens[i].inThongTin();
                }

            }
        }

    }
}