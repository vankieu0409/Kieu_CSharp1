﻿ using System;
 using System.Collections.Generic;
using System.Linq;

 namespace Assigment
{
    //Các chức năng chương trình cần có:
    //THÊM - SỬA - XÓA NGƯỜI TRONG DANH BẠ
    //    THÊM 15 NGƯỜI TẠO SẴN VÀO TRONG DANH BẠ
    //    TÌM KIẾM NGƯỜI THEO TÊN HOẶC SỐ ĐIỆN THOẠI
    //LOAD TẤT TT CẢ NGƯỜI TRONG DANH BẠ - (Lưu ý: Khi hiển thị những người nào lớn tuổi hơn mình dựa theo năm sinh thì hiện thị là ANH - CHỊ - EM trước Tên)
    //TÌM KIẾM THEO SỐ ĐIỆN THOẠI GẦN ĐÚNG
    //TÌM KIẾM THEO TÊN GẦN ĐÚNG
    //SẮP XẾP DANH BẠ THEO NGƯỢC VÀ XUÔI DO NGƯỜI DÙNG CHỌN
    public class FunctionsDanhBa
    {
        private List<DanhBa> lstDanhBas;
        private DanhBa nguoi = new DanhBa();// Danh Bạ(): là contructor có tham số
        private string input;

        public FunctionsDanhBa()
        {
            lstDanhBas = new List<DanhBa>();
            DanhBa nguoi1 = new DanhBa("Nguyễn", "Văn", "Kiều", 1998, "Nam", "0382802345", "0857326448",
                " vankieu0409@gmail.com", "Hiền Huynh");
            DanhBa nguoi2 = new DanhBa("Lê", "Thị", "Phương", 1998, "Nữ", "0389062345", "08573209006",
                " hiplee0906@gmail.com", "Honey");
            DanhBa nguoi3 = new DanhBa("Nguyễn", "Văn", "Phương", 2001, "Nam", "0382803456", "0857326848",
                " phuongCsharp@gmail.com", "Tiểu đệ C#");
            DanhBa nguoi4 = new DanhBa("Hoàng", "Thị", "Hải", 2002, "Nữ", "0382804567", "08599885566",
                " haixu2002@gmail.com", "Tiểu Nguội C#");
            DanhBa nguoi5 = new DanhBa("Kiều", "Thị", "Bình", 2001, "Nữ", "0388025345", "0957326448",
                " binhbong@gmail.com", "Tiểu Nguội C#");
            DanhBa nguoi6 = new DanhBa("Liêu", "Long", "Vũ ", 2002, "Nam", "0382801234", "0852346448",
                " vucute2k2@gmail.com", "");
            DanhBa nguoi7 = new DanhBa("Lê", "Đình", "Nghĩa", 2002, "Nam", "0982802345", "0757326448",
                " nghiaxoan2k2@gmail.com", "AE trong Ao Hồ");
            DanhBa nguoi8 = new DanhBa("Hoàng", "Thái", "Sơn", 2002, "Nam", "0828023456", "0987326448",
                " sonHQteam@gmail.com", "team HQ's Gamer ");
            DanhBa nguoi9 = new DanhBa("Đặng", "", "Vũ", 2002, "Nam", "035698471", "0986574321",
                " vudang555@gmail.com", " hàng xóm của hàng xóm");
            DanhBa nguoi10 = new DanhBa("Nguyễn", "Thị", "Hảo", 2003, "Nữ", "0958764321", "0369872541",
                " haohaok98@gmail.com", " Chủ Shop MỸ Phẩm Hàn Quốc");
            DanhBa nguoi11 = new DanhBa("Thiều ", "Đức", "Lâm", 1998, "Nam", "0375423456", "0852346179",
                " thieulam289@gmail.com", "Hiền ĐỆ");
            DanhBa nguoi12 = new DanhBa("Đặng", "Mai", "Lan", 1998, "Nữ", "02113655998", "0986753421",
                " lamdam98@gmail.com", " bà chủ tiệm thuốc  ");
            DanhBa nguoi13 = new DanhBa("Trần", "Thị Bích", "Thủy", 1998, "Nữ", "0986513724", "0356241897",
                " thuybundau@gmail.com", " Chủ Quán Bún đậu AE-5k");
            DanhBa nguoi14 = new DanhBa("Phùng", "Thị ", "Thúy", 1999, "Nữ", "0986513427", "0356249999",
                "thuysell@gmail.com", " CEO- Đồ gia dụng An Phát");
            DanhBa nguoi15 = new DanhBa(" Nguyễn", " Thị", "Thúy", 1999, "Nữ", "0879645213", "0956821473",
                "thuyhiep@gmail.com", "Trưởng phòng Điều hành cty Du Lịch Âu Việt");
            lstDanhBas.Add(nguoi1);
            lstDanhBas.Add(nguoi2);
            lstDanhBas.Add(nguoi3);
            lstDanhBas.Add(nguoi4);
            lstDanhBas.Add(nguoi5);
            lstDanhBas.Add(nguoi6);
            lstDanhBas.Add(nguoi7);
            lstDanhBas.Add(nguoi8);
            lstDanhBas.Add(nguoi9);
            lstDanhBas.Add(nguoi10);
            lstDanhBas.Add(nguoi11);
            lstDanhBas.Add(nguoi12);
            lstDanhBas.Add(nguoi13);
            lstDanhBas.Add(nguoi14);
            lstDanhBas.Add(nguoi15);

        }

        public void ThemLienHe() //THÊM -  Liên Hệ vào TRONG DANH BẠ
        {
            Console.Write(" mời nhập Số người cần thêm: ");
            input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(input); i++)
            {
                nguoi = new DanhBa();

                Console.Write(" mời bạn nhập Họ: ");
                nguoi.Ho = Console.ReadLine();
                Console.Write(" mời bạn nhập Tên Đệm: ");
                nguoi.TenDem = Console.ReadLine();
                Console.Write(" mời bạn nhập Tên: ");
                nguoi.Ten = Console.ReadLine();
                Console.Write(" mời bạn nhập Năm Sinh: ");
                nguoi.NamSinh = Int32.Parse(Console.ReadLine());
                Console.Write(" mời bạn nhập Giới Tính: ");
                nguoi.GioiTinh = Console.ReadLine();
                Console.Write(" mời bạn nhập SĐT 1: ");
                nguoi.Sdt1 = Console.ReadLine();
                Console.Write(" mời bạn nhập SĐT 2: ");
                nguoi.Ssdt2 = Console.ReadLine();
                Console.Write(" mời bạn nhập Email:");
                nguoi.Email = Console.ReadLine();
                Console.Write(" mời bạn nhập Ghi Chú:");
                nguoi.GhiChu = Console.ReadLine();

                lstDanhBas.Add(nguoi);

            }

        }
        public void TimKiemDb() // tìm kiếm bằng tên hoặc số điện thoại
        {
            Console.Write(" mời bạn Nhập Tên hoặc số điện thoại: ");
            input = Console.ReadLine();
            int temp = GetIndex(input);
            if (temp == -1)
            {
                Console.WriteLine(" Liện hệ Không tồn tại");
                return;
            }
            lstDanhBas[temp].InRaManHinh();
        }


        public void XoaLienHe() //xóa theo index--  XÓA Liên Hệ TRONG DANH BẠ
        {
            Console.WriteLine(" mời bạn Nhập tên Liên hệ cần tìm: ");
            input = Console.ReadLine();
            int temp = GetIndex(input);
            if (temp == -1)
            {
                Console.WriteLine("            Liên Hệ không tồn tại,");
                return;
            }

            lstDanhBas.RemoveAt(temp);
            Console.WriteLine("            Xóa Thành Công");
        }

        public void SuaSv() //sửa theo index //T SỬA Thông tin Liên hệ TRONG DANH BẠ
        {
            Console.WriteLine(" Mời bạn Nhập tên hoặc số điện thoại LIên Hệ mà bạn Muốn sửa:  ");
            input = Console.ReadLine();
            int temp = GetIndex(input);
            if (temp == -1)
            {
                Console.WriteLine(" Liên hệ không tồn tại,");
                return;
            }

            do
            {
                Console.WriteLine("           Bạn Muốn sửa :\n" +
                                  " 1. họ tên\n" +
                                  " 2. Năm Sinh\n" +
                                  " 3. giới tính\n" +
                                  " 4. SĐT 1\n" +
                                  " 5. SĐT 2\n" +
                                  " 6. Email\n" +
                                  " 7. ghi chú\n" +
                                  " 8. thoát! Không sửa nữa.");
                Console.Write(" mời bạn Chọn:  ");
                input = Console.ReadLine();
                Console.WriteLine("\n");
                switch (input)
                {
                    case "1":
                        Console.Write(" Họ tên của " + lstDanhBas[temp] + ": " + lstDanhBas[temp].Ho + " " + lstDanhBas[temp].TenDem + " " + lstDanhBas[temp].Ten + "\n" +
                                          " Bạn muốn sửa thành: \n " +
                                          " họ: ");
                        lstDanhBas[temp].Ho = Console.ReadLine();
                        Console.Write(" Tên Đệm: ");
                        lstDanhBas[temp].TenDem = Console.ReadLine();
                        Console.Write(" Tên: ");
                        lstDanhBas[temp].Ten = Console.ReadLine();
                        break;

                    case "2":
                        Console.Write(" Năm Sinh cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].NamSinh + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].NamSinh = Int32.Parse(Console.ReadLine()); break;
                    case "3":
                        Console.Write(" Giới Tính cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].GioiTinh + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].GioiTinh = Console.ReadLine(); break;
                    case "4":
                        Console.Write(" SĐT1 cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].Sdt1 + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].Sdt1 = Console.ReadLine(); break;
                    case "5":
                        Console.Write(" SĐT2 cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].Ssdt2 + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].Ssdt2 = Console.ReadLine(); break;
                    case "6":
                        Console.Write(" Email cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].Email + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].Email = Console.ReadLine();
                        break;
                    case "7":
                        Console.Write(" Ghi chú cũ của " + lstDanhBas[temp].Ten + ": " + lstDanhBas[temp].GhiChu + "\n" +
                                      " Bạn muốn sửa thành: ");
                        lstDanhBas[temp].GhiChu = Console.ReadLine();
                        
                        break;
                    case "8":
                        Console.WriteLine(" oke Tạm biệt "); break;
                    default:
                        Console.WriteLine(" Chức Năng Không có");
                        break;

                }

            } while (!(input == "8"));// toán tử phủ định. dùng vong do- while
        }
        public void Inra()
        {
            Console.WriteLine("----------- Danh bạ của bạn ---------- " +
                              "\n");
            foreach (var VARIABLE in lstDanhBas)
            {
                VARIABLE.InRaManHinh();
            }
        }


        public void SapxepnguoichonDb()//chức năng Sắp Xếp
        {
            Console.Write(" mời bạn chọn cách hiển thị được Sắp xếp theo:\n" +
                              " 1. Tên\n" +
                              " 2. Năm sinh\n" +
                              " Mời bạn chọn: ");
            input = Console.ReadLine();
            Console.WriteLine("\n");
            switch (input)
            {
                case "1":
                    Console.Write(" Mời bạn chọn cách sắp xếp Tên theo thứ tự AlphaB: \n" +
                                      " 1. Xuôi\n" +
                                      " 2. Ngược\n" +
                                      " Mời bạn chọn: ");
                    input = Console.ReadLine();
                    Console.WriteLine("\n");
                    switch (input)
                    {
                        case "1":
                            InDs(lstDanhBas.OrderBy(c => c.Ten).ToList());
                            break;
                        case "2":
                            InDs(lstDanhBas.OrderByDescending(c => c.Ten).ToList());
                            break;
                    };
                    break;
                case "2":
                    Console.Write(" Mời bạn chọn cách sắp xếp theo tuổi: \n" +
                                      " 1. từ già đến trẻ \n" +
                                      " 2. từ trẻ đến già \n" +
                                      " Mời bạn chọn: ");
                    input = Console.ReadLine();
                    Console.WriteLine("\n");
                    switch (input)
                    {
                        case "1":
                            InDs(lstDanhBas.OrderBy(c => c.NamSinh).ToList());
                            break;
                            
                        case "2":
                            InDs(lstDanhBas.OrderByDescending(c => c.NamSinh).ToList());
                            break;
                    };
                    break;

            }
          
        }
        // phương thức 1: tái sử dụng khị in ra a=màn hình
        private void InDs(List<DanhBa> danhBas)
        {
            foreach (var x in danhBas)// x là phần tử trong danh sach => x=nguoi
            {
                if (x.GioiTinh == "Nam" && x.NamSinh <= 1998)
                {

                    Console.Write(" Anh ");
                    x.InRaManHinh();

                }
                else if ((x.GioiTinh == "Nữ") && x.NamSinh <= 1998)
                {
                    Console.Write(" Chị ");
                    x.InRaManHinh();

                }
                else
                {
                    Console.Write(" Em ");
                    x.InRaManHinh();
                }

                Console.WriteLine("_________\n" +
                                  "\n");
            }
        }

        //PHương thức 2: Lấy Index của đối rượng trong danh sách
        private int GetIndex(string msv) // Phương thức trả về số nguyên ---- dùng để tìm vị trí
        {
            for (int i = 0; i < lstDanhBas.Count; i++)
            {
                if (lstDanhBas[i].Ten == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
                else if (lstDanhBas[i].Sdt1 == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
                else if (lstDanhBas[i].Ssdt2 == msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
            }
            return -1;// Không tìm được mã trùng thì phải trả về số âm để không bị trùng với count_list
        }

        public void TimkiemgandungTen()
        {
            Console.WriteLine(" mời bạn nhập tên để tìm: ");
            string input = Console.ReadLine();
            foreach (var x in lstDanhBas.Where(c=>c.Ten.Contains(input)))
            {
                x.InRaManHinh();
                    Console.WriteLine("----------\n" +
                                      "\n");
            }
        }

        public void TimKiemDanDungSdt()
        {
            Console.Write(" Mời Bạn Nhập số điện thoại gần đúng: ");
            string input = Console.ReadLine();
            var lstTemp = lstDanhBas.Where(c => c.Sdt1.Contains(input)).ToList();
            if (lstTemp.Count > 0)
            {
                foreach (var x in lstTemp)
                {
                    x.InRaManHinh();
                    Console.WriteLine("----------" +
                                      "\n");
                }
                return;
            }
            else
            {
                Console.WriteLine(" số điện thoại bạn tìm không có.");
            }
            
          
        }

        public void SapXepKoin()// dùng sort
        {
            //_lstDanhBas.Sort((a,b) => a.Ten.CompareTo(b.Ten));
            var listSapXep = from x in lstDanhBas orderby x.Ten select x;

        }

    }
}