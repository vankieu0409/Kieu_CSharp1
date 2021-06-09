using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._7_CauLenh_Else
{
    class Program
    {
        /*
        * Bài 1.6 Cầu điều kiện IF...ELSE (Nếu Thì)
        * Dùng để thực hiện 1 hành động nếu IF(TRUE) và ngược lại sẽ vào Else.
        *
        * Cấu trúc: 
        * if (true)
           {
               Nếu mà If true thì sẽ thực hiện 1 hành động nào đó
           }
           else
           {
               Nếu không thỏa mãn IF thì mặc định là vào ELSE
           }
        */
        static void Main(string[] args)
        {
            if (true)
            {

            }
            else
            {

            }

            /*
             * Viết 1 chương trình cho người dùng nhập điểm GPA
             * 9 - 10 = Xuất Sắc
             * 8 - 9 = Giỏi
             * 6 - 7 = Khá
             * 5 - 6 = TB
             * 0 - 5 = Học lại
             * Không sử dụng Else IF - Ko dùng return
             * Chỉ dùng IF Else
             */
            double diem;
            Console.WriteLine("Mời bạn nhập điểm: ");
            diem = Double.Parse(Console.ReadLine());// Gán giá trị do người dùng nhập vào
            if (diem >= 9 && diem <= 10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else
            {
                if (diem >= 8 && diem < 9)
                {
                    Console.WriteLine("Giỏi");
                }
                else
                {
                    if (diem >= 7 && diem < 8)
                    {
                        Console.WriteLine("Khá");
                    }
                    else
                    {
                        if (diem >= 5 && diem < 6)
                        {
                            Console.WriteLine("Trung bình");
                        }
                        else
                        {
                            Console.WriteLine("Học lại");
                        }
                    }
                }
            }
        }
    }
}
