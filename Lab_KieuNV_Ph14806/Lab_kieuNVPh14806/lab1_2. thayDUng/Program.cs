using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab1_2.thayDUng
{
    class Program
    {
        static int siSo;
        static string[] ma, hoTen, namSinh;

        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.GetEncoding("UTF-8");
            menu();
        }

        static void menu()
        {
            int lenh;
            do
            {
                Console.WriteLine(" chương trình quản lý học sinh, sinh viên\n" +
                                  "1. CT nhập thông tin Sinh Viên \n" +
                                  "2. CT xuất thông tin Sinh Viên.");
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
            Console.Write(" mời bạn nhâp Sĩ số: ");
            siSo = Int32.Parse(Console.ReadLine());
            ma = new string[siSo];
            hoTen = new string[siSo];
            namSinh = new string[siSo];
            for (int i = 0; i < siSo; i++)
            {
                Console.WriteLine("\n" +
                                  "Sinh viên thứ: "+(i+1)+"\n");
                Console.Write(" Mã SInh viên: ");
                ma[i] = Console.ReadLine();
                Console.WriteLine("");
                Console.Write(" Họ ten SInh Viên: ");
                hoTen[i] = Console.ReadLine();
                Console.WriteLine("");
                Console.Write(" năm Sinh: ");
                namSinh[i] = Console.ReadLine();

            }

            // xuất danh sách

            
        }

        static void xuatDanhSach()
        {
            Console.WriteLine(" Danh Sách Sinh Viên: ");
            for (int i = 0; i < siSo; i++)
            {
                Console.WriteLine("----------------------\n" +
                                  "SInh viên thứ: "+(i+1));
                Console.WriteLine(" Mã Sinh viên: " + ma[i]);
                Console.WriteLine(" HỌ tên:  "+hoTen[i]);
                Console.WriteLine(" năm Sinh: "+ namSinh[i]);
                Console.WriteLine("");

            }
        }

    }
}
