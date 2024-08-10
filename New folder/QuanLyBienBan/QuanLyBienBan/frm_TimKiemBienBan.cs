using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using DTO;

namespace QuanLyBienBan
{
    public partial class frm_TimKiemBienBan : Form
    {
        Bus_BienBan bus_bienBan = new Bus_BienBan();
        DTO_BienBan dto_bienBan;

        public frm_TimKiemBienBan()
        {
            InitializeComponent();
        }

        private void frm_TimKiemBienBan_Load(object sender, EventArgs e)
        {
            load();
        }

        private void txt_tieuDe_TextChanged(object sender, EventArgs e)
        {

        }
        private void load()
        {
            dgv_bienBan.DataSource = bus_bienBan.HienThiDanhSachBienBan();  
        }
        private void btn_timKiemBienBan_Click(object sender, EventArgs e)
        {
           
                dgv_bienBan.DataSource = bus_bienBan.TimKiemBienBan(txt_tieuDe.Text,txt_thuKi.Text,txt_chuTri.Text,txt_noiDung.Text,txt_yKien.Text,txt_ketLuan.Text,cbb_khoa.Text);
          
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            clearText();
            load();
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
                MessageBox.Show("Vui lòng chọn 1 dòng", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btn_inPDF_Click(object sender, EventArgs e)
        {
            
                rpt_BienBan rpt_BienBan = new rpt_BienBan();
                rpt_BienBan.DataSource = bus_bienBan.TimKiemBienBan(txt_tieuDe.Text, txt_thuKi.Text, txt_chuTri.Text, txt_noiDung.Text, txt_yKien.Text, txt_ketLuan.Text, cbb_khoa.Text); 
                rpt_BienBan.ShowPreview();
                load();
            
        }
    }
}
