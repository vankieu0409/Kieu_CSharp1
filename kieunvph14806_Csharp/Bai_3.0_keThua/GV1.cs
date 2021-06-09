namespace Bai_3._0_keThua
{
    public class GV1
    {
        private string ten;
        private string ho;
        private string tenDem;
        private string sdt;
        private string email;
        private string mgv;
        private string gioDay;

        public GV1()
        {

        }

        public GV1(string ten, string ho, string tenDem, string sdt, string email, string mgv, string gioDay)
        {
            this.ten = ten;
            this.ho = ho;
            this.tenDem = tenDem;
            this.sdt = sdt;
            this.email = email;
            this.mgv = mgv;
            this.gioDay = gioDay;
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

        public string Mgv
        {
            get => mgv;
            set => mgv = value;
        }

        public string GioDay
        {
            get => gioDay;
            set => gioDay = value;
        }
    }
}