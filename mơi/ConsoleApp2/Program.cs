using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static int siSo;
        static string[] ma, hoTen, namSinh;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            menu();
        }

        static void menu()
        {
            int lenh;
            do
            {
                Console.WriteLine(" chương trình quản lý Người Yêu \n" +
                                  "1. CT nhập thông tin Người Yêu \n" +
                                  "2. CT xuất thông tin Người Yêu");
                Console.WriteLine(" mời bạn chọn CHương trinh");
                lenh = Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        NhapDSSV();
                        break;
                    case 2:
                        xuatDanhSach();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine(" mời bạn chọn lại chương trình");
                        break;

                }

                
                Console.WriteLine("--------------------");
                Console.WriteLine("");
            } while (true);
        }

        static void NhapDSSV()
        {
            Console.Write(" mời bạn nhâp số Lượng Người Yêu muôn thêm: ");
            siSo = Int32.Parse(Console.ReadLine());
            if (siSo == 0)
            {
                Console.WriteLine(" Lêu lêu!  Đồ FA !");
            }
            else
            {


                ma = new string[siSo];
                hoTen = new string[siSo];
                namSinh = new string[siSo];
                for (int i = 0; i < siSo; i++)
                {
                    Console.WriteLine("\n" +
                                      "Người Yêu  thứ: " + (i + 1) + "\n");
                    Console.Write(" Mã Người Yêu : ");
                    ma[i] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write(" Họ ten Người Yêu : ");
                    hoTen[i] = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write(" năm Sinh: ");
                    namSinh[i] = Console.ReadLine();

                }
            }

            // xuất danh sách


        }

        static void xuatDanhSach()
        {
            Console.WriteLine(" Danh Sách Người Yêu: ");
            for (int i = 0; i < siSo; i++)
            {
                Console.WriteLine("----------------------\n" +
                                  " Người Yêu thứ: " + (i + 1));
                Console.WriteLine(" Mã Người Yêu: " + ma[i]);
                Console.WriteLine(" HỌ tên:  " + hoTen[i]);
                Console.WriteLine(" năm Sinh: " + namSinh[i]);
                Console.WriteLine("");

            }
        }

    }
}
