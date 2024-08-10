using BUS;
using DevExpress.XtraReports.UI;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBienBan
{
    public partial class frm_BienBan : Form
    {
        Bus_BienBan bus_bienBan = new Bus_BienBan();
        DTO_BienBan dto_bienBan;
        private int idBienBan = -1;
        public frm_BienBan()
        {
            InitializeComponent();
        }
        private void btn_themBienBan_Click(object sender, EventArgs e)
        {

            try
            {
                dto_bienBan = new DTO_BienBan(txt_tieuDe.Text, txt_noiDung.Text, cbb_khoa.Text.ToString(), txt_tptg.Text, txt_ttNgD.Text
                    , txt_thuKi.Text, txt_chuTri.Text, txt_ketLuan.Text, txt_yKien.Text, txt_diaDiem.Text, dtp_NgayThang.Value, dtp_timeStart.Value, dtp_timEnd.Value);
                if (txt_tieuDe.Text.Length > 0 && txt_thuKi.Text.Length > 0 && txt_chuTri.Text.Length > 0 &&
                    txt_ketLuan.Text.Length > 0 && txt_noiDung.Text.Length > 0 && txt_yKien.Text.Length > 0 &&
                    txt_tptg.Text.Length > 0 && txt_ttNgD.Text.Length > 0)
                {
                    bus_bienBan.ThemBienBan(dto_bienBan);
                    clearText();
                    frm_BienBan_LoadData();
                }
                else
                {
                    MessageBox.Show("không được để rỗng", "Lỗi");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_BienBan_Load(object sender, EventArgs e)
        {
            dgv_bienBan.DataSource = bus_bienBan.HienThiDanhSachBienBan();
        }
        private void frm_BienBan_LoadData()
        {
            dgv_bienBan.DataSource = bus_bienBan.HienThiDanhSachBienBan();
        }

        private void clearText()
        {
            txt_chuTri.Text = "";
            txt_ketLuan.Text = "";
            txt_noiDung.Text = "";
            txt_thuKi.Text = "";
            txt_tieuDe.Text = "";
            txt_tptg.Text = "";
            txt_ttNgD.Text = "";
            txt_yKien.Text = "";
            dtp_NgayThang.Value = DateTime.Now;
        }

        private void dgv_bienBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 || dgv_bienBan.Rows[i] != null)
            {
                DataGridViewRow row = dgv_bienBan.Rows[i];
                idBienBan = int.Parse(row.Cells[0].Value.ToString());
                txt_tieuDe.Text = row.Cells[1].Value.ToString();
                dtp_NgayThang.Text = row.Cells[2].Value.ToString();
                txt_noiDung.Text = row.Cells[3].Value.ToString();
                cbb_khoa.Text = row.Cells[4].Value.ToString();
                txt_tptg.Text = row.Cells[5].Value.ToString();
                txt_ttNgD.Text = row.Cells[6].Value.ToString();
                txt_thuKi.Text = row.Cells[7].Value.ToString();
                txt_chuTri.Text = row.Cells[8].Value.ToString();
                txt_ketLuan.Text = row.Cells[9].Value.ToString();
                txt_yKien.Text = row.Cells[10].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng", "Lỗi",MessageBoxButtons.OK);
            }
        }

        private void cbb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_khoa.SelectedIndex == 0)
            {
                cbb_khoa.Text = "Công Nghệ Thông Tin";
            }
            if (cbb_khoa.SelectedIndex == 1)
            {
                cbb_khoa.Text = "Tiếng Anh";
            }
            if (cbb_khoa.SelectedIndex == 2)
            {
                cbb_khoa.Text = "logistic";
            }
            if (cbb_khoa.SelectedIndex == 3)
            {
                cbb_khoa.Text = "Ô Tô";
            }
        }

        private void btn_xoaBienBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tieuDe.Text.Length > 0 && txt_thuKi.Text.Length > 0 && txt_chuTri.Text.Length > 0 &&
                    txt_ketLuan.Text.Length > 0 && txt_noiDung.Text.Length > 0 && txt_yKien.Text.Length > 0 &&
                    txt_tptg.Text.Length > 0 && txt_ttNgD.Text.Length > 0)
                {
                    MessageBox.Show("Xóa biên bản thành công", "Thông Báo", MessageBoxButtons.OK);
                    bus_bienBan.XoaBienBan(idBienBan);
                    frm_BienBan_LoadData();
                }
                else
                {
                    MessageBox.Show("không được để rỗng", "Lỗi",MessageBoxButtons.OK);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_suaBienBan_Click(object sender, EventArgs e)
        {
            try
            {
                dto_bienBan = new DTO_BienBan(txt_tieuDe.Text, txt_noiDung.Text, cbb_khoa.Text.ToString(), txt_tptg.Text, txt_ttNgD.Text
                    , txt_thuKi.Text, txt_chuTri.Text, txt_ketLuan.Text, txt_yKien.Text,txt_diaDiem.Text, dtp_NgayThang.Value,dtp_timeStart.Value,dtp_timEnd.Value);
                if (txt_tieuDe.Text.Length > 0 && txt_thuKi.Text.Length > 0 && txt_chuTri.Text.Length > 0 &&
                    txt_ketLuan.Text.Length > 0 && txt_noiDung.Text.Length > 0 && txt_yKien.Text.Length > 0 &&
                    txt_tptg.Text.Length > 0 && txt_ttNgD.Text.Length > 0)
                {
                    bus_bienBan.SuaBienBan(dto_bienBan, idBienBan);
                    clearText();
                    frm_BienBan_LoadData();
                    MessageBox.Show("Sửa thông tin thành công", "Thông Báo",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("không được để rỗng", "Lỗi",MessageBoxButtons.OK);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public Boolean HamKiemTraNhapHopLe(string checkText)
        {

            // Danh sách các ký tự đặc biệt
            string specialChars = @"!@#$%^&*()_+-=[]{}|;':"",./<>?";

            // Kiểm tra ký tự đặc biệt
            if (checkText.IndexOfAny(specialChars.ToCharArray()) != -1 || checkText.Contains("  "))
            {
                thongBaoLoi.Text = "Chuỗi không được chứa ký tự đặc biệt và 2 khoảng trắng liền nhau!";
                thongBaoLoi.BackColor = Color.Red;
                btn_themBienBan.Enabled = false;
                btn_suaBienBan.Enabled = false;
                btn_xoaBienBan.Enabled = false;
               
                return true;
            }
            else
            {
                btn_themBienBan.Enabled = true;
                btn_suaBienBan.Enabled = true;
                btn_xoaBienBan.Enabled = true;
                
                thongBaoLoi.BackColor = Color.White;
                thongBaoLoi.Text = "";
            }
            return false;
        }
        private void txt_tieuDe_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_tieuDe.Text);
        }

        private void txt_thuKi_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_thuKi.Text);
        }

        private void txt_chuTri_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_chuTri.Text);
        }

        private void txt_diaDiem_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_diaDiem.Text);
        }

        private void txt_tptg_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_tptg.Text);
        }

        private void txt_ketLuan_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_ketLuan.Text);
        }

        private void txt_noiDung_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_noiDung.Text);
        }

        private void txt_ttNgD_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_ttNgD.Text);
        }

        private void txt_yKien_TextChanged(object sender, EventArgs e)
        {
            HamKiemTraNhapHopLe(txt_yKien.Text);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
