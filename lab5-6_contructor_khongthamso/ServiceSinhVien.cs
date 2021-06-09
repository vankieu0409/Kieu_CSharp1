using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Mime;

namespace lab5_6_contructor_khongthamso
{
    public class ServiceSinhVien
    {
        private List<SinhVienKoTS> _lstSinhViens;
        private SinhVienKoTS sv;
        private string input;

        public ServiceSinhVien()
        {
            _lstSinhViens = new List<SinhVienKoTS>();
            //SinhVienKoTS kt1 = new SinhVienKoTS("Kiều", "1", 200, 22);
            //SinhVienKoTS kt2 = new SinhVienKoTS("Phương", "2", 200, 22);
            //SinhVienKoTS kt3 = new SinhVienKoTS("Nghĩa", "4", 200, 22);
            //SinhVienKoTS kt4 = new SinhVienKoTS("Bình", "5", 200, 22);
            //SinhVienKoTS kt5 = new SinhVienKoTS("Hải", "3", 200, 22);

        }
        //1.      Thêm 5 sinh viên bằng contructor không tham số(Tên,
        //    Mã, Điểm Java - double, Điểm Csharp - double) – (5 Điểm)
        public void Nhap_5_SV()
        {
            Console.WriteLine("Ban Chỉ được phép nhập 5 sinh viên không thừa không thiếu\n" +
                              "\n" +
                              " mời bạn nhập thông tin đủ 5 SV ");
            for (int i = 0; i < 5; i++)
            {
                sv = new SinhVienKoTS();

                Console.Write(" Tên: ");
                sv.Ten = Console.ReadLine();
                Console.Write(" Mã Sinh Viên: ");
                sv.Ma = Console.ReadLine();
                Console.Write(" Điểm Java: ");
                sv.Java = Double.Parse(Console.ReadLine());
                Console.Write("Điểm C#: ");
                sv.CSharp = Double.Parse(Console.ReadLine());

                _lstSinhViens.Add(sv);
                Console.WriteLine("__________");


            }
        }


        //2.      Tìm kiếm sinh viên theo mã(3- Điểm) – Sử dụng List
        public void timKiemMaSV()
        {
            Console.Write("mời bạn Nhập mã SInh Viên Cần tìm: ");
            input = Console.ReadLine();
            int temp = getIndex(input);
            if (temp == -1)
            {
                Console.WriteLine(" Không tồn tại sinh viên vần tìm");
                return;
            }

            _lstSinhViens[temp].InRaManHinh();
        }


        //3.      Sắp xếp tăng dần(1 - Điểm)
        public void SapXepTangdantheoDiemCSharp()
        {
            _lstSinhViens.Sort((a, b) => a.CSharp.CompareTo(b.CSharp));
        }

        //in ra màn hình

        public void Xuat()
        {
            foreach (var VARIABLE in _lstSinhViens)
            {
                VARIABLE.InRaManHinh();
                Console.WriteLine("-------\n");
            }
        }

        private int getIndex(string _input)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Ma == _input)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}