using System;
using System.Text;

namespace Bai_2._9_method
{
    class Program
    {  /*
       *  Bài 2.9 Phương thức - Method
       *  Định nghĩa: 1 tập các câu lệnh cùng nhau thực hiện 1 tác vụ nào đó.
       *  LỢI ÍCH: - Giúp quản lý code tốt hơn
       *           - Tái sử dụng
       *
       *  Công thức chung:
       *  <Phạm vi truy cập> <Kiểu trả về> <Tên phương thức> (<Danh sách tham số>)
       *  {
       *          Body code
       *  }
         *
       * <Phạm vi truy cập> - Access Specifier:Public,Private,Protected, Default, Internal
       *
       * <Kiểu trả về> : có 2 kiểu trả về và không trả về
       *          - Kiểu không trả về: void
       *          - Kiểu trả về: là giá trị đơn(int,string,double....) hoặc tập giá trị(Array,List.....) hoặc đối tượng(class) và còn nhiều kiểu khác.
       *
       * <Tên phương thức>: Tên động từ viết thường + tên.
       * <Danh sách tham số>: Phương thức có thể có tham hoặc không tham số và lưu ý khi sử dụng tham số thì khi gọi phương thức thì phải truyền đúng vị trí của tham số và kiểu dữ liệu.
        
        PHƯƠNG THỨC KHÔNG ĐƯỢC TRÙNG TÊN NHƯNG ĐƯỢC PHÉP TRÙNG TÊN VÀ KHÁC THAM SỐ
       */
        static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.GetEncoding("UTF-8");

            PhuongThucKHongtrave pt = new PhuongThucKHongtrave();
            #region  phần 1: PHương thức Không trả về
            /*
             * 1 hướng dẫn sử dụng
             * -cần biết phương thức và phương thức nó đang nằm trong class nào.
             * - khi gọi ra kết thúc bằng();
             */
            pt.tinhTong();


            /*
             * 2. sử dụng phương thức không trả về có tham số
             *      - bắt buộc phải truyển đúng thứ tự vị trí tham số
             *      - bắt buộc phải truyền tham số nếu phươn thức có
             *      - nếu là nập chồng phươn thức truyền
             */

            pt.tinhTong(3, 5);

            #endregion



            #region phần 2: Phương thức trả về
            PhuongThucTraVe ptTraVe = new PhuongThucTraVe();
            //ptTraVe.tinhTong(); Nó là 1 giá trị không thể tự in
            Console.WriteLine(ptTraVe.tinhTong());


            // phương thức trả mảng về
            foreach (var x in ptTraVe.getYear())
            {
                Console.WriteLine(x);
            }

            


            #endregion




        }
    }
}
