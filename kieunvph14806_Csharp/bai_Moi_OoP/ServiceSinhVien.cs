using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai_Moi_OoP
{// contructor: 
    class ServiceSinhVien
    {
        SinhVien[] arrSinhViens;                           // khai báo 1 mảng đối tượng sinh viên -- KHAI BÁO  TOÀN CỤC
        private List<SinhVien> _lstSinhViens;
        private SinhVien sv1;

        public ServiceSinhVien()
        {
            _lstSinhViens = new List<SinhVien>();
        }

       //bài 1: tạo 2 đối tượng sử dụng Contrcutor có tham so svaf không có tham số
        public void BAitap1()
        {

            SinhVien sv1 = new SinhVien("Kieu", "PH14806", 2000, 9.4);
            // cách 2: Con trcutor không tham số
            SinhVien sv2 = new SinhVien();
            sv2.Name = " kk";
            sv2.Msv = "âfs";
            sv2.Ns = 1998;
            sv2.DiemCsharp = 9.5;

            sv1.InraManHinh();
            sv2.InraManHinh();

        }
        // bài 2: tạo đối tượng do người dùng nhập vào
        public void bai2TaodoiTuongDoNguoiDungNhapVao()
        {
            SinhVien sv1 = new SinhVien();

            Console.Write(" mời bạn nhập Tên: ");
            sv1.Name = Console.ReadLine();
            Console.Write(" mời bạn nhập Mã SV: ");
            sv1.Msv = Console.ReadLine();
            Console.Write(" mời bạn nhập Năm sinh: ");
            sv1.Ns = Int32.Parse(Console.ReadLine()); 
            Console.Write(" mời bạn nhập điểm C#1: ");
            sv1.DiemCsharp =Double.Parse( Console.ReadLine());

            sv1.InraManHinh();
        }

        // bài 3: tạo Array đối tượng SINH VIen
        public void Bai3()
        {
            //SinhVien[] arrSinhViens; // khai báo 1 mảng đối tượng sinh viên
           
                
            
            int size;
            Console.WriteLine(" mời bạn nhập số lượng sinh viên: ");
            size=Int32.Parse(Console.ReadLine());
            arrSinhViens = new SinhVien[size]; // Khởi tạo kích thước do người dung nhập vào

            for (int i = 0; i < arrSinhViens.Length; i++)
            {
                arrSinhViens[i] = new SinhVien();//Khởi tạo giá trị trong mảng

                Console.Write(" mời bạn nhập Tên: ");
                arrSinhViens[i].Name = Console.ReadLine();
                Console.Write(" mời bạn nhập Mã SV: ");
                arrSinhViens[i].Msv = Console.ReadLine();
                Console.Write(" mời bạn nhập Năm sinh: ");
                arrSinhViens[i].Ns = Int32.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập điểm C#1: ");
                arrSinhViens[i].DiemCsharp = Double.Parse(Console.ReadLine());
            }
            
            
            
            
        }
        public void INRAManHinh()
        {
            foreach (var x in arrSinhViens)
            {
                x.InraManHinh();
            }

        }

        // bài 4: tao list SInh Viên
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
                sv.Name = Console.ReadLine();
                Console.Write(" mời bạn nhập Mã SV: ");
                sv.Msv = Console.ReadLine();
                Console.Write(" mời bạn nhập Năm sinh: ");
                sv.Ns = Int32.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập điểm C#1: ");
                sv.DiemCsharp = Double.Parse(Console.ReadLine());

                _lstSinhViens.Add(sv);// thêm một đối tượng sau mỗi vòng chạy vào list Sinh Viên.
            }
        }

        public void inramanhinh()
        {
            foreach (var xSinhVien in _lstSinhViens)
            {
                xSinhVien.InraManHinh();
            }
        }

        public void method1()
        {
            SinhVien sv1 = new SinhVien();
            Console.WriteLine( " ");
        }

       
    }

} 


