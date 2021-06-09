using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2_Xu_ly_chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*mời người dùng vào nhập tên, năm sinh, giới tính
             xuất danh sach có anh chị em, bạn trước tên
             dùng 1 dòng code*/


            while (true)
            {

                string ten, gioiTinh;
                int nsBT = 1998, ns;
                Console.Write(" bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.Write(" bạn nhập sêx: ");
                gioiTinh = Console.ReadLine();
                Console.Write(" bạn nhập tên: ");
                ns = Int32.Parse(Console.ReadLine());

                Console.WriteLine("chào {0} {1}", (nsBT > ns && gioiTinh == "nam") ? "Anh" : (ns < nsBT && gioiTinh == "nu") ? "CHỊ" : (ns < nsBT) ? "em" : "bạn", ten);
            }

        }

        void method()
        {
            while (true)
            {

                string ten, gioiTinh;
                int nsBT = 1998,ns;
                Console.Write( " bạn nhập tên: ");
                ten = Console.ReadLine();
                Console.Write(" bạn nhập sêx: ");
                gioiTinh = Console.ReadLine();
                Console.Write(" bạn nhập tên: ");
                ns = Int32.Parse(Console.ReadLine());
            
                Console.WriteLine("chào {0} {1}",(nsBT>ns && gioiTinh=="nam")?"Anh":(ns<nsBT&&gioiTinh=="nu")?"CHỊ":(ns<nsBT)?"em":"bạn",ten);
            }

        }
    }
}
