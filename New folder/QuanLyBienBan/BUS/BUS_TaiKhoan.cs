using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_TaiKhoan = new DAL_TaiKhoan();

        public IQueryable HienThiDanhSachTaiKhoan()
        {
            return dal_TaiKhoan.HienThiDanhSachTaiKhoan();
        }

        public void ThemTaiKhoan(DTO_TaiKhoan taiKhoan)
        {
            dal_TaiKhoan.ThemTaiKhoan(taiKhoan);
        }
        public void SuaTaiKhoan(DTO_TaiKhoan taiKhoan, int id)
        {
            dal_TaiKhoan.XuaTaiKhoan(taiKhoan, id);
        }
        public void XoaTaiKhoan(int id)
        {
            dal_TaiKhoan.XoaTaiKhoan(id);
        }

        public bool KiemTraTonTaiTenTaiKhoan(string tenTaiKhoan)
        {
           return dal_TaiKhoan.KiemTraTonTaiTenTaiKhoan(tenTaiKhoan);
        }
    }
}
