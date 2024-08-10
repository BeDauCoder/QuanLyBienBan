namespace QuanLyBienBan
{
    partial class frm_TaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenTaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_matKhau = new System.Windows.Forms.TextBox();
            this.dgv_DSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.idTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themTaiKhoan = new System.Windows.Forms.Button();
            this.btn_xuaTaiKhoan = new System.Windows.Forms.Button();
            this.btn_xoaTaiKhoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord";
            // 
            // txt_tenTaiKhoan
            // 
            this.txt_tenTaiKhoan.Location = new System.Drawing.Point(256, 106);
            this.txt_tenTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_tenTaiKhoan.Name = "txt_tenTaiKhoan";
            this.txt_tenTaiKhoan.Size = new System.Drawing.Size(76, 20);
            this.txt_tenTaiKhoan.TabIndex = 2;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.Location = new System.Drawing.Point(256, 132);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Size = new System.Drawing.Size(76, 20);
            this.txt_matKhau.TabIndex = 3;
            // 
            // dgv_DSTaiKhoan
            // 
            this.dgv_DSTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTaiKhoan,
            this.tenTaiKhoan,
            this.matKhau});
            this.dgv_DSTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DSTaiKhoan.Location = new System.Drawing.Point(0, 225);
            this.dgv_DSTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DSTaiKhoan.Name = "dgv_DSTaiKhoan";
            this.dgv_DSTaiKhoan.ReadOnly = true;
            this.dgv_DSTaiKhoan.RowHeadersWidth = 51;
            this.dgv_DSTaiKhoan.RowTemplate.Height = 24;
            this.dgv_DSTaiKhoan.Size = new System.Drawing.Size(600, 141);
            this.dgv_DSTaiKhoan.TabIndex = 4;
            this.dgv_DSTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSTaiKhoan_CellClick);
            // 
            // idTaiKhoan
            // 
            this.idTaiKhoan.DataPropertyName = "idTaiKhoan";
            this.idTaiKhoan.HeaderText = "ID TÀI KHOẢN";
            this.idTaiKhoan.MinimumWidth = 6;
            this.idTaiKhoan.Name = "idTaiKhoan";
            this.idTaiKhoan.ReadOnly = true;
            // 
            // tenTaiKhoan
            // 
            this.tenTaiKhoan.DataPropertyName = "tenTaiKhoan";
            this.tenTaiKhoan.HeaderText = "TÊN TÀI KHOẢN";
            this.tenTaiKhoan.MinimumWidth = 6;
            this.tenTaiKhoan.Name = "tenTaiKhoan";
            this.tenTaiKhoan.ReadOnly = true;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật Khẩu";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            // 
            // btn_themTaiKhoan
            // 
            this.btn_themTaiKhoan.Location = new System.Drawing.Point(152, 173);
            this.btn_themTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_themTaiKhoan.Name = "btn_themTaiKhoan";
            this.btn_themTaiKhoan.Size = new System.Drawing.Size(56, 29);
            this.btn_themTaiKhoan.TabIndex = 5;
            this.btn_themTaiKhoan.Text = "ADd";
            this.btn_themTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_themTaiKhoan.Click += new System.EventHandler(this.btn_themTaiKhoan_Click);
            // 
            // btn_xuaTaiKhoan
            // 
            this.btn_xuaTaiKhoan.Location = new System.Drawing.Point(242, 173);
            this.btn_xuaTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xuaTaiKhoan.Name = "btn_xuaTaiKhoan";
            this.btn_xuaTaiKhoan.Size = new System.Drawing.Size(56, 29);
            this.btn_xuaTaiKhoan.TabIndex = 6;
            this.btn_xuaTaiKhoan.Text = "update";
            this.btn_xuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_xuaTaiKhoan.Click += new System.EventHandler(this.btn_xuaTaiKhoan_Click);
            // 
            // btn_xoaTaiKhoan
            // 
            this.btn_xoaTaiKhoan.Location = new System.Drawing.Point(332, 173);
            this.btn_xoaTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoaTaiKhoan.Name = "btn_xoaTaiKhoan";
            this.btn_xoaTaiKhoan.Size = new System.Drawing.Size(56, 29);
            this.btn_xoaTaiKhoan.TabIndex = 7;
            this.btn_xoaTaiKhoan.Text = "Delete";
            this.btn_xoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btn_xoaTaiKhoan.Click += new System.EventHandler(this.btn_xoaTaiKhoan_Click);
            // 
            // frm_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_xoaTaiKhoan);
            this.Controls.Add(this.btn_xuaTaiKhoan);
            this.Controls.Add(this.btn_themTaiKhoan);
            this.Controls.Add(this.dgv_DSTaiKhoan);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_TaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frm_TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenTaiKhoan;
        private System.Windows.Forms.TextBox txt_matKhau;
        private System.Windows.Forms.DataGridView dgv_DSTaiKhoan;
        private System.Windows.Forms.Button btn_themTaiKhoan;
        private System.Windows.Forms.Button btn_xuaTaiKhoan;
        private System.Windows.Forms.Button btn_xoaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
    }
}

