namespace QuanLyBienBan
{
    partial class frm_TimKiemBienBan
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
            this.txt_yKien = new System.Windows.Forms.RichTextBox();
            this.txt_ketLuan = new System.Windows.Forms.RichTextBox();
            this.txt_noiDung = new System.Windows.Forms.RichTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_timKiemBienBan = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ttNgD = new System.Windows.Forms.TextBox();
            this.txt_tptg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgv_bienBan = new System.Windows.Forms.DataGridView();
            this.cbb_khoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chuTri = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_NgayThang = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_thuKi = new System.Windows.Forms.TextBox();
            this.txt_tieuDe = new System.Windows.Forms.TextBox();
            this.btn_inPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienBan)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_yKien
            // 
            this.txt_yKien.Location = new System.Drawing.Point(80, 187);
            this.txt_yKien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_yKien.Name = "txt_yKien";
            this.txt_yKien.Size = new System.Drawing.Size(750, 36);
            this.txt_yKien.TabIndex = 52;
            this.txt_yKien.Text = "";
            // 
            // txt_ketLuan
            // 
            this.txt_ketLuan.Location = new System.Drawing.Point(80, 129);
            this.txt_ketLuan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ketLuan.Name = "txt_ketLuan";
            this.txt_ketLuan.Size = new System.Drawing.Size(750, 36);
            this.txt_ketLuan.TabIndex = 51;
            this.txt_ketLuan.Text = "";
            // 
            // txt_noiDung
            // 
            this.txt_noiDung.Location = new System.Drawing.Point(86, 75);
            this.txt_noiDung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_noiDung.Name = "txt_noiDung";
            this.txt_noiDung.Size = new System.Drawing.Size(750, 36);
            this.txt_noiDung.TabIndex = 50;
            this.txt_noiDung.Text = "";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(108, 257);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 43);
            this.btn_reset.TabIndex = 49;
            this.btn_reset.Text = "Đặt Lại";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_timKiemBienBan
            // 
            this.btn_timKiemBienBan.Location = new System.Drawing.Point(15, 257);
            this.btn_timKiemBienBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_timKiemBienBan.Name = "btn_timKiemBienBan";
            this.btn_timKiemBienBan.Size = new System.Drawing.Size(85, 43);
            this.btn_timKiemBienBan.TabIndex = 46;
            this.btn_timKiemBienBan.Text = "Tìm Kiếm";
            this.btn_timKiemBienBan.UseVisualStyleBackColor = true;
            this.btn_timKiemBienBan.Click += new System.EventHandler(this.btn_timKiemBienBan_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "Y Kiến";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "Kết Luận";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "Thông Tin Người Dự";
            // 
            // txt_ttNgD
            // 
            this.txt_ttNgD.Location = new System.Drawing.Point(567, 38);
            this.txt_ttNgD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ttNgD.Name = "txt_ttNgD";
            this.txt_ttNgD.Size = new System.Drawing.Size(270, 20);
            this.txt_ttNgD.TabIndex = 42;
            // 
            // txt_tptg
            // 
            this.txt_tptg.Location = new System.Drawing.Point(137, 41);
            this.txt_tptg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tptg.Name = "txt_tptg";
            this.txt_tptg.Size = new System.Drawing.Size(270, 20);
            this.txt_tptg.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "Thành Phần Tham Gia";
            // 
            // dgv_bienBan
            // 
            this.dgv_bienBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bienBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_bienBan.Location = new System.Drawing.Point(0, 346);
            this.dgv_bienBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_bienBan.Name = "dgv_bienBan";
            this.dgv_bienBan.RowHeadersWidth = 51;
            this.dgv_bienBan.RowTemplate.Height = 24;
            this.dgv_bienBan.Size = new System.Drawing.Size(844, 201);
            this.dgv_bienBan.TabIndex = 39;
            this.dgv_bienBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_bienBan_CellClick);
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
            this.cbb_khoa.Location = new System.Drawing.Point(745, 5);
            this.cbb_khoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_khoa.Name = "cbb_khoa";
            this.cbb_khoa.Size = new System.Drawing.Size(92, 21);
            this.cbb_khoa.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(704, 7);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Khoa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nội Dung";
            // 
            // txt_chuTri
            // 
            this.txt_chuTri.Location = new System.Drawing.Point(606, 5);
            this.txt_chuTri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_chuTri.Name = "txt_chuTri";
            this.txt_chuTri.Size = new System.Drawing.Size(85, 20);
            this.txt_chuTri.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Chủ Trì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Thư Kí";
            // 
            // dtp_NgayThang
            // 
            this.dtp_NgayThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayThang.Location = new System.Drawing.Point(281, 8);
            this.dtp_NgayThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_NgayThang.Name = "dtp_NgayThang";
            this.dtp_NgayThang.Size = new System.Drawing.Size(110, 20);
            this.dtp_NgayThang.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Thời Gian";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tiêu Đề";
            // 
            // txt_thuKi
            // 
            this.txt_thuKi.Location = new System.Drawing.Point(454, 5);
            this.txt_thuKi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_thuKi.Name = "txt_thuKi";
            this.txt_thuKi.Size = new System.Drawing.Size(96, 20);
            this.txt_thuKi.TabIndex = 29;
            // 
            // txt_tieuDe
            // 
            this.txt_tieuDe.Location = new System.Drawing.Point(62, 7);
            this.txt_tieuDe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tieuDe.Name = "txt_tieuDe";
            this.txt_tieuDe.Size = new System.Drawing.Size(131, 20);
            this.txt_tieuDe.TabIndex = 28;
            this.txt_tieuDe.TextChanged += new System.EventHandler(this.txt_tieuDe_TextChanged);
            // 
            // btn_inPDF
            // 
            this.btn_inPDF.Location = new System.Drawing.Point(210, 257);
            this.btn_inPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_inPDF.Name = "btn_inPDF";
            this.btn_inPDF.Size = new System.Drawing.Size(85, 43);
            this.btn_inPDF.TabIndex = 53;
            this.btn_inPDF.Text = "InPDF";
            this.btn_inPDF.UseVisualStyleBackColor = true;
            this.btn_inPDF.Click += new System.EventHandler(this.btn_inPDF_Click);
            // 
            // frm_TimKiemBienBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 547);
            this.Controls.Add(this.btn_inPDF);
            this.Controls.Add(this.txt_yKien);
            this.Controls.Add(this.txt_ketLuan);
            this.Controls.Add(this.txt_noiDung);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_timKiemBienBan);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_TimKiemBienBan";
            this.Text = "Tìm Kiếm Biên Bản";
            this.Load += new System.EventHandler(this.frm_TimKiemBienBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bienBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_yKien;
        private System.Windows.Forms.RichTextBox txt_ketLuan;
        private System.Windows.Forms.RichTextBox txt_noiDung;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_timKiemBienBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ttNgD;
        private System.Windows.Forms.TextBox txt_tptg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgv_bienBan;
        private System.Windows.Forms.ComboBox cbb_khoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chuTri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_NgayThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_thuKi;
        private System.Windows.Forms.TextBox txt_tieuDe;
        private System.Windows.Forms.Button btn_inPDF;
    }
}