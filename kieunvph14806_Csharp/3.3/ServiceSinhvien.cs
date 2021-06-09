using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3
{
    public class ServiceSinhVien
    {
                                  // khai báo 1 mảng đối tượng sinh viên -- KHAI BÁO  TOÀN CỤC
        private List<SinhVien> _lstSinhViens;

        public ServiceSinhVien()
        {
            fakeData();
        }

        public void fakeData()
        {
            SinhVien sv1 = new SinhVien("ten", "13", 4, 5);
            SinhVien sv2 = new SinhVien("tqen", "13", 4, 5);
            SinhVien sv3 = new SinhVien("teen", "13", 4, 5);
            SinhVien sv4 = new SinhVien("tten", "13", 4, 5);

            _lstSinhViens.Add(sv1);
            _lstSinhViens.Add(sv2);
            _lstSinhViens.Add(sv3);
            _lstSinhViens.Add(sv4);

        }

        public void timkiemSV()
        {
            Console.WriteLine(" mời bạn Nhập mã: ");
            string input = Console.ReadLine();
            //cách 1:
            foreach (var x in _lstSinhViens)

            {
                if (x.Ma==input)
                {
                    x.inRA();
                }
                
            }

            //cách 2: 
            // Sử DỤng LINQ
            _lstSinhViens.Where(c=>c.Ma==input).FirstOrDefault().inRA();



        }

        public void xoaSV()
        {
            Console.WriteLine( " mời bạn nhập mã để xóa: " );
            string input = Console.ReadLine();
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Ma==input)
                {
                    _lstSinhViens.RemoveAt(i);
                }
            }
            // Dung LinQ
            _lstSinhViens.RemoveAt(_lstSinhViens.FindIndex(c=>c.Ma==input));

            foreach (var x in _lstSinhViens)
            {
                x.inRA();
            }
        }

        public void srotSV() //sắp sếp
        {
            foreach (var VARIABLE in _lstSinhViens.OrderBy(c=>c.Ma))
            {
                VARIABLE.inRA();
            }
        }


    }
}