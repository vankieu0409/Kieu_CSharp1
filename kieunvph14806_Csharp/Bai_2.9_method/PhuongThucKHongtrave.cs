using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._9_method
{
    class PhuongThucKHongtrave
    {
        //phần 1: phương thức trả về không tham số
        public void tinhTong() //không tham số
        {
            int a, b;
            Console.Write(" mời bạn nhập số:  ");
            a = Int16.Parse(Console.ReadLine());
            Console.Write(" mời bạn nhập số:  ");
            b = Int16.Parse(Console.ReadLine());
            Console.Write(" tổng 2 số:  "+(b+a));

        }

        //phàn 2: phương thức không trả về có tham số
        // họa thêm tính nạp chông thương thức
        public void tinhTong(int a, int b)
        {
            Console.WriteLine(" tổng 2 số:  " + (b + a));
        }

        // 1 vài ví dụ:
        public void methodl(string a, SinhVien sv, SinhVien[] arrSinhViens, List<SinhVien> lstSinhViens)
        {

        }

        // Phương thức trả về không tham số:
        /* hướng đãn sử dụng*/
    }


}
