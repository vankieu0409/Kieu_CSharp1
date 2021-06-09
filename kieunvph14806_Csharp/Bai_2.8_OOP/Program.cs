using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._8_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            //phàn 1: khai báo và khởi tạo
            List<int> lstYear = new List<int>();
            List<string> lstName = new List<string>();
            List<double> lstDiemCsharp = new List<double>();
            //..................... vân vân

            // Phần 2: thêm giá trị vào Lít
            lstName.Add("Kiều");
            lstName.Add("trai");
            lstName.Add("Heloo");
            lstName.Add("Lôcica");

            // Phần 3: Lấy giá trị cần biết Index
            Console.WriteLine(lstName[0]);
            for (int i = 0; i < lstName.Count; i++)
            {
                Console.WriteLine(lstName[i]+"  ");
            }

            // Phần 4 : Lấy giá trị
            lstName.RemoveAt(0);
            for (int i = 0; i < lstName.Count; i++)
            {
                Console.WriteLine(lstName[i] + "  ");
            }

            // 1 vài Phương thức:
            lstName.Clear();// Dùng để xóa trắng cái list
        }
    }
}
