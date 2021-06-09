using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_bai_mau
{
    class Program
    {
        static void Main(string[] args)
        {
            KhaiBaoDoiTuongCuThe.service = new KhaiBaoDoiTuongCuThe();
            IServiceProvider.bai1DungCOntructorCoVaKhongCoThamSoTruyenVao();
        }
    }
}
