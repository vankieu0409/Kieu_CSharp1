using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6.ToanTu
{
    class Program
    {
        /*
        * Bài 1.5 Câu điều kiện rẽ nhánh IF
        * ĐƯợc sử dụng để lập điều kiện và sẽ thực thi 1 hành động nào đó nếu thỏa mãn điều kiện.
        *
        * Công thức IF: if + tab       
        *   if (<Điều kiện>)
           {
               If phải luôn đúng
               Một hành động được thi khi thỏa mãn điều kiện
           }
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            /*  double diem;
              Console.Write(" mời bạn nhập điểm: ");
              diem = double.Parse(Console.ReadLine());
              if (diem >= 9)//Điều kiện để chạy câu lệnh trong IF thì IF phải luôn đúng.
              {
                  Console.WriteLine("Ban la hoc sinh xuat sac");
              }
              else
              {

                  if ((diem >= 8) && (diem < 9))//= False
                  {
                      Console.WriteLine(" Bann la hoc sinh KHa ");
                  }
                  else
                  {

                      if ((diem >= 6) && (diem <= 7))//= False
                      {
                          Console.WriteLine(" Bann la hoc sinh KHa ");
                      }
                      else
                      {
                          if ((diem >= 5) && (diem < 6))//= False
                          {
                              Console.WriteLine(" Bann la hoc sinh Trung binh ");
                          }

                          else
                          {
                              Console.WriteLine(" Chuc muwng ban da phai hoc lai ");
                          }
                      }
                  }
              }
          }
          */

            //esle- if
            double diem;
            diem = double.Parse(Console.ReadLine());

            if (diem >= 9)
            {
                Console.WriteLine(" xuaast  sac");
            }
            else if (diem > 8 && diem < 9)
            {
                Console.WriteLine(" gioi");
            }
            else if (diem > 6 && diem < 8)
            {
                Console.WriteLine(" kha");
            }
            else if (diem > 5 && diem < 6)
            {
                Console.WriteLine(" trung binh");
            }
            else if (diem <= 5)
            {
                Console.WriteLine(" chúc mừng bạn đã phải học lại");
            }
        }
    }



}  
