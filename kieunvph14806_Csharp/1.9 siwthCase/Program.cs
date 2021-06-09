using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9_siwthCase
{
    class Program
    {
		static void Main(string[] args)
		{
			// swich case:
			switch (lenh)
			{
				case 1:
					cachthuclixi(); break;
				case 2:
					xemstk(); break;
				default:
					cout << " Khong co chuc nang vua nhap" << endl;
					cout << " moi chon lai chuong trinh" << endl;
			}

		}
    }
}
