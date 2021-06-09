using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2._0_ToanTuBaNgoi
{
    class Program
    {
        /*
        * TOÁN TỬ 3 NGÔI
        * <Điều kiện hoặc nhiều điều kiện> ? <Kết quả nếu điều kiện đúng> : <Kết quả nếu điều kiện sai>;
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");//hiển thị tiếng việt khi chạy
            bool logic1 = 5 == 3 ? true : false;
            int logic2 = 5 == 3 ? 1 : 0;
            string logic3 = 5 == 3 ? "Đúng" : "Sai";

            string kq = 5 > 9 ? "Đúng" : "Sai";
            Console.WriteLine(kq);

            Console.WriteLine("--------------");
            int nghi = 4;
            double diemCsharp = 4, Gpa = 5;

            string danhGiaHs = nghi <= 4 && diemCsharp >= 5 && Gpa >= 5 ? "Qua môn" : "Học lại";
            Console.WriteLine(danhGiaHs);
            
            if (nghi <= 4 && diemCsharp >= 5 && Gpa >= 5)
            {
                Console.WriteLine("Qua môn");
            }
            else
            {
                Console.WriteLine("Học lại");
            }

            while (true)
            {
                string id, pass, login;
                Console.Write("id: ");
                id = Console.ReadLine();
                Console.Write("pass: ");
                pass = Console.ReadLine();
                login = (id == "admin" && pass == "123") ? "Login thành công" : "Thất bại";
                Console.WriteLine(login);
            }
        }
    }
}