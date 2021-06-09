using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace lab_5_6_contructor_Khongtham_so
{
    public class ServiceKeToan
    {
        private List<KeToan> _lstKeToans;
        KeToan kt = new KeToan();
        private string input;

        //1.      Thêm 5 Kế Toán bằng contructor có tham số(ID -
        //Int, luong – double, Ten – string, TrangThai - bool) – (5 Điểm)

        //2.      Xóa kế toán theo mã(3- Điểm) – Sử dụng List

        //3.      Sắp xếp giảm dần. (1 - Điểm)

        public ServiceKeToan()
        {
            _lstKeToans = new List<KeToan>();

            KeToan kt1 = new KeToan("Kiều", "1", 200, true);
            KeToan kt2 = new KeToan("Phương", "2", 200, false);
            KeToan kt3 = new KeToan("Nghĩa", "4", 200, true);
            KeToan kt4 = new KeToan("Bình", "5", 200, false);
            KeToan kt5 = new KeToan("Hải", "3", 200, true);
            _lstKeToans.Add(kt1);
            _lstKeToans.Add(kt2);
            _lstKeToans.Add(kt3);
            _lstKeToans.Add(kt4);
            _lstKeToans.Add(kt5);
        }

        //public void nhap()
        //{
        //    kt = new KeToan();
        //    cw
        //}
        //2.      Xóa kế toán theo mã(3- Điểm) – Sử dụng List
        public void xoabangMa()
        {
            Console.WriteLine(" mời bạn nhập ID của KT mà bạn muốn xóa: ");
            input = Console.ReadLine();
            int temp = getIndex(input);
            for (int i = 0; i < _lstKeToans.Count; i++)
            {
                if (temp == -1)
                {
                    Console.WriteLine(" KT bạn muốn tìm không tồn tại");
                }
                _lstKeToans.RemoveAt(i);
                Console.WriteLine(" Bạn Đã xóa thành công");
            }
        }
        //3.      Sắp xếp giảm dần. (1 - Điểm)//3.      Sắp xếp giảm dần. (1 - Điểm)
        public void sapXepAn()
        {
            _lstKeToans.Sort((b, a) => a.Id1.CompareTo(b.Id1));
        }

        public void inra()
        {
            foreach (var x in _lstKeToans)
            {
                x.inRa();
                Console.WriteLine("---\n");
            }
        }

        private int getIndex(string _input)
        {
            for (int i = 0; i < _lstKeToans.Count; i++)
            {

                if (_lstKeToans[i].Id1 == _input)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}