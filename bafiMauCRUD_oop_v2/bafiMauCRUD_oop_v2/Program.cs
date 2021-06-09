using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bafiMauCRUD_oop_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
            ServiceStudents pt = new ServiceStudents();
            string chon;
            do
            {
                Console.WriteLine("     Danh Sách CT liên quan     \n" +
                                  " 1. Nhập sinh viên\n" +
                                  " 2. sửa\n" +
                                  " 3. xóa\n" +
                                  " 4. tìm kiếm\n" +
                                  " 5. xuất DS\n" +
                                  " 6. xuất DS đã tìm kiếm\n" +
                                  " 7. thoát");
                Console.Write(" Mời bjan Chọn CT: ");
                chon=Console.ReadLine();
                switch (chon)
                {
                    case "1":
                        pt.Add_Sudents();break;
                    case "2":
                        pt.SuaSV(); break;
                    case "3":
                        pt.XoaSV(); break;
                    case "4":
                        pt.timKiem(); break;
                    case "5":
                        pt.inra(); break;
                    case "6":
                        pt.sortListSV(); break;
                    case "7":
                        Environment.Exit(7); break;

                }


                Console.WriteLine("");
            } while (true);
        }
    }
}
