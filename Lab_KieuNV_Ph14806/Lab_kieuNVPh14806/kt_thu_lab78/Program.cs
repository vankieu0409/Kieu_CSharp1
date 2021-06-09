using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_thu_lab78
{
    class Program
    {


        #region Đề Bài

        //{1)     
        //Tạo Class SinhVien
        //bao gồm các thuộc tính: MaSV – int, Ten – string, NamSinh – int
        //– inThongTin() :void - (Đối với class Private các thuộc tính, Getter
        //& Setter, Contructor có tham số và không tham số) - (1 điểm)

        //2)     
        //Tạo Class QLSV sử
        //dụng(List) Hoặc ArrayList<SinhVien>, code
        //các chức năng tại đây như (nhập danh sách, xuất danh sách, xóa, tìm kiếm…..) - (0.5 điểm)

        //3)     
        //Tạo Class Main
        //Tạo Menu sử dụng SwitchCase  và gán các chức năng bên Class QLSV sang.

        //Viết chương
        //trình thực hiện việc quản lý như menu sau(Switch Case – Loop) : (1.5 điểm)

        //1.Nhập danh sách đối tượng(1đ )

        //Khi nhập có hỏi tiếp hay ko? (0,5đ)

        //2.Xuất danh sách đối tượng(1đ )

        //3.Xuất danh sách các SV qua môn(Điểm Csharp >= 5)(1 đ)

        //4.Tìm SV theo mã(1 đ)

        //0.Thoát 

        //4)     
        //Tạo lớp SinhVienUDPM
        //kế thừa từ SinhVien thêm thuộc tính: DiemJava – double, DiemCsharp-
        //double – Kế thừa phương thức inThongTin() :void của lớp cha
        //(Đối với class con Private các thuộc tính, Getter & Setter, Contructor
        //có tham số và không tham số).(0,5đ)

        //5)     
        //Bổ sung vào menu chức năng tên 5. Kế thừa, khi lựa
        //chọn chức năng 5 khởi tạo 1 đối tượng lớp SinhVienUDPM có giá trị ban
        //đầu bằng Contructor có tham số sau đó in thông tin đối tượng đó ra màn hình
        //bằng phương thức inThongTin():void (1đ )

        #endregion

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            QLSV pt = new QLSV();
            string lenh;

            do
            {
                Console.WriteLine("  danh chương trình:\n" +
                                  " 1. Nhập sinh viên\n" +
                                  " 2. xuât Sinh viên\n" +
                                  " 3. Xuất SV21 tuổi trở lên\n" +
                                  " 4. Tìm Kiếm\n" +
                                  " 5. Kế thừa\n" +
                                  " 6. exit\n");
                Console.Write(" Mời bạn  chọn CT: ");
                lenh = (Console.ReadLine());

                switch (lenh)
{

                    case "1":
                        pt.Nhap();
                        break;
                    case "2":
                        pt.DStuoi21();
                        break;
                    case "3": pt.SVLonHon21(); break;
                    case "4":
                        pt.timKiem();
                        break;
                    case "5":
                        pt.KeThua();
                        break;
                    case "6":

                        Console.WriteLine(" bye bye!\n" +
                                          " gặp lại sau");
                            Environment.Exit(6); break;
                    default:
                        Console.WriteLine(" CT bạn chọn Không có\n" +
                                          " mời chọn lại: "); break;


                }
                Console.WriteLine(" ---------------------");
            }
            while (true);

            

        }
    }
}