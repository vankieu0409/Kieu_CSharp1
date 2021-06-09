using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            QLGV pt = new QLGV();
            pt.Nhap();
            pt.DSGiaoVienhown21gioday();
            pt.Xuat();
        }
    }
}
