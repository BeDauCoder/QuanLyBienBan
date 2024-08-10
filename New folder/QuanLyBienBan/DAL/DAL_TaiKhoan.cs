using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TaiKhoan
    {
        Data_qlbbDataContext db = new Data_qlbbDataContext();

        public IQueryable HienThiDanhSachTaiKhoan()
        {
            var xem = db.TaiKhoans
                .Select(tk => tk);
            return xem;
        }

        public void ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            try
            {
                if (taiKhoan == null)
                {
                    throw new ArgumentNullException(nameof(taiKhoan), "DTO_TaiKhoan không được null");
                }
                TaiKhoan tk = new TaiKhoan
                {
                    tenTaiKhoan = taiKhoan.TenTaiKhoan,
                    matKhau = taiKhoan.MatKhau
                };
                db.TaiKhoans.InsertOnSubmit(tk);
            }
            finally
            {
                db.SubmitChanges();
            }
        }

        public void XuaTaiKhoan(DTO_TaiKhoan taiKhoan, int id)
        {
            var suaTaiKhoan = db.TaiKhoans.Single(tk => tk.idTaiKhoan == id);
            suaTaiKhoan.tenTaiKhoan = taiKhoan.TenTaiKhoan;
            suaTaiKhoan.matKhau = taiKhoan.MatKhau;
            db.SubmitChanges();
        }

        
        public void XoaTaiKhoan(int id)
        {
            var xoaTaiKhoan = db.TaiKhoans
                .Where(tk => tk.idTaiKhoan == id)
                .Select(tk => tk);
            foreach (var tk in xoaTaiKhoan)
            {
                db.TaiKhoans.DeleteOnSubmit(tk);
            }
            db.SubmitChanges();
        }

        public bool KiemTraTonTaiTenTaiKhoan(string tenTaiKhoan)
        {
            // Sử dụng LINQ để truy vấn dữ liệu từ context
            using (Data_qlbbDataContext dba = new Data_qlbbDataContext())
            {
                // Kiểm tra xem có tồn tại tài khoản nào có tên tài khoản trùng khớp hay không
                var isTonTai = (from tk in dba.TaiKhoans
                                where tk.tenTaiKhoan == tenTaiKhoan
                                select tk).Any();

                // Trả về kết quả kiểm tra
                return isTonTai;
            }
        }

    }
}
