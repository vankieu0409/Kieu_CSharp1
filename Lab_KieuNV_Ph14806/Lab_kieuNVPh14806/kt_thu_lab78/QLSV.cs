using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace kt_thu_lab78
{
    public class QLSV
    {
        private List<SinhVienUDPM> _lstSinhVienUDPM;
        private SinhVienUDPM svUdpm1, svUdpm2, svUdpm3, svUdpm4, svUdpm5;
        private List<SinhVien> _lstSinhViens;
        private SinhVien sv;
        private string input;

        public QLSV()
        {
            _lstSinhViens = new List<SinhVien>();
            // Lớp con
             _lstSinhVienUDPM = new List<SinhVienUDPM>();

            svUdpm1 = new SinhVienUDPM(1, "Kiều", 1998, 1, 1);
            svUdpm2 = new SinhVienUDPM(1, "d", 2001, 1, 2);
            svUdpm3 = new SinhVienUDPM(1, "1", 1995, 1, 3);
            svUdpm4 = new SinhVienUDPM(1, "3", 1997, 1, 4);
            svUdpm5 = new SinhVienUDPM(1, "g", 1991, 1, 5);

            _lstSinhVienUDPM.Add(svUdpm1);
            _lstSinhVienUDPM.Add(svUdpm2);
            _lstSinhVienUDPM.Add(svUdpm3);
            _lstSinhVienUDPM.Add(svUdpm4);
            _lstSinhVienUDPM.Add(svUdpm5);

        }

        public void Nhap()
        {
            string temp;
            do
            {
                int sl;
                Console.WriteLine(" Mời bạn Nhập số lượng SV : ");
                sl = Int16.Parse(Console.ReadLine());

                for (int i = 0; i < sl; i++)
                {
                    sv = new SinhVien();

                    Console.WriteLine(" mời bạn nhập MaSV: ");
                    sv.Msv = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(" mời bạn nhập TÊN: ");
                    sv.Ten = (Console.ReadLine());
                    Console.WriteLine(" mời bạn nhập MaSV: ");
                    sv.NamSinh = Convert.ToInt16(Console.ReadLine());

                    _lstSinhViens.Add(sv);
                }

                Console.WriteLine(" Bạn có muốn nhập thêm không" +
                                  "1. có= c\n" +
                                  "2. không= k");
                temp = Console.ReadLine();
            } while (!(temp == "k"));
        }

        public void inRA()
        {
            foreach (var x in _lstSinhViens)
            {
                x.inThongTin();
                Console.WriteLine("-----\n");
            }
        }

        public void timKiem()
        {
            Console.WriteLine(" mời bạn nhập mã sinh viên muốn tìm kiếm: ");
            input = Console.ReadLine();
            int temp = getIndex(Convert.ToInt16(input));
            if (temp == -1)
            {
                Console.WriteLine(" SV bạn muốn tìm không có");
                return;
            }
            _lstSinhViens[temp].inThongTin();
        }
        private int getIndex(int _input)
        {
            for (int i = 0; i < _lstSinhViens.Count; i++)
            {
                if (_lstSinhViens[i].Msv == _input)
                {
                    return i;
                }
            }

            return -1;
        }

        public void SVLonHon21()
        {
            for (int i = 0; i < _lstSinhVienUDPM.Count; i++)
            {
                if (_lstSinhVienUDPM[i].NamSinh <= 2000)
                {
                    _lstSinhVienUDPM[i].inThongTin();
                    Console.WriteLine("-----\n");
                }
            }
        }

        public void KeThua()
        {
            foreach (var x in _lstSinhVienUDPM)
            {
                x.inThongTin();
                Console.WriteLine("-----\n");
            }
        }

        public void DStuoi21()
        {
            foreach (var x in _lstSinhVienUDPM)
            {
                if (tinhtuoi(x.NamSinh)>=21)
                {
                   x.inThongTin();
                   Console.WriteLine("-----\n");
                }
                
            }
        } 
        int tinhtuoi(int ns )
        {
            return 2021 - ns;
        }
    }
}