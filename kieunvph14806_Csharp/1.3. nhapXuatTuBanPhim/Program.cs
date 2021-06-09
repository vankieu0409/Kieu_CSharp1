using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3.nhapXuatTuBanPhim
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
        * BÀI 1.2 Nhập xuất dữ liệu từ bàn phím
        *  1. Xuất dữ liệu ra màn hình
        *      + Phím tắt : cw + tab
        *      + Console.WriteLine(); Ghi xong thì xuống dòng
        *      + Console.Write(); Ghi xong thì không xuống dòng
        *  2. Nhập dữ liệu từ bàn phím:
        *      + Console.Read(); Đọc 1 ký tự từ bàn phím nhưng là số ASII
        *      + Console.ReadLine();  Đọc nhiều ký tự từ bàn phím và kiểu dữ liệu là string - chuỗi
        */

            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            // Phần 1: Xuất dữ liệu ra màn hình cw + tab
            Console.Write("Chào các bạn");
            Console.WriteLine(" học môn C#");
            Console.Write(" tại FPOLY");

            //Tạo template mẫu
            Console.WriteLine("Chào bạn: {0} Năm sinh: {1} Trường: {2}", "Hương", 2000, "Fpoly");

            //Phần 2: Nhập dữ liệu từ bàn phím
            string name;
            Console.Write("Mời bạn nhập tên: ");
            name = Console.ReadLine();//Console.ReadLine() có giá trị string
            Console.WriteLine("Tên bạn vừa nhập là : " + name);

            //Sử dụng Console.Read();
            int input;
            Console.WriteLine("Mời bạn nhập Console.Read(): ");
            input = Console.Read();//Đọc 1 ký tự từ bàn phím nhưng là số ASII
            Console.WriteLine("Mã = " + input);



        }
    }
}
