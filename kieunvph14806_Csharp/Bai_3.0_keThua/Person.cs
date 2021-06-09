using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._0_keThua
{

    /* đưa các thược tính tính chung lên lớp cha
     2. Lớp cha như lớp đối tượng tbinhf thường
     */
    class Person
    {
        private string ten;
        private string ho;
        private string tenDem;
        private string sdt;
        private string email;

        public Person()
        {

        }    
        public Person(string ten, string ho, string tenDem, string sdt, string email)
        {
            this.ten = ten;
            this.ho = ho;
            this.tenDem = tenDem;
            this.sdt = sdt;
            this.email = email;
        }

        public string Ten
        {
            get => ten;
            set => ten = value;
        }

        public string Ho
        {
            get => ho;
            set => ho = value;
        }

        public string TenDem
        {
            get => tenDem;
            set => tenDem = value;
        }

        public string Sdt
        {
            get => sdt;
            set => sdt = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public virtual void INramanhinh()
        {
            Console.WriteLine(" đay là phưuosntnhwius");
        }
    }
}
