using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4_1
{
    class NhapThuocTinh
    {
        private DoiTuong sv = new DoiTuong();// khởi tạo và gán giá trị cục bộ
        private List<DoiTuong> _lstSinhVien;

        
        public NhapThuocTinh()
        {
            DoiTuong sv = new DoiTuong();
            _lstSinhVien = new List<DoiTuong>();
        }

        public void Nhap1SV()
        {
            

            Console.Write(" mời bạn Nhập tên: ");
            sv.Ten = Console.ReadLine();
            Console.Write(" mời bạn Nhập MSV: ");
            sv.Ma = Console.ReadLine();
            Console.Write(" mời bạn Nhập DiemJAVA: ");
            sv.DiemJava = Double.Parse(Console.ReadLine());
            Console.Write(" mời bạn Nhập Điểm C#1: ");
            sv.DiemCsharp = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------");
        }

        public void NhapDTDungList()
        {
            int sizeList;
            Console.Write("Mời bạn Nhập số lượng sinh viên trong danh sách: ");
            sizeList = Int16.Parse(Console.ReadLine());
            for (int i = 0; i < sizeList; i++)
            {
                DoiTuong sv = new DoiTuong();

                Console.Write(" mời bạn Nhập tên: ");
                sv.Ten = Console.ReadLine();
                Console.Write(" mời bạn Nhập MSV: ");
                sv.Ma = Console.ReadLine();
                Console.Write(" mời bạn Nhập DiemJAVA: ");
                sv.DiemJava = Double.Parse(Console.ReadLine());
                Console.Write(" mời bạn Nhập Điểm C#1: ");
                sv.DiemCsharp = double.Parse(Console.ReadLine());

                _lstSinhVien.Add(sv);
                Console.WriteLine("\n");


            }

            Console.WriteLine("----------");
        }

        public void InDoiTuong()
        {
       
                    sv.inRa();

                    foreach (var xSV in _lstSinhVien)
                    {
                        xSV.inRa();
                    } 

        }
            

    }

}

