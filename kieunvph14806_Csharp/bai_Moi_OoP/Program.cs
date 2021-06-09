using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace bai_Moi_OoP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.GetEncoding("UTF-8");
             ServiceSinhVien service =new ServiceSinhVien(); //cách chạy các chương trình in ra màn hình
             //service.BAitap1();
             //service.bai2TaodoiTuongDoNguoiDungNhapVao();
             //service.Bai3();
             //service.INRAManHinh();
             service.themSinhVienList();
             service.inramanhinh();

        }
    }
}
