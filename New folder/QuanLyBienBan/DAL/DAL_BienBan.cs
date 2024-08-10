using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_BienBan
    {
        Data_qlbbDataContext db = new Data_qlbbDataContext();

        public IQueryable HienThiDanhSachBienBan()
        {
            IQueryable xem = from x in db.BienBans
                             select x;
            return xem;
        }

        public void ThemBienBan(DTO_BienBan bienBan)
        {
            try
            {
                if (bienBan == null)
                {
                    throw new ArgumentNullException(nameof(bienBan), "DTO_BienBan không được null");
                }
                BienBan bb = new BienBan
                {
                    
                    tieuDe= bienBan.TieuDe,
                    khoa = bienBan.Khoa,
                    chuTri = bienBan.ChuTri,
                    thuKi = bienBan.ThuKi,
                    thoiGian = bienBan.ThoiGian,
                    thoiGianBatDau = bienBan.ThoiGianBatDau,
                    thoiGianKetThuc = bienBan.ThoiGianKetThuc,
                    thanhPhanThamGia = bienBan.ThanhPhanThamGia,
                    thongTinNguoiDu = bienBan.ThongTinNguoiDu,
                    noiDung = bienBan.NoiDung,
                    ketLuan = bienBan.KetLuan,
                    yKien = bienBan.YKien,
                    diaDiem = bienBan.DiaDiem
                   

                };
                db.BienBans.InsertOnSubmit(bb);
            }
            finally
            {
                db.SubmitChanges();
            }
        }

        public void XuaBienBan(DTO_BienBan bienBan, int idBienBan)
        {
            var suaBienBan = db.BienBans.Single(bb => bb.idBienBan == idBienBan);
            suaBienBan.thanhPhanThamGia = bienBan.ThanhPhanThamGia;
            suaBienBan.chuTri = bienBan.ChuTri;
            suaBienBan.thuKi = bienBan.ThuKi;
            suaBienBan.khoa = bienBan.Khoa;
            suaBienBan.khoa = suaBienBan.khoa;
            suaBienBan.thoiGian = bienBan.ThoiGian;
            suaBienBan.ketLuan = bienBan.KetLuan;
            suaBienBan.noiDung = bienBan.NoiDung;
            suaBienBan.yKien = bienBan.YKien;
            suaBienBan.tieuDe = bienBan.TieuDe;
            suaBienBan.thoiGianBatDau = bienBan.ThoiGianBatDau;
            suaBienBan.thoiGianKetThuc = bienBan.ThoiGianKetThuc;
            db.SubmitChanges();
        }


        public void XoaBienBan(int idBienBan)
        {
            var xoaBienBan = db.BienBans
                .Where(bb => bb.idBienBan == idBienBan)
                .Select(bb => bb);
            foreach (var bb in xoaBienBan)
            {
                db.BienBans.DeleteOnSubmit(bb);
            }
            db.SubmitChanges();
        }

        public IQueryable TimKiemBienBan(string tieuDe,string thuki , string chutri, string noidung,string ykien , string ketluan ,string khoa)
        {
           IQueryable tim = from t in  db.BienBans
                            where t.tieuDe == tieuDe || t.thuKi == thuki || t.chuTri == chutri || t.noiDung==noidung || t.yKien == ykien || t.ketLuan == ketluan || t.khoa == khoa
                            select t;
            return tim;

            //if (!string.IsNullOrEmpty(tieuDe))
            //{
            //    query = query.Where(bb => bb.tieuDe.Contains(tieuDe));
            //    HienThiDanhSachBienBan();
            //}

            //if (!string.IsNullOrEmpty(thuKi))
            //{
            //    query = query.Where(bb => bb.thuKi.Contains(thuKi));
            //    HienThiDanhSachBienBan();
            //}

            //if (!string.IsNullOrEmpty(chuTri))
            //{
            //    query = query.Where(bb => bb.chuTri.Contains(chuTri));
            //    HienThiDanhSachBienBan();
            //}

           
        }


    }
}
