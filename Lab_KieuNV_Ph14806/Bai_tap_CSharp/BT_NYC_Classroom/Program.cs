using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_NYC_Classroom
{
    class Program

    {
        //Switch Case + Vòng lặp vô hạn gồm 2 chức năng:
        //1 - Nhập thông tin người yêu cũ
        //2 - Xuất thông tin NY cũ
        //3 - Thoát

        //    Nhập thông tin nhiều người yêu cũ: Nhập các thông tin của NY Cũ thông tin sau: Tên, Năm Sinh, Giới tính, Chiều cao(Sử dụng mảng)
        //    * - Tên người yêu:
        //* - Năm sinh:
        //* - Tuổi người yêu:
        //* - Giới tính:
        //* - Chiều cao:
        static void Main(string[] args)
        { 
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            menu();
        }

        
        static int soExGirlFriends;           // khai báo bên ngoài Void khi 2 Chương trình có SỬ DỤNG CHUNG BIẾN
        static string[] name, yearOfBrith, Age, sex, height;

        // nhập danh  sách người yêu cũ
        static void NhapDS_NYC()
        {
            Console.Write("\n" + " CT liệt kê Danh sach người yêu cũ\n" + " Mời bạn nhập số Người yêu của của bạn: ");
                soExGirlFriends = Int32.Parse(Console.ReadLine());
                name = new string[soExGirlFriends];
                yearOfBrith = new string[soExGirlFriends];
                Age = new string[soExGirlFriends];
                sex = new string[soExGirlFriends];
                height = new string[soExGirlFriends];
                Console.WriteLine("\n");
                if (soExGirlFriends == 0)
                {
                    Console.WriteLine("\n" + " Lêu Lêu !!!!\n" +
                                      "Đồ Không có Người Yêu!!!       (^_^)(^_^) \n"
                                      +"______________________________________" );

                }
                else
                {

                    for (int i = 0; i < soExGirlFriends; i++)
                    {
                        Console.WriteLine("Mời bạn nhâp thông tin của Người Yêu Cũ thứ: " + (i + 1));
                        Console.Write(" - Họ tên: ");
                        name[i] = Console.ReadLine();
                        Console.Write(" - Năm Sinh: ");
                        yearOfBrith[i] = Console.ReadLine();
                        Console.Write(" - Tuổi: ");
                        Age[i] = Console.ReadLine();
                        Console.Write(" - Giới tính: ");
                        sex[i] = Console.ReadLine();
                        Console.Write(" - Chiều cao: ");
                        height[i] = Console.ReadLine();

                        Console.WriteLine("-------------------------------\n");
                    }
                }
            
        }
        // hiện Danh sách thông tin Ex
        static void danhSachEx()
        {
            Console.WriteLine(" Danh Sách thông tin những Người Yêu Cũ của Bạn: ");
            Console.WriteLine("");
            for (int i = 0; i < soExGirlFriends; i++)
            {
                Console.WriteLine(" Thông tin về Người Yêu Cũ thứ: "+(i+1)+"\n" +
                                  " - Họ và tên: {0}\n" +
                                  " - Năm Sinh: {1}\n" +
                                  " - Tuổi: {2}\n" +
                                  " - Giới tính: {3}\n" +
                                  " - Chiều cao: {4}\n",name[i],yearOfBrith[i],Age[i],sex[i],height[i]);
                
                Console.WriteLine(" tuổi: "+ "nowDateTime");

                Console.WriteLine("______________________________________\n");
            }
        }

        static void menu()
        {
            int lenh;
            do
            {
                Console.WriteLine("\n" +
                                  "      Danh Sách Chương trình về Người Yêu Cũ \n" +
                                  "\n" +
                                  " 1. Nhập Danh sách thông tin về Người Yêu Cũ\n" +
                                  " 2. Hiện Danh sách và thông tin chi tiết về nhưng Người Yêu Cũ của bạn\n" +
                                  " 3. Thoát chương trình\n");
                Console.Write(" Mời Bạn chọn Chương trình: "); 
                lenh=Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
                switch (lenh)
                {
                    case 1:
                        NhapDS_NYC();break;
                    case 2:
                        danhSachEx();break;
                    case 3:
                        Environment.Exit(3); break;
                    default:
                    {
                        Console.WriteLine(" Chương trình bạn vừa chọn không tồn tại\n" +
                                          " Vui lòng chọn lại.");
                    }
                        ;break;
                        Console.WriteLine("\n"+"+++++++++++++++++++++++++++\n");
                }

            } while (true);
        }
    }
}
