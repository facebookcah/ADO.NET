
namespace BTL_Nhom5
{
    partial class FormPhieuChi
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoTienChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPhieuChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dateTimePickerKT = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBD = new System.Windows.Forms.DateTimePicker();
            this.dgvPhieuChi = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_NhapLai = new FontAwesome.Sharp.IconButton();
            this.btn_Thoat = new FontAwesome.Sharp.IconButton();
            this.BtnThem = new FontAwesome.Sharp.IconButton();
            this.BtnSua = new FontAwesome.Sharp.IconButton();
            this.BtnXoa = new FontAwesome.Sharp.IconButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(471, 149);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 118;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 117;
            this.label11.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(471, 112);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(141, 20);
            this.txtSDT.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 115;
            this.label4.Text = "SĐT";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(471, 76);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(141, 20);
            this.txtDiaChi.TabIndex = 114;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Địa chỉ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Nhà CC";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayLap.Location = new System.Drawing.Point(156, 112);
            this.txtNgayLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(149, 20);
            this.txtNgayLap.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Ngày Lập";
            // 
            // txtSoTienChi
            // 
            this.txtSoTienChi.Location = new System.Drawing.Point(471, 40);
            this.txtSoTienChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoTienChi.Name = "txtSoTienChi";
            this.txtSoTienChi.Size = new System.Drawing.Size(141, 20);
            this.txtSoTienChi.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(379, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 107;
            this.label7.Text = "Số Tiền Chi";
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(156, 148);
            this.txtNguoiLap.Margin = new System.Windows.Forms.Padding(2);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(149, 20);
            this.txtNguoiLap.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Người Lập";
            // 
            // txtMaPhieuChi
            // 
            this.txtMaPhieuChi.Location = new System.Drawing.Point(156, 43);
            this.txtMaPhieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuChi.Name = "txtMaPhieuChi";
            this.txtMaPhieuChi.Size = new System.Drawing.Size(149, 20);
            this.txtMaPhieuChi.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Mã Phiếu Chi";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnThongKe.Location = new System.Drawing.Point(371, 219);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 32);
            this.btnThongKe.TabIndex = 102;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dateTimePickerKT
            // 
            this.dateTimePickerKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKT.Location = new System.Drawing.Point(578, 234);
            this.dateTimePickerKT.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerKT.Name = "dateTimePickerKT";
            this.dateTimePickerKT.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerKT.TabIndex = 101;
            // 
            // dateTimePickerBD
            // 
            this.dateTimePickerBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBD.Location = new System.Drawing.Point(128, 234);
            this.dateTimePickerBD.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerBD.Name = "dateTimePickerBD";
            this.dateTimePickerBD.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBD.TabIndex = 100;
            // 
            // dgvPhieuChi
            // 
            this.dgvPhieuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuChi.Location = new System.Drawing.Point(33, 265);
            this.dgvPhieuChi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuChi.Name = "dgvPhieuChi";
            this.dgvPhieuChi.RowHeadersWidth = 51;
            this.dgvPhieuChi.RowTemplate.Height = 24;
            this.dgvPhieuChi.Size = new System.Drawing.Size(849, 236);
            this.dgvPhieuChi.TabIndex = 96;
            this.dgvPhieuChi.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuChi_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Từ ngày:";
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
            this.iconButton1.Location = new System.Drawing.Point(562, 519);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.iconButton1.Size = new System.Drawing.Size(101, 37);
            this.iconButton1.TabIndex = 179;
            this.iconButton1.Text = "ReLoad";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.btn_NhapLai.Location = new System.Drawing.Point(426, 520);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btn_NhapLai.Size = new System.Drawing.Size(99, 38);
            this.btn_NhapLai.TabIndex = 178;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
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
            this.btn_Thoat.Location = new System.Drawing.Point(706, 519);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Thoat.Size = new System.Drawing.Size(83, 39);
            this.btn_Thoat.TabIndex = 177;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnThem.FlatAppearance.BorderSize = 0;
            this.BtnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnThem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.BtnThem.IconColor = System.Drawing.Color.White;
            this.BtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnThem.IconSize = 22;
            this.BtnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnThem.Location = new System.Drawing.Point(75, 519);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(0);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnThem.Size = new System.Drawing.Size(82, 39);
            this.BtnThem.TabIndex = 174;
            this.BtnThem.Text = "Thêm";
            this.BtnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnThem.UseVisualStyleBackColor = false;
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSua.FlatAppearance.BorderSize = 0;
            this.BtnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnSua.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            this.BtnSua.IconColor = System.Drawing.Color.White;
            this.BtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnSua.IconSize = 22;
            this.BtnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSua.Location = new System.Drawing.Point(188, 520);
            this.BtnSua.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnSua.Size = new System.Drawing.Size(77, 39);
            this.BtnSua.TabIndex = 175;
            this.BtnSua.Text = "Sửa ";
            this.BtnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSua.UseVisualStyleBackColor = false;
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnXoa.FlatAppearance.BorderSize = 0;
            this.BtnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.BtnXoa.IconColor = System.Drawing.Color.White;
            this.BtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnXoa.IconSize = 22;
            this.BtnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnXoa.Location = new System.Drawing.Point(307, 519);
            this.BtnXoa.Margin = new System.Windows.Forms.Padding(0);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnXoa.Size = new System.Drawing.Size(73, 39);
            this.BtnXoa.TabIndex = 176;
            this.BtnXoa.Text = "Xóa";
            this.BtnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnXoa.UseVisualStyleBackColor = false;
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 24);
            this.label12.TabIndex = 180;
            this.label12.Text = "Phiếu chi";
            // 
            // cbNCC
            // 
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(156, 76);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(149, 21);
            this.cbNCC.TabIndex = 181;
            // 
            // FormPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 578);
            this.Controls.Add(this.cbNCC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_NhapLai);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnSua);
            this.Controls.Add(this.BtnXoa);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoTienChi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNguoiLap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaPhieuChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dateTimePickerKT);
            this.Controls.Add(this.dateTimePickerBD);
            this.Controls.Add(this.dgvPhieuChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPhieuChi";
            this.Load += new System.EventHandler(this.FormPhieuChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoTienChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaPhieuChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dateTimePickerKT;
        private System.Windows.Forms.DateTimePicker dateTimePickerBD;
        private System.Windows.Forms.DataGridView dgvPhieuChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_NhapLai;
        private FontAwesome.Sharp.IconButton btn_Thoat;
        private FontAwesome.Sharp.IconButton BtnThem;
        private FontAwesome.Sharp.IconButton BtnSua;
        private FontAwesome.Sharp.IconButton BtnXoa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbNCC;
    }
}