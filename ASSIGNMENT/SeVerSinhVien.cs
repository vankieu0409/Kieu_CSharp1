using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    class SeVerSinhVien
    { 
        private SinhVien[] arrSinhViens;
        private int soluong;
        private char hocluc;
        public SeVerSinhVien()
        {

        }
        public void Nhap()
        {
           
            Console.WriteLine("moi ban nhap so luong sinh vien ");
            soluong = Convert.ToInt32(Console.ReadLine());
            arrSinhViens = new SinhVien[soluong];
            //Khoi tạo kích thước mảng do người dùng nhap vao 
            for (int i = 0; i < soluong; i++)
            {
                arrSinhViens[i] = new SinhVien();
                //Khoi tao gia trị trong mảng 
                Console.WriteLine("moi ban nhap ho ten sinh vien");
                arrSinhViens[i].HoVaTen = Console.ReadLine();
                Console.WriteLine("moi ban nhap diem sinh vien");
                arrSinhViens[i].Diem = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("moi ban nhap email:");
                arrSinhViens[i].Email = Console.ReadLine();
                Console.WriteLine("\n" +
                                  "");
            }

            Console.WriteLine("____");
        }

        public void TimKiemTheoKhoang()
        {
            double diemthapnhat;
            double diemcaonhat;
            Console.WriteLine("moi ban nhap diem thap nhat ");
            diemthapnhat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("moi ban nhap diem cao nhat ");
            diemcaonhat = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < arrSinhViens.Length; i++)
            {
                if (diemthapnhat <= arrSinhViens[i].Diem && diemcaonhat >= arrSinhViens[i].Diem)
                {
                    Console.WriteLine("ho va ten: {0} ", arrSinhViens[i].HoVaTen);
                    Console.WriteLine("Diem: {0} ", arrSinhViens[i].Diem);
                }
            }

            Console.WriteLine("------------------");
        }

        public void TimKiemTheohocluc()
        {

            Console.WriteLine("A.hoc luc kem ");
            Console.WriteLine("B.hoc luc yeu ");
            Console.WriteLine("C.hoc luc TB ");
            Console.WriteLine("D.hoc luc Kha ");
            Console.WriteLine("E.hoc luc Gioi ");
            Console.WriteLine("F.hoc luc xuat sac ");
            Console.Write("moi ban chon hoc luc ");
            hocluc = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" +
                              "           Danh Sách        " +
                              "\n");
            switch (hocluc)
            {
                case 'A':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 3)
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                case 'B':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 5 && arrSinhViens[i].Diem > 3)
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                case 'C':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 6.5 && arrSinhViens[i].Diem > 5 )
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                case 'D':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 7.5 && arrSinhViens[i].Diem > 6.5)
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                case 'E':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 9 && arrSinhViens[i].Diem > 7.5)
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                case 'F':
                    for (int i = 0; i < arrSinhViens.Length; i++)
                    {
                        if (arrSinhViens[i].Diem <= 10 && arrSinhViens[i].Diem > 9)
                        {
                            Console.WriteLine("ho va ten: {0}", arrSinhViens[i].HoVaTen);
                        }
                    }
                    Console.WriteLine("\n" +
                                      "");
                    break;
                default:
                    Console.WriteLine("nhap sai moi nhap lai");
                    break;
            }

            Console.WriteLine("\n" +
                              "");
        }                
                        
        public void Inra()
        {
            for (int i = 0; i <soluong; i++)
            {
                Console.WriteLine("Ten Sinh Vien: "+arrSinhViens[i].HoVaTen);
                Console.WriteLine("diem Sinh Vien: "+arrSinhViens[i].Diem);
                Console.WriteLine("email Sinh Vien: "+arrSinhViens[i].Email);
                if (arrSinhViens[i].Diem < 3)
                {
                    Console.WriteLine(" kem ");
                }
                else if (arrSinhViens[i].Diem < 5 && arrSinhViens[i].Diem>=3)
                {
                    Console.WriteLine(" yeu ");
                }
                else if (arrSinhViens[i].Diem < 6.5 && arrSinhViens[i].Diem >=5)
                {
                    Console.WriteLine(" TB ");
                }
                else if (arrSinhViens[i].Diem < 7.5 && arrSinhViens[i].Diem >=6.5)
                {
                    Console.WriteLine(" kha ");
                }
                else if (arrSinhViens[i].Diem < 9 && arrSinhViens[i].Diem >=7.5)
                {
                    Console.WriteLine(" gioi ");
                }
                else
                {
                    Console.WriteLine(" Xuat Sac ");
                }

            }

            Console.WriteLine("\n");
        }
        

    }
}
