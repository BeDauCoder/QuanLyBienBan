using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_BienBan
    {
        private string tieuDe, noiDung, khoa, thanhPhanThamGia, thongTinNguoiDu, thuKi, chuTri, ketLuan, yKien, diaDiem;
        private DateTime thoiGian;
        private DateTime thoiGianBatDau;
        private DateTime thoiGianKetThuc;


        public DTO_BienBan() { }

        public DTO_BienBan(string tieuDe, string noiDung, string khoa, string thanhPhanThamGia, string thongTinNguoiDu, string thuKi, string chuTri, string ketLuan, string yKien, string diaDiem, DateTime thoiGian, DateTime thoiGianBatDau, DateTime thoiGianKetThuc)
        {
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.khoa = khoa;
            this.thanhPhanThamGia = thanhPhanThamGia;
            this.thongTinNguoiDu = thongTinNguoiDu;
            this.thuKi = thuKi;
            this.chuTri = chuTri;
            this.ketLuan = ketLuan;
            this.yKien = yKien;
            this.diaDiem = diaDiem;
            this.thoiGian = thoiGian;
            this.ThoiGianBatDau = thoiGianBatDau;
            this.ThoiGianKetThuc = thoiGianKetThuc;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public string ThanhPhanThamGia { get => thanhPhanThamGia; set => thanhPhanThamGia = value; }
        public string ThongTinNguoiDu { get => thongTinNguoiDu; set => thongTinNguoiDu = value; }
        public string ThuKi { get => thuKi; set => thuKi = value; }
        public string ChuTri { get => chuTri; set => chuTri = value; }
        public string KetLuan { get => ketLuan; set => ketLuan = value; }
        public string YKien { get => yKien; set => yKien = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public DateTime ThoiGianBatDau { get => thoiGianBatDau; set => thoiGianBatDau = value; }
        public DateTime ThoiGianKetThuc { get => thoiGianKetThuc; set => thoiGianKetThuc = value; }
    }
}
