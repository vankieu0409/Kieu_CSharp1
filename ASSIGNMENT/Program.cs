using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int chon;
            SeVerSinhVien chuongtrinh = new SeVerSinhVien();
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            do
            {
                Console.WriteLine("1. nhap danh sach hoc vien");
                Console.WriteLine("2. Xuat danh sach hoc vien");
                Console.WriteLine("3. Tim kiem hoc vien theo khoang điem nhap tu ban phim");
                Console.WriteLine("4. Tim kiem hoc vien theo hoc luc nhap tu ban phim");
                Console.WriteLine("5. Tim hoc vien theo ma so va cap nhat thong tin hoc vien");
                Console.WriteLine("6. xap xep hoc vien theo diem ");
                Console.WriteLine("7. xuat 5 hoc vien co diem cao nhat ");
                Console.WriteLine("8. tinh diem trung binh cua lop ");
                Console.WriteLine("9. xuat danh sach nhung hoc vien co diem tren TB cua lop");
                Console.WriteLine("10. tong hop so hoc vien theo hoc luc");
                Console.WriteLine("-------------------");
                Console.Write("moi ban chon 1 chuc nang:");
                chon = Convert.ToInt32(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("ban chon nhap sinh vien");
                        chuongtrinh.Nhap();
                        break;
                    case 2:
                        Console.WriteLine("Ban Chon Xuat Sinh Viên ");
                        chuongtrinh.Inra();
                        break;
                    case 3:
                        Console.WriteLine("Ban Chon Tim Kiem Sinh Viên Theo Khoang ");
                        chuongtrinh.TimKiemTheoKhoang();
                        break;
                    case 4:
                        Console.WriteLine("ban chon tim kiem theo hoc luc:");
                        chuongtrinh.TimKiemTheohocluc();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        Console.WriteLine("ban chon thoat");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("ban chon sai so vui long chon lai");
                        break;
                }

                Console.WriteLine("------------------");
            } while (true);

        }

    }
}
