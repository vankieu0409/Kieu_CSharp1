using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_6_contructor_Khongtham_so
{
    ////Đề 1: Viết 1 chương trình các chức năng sau: (SwitchCase - While)

    //1.      Thêm 5 Kế Toán bằng contructor có tham số(ID -
    //Int, luong – double, Ten – string, TrangThai - bool) – (5 Điểm)

    //2.      Xóa kế toán theo mã(3- Điểm) – Sử dụng List

    //3.      Sắp xếp giảm dần. (1 - Điểm)

    //4.      Thoát

    //Triển khai bài: Có lớp đối tượng riêng, lớp chức năng riêng,
    //và main riêng. 1 Điểm còn lại các thành phần nhỏ trong bài.

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ServiceKeToan pt = new ServiceKeToan();

            string lenh;
            do
            {
                Console.WriteLine("         Danh sách Ct\n" +
                                  " 1. Thêm kế toán nhập từ bàn phím\n" +
                                  " 2. xóa kế toán\n" +
                                  " 3. Sắp xếp thứ tự theo ID, không in ra\n" +
                                  " 4. in ra\n" +
                                  " 5. thoát\n" +
                                  "_______________");
                Console.Write(" mời bạn nhập chọn CT: ");
                lenh = Console.ReadLine();
                switch (lenh)
                {
                    case "1": ; break;
                    case "2": pt.xoabangMa(); break;
                    case "3": pt.sapXepAn(); break;
                    case "4": pt.inra(); break;
                    case "5":
                        Console.WriteLine(" chào bạn!\n" +
                                          " Mình Té đây."); break;
                    default: Console.WriteLine(" Chức năng Không có mời nhập lại:"); break;
                }

                Console.WriteLine("\n");
            } while ((lenh == "5") ? false : true);
        }
    }
}
