using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1._9_SwitchCase
{
    class Program
    {
        /*
         * Switch Case câu lệnh rẽ nhành và thường được sử dụng làm menu trong lập trình.
         *
         * Công thức: sw + tab
         *
         *  switch (<Biểu thức>)
            {
                case <giá trị 1>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break; 
                case <giá trị 2>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                .......
                case <giá trị n>:
                    Thực hiện 1 hành động nào đó nếu vào đúng case
                    break;
                default:
                    Khi không thỏa mãn tất cả các trường hợp trên thì sẽ vào default
                    break;
            }
         */
        static void Main(string[] args)
        
        { Console.OutputEncoding= Encoding.GetEncoding("UTF-8");
            switch (1)
            {
                case 1:
                    Console.WriteLine(" chao em: {0} năm sinh: {1}", "Nguyễn Kiều",2000);
                    break;
                case 2:
                    Console.WriteLine("CN4");
                    break;
                case 3:
                    Console.WriteLine("CN4");
                    break;
                case 4:
                    Console.WriteLine("CN4");
                    break;
                default:
                    Console.WriteLine("Chức năng không tồn tại");
                    break;
            }
            /*
            //Ví dụ: Swich case sử dụng int
            switch (1)
            {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }

            //Ví dụ: Swich case sử dụng string
            switch ("1")
            {
                case "1":
                    break;
                case "2":
                    break;
                default:
                    break;
            }

            //Ví dụ: Swich case sử dụng char
          
            switch ('a')//truyền giá trị kiểu số nguyên ở bà toán này
            {
                case 'a':
                    Console.WriteLine(" chao em: {0} năm sinh: {1}","Nguyễn Kiều,2000");
                    break;
                case 'b':
                    break;
                default:
                    break;
            }*/
        }
    }
}