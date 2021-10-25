
namespace BTL_Nhom5
{
    partial class QuanLyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTaiKhoan));
            this.dgv_QLTaiKhoan = new System.Windows.Forms.DataGridView();
            this.MaTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdMaCV = new System.Windows.Forms.RadioButton();
            this.rdMaTK = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbChucVu = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new FontAwesome.Sharp.IconButton();
            this.btn_Them = new FontAwesome.Sharp.IconButton();
            this.btn_Sua = new FontAwesome.Sharp.IconButton();
            this.btn_Xoa = new FontAwesome.Sharp.IconButton();
            this.btnPreview = new FontAwesome.Sharp.IconButton();
            this.btn_NhapLai = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.txtphantrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLTaiKhoan
            // 
            this.dgv_QLTaiKhoan.AllowUserToAddRows = false;
            this.dgv_QLTaiKhoan.AllowUserToDeleteRows = false;
            this.dgv_QLTaiKhoan.AllowUserToResizeColumns = false;
            this.dgv_QLTaiKhoan.AllowUserToResizeRows = false;
            this.dgv_QLTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTaiKhoan,
            this.MatKhau,
            this.MaCV,
            this.TenCV});
            this.dgv_QLTaiKhoan.Location = new System.Drawing.Point(80, 205);
            this.dgv_QLTaiKhoan.Name = "dgv_QLTaiKhoan";
            this.dgv_QLTaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLTaiKhoan.Size = new System.Drawing.Size(644, 178);
            this.dgv_QLTaiKhoan.TabIndex = 125;
            this.dgv_QLTaiKhoan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLTaiKhoan_CellDoubleClick);
            this.dgv_QLTaiKhoan.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLTaiKhoan_RowEnter);
            // 
            // MaTaiKhoan
            // 
            this.MaTaiKhoan.DataPropertyName = "MaTaiKhoan";
            this.MaTaiKhoan.HeaderText = "Mã TK";
            this.MaTaiKhoan.Name = "MaTaiKhoan";
            this.MaTaiKhoan.Width = 150;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 150;
            // 
            // MaCV
            // 
            this.MaCV.DataPropertyName = "MaCV";
            this.MaCV.HeaderText = "Mã chức vụ";
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.DataPropertyName = "TenCV";
            this.TenCV.HeaderText = "Chức vụ";
            this.TenCV.Name = "TenCV";
            this.TenCV.Width = 200;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(19, 68);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(144, 20);
            this.txtTimKiem.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(178, 66);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(69, 23);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.rdMaCV);
            this.panel1.Controls.Add(this.rdMaTK);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(442, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 125);
            this.panel1.TabIndex = 114;
            // 
            // rdMaCV
            // 
            this.rdMaCV.AutoSize = true;
            this.rdMaCV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaCV.Location = new System.Drawing.Point(168, 30);
            this.rdMaCV.Name = "rdMaCV";
            this.rdMaCV.Size = new System.Drawing.Size(100, 23);
            this.rdMaCV.TabIndex = 1;
            this.rdMaCV.Text = "Mã chức vụ";
            this.rdMaCV.UseVisualStyleBackColor = true;
            // 
            // rdMaTK
            // 
            this.rdMaTK.AutoSize = true;
            this.rdMaTK.Checked = true;
            this.rdMaTK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMaTK.Location = new System.Drawing.Point(19, 30);
            this.rdMaTK.Name = "rdMaTK";
            this.rdMaTK.Size = new System.Drawing.Size(107, 23);
            this.rdMaTK.TabIndex = 0;
            this.rdMaTK.TabStop = true;
            this.rdMaTK.Text = "Mã tài khoản";
            this.rdMaTK.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(175, 33);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(157, 20);
            this.txtMaTK.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 112;
            this.label1.Text = "Mã tài khoản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 115;
            this.label5.Text = "Mật khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 19);
            this.label8.TabIndex = 124;
            this.label8.Text = "Chức vụ";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.FormattingEnabled = true;
            this.cmbChucVu.Location = new System.Drawing.Point(178, 142);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Size = new System.Drawing.Size(154, 21);
            this.cmbChucVu.TabIndex = 123;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(175, 87);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(157, 20);
            this.txtMK.TabIndex = 116;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_Thoat.IconColor = System.Drawing.Color.White;
            this.btn_Thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Thoat.IconSize = 22;
            this.btn_Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Thoat.Location = new System.Drawing.Point(676, 447);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(83, 39);
            this.btn_Thoat.TabIndex = 130;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_Them.IconColor = System.Drawing.Color.White;
            this.btn_Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Them.IconSize = 22;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(64, 447);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Them.Size = new System.Drawing.Size(82, 39);
            this.btn_Them.TabIndex = 126;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.btn_Sua.IconColor = System.Drawing.Color.White;
            this.btn_Sua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Sua.IconSize = 22;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(156, 447);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Sua.Size = new System.Drawing.Size(77, 39);
            this.btn_Sua.TabIndex = 127;
            this.btn_Sua.Text = "Sửa ";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btn_Xoa.IconColor = System.Drawing.Color.White;
            this.btn_Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Xoa.IconSize = 22;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(247, 449);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Xoa.Size = new System.Drawing.Size(73, 39);
            this.btn_Xoa.TabIndex = 128;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPreview.FlatAppearance.BorderSize = 0;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreview.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btnPreview.IconColor = System.Drawing.Color.White;
            this.btnPreview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPreview.IconSize = 22;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(563, 447);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnPreview.Size = new System.Drawing.Size(96, 39);
            this.btnPreview.TabIndex = 129;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhapLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NhapLai.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.btn_NhapLai.IconColor = System.Drawing.Color.White;
            this.btn_NhapLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_NhapLai.IconSize = 20;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(333, 450);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_NhapLai.Size = new System.Drawing.Size(99, 38);
            this.btn_NhapLai.TabIndex = 131;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(445, 450);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.iconButton1.Size = new System.Drawing.Size(101, 37);
            this.iconButton1.TabIndex = 132;
            this.iconButton1.Text = "ReLoad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // txtphantrang
            // 
            this.txtphantrang.Location = new System.Drawing.Point(80, 402);
            this.txtphantrang.Name = "txtphantrang";
            this.txtphantrang.Size = new System.Drawing.Size(153, 20);
            this.txtphantrang.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 134;
            this.label2.Text = "Tài khoản";
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtphantrang);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.dgv_QLTaiKhoan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.txtMK);
            this.Name = "QuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLTaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdMaCV;
        private System.Windows.Forms.RadioButton rdMaTK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbChucVu;
        private System.Windows.Forms.TextBox txtMK;
        private FontAwesome.Sharp.IconButton btn_Thoat;
        private FontAwesome.Sharp.IconButton btn_Them;
        private FontAwesome.Sharp.IconButton btn_Sua;
        private FontAwesome.Sharp.IconButton btn_Xoa;
        private FontAwesome.Sharp.IconButton btnPreview;
        private FontAwesome.Sharp.IconButton btn_NhapLai;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox txtphantrang;
        private System.Windows.Forms.Label label2;
    }
}