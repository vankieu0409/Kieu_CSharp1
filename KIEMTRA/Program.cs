using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIEMTRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            int input;
            QLSV sv = new QLSV();
            do
            {
                Console.WriteLine("1.Nhap DS Sinh Vien ");
                Console.WriteLine("2.Xuat Danh Sach Doi Tuong ");
                Console.WriteLine("3.Xuat Danh Sach Co Danh Sach SV Tu 21 tuoi Tro Len ");
                Console.WriteLine("4. Tim SV Theo Ma \n" +
                                  " 5. Kế thừa ");
                Console.WriteLine("0.Thoat ");
                Console.WriteLine("Mời Bạn Chọn 1 Chức Năng ");
                input = Convert.ToInt32(Console.ReadLine());
                switch (Convert.ToInt32(input))
                {
                    case 1:
                        sv.NhapDS();
                        break;
                    case 2:
                        sv.XuatDS();
                        break;
                    case 3:
                        sv.XuatTheoTuoi();
                        break;
                    case 4:
                        sv.TimKiemTheoMa();
                        break;
                    case 5:
                        sv.KeThua();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Chức Năng Bạn Chọn Không Có !");
                        break;
                }
            } while (true);
        }
    }
}
