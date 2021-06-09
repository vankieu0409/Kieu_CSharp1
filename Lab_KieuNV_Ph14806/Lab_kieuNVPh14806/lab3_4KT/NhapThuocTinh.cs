using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4KT
{
    class NhapThuocTinh
    {
        private DoiTuong sv = new DoiTuong();
        private List<DoiTuong> _lstSInhViens;

        public NhapThuocTinh()
        {
            _lstSInhViens = new List<DoiTuong>();
        }

        public void Nhap1SV()
        {
            Console.Write(" mời bạn nhập tên: ");
            sv.Ten = Console.ReadLine();
            Console.Write(" mời bạn nhập MSV: ");
            sv.Msv = Console.ReadLine();
            Console.Write(" mời bạn nhập Điểm Java: ");
            sv.Java = double.Parse(Console.ReadLine());
            Console.Write(" mời bạn nhập Điểm C#1 : ");
            sv.Csharp= double.Parse(Console.ReadLine());

            Console.WriteLine("----\n");


        }

        public void NhapSVList()
        {
            

            int sizeList;
            Console.Write(" mời bạn nhập số Luojng Sinh Viên: ");
            sizeList= Int32.Parse(Console.ReadLine());

            for (int i = 0; i < sizeList; i++)
            {
                DoiTuong sv = new DoiTuong();

                Console.Write(" mời bạn nhập tên: ");
                sv.Ten = Console.ReadLine();
                Console.Write(" mời bạn nhập MSV: ");
                sv.Msv = Console.ReadLine();
                Console.Write(" mời bạn nhập Điểm Java: ");
                sv.Java = double.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập Điểm C#1 : ");
                sv.Csharp = double.Parse(Console.ReadLine());

                _lstSInhViens.Add(sv);
                Console.WriteLine("----\n");
            }
            
        }

        public void xuatRaManHinh()
        {
            Console.WriteLine("\n"+" SV: của CT1 vừa nhập: ");
            sv.inRa();
            Console.WriteLine("\n" +
                              "------ DSSV của CT2: -----\n");
            foreach (var xSV in _lstSInhViens)
            {
                xSV.inRa();
                Console.WriteLine("\n");
            }
            
        }
    }
}
