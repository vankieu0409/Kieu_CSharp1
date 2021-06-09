using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_6_KTlop
{
    class Program
    {
        static void Main(string[] args)
        { Console.OutputEncoding=Encoding.UTF8;
            Service pt = new Service();
            string lenh;
            do
            {
                Console.WriteLine(" Danh sach CT\n" +
                                  " 1. tìm Kiếm SV\n" +
                                  " 2. Sắp xếp theo điểm java khôn in ra màn hình\n" +
                                  " 3. xuất\n" +
                                  " 4.thoát ");
                Console.Write(" mời bạn chọn ct:" );
                lenh = Console.ReadLine();
                switch (lenh)
                {
                    case "1":pt.timkiem();break;
                    case "2": pt.Sapxep(); break;
                    case "3": pt.xuat(); break;
                    case "4": Environment.Exit(4); break;
                    default: Console.WriteLine(" ct bạn chọn không đúng");break;
                }

                Console.WriteLine("-------" +
                                  "\n" +
                                  "\n");
            } while (true);
        }
    }
}
