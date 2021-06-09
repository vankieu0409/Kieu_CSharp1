using System;
using System.Collections.Generic;

namespace test_lab3_4
{
    public class ThongTinSV
    {
        SinhVien[] arrSinhViens;                           // khai báo 1 mảng đối tượng sinh viên -- KHAI BÁO  TOÀN CỤC
        private List<SinhVien> _lstSinhViens;
        private SinhVien sv;
        private SinhVien sv1;
        
        public ThongTinSV()
        {
            _lstSinhViens = new List<SinhVien>();
        }
        public SinhVien bai2TaodoiTuongDoNguoiDungNhapVao()
        {
            SinhVien sv1 = new SinhVien();

            Console.Write(" mời bạn nhập Tên: ");
            sv1.Ten = Console.ReadLine();
            Console.Write(" mời bạn nhập Mã SV: ");
            sv1.Ma = Console.ReadLine();
            Console.Write(" mời bạn nhập điểm Java: ");
            sv1.DiemJava = double.Parse(Console.ReadLine());
            Console.Write(" mời bạn nhập điểm C#1: ");
            sv1.DiemCSharp = double.Parse(Console.ReadLine());
            Console.WriteLine("");


        }

       

        public void themSinhVienList()
        {

            int size;
            Console.WriteLine(" mời bạn nhập số lượng sinh viên: ");
            size = Int32.Parse(Console.ReadLine());
            arrSinhViens = new SinhVien[size]; // Khởi tạo kích thước do người dung nhập vào

            for (int i = 0; i < size; i++)
            {

                SinhVien sv = new SinhVien();

                Console.Write(" mời bạn nhập Tên: ");
                sv.Ten= Console.ReadLine();
                Console.Write(" mời bạn nhập Mã SV: ");
                sv.Ma = Console.ReadLine();
                Console.Write(" mời bạn nhập Năm sinh: ");
                sv.DiemJava = double.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập điểm C#1: ");
                sv.DiemCSharp = double.Parse(Console.ReadLine());

                _lstSinhViens.Add(sv);// thêm một đối tượng sau mỗi vòng chạy vào list Sinh Viên.
            }

            Console.WriteLine("");
        }

        public void inramanhinh()
        {
            int a;
            Console.WriteLine(" chọn 1 để hiện lên bạn sv nhập trong CT1\n" +
                              " chọn 2 để hiện lên DS SV ở CCT2");
            a=Int32.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                     sv1.inRA();
                    break;
                case 2:
                    foreach (var xSinhVien in _lstSinhViens)
                    {
                        xSinhVien.inRA();
                    }

                    ;break;
            }

            
            
        }

    }
}