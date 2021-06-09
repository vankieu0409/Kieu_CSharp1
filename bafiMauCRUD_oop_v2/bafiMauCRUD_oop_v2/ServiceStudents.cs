using System;
using System.Collections.Generic;
using System.Linq;

namespace bafiMauCRUD_oop_v2
{
    public class ServiceStudents
    {
        private List<Students> _lstStudents =new List<Students>();
        private Students _students;
        private string input;


        public ServiceStudents()
        {
            Students st1 = new Students(" kiều", "1", "as", "149", 9);
            Students st2 = new Students(" Bâu", "1", "as", "148", 9);
            _lstStudents.Add(st1);
            _lstStudents.Add(st2);
        }

        public void Add_Sudents()
        {
            Console.Write(" mời bạn nhập số lượng: ");
            input = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(input); i++)
            {
                _students = new Students();

                Console.WriteLine(" mời bạn Nhập: ");
                _students.Ten = Console.ReadLine();
                Console.WriteLine(" mời bạn Nhập: ");
                _students.Sdt = Console.ReadLine();
                Console.WriteLine(" mời bạn Nhập: ");
                _students.Email = Console.ReadLine(); 
                Console.WriteLine(" mời bạn Nhập: ");
                _students.Ma = Console.ReadLine();
                Console.WriteLine(" mời bạn Nhập: ");
                _students.DiemC = double.Parse(Console.ReadLine());

                _lstStudents.Add(_students);

            }
        }

        public void timKiem()
        {
            Console.WriteLine(" mời bạn Nhập mã Sv cần tìm: ");
            input = Console.ReadLine();
            int temp = getIndex(input);
            if (temp==-1)
            {
                Console.WriteLine(" Mã Sinh viên không tồn tại,");
                return;
            }
            _lstStudents[temp].inRaMaHinh();
        }


        public void XoaSV() //xóa theo index
        {
            Console.WriteLine(" mời bạn Nhập mã Sv cần tìm: ");
            input = Console.ReadLine();
            int temp = getIndex(input);
            if (temp == -1)
            {
                Console.WriteLine(" Mã Sinh viên không tồn tại,");
                return;
            }

            _lstStudents.RemoveAt(temp);
            Console.WriteLine(" Xóa Thành Công");
        }

        public void SuaSV() //sửa theo index
        {
            Console.WriteLine(" mời bạn Nhập mã Sv cần tìm: ");
            input = Console.ReadLine();
            int temp = getIndex(input);
            if (temp == -1)
            {
                Console.WriteLine(" Mã Sinh viên không tồn tại,");
                return;
            }

            do
            {
                Console.WriteLine(" bạn Muốn sửa Cái gì\n" +
                                  " 1. Tên\n" +
                                  " 2. SĐT\n" +
                                  " 3. Thoát\n");
                Console.Write(" mời bạn Chọn:  ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write(" Tên cũ của bạn: "+_lstStudents[temp].Ten+"\n" +
                                          " Bạn muốn sửa thành: ");
                        _lstStudents[temp].Ten = Console.ReadLine();

                        break;
                    case "2":
                        Console.Write(" SĐT cũ của bạn: " + _lstStudents[temp].Ten + "\n" +
                                      " Bạn muốn sửa thành: ");
                        _lstStudents[temp].Sdt = Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(" thoát")
                            ;
                        break;
                    default:
                        Console.WriteLine(" Chức Năng Không có");
                        break;

                }

            } while (!(input=="3"));// toán tử phủ định. dùng vong do- while
        }

        public void inra()
        {
            inDS(_lstStudents);
        }


            public void sortListSV()//chức năng Sắp Xếp
        {
            inDS(_lstStudents.OrderBy(c=>c.Ma).ToList());
        }
        // phương thức 1: tái sử dụng khị in ra a=màn hình
       private void inDS(List<Students> lsStudents)
        {
            foreach (var x in lsStudents)
            {
                x.inRaMaHinh();
            }
        }

        //PHương thức 2: Lấy Index của đối rượng trong danh sách
        private int getIndex(string msv) // Phương thức trả về số nguyên ---- dùng để tìm vị trí
        {
            for (int i = 0; i < _lstStudents.Count; i++)
            {
                if (_lstStudents[i].Ma==msv)
                {
                    return i; //trả về vị trí của đối tượng cần tìm
                }
            }
            return -1;// Không tìm được mã trùng thì phải trả về số âm để không bị trùng với count_list
        }
    }
}