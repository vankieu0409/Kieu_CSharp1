using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        { Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            // ArrayList dùng để lưu trữ và không định kiểu ( Không có kiểu dữ liệu)
            // Phần 1: Kahi báo và khởi tạo
            ArrayList arrLstKhongDinhKieu; // khai báo
            arrLstKhongDinhKieu = new ArrayList(); //khởi tạo
            
            //Phần 2: thêm phần tử vào ArrayList
            arrLstKhongDinhKieu.Add(1);
            arrLstKhongDinhKieu.Add(1.6);
            arrLstKhongDinhKieu.Add(true);
            arrLstKhongDinhKieu.Add("C#1");

            // Phần 3: lấy giá trị từ ArrayList
            Console.WriteLine(arrLstKhongDinhKieu[0]);
            for (int i = 0; i < arrLstKhongDinhKieu.Count; i++)
            {
                Console.WriteLine(arrLstKhongDinhKieu[i]+"|");
            }

            Console.WriteLine("");

            // Phần 4: xóa phần tử
            
            arrLstKhongDinhKieu.RemoveAt(0);// xóa các phần tử khỏi ArrayList theo index
            for (int i = 0; i < arrLstKhongDinhKieu.Count; i++)
            {
                Console.WriteLine(arrLstKhongDinhKieu[i] + "|");
            }
            // Một bài phương thức hay sử dụng

            arrLstKhongDinhKieu.Clear();// xóa hết các phần tử bên trong ArrayList
        }
    }
}
