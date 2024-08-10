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
using DTO;

/*
 * 
 */
namespace QuanLyBienBan
{
    public partial class frm_TaiKhoan : Form
    {
        BUS_TaiKhoan bus_taiKhoan = new BUS_TaiKhoan();
        DTO_TaiKhoan dto_taiKhoan;
        private int id = -1;
        public frm_TaiKhoan()
        {
            InitializeComponent();
        }

        private void frm_TaiKhoan_Load(object sender, EventArgs e)
        {
            dgv_DSTaiKhoan.DataSource = bus_taiKhoan.HienThiDanhSachTaiKhoan();
        }

        private void btn_themTaiKhoan_Click(object sender, EventArgs e)
        {
           
            try
            {
                dto_taiKhoan = new DTO_TaiKhoan(txt_tenTaiKhoan.Text, txt_matKhau.Text);
                if (txt_tenTaiKhoan.Text.Length > 0 && txt_matKhau.Text.Length > 0)
                {
                    if (bus_taiKhoan.KiemTraTonTaiTenTaiKhoan(txt_tenTaiKhoan.Text))
                    {
                        MessageBox.Show("Trùng Tên Tài Khoản", "Lỗi");
                    }
                    else
                    {
                        bus_taiKhoan.ThemTaiKhoan(dto_taiKhoan);
                        dgv_DSTaiKhoan.DataSource = bus_taiKhoan.HienThiDanhSachTaiKhoan();
                        txt_tenTaiKhoan.Text = "";
                        txt_matKhau.Text = "";
                    }
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

        private void btn_xuaTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txt_tenTaiKhoan.Text.Length > 0 && txt_matKhau.Text.Length > 0)
            {
                dto_taiKhoan = new DTO_TaiKhoan(txt_tenTaiKhoan.Text, txt_matKhau.Text);
                txt_tenTaiKhoan.Text = "";
                txt_matKhau.Text = "";
                bus_taiKhoan.SuaTaiKhoan(dto_taiKhoan, id);
            }
            else
            {
                MessageBox.Show("không được để rỗng", "Lỗi");
            }
        }

        private void dgv_DSTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0 || dgv_DSTaiKhoan.Rows[i] != null) 
            {
                DataGridViewRow row = dgv_DSTaiKhoan.Rows[i];
                id = int.Parse(row.Cells[0].Value.ToString());
                txt_tenTaiKhoan.Text = row.Cells[1].Value.ToString();
                txt_matKhau.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 dòng", "Lỗi");
            }
        }

        private void btn_xoaTaiKhoan_Click(object sender, EventArgs e)
        {   
            if (txt_tenTaiKhoan.Text.Length > 0 && txt_matKhau.Text.Length > 0)
            {
               bus_taiKhoan.XoaTaiKhoan(id);
               dgv_DSTaiKhoan.DataSource = bus_taiKhoan.HienThiDanhSachTaiKhoan();
            }
            else
            {
                MessageBox.Show("không được để rỗng", "Lỗi");
            }
        }
    }
}
