namespace QuanLyBienBan
{
    partial class frm_BienBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_tieuDe = new System.Windows.Forms.TextBox();
            this.txt_thuKi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_NgayThang = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_chuTri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_khoa = new System.Windows.Forms.ComboBox();
            this.dgv_bienBan = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tptg = new System.Windows.Forms.TextBox();
            this.txt_ttNgD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_themBienBan = new System.Windows.Forms.Button();
            this.btn_suaBienBan = new System.Windows.Forms.Button();
            this.btn_xoaBienBan = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_noiDung = new System.Windows.Forms.RichTextBox();
            this.txt_ketLuan = new System.Windows.Forms.RichTextBox();
            this.txt_yKien = new System.Windows.Forms.RichTextBox();
            this.dtp_timeStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_timEnd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_diaDiem = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.thongBaoLoi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_tieuDe
            // 
            this.txt_tieuDe.Location = new System.Drawing.Point(82, 15);
            this.txt_tieuDe.Name = "txt_tieuDe";
            this.txt_tieuDe.Size = new System.Drawing.Size(173, 22);
            this.txt_tieuDe.TabIndex = 0;
            this.txt_tieuDe.TextChanged += new System.EventHandler(this.txt_tieuDe_TextChanged);
            // 
            // txt_thuKi
            // 
            this.txt_thuKi.Location = new System.Drawing.Point(605, 12);
            this.txt_thuKi.Name = "txt_thuKi";
            this.txt_thuKi.Size = new System.Drawing.Size(127, 22);
            this.txt_thuKi.TabIndex = 1;
            this.txt_thuKi.TextChanged += new System.EventHandler(this.txt_thuKi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiêu Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời Gian";
            // 
            // dtp_NgayThang
            // 
            this.dtp_NgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayThang.Location = new System.Drawing.Point(375, 16);
            this.dtp_NgayThang.Name = "dtp_NgayThang";
            this.dtp_NgayThang.Size = new System.Drawing.Size(146, 22);
            this.dtp_NgayThang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Thư Kí";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(753, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chủ Trì";
            // 
            // txt_chuTri
            // 
            this.txt_chuTri.Location = new System.Drawing.Point(808, 12);
            this.txt_chuTri.Name = "txt_chuTri";
            this.txt_chuTri.Size = new System.Drawing.Size(112, 22);
            this.txt_chuTri.TabIndex = 7;
            this.txt_chuTri.TextChanged += new System.EventHandler(this.txt_chuTri_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nội Dung";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(939, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Khoa";
            // 
            // cbb_khoa
            // 
            this.cbb_khoa.FormattingEnabled = true;
            this.cbb_khoa.Items.AddRange(new object[] {
            "CNTT",
            "TA",
            "KT",
            "LG",
            "OT"});
            this.cbb_khoa.Location = new System.Drawing.Point(993, 12);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(121, 24);
            this.cbb_khoa.TabIndex = 11;
            this.cbb_khoa.SelectedIndexChanged += new System.EventHandler(this.cbb_khoa_SelectedIndexChanged);
            // 
            // dgv_bienBan
            // 
            this.dgv_bienBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bienBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_bienBan.Location = new System.Drawing.Point(0, 460);
            this.dgv_bienBan.Name = "dgv_bienBan";
            this.dgv_bienBan.RowHeadersWidth = 51;
            this.dgv_bienBan.RowTemplate.Height = 24;
            this.dgv_bienBan.Size = new System.Drawing.Size(1282, 247);
            this.dgv_bienBan.TabIndex = 12;
            this.dgv_bienBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bienBan_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Thành Phần Tham Gia";
            // 
            // txt_tptg
            // 
            this.txt_tptg.Location = new System.Drawing.Point(186, 100);
            this.txt_tptg.Name = "txt_tptg";
            this.txt_tptg.Size = new System.Drawing.Size(358, 22);
            this.txt_tptg.TabIndex = 14;
            this.txt_tptg.TextChanged += new System.EventHandler(this.txt_tptg_TextChanged);
            // 
            // txt_ttNgD
            // 
            this.txt_ttNgD.Location = new System.Drawing.Point(759, 97);
            this.txt_ttNgD.Name = "txt_ttNgD";
            this.txt_ttNgD.Size = new System.Drawing.Size(358, 22);
            this.txt_ttNgD.TabIndex = 15;
            this.txt_ttNgD.TextChanged += new System.EventHandler(this.txt_ttNgD_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(612, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thông Tin Người Dự";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kết Luận";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Y Kiến";
            // 
            // btn_themBienBan
            // 
            this.btn_themBienBan.Location = new System.Drawing.Point(22, 384);
            this.btn_themBienBan.Name = "btn_themBienBan";
            this.btn_themBienBan.Size = new System.Drawing.Size(113, 53);
            this.btn_themBienBan.TabIndex = 21;
            this.btn_themBienBan.Text = "Thêm";
            this.btn_themBienBan.UseVisualStyleBackColor = true;
            this.btn_themBienBan.Click += new System.EventHandler(this.btn_themBienBan_Click);
            // 
            // btn_suaBienBan
            // 
            this.btn_suaBienBan.Location = new System.Drawing.Point(135, 384);
            this.btn_suaBienBan.Name = "btn_suaBienBan";
            this.btn_suaBienBan.Size = new System.Drawing.Size(113, 53);
            this.btn_suaBienBan.TabIndex = 22;
            this.btn_suaBienBan.Text = "Sửa";
            this.btn_suaBienBan.UseVisualStyleBackColor = true;
            this.btn_suaBienBan.Click += new System.EventHandler(this.btn_suaBienBan_Click);
            // 
            // btn_xoaBienBan
            // 
            this.btn_xoaBienBan.Location = new System.Drawing.Point(248, 384);
            this.btn_xoaBienBan.Name = "btn_xoaBienBan";
            this.btn_xoaBienBan.Size = new System.Drawing.Size(113, 53);
            this.btn_xoaBienBan.TabIndex = 23;
            this.btn_xoaBienBan.Text = "Xóa";
            this.btn_xoaBienBan.UseVisualStyleBackColor = true;
            this.btn_xoaBienBan.Click += new System.EventHandler(this.btn_xoaBienBan_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(367, 384);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(113, 53);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Đặt Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_noiDung
            // 
            this.txt_noiDung.Location = new System.Drawing.Point(118, 151);
            this.txt_noiDung.Name = "txt_noiDung";
            this.txt_noiDung.Size = new System.Drawing.Size(999, 43);
            this.txt_noiDung.TabIndex = 25;
            this.txt_noiDung.Text = "";
            this.txt_noiDung.TextChanged += new System.EventHandler(this.txt_noiDung_TextChanged);
            // 
            // txt_ketLuan
            // 
            this.txt_ketLuan.Location = new System.Drawing.Point(118, 218);
            this.txt_ketLuan.Name = "txt_ketLuan";
            this.txt_ketLuan.Size = new System.Drawing.Size(999, 43);
            this.txt_ketLuan.TabIndex = 26;
            this.txt_ketLuan.Text = "";
            this.txt_ketLuan.TextChanged += new System.EventHandler(this.txt_ketLuan_TextChanged);
            // 
            // txt_yKien
            // 
            this.txt_yKien.Location = new System.Drawing.Point(118, 289);
            this.txt_yKien.Name = "txt_yKien";
            this.txt_yKien.Size = new System.Drawing.Size(999, 43);
            this.txt_yKien.TabIndex = 27;
            this.txt_yKien.Text = "";
            this.txt_yKien.TextChanged += new System.EventHandler(this.txt_yKien_TextChanged);
            // 
            // dtp_timeStart
            // 
            this.dtp_timeStart.CustomFormat = "HH:mm";
            this.dtp_timeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_timeStart.Location = new System.Drawing.Point(162, 56);
            this.dtp_timeStart.Name = "dtp_timeStart";
            this.dtp_timeStart.ShowUpDown = true;
            this.dtp_timeStart.Size = new System.Drawing.Size(146, 22);
            this.dtp_timeStart.TabIndex = 30;
            this.dtp_timeStart.Value = new System.DateTime(2024, 8, 7, 12, 33, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Thời Gian Bắt Đầu";
            // 
            // dtp_timEnd
            // 
            this.dtp_timEnd.CustomFormat = "HH:mm";
            this.dtp_timEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_timEnd.Location = new System.Drawing.Point(509, 56);
            this.dtp_timEnd.Name = "dtp_timEnd";
            this.dtp_timEnd.ShowUpDown = true;
            this.dtp_timEnd.Size = new System.Drawing.Size(146, 22);
            this.dtp_timEnd.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Thời Gian Kết Thúc";
            // 
            // txt_diaDiem
            // 
            this.txt_diaDiem.Location = new System.Drawing.Point(756, 59);
            this.txt_diaDiem.Name = "txt_diaDiem";
            this.txt_diaDiem.Size = new System.Drawing.Size(358, 22);
            this.txt_diaDiem.TabIndex = 34;
            this.txt_diaDiem.TextChanged += new System.EventHandler(this.txt_diaDiem_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(681, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "Địa Điểm";
            // 
            // thongBaoLoi
            // 
            this.thongBaoLoi.AutoSize = true;
            this.thongBaoLoi.Location = new System.Drawing.Point(25, 348);
            this.thongBaoLoi.Name = "thongBaoLoi";
            this.thongBaoLoi.Size = new System.Drawing.Size(0, 16);
            this.thongBaoLoi.TabIndex = 35;
            // 
            // frm_BienBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 707);
            this.Controls.Add(this.thongBaoLoi);
            this.Controls.Add(this.txt_diaDiem);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtp_timEnd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtp_timeStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_yKien);
            this.Controls.Add(this.txt_ketLuan);
            this.Controls.Add(this.txt_noiDung);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_xoaBienBan);
            this.Controls.Add(this.btn_suaBienBan);
            this.Controls.Add(this.btn_themBienBan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ttNgD);
            this.Controls.Add(this.txt_tptg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_bienBan);
            this.Controls.Add(this.cbb_khoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_chuTri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_NgayThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_thuKi);
            this.Controls.Add(this.txt_tieuDe);
            this.Name = "frm_BienBan";
            this.Text = "Quản Lý Biên Bản";
            this.Load += new System.EventHandler(this.frm_BienBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tieuDe;
        private System.Windows.Forms.TextBox txt_thuKi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_NgayThang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_chuTri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_khoa;
        private System.Windows.Forms.DataGridView dgv_bienBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tptg;
        private System.Windows.Forms.TextBox txt_ttNgD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_themBienBan;
        private System.Windows.Forms.Button btn_suaBienBan;
        private System.Windows.Forms.Button btn_xoaBienBan;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.RichTextBox txt_noiDung;
        private System.Windows.Forms.RichTextBox txt_ketLuan;
        private System.Windows.Forms.RichTextBox txt_yKien;
        private System.Windows.Forms.DateTimePicker dtp_timeStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_timEnd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_diaDiem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label thongBaoLoi;
    }
}