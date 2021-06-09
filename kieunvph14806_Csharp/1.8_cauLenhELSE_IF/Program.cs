using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._8_CauLenh_Else_If
{
    class Program
    {
        /*
       * Bài  1.7 Cầu điều kiện Else If dùng trong trường hợp có nhiều điều kiện khác nhau và thực hành động tương ứng với từng điều kiện. Else If phải luôn True thì mới thực hiện hành động bên trong nó.
       *
       * Lưu ý: Nếu thỏa mãn 1 điều kiện thì nó chỉ thực hiện hành động trong điều kiện đó mà thôi.
       *
       * Công thức:
       *   if (true)
          {
              //Thực hiện 1 hành động nếu If đúng
          }else if (<Điều kiện 1>)
          {
              //Khi If không thỏa mãn và Else If phải true thì mới vào đây thực hiện 1 hành động.
          }else if (<Điều kiện 2>)
          {
              //Tương tự
          }else
          {
              //Khi tất cả các điều kiện ở trên không thỏa mãn thì sẽ vào đây
          }
       */
        static void Main(string[] args)
        {
            /*
             * Viết 1 chương trình cho người dùng nhập điểm GPA
             * 9 - 10 = Xuất Sắc
             * 8 - 9 = Giỏi
             * 6 - 7 = Khá
             * 5 - 6 = TB
             * 0 - 5 = Học lại     
             */
            double diem = 8.5;
            if (diem >= 9 && diem <= 10)
            {
                Console.WriteLine("Xuất sắc");
            }
            else if (diem > 8 && diem < 9)
            {

            }
            else if (diem > 6 && diem < 8)
            {

            }
            else
            {

            }
        }
    }
}