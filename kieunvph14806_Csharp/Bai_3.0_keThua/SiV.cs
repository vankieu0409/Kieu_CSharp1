using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_keThua
{
    /* 1. lớp con muốn kế thừalớp cha sử dụng : <ten lớp Cha>
     *
     * 3. khi lớp con kế thừa lớp cha thì sẽ kế thừa các thuộc tính và phương thức 
     **/
     
    class SiV:Person
    {
        private string msv;
        private double diemJava;
        private double diemCsharp;

        public SiV()
        {

        }

        public SiV(string ten, string ho, string tenDem, string sdt, string email, string msv, double diemJava, double diemCsharp) : base(ten, ho, tenDem, sdt, email)
        {
            this.msv = msv;
            this.diemJava = diemJava;
            this.diemCsharp = diemCsharp;
            // this dùng để tham chiếu thuộc tính và phương của lớp hiện tại
            // Từ Khóa base dùng tham chiếu thuộc tính và phương thức của lớp cha

        }

        public string Msv
        {
            get => msv;
            set => msv = value;
        }

        public double DiemJava
        {
            get => diemJava;
            set => diemJava = value;
        }

        public double DiemCsharp
        {
            get => diemCsharp;
            set => diemCsharp = value;
        }
        //sử dụng từ khóa override để nghi đè lên thương thức lớp cha
        // kHi kế thừa phải dùng kiểu dữ liệu phương thức và giống tham số . Bên trong body code có thể códe
        public override void INramanhinh()
        {
            base.INramanhinh();
        }
    }
}
