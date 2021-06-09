using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_4_2_Contructor_CoThamSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");
            ThemDTKeToan pt = new ThemDTKeToan();
            int lenh;
            do
            {
                Console.WriteLine("-------DS Chương trinh------\n" +
                                  " 1. Nhập 1 kế toán\n" +
                                  " 2. nhâp ds kế toán dùng list\n" +
                                  " 3. xuất ra màn hình\n" +
                                  " 4. thoát\n");
                Console.Write(" mời nạn chọn CT: ");
                lenh = Int32.Parse(Console.ReadLine());
                switch (lenh)
                {
                    case 1:
                        pt.nhap1KeToan();
                        break;
                    case 2:
                        pt.nhapListKeToans();
                        break;
                    case 3:
                        pt.inDanhSach();
                        break;
                    case 4:
                        Console.WriteLine("ban chon thoát CT");
                        return;
                    default:
                        Console.WriteLine(" chức năng bạn chon không có. Mời chọn lại: ");
                        break;
                }

                Console.WriteLine("\n");
            } while (true);
        }
    }
}