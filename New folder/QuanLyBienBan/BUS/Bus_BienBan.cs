using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Bus_BienBan
    {
        DAL_BienBan dal_BienBan = new DAL_BienBan();
        

        public IQueryable HienThiDanhSachBienBan()
        {
            return dal_BienBan.HienThiDanhSachBienBan();
        }

        public void ThemBienBan(DTO_BienBan bienBan)
        {
            dal_BienBan.ThemBienBan(bienBan);
        }

        public void SuaBienBan(DTO_BienBan bienBan, int idBienBan)
        {
            dal_BienBan.XuaBienBan(bienBan, idBienBan);
        }
        public void XoaBienBan(int idBienBan)
        {
            dal_BienBan.XoaBienBan(idBienBan);
        }
        public IQueryable TimKiemBienBan(string tieuDe, string thuki, string chutri, string noidung, string ykien, string ketluan, string khoa)
        {
           return dal_BienBan.TimKiemBienBan(tieuDe,thuki,chutri,noidung,ykien,ketluan,khoa);
        }
    }
}
