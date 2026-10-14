namespace ChuDe3_ThaoTacTapTin.Forms
{
    partial class frmTimKiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlTimKiem = new System.Windows.Forms.TabControl();
            this.tabCoBan = new System.Windows.Forms.TabPage();
            this.txtTuKhoaCoBan = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.panelKieuTim = new System.Windows.Forms.Panel();
            this.radTimTheoLop = new System.Windows.Forms.RadioButton();
            this.radTimTheoTen = new System.Windows.Forms.RadioButton();
            this.radTimTheoMSSV = new System.Windows.Forms.RadioButton();
            this.tabNangCao = new System.Windows.Forms.TabPage();
            this.txtMonHocNangCao = new System.Windows.Forms.TextBox();
            this.lblMonHocNC = new System.Windows.Forms.Label();
            this.txtDiaChiNangCao = new System.Windows.Forms.TextBox();
            this.lblDiaChiNC = new System.Windows.Forms.Label();
            this.txtSDTNangCao = new System.Windows.Forms.TextBox();
            this.lblSDTNC = new System.Windows.Forms.Label();
            this.txtCMNDNangCao = new System.Windows.Forms.TextBox();
            this.lblCMNDNC = new System.Windows.Forms.Label();
            this.cboGioiTinhNangCao = new System.Windows.Forms.ComboBox();
            this.lblGioiTinhNC = new System.Windows.Forms.Label();
            this.cboLopNangCao = new System.Windows.Forms.ComboBox();
            this.lblLopNC = new System.Windows.Forms.Label();
            this.txtHoTenNangCao = new System.Windows.Forms.TextBox();
            this.lblHoTenNC = new System.Windows.Forms.Label();
            this.txtMSSVNangCao = new System.Windows.Forms.TextBox();
            this.lblMSSVNC = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpKetQua = new System.Windows.Forms.GroupBox();
            this.lvKetQua = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoLot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCMND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblThongKe = new System.Windows.Forms.Label();
            this.tabControlTimKiem.SuspendLayout();
            this.tabCoBan.SuspendLayout();
            this.panelKieuTim.SuspendLayout();
            this.tabNangCao.SuspendLayout();
            this.grpKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTimKiem
            // 
            this.tabControlTimKiem.Controls.Add(this.tabCoBan);
            this.tabControlTimKiem.Controls.Add(this.tabNangCao);
            this.tabControlTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTimKiem.Location = new System.Drawing.Point(12, 12);
            this.tabControlTimKiem.Name = "tabControlTimKiem";
            this.tabControlTimKiem.SelectedIndex = 0;
            this.tabControlTimKiem.Size = new System.Drawing.Size(810, 160);
            this.tabControlTimKiem.TabIndex = 0;
            // 
            // tabCoBan
            // 
            this.tabCoBan.Controls.Add(this.txtTuKhoaCoBan);
            this.tabCoBan.Controls.Add(this.lblTuKhoa);
            this.tabCoBan.Controls.Add(this.panelKieuTim);
            this.tabCoBan.Location = new System.Drawing.Point(4, 29);
            this.tabCoBan.Name = "tabCoBan";
            this.tabCoBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoBan.Size = new System.Drawing.Size(802, 127);
            this.tabCoBan.TabIndex = 0;
            this.tabCoBan.Text = "Tìm kiếm cơ bản";
            this.tabCoBan.UseVisualStyleBackColor = true;
            // 
            // txtTuKhoaCoBan
            // 
            this.txtTuKhoaCoBan.Location = new System.Drawing.Point(145, 75);
            this.txtTuKhoaCoBan.Name = "txtTuKhoaCoBan";
            this.txtTuKhoaCoBan.Size = new System.Drawing.Size(460, 27);
            this.txtTuKhoaCoBan.TabIndex = 2;
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuKhoa.Location = new System.Drawing.Point(20, 78);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(110, 20);
            this.lblTuKhoa.TabIndex = 1;
            this.lblTuKhoa.Text = "Nhập từ khóa:";
            // 
            // panelKieuTim
            // 
            this.panelKieuTim.Controls.Add(this.radTimTheoLop);
            this.panelKieuTim.Controls.Add(this.radTimTheoTen);
            this.panelKieuTim.Controls.Add(this.radTimTheoMSSV);
            this.panelKieuTim.Location = new System.Drawing.Point(20, 15);
            this.panelKieuTim.Name = "panelKieuTim";
            this.panelKieuTim.Size = new System.Drawing.Size(585, 45);
            this.panelKieuTim.TabIndex = 0;
            // 
            // radTimTheoLop
            // 
            this.radTimTheoLop.AutoSize = true;
            this.radTimTheoLop.Location = new System.Drawing.Point(380, 10);
            this.radTimTheoLop.Name = "radTimTheoLop";
            this.radTimTheoLop.Size = new System.Drawing.Size(117, 24);
            this.radTimTheoLop.TabIndex = 2;
            this.radTimTheoLop.Text = "Theo Lớp học";
            this.radTimTheoLop.UseVisualStyleBackColor = true;
            // 
            // radTimTheoTen
            // 
            this.radTimTheoTen.AutoSize = true;
            this.radTimTheoTen.Location = new System.Drawing.Point(190, 10);
            this.radTimTheoTen.Name = "radTimTheoTen";
            this.radTimTheoTen.Size = new System.Drawing.Size(135, 24);
            this.radTimTheoTen.TabIndex = 1;
            this.radTimTheoTen.Text = "Theo Họ tên/Tên";
            this.radTimTheoTen.UseVisualStyleBackColor = true;
            // 
            // radTimTheoMSSV
            // 
            this.radTimTheoMSSV.AutoSize = true;
            this.radTimTheoMSSV.Checked = true;
            this.radTimTheoMSSV.Location = new System.Drawing.Point(15, 10);
            this.radTimTheoMSSV.Name = "radTimTheoMSSV";
            this.radTimTheoMSSV.Size = new System.Drawing.Size(107, 24);
            this.radTimTheoMSSV.TabIndex = 0;
            this.radTimTheoMSSV.TabStop = true;
            this.radTimTheoMSSV.Text = "Theo MSSV";
            this.radTimTheoMSSV.UseVisualStyleBackColor = true;
            // 
            // tabNangCao
            // 
            this.tabNangCao.Controls.Add(this.txtMonHocNangCao);
            this.tabNangCao.Controls.Add(this.lblMonHocNC);
            this.tabNangCao.Controls.Add(this.txtDiaChiNangCao);
            this.tabNangCao.Controls.Add(this.lblDiaChiNC);
            this.tabNangCao.Controls.Add(this.txtSDTNangCao);
            this.tabNangCao.Controls.Add(this.lblSDTNC);
            this.tabNangCao.Controls.Add(this.txtCMNDNangCao);
            this.tabNangCao.Controls.Add(this.lblCMNDNC);
            this.tabNangCao.Controls.Add(this.cboGioiTinhNangCao);
            this.tabNangCao.Controls.Add(this.lblGioiTinhNC);
            this.tabNangCao.Controls.Add(this.cboLopNangCao);
            this.tabNangCao.Controls.Add(this.lblLopNC);
            this.tabNangCao.Controls.Add(this.txtHoTenNangCao);
            this.tabNangCao.Controls.Add(this.lblHoTenNC);
            this.tabNangCao.Controls.Add(this.txtMSSVNangCao);
            this.tabNangCao.Controls.Add(this.lblMSSVNC);
            this.tabNangCao.Location = new System.Drawing.Point(4, 29);
            this.tabNangCao.Name = "tabNangCao";
            this.tabNangCao.Padding = new System.Windows.Forms.Padding(3);
            this.tabNangCao.Size = new System.Drawing.Size(802, 127);
            this.tabNangCao.TabIndex = 1;
            this.tabNangCao.Text = "Tìm kiếm đa điều kiện (Bất kỳ)";
            this.tabNangCao.UseVisualStyleBackColor = true;
            // 
            // txtMonHocNangCao
            // 
            this.txtMonHocNangCao.Location = new System.Drawing.Point(475, 85);
            this.txtMonHocNangCao.Name = "txtMonHocNangCao";
            this.txtMonHocNangCao.Size = new System.Drawing.Size(130, 27);
            this.txtMonHocNangCao.TabIndex = 15;
            // 
            // lblMonHocNC
            // 
            this.lblMonHocNC.AutoSize = true;
            this.lblMonHocNC.Location = new System.Drawing.Point(395, 88);
            this.lblMonHocNC.Name = "lblMonHocNC";
            this.lblMonHocNC.Size = new System.Drawing.Size(71, 20);
            this.lblMonHocNC.TabIndex = 14;
            this.lblMonHocNC.Text = "Môn học:";
            // 
            // txtDiaChiNangCao
            // 
            this.txtDiaChiNangCao.Location = new System.Drawing.Point(260, 85);
            this.txtDiaChiNangCao.Name = "txtDiaChiNangCao";
            this.txtDiaChiNangCao.Size = new System.Drawing.Size(125, 27);
            this.txtDiaChiNangCao.TabIndex = 13;
            // 
            // lblDiaChiNC
            // 
            this.lblDiaChiNC.AutoSize = true;
            this.lblDiaChiNC.Location = new System.Drawing.Point(195, 88);
            this.lblDiaChiNC.Name = "lblDiaChiNC";
            this.lblDiaChiNC.Size = new System.Drawing.Size(58, 20);
            this.lblDiaChiNC.TabIndex = 12;
            this.lblDiaChiNC.Text = "Địa chỉ:";
            // 
            // txtSDTNangCao
            // 
            this.txtSDTNangCao.Location = new System.Drawing.Point(75, 85);
            this.txtSDTNangCao.Name = "txtSDTNangCao";
            this.txtSDTNangCao.Size = new System.Drawing.Size(110, 27);
            this.txtSDTNangCao.TabIndex = 11;
            // 
            // lblSDTNC
            // 
            this.lblSDTNC.AutoSize = true;
            this.lblSDTNC.Location = new System.Drawing.Point(15, 88);
            this.lblSDTNC.Name = "lblSDTNC";
            this.lblSDTNC.Size = new System.Drawing.Size(52, 20);
            this.lblSDTNC.TabIndex = 10;
            this.lblSDTNC.Text = "Số ĐT:";
            // 
            // txtCMNDNangCao
            // 
            this.txtCMNDNangCao.Location = new System.Drawing.Point(670, 50);
            this.txtCMNDNangCao.Name = "txtCMNDNangCao";
            this.txtCMNDNangCao.Size = new System.Drawing.Size(120, 27);
            this.txtCMNDNangCao.TabIndex = 9;
            // 
            // lblCMNDNC
            // 
            this.lblCMNDNC.AutoSize = true;
            this.lblCMNDNC.Location = new System.Drawing.Point(610, 53);
            this.lblCMNDNC.Name = "lblCMNDNC";
            this.lblCMNDNC.Size = new System.Drawing.Size(56, 20);
            this.lblCMNDNC.TabIndex = 8;
            this.lblCMNDNC.Text = "CMND:";
            // 
            // cboGioiTinhNangCao
            // 
            this.cboGioiTinhNangCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinhNangCao.FormattingEnabled = true;
            this.cboGioiTinhNangCao.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.cboGioiTinhNangCao.Location = new System.Drawing.Point(475, 50);
            this.cboGioiTinhNangCao.Name = "cboGioiTinhNangCao";
            this.cboGioiTinhNangCao.Size = new System.Drawing.Size(130, 28);
            this.cboGioiTinhNangCao.TabIndex = 7;
            // 
            // lblGioiTinhNC
            // 
            this.lblGioiTinhNC.AutoSize = true;
            this.lblGioiTinhNC.Location = new System.Drawing.Point(395, 53);
            this.lblGioiTinhNC.Name = "lblGioiTinhNC";
            this.lblGioiTinhNC.Size = new System.Drawing.Size(68, 20);
            this.lblGioiTinhNC.TabIndex = 6;
            this.lblGioiTinhNC.Text = "Giới tính:";
            // 
            // cboLopNangCao
            // 
            this.cboLopNangCao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopNangCao.FormattingEnabled = true;
            this.cboLopNangCao.Location = new System.Drawing.Point(260, 50);
            this.cboLopNangCao.Name = "cboLopNangCao";
            this.cboLopNangCao.Size = new System.Drawing.Size(125, 28);
            this.cboLopNangCao.TabIndex = 5;
            // 
            // lblLopNC
            // 
            this.lblLopNC.AutoSize = true;
            this.lblLopNC.Location = new System.Drawing.Point(195, 53);
            this.lblLopNC.Name = "lblLopNC";
            this.lblLopNC.Size = new System.Drawing.Size(37, 20);
            this.lblLopNC.TabIndex = 4;
            this.lblLopNC.Text = "Lớp:";
            // 
            // txtHoTenNangCao
            // 
            this.txtHoTenNangCao.Location = new System.Drawing.Point(75, 50);
            this.txtHoTenNangCao.Name = "txtHoTenNangCao";
            this.txtHoTenNangCao.Size = new System.Drawing.Size(110, 27);
            this.txtHoTenNangCao.TabIndex = 3;
            // 
            // lblHoTenNC
            // 
            this.lblHoTenNC.AutoSize = true;
            this.lblHoTenNC.Location = new System.Drawing.Point(15, 53);
            this.lblHoTenNC.Name = "lblHoTenNC";
            this.lblHoTenNC.Size = new System.Drawing.Size(57, 20);
            this.lblHoTenNC.TabIndex = 2;
            this.lblHoTenNC.Text = "Họ tên:";
            // 
            // txtMSSVNangCao
            // 
            this.txtMSSVNangCao.Location = new System.Drawing.Point(75, 12);
            this.txtMSSVNangCao.Name = "txtMSSVNangCao";
            this.txtMSSVNangCao.Size = new System.Drawing.Size(150, 27);
            this.txtMSSVNangCao.TabIndex = 1;
            // 
            // lblMSSVNC
            // 
            this.lblMSSVNC.AutoSize = true;
            this.lblMSSVNC.Location = new System.Drawing.Point(15, 15);
            this.lblMSSVNC.Name = "lblMSSVNC";
            this.lblMSSVNC.Size = new System.Drawing.Size(51, 20);
            this.lblMSSVNC.TabIndex = 0;
            this.lblMSSVNC.Text = "MSSV:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(830, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(110, 35);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(830, 85);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnLamMoi.TabIndex = 2;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChon.Location = new System.Drawing.Point(830, 130);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(110, 35);
            this.btnChon.TabIndex = 3;
            this.btnChon.Text = "Chọn SV";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(830, 500);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 35);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // grpKetQua
            // 
            this.grpKetQua.Controls.Add(this.lvKetQua);
            this.grpKetQua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKetQua.Location = new System.Drawing.Point(12, 180);
            this.grpKetQua.Name = "grpKetQua";
            this.grpKetQua.Size = new System.Drawing.Size(810, 355);
            this.grpKetQua.TabIndex = 4;
            this.grpKetQua.TabStop = false;
            this.grpKetQua.Text = "Kết quả tìm kiếm";
            // 
            // lvKetQua
            // 
            this.lvKetQua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoLot,
            this.colTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colLop,
            this.colCMND,
            this.colSDT,
            this.colDiaChi,
            this.colMonHoc});
            this.lvKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvKetQua.FullRowSelect = true;
            this.lvKetQua.GridLines = true;
            this.lvKetQua.HideSelection = false;
            this.lvKetQua.Location = new System.Drawing.Point(3, 23);
            this.lvKetQua.MultiSelect = false;
            this.lvKetQua.Name = "lvKetQua";
            this.lvKetQua.Size = new System.Drawing.Size(804, 329);
            this.lvKetQua.TabIndex = 0;
            this.lvKetQua.UseCompatibleStateImageBehavior = false;
            this.lvKetQua.View = System.Windows.Forms.View.Details;
            this.lvKetQua.DoubleClick += new System.EventHandler(this.lvKetQua_DoubleClick);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 80;
            // 
            // colHoLot
            // 
            this.colHoLot.Text = "Họ và tên lót";
            this.colHoLot.Width = 110;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 70;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 65;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 85;
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            this.colLop.Width = 65;
            // 
            // colCMND
            // 
            this.colCMND.Text = "Số CMND";
            this.colCMND.Width = 85;
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số ĐT";
            this.colSDT.Width = 85;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ liên lạc";
            this.colDiaChi.Width = 150;
            // 
            // colMonHoc
            // 
            this.colMonHoc.Text = "Môn học";
            this.colMonHoc.Width = 150;
            // 
            // lblThongKe
            // 
            this.lblThongKe.AutoSize = true;
            this.lblThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongKe.Location = new System.Drawing.Point(15, 545);
            this.lblThongKe.Name = "lblThongKe";
            this.lblThongKe.Size = new System.Drawing.Size(155, 20);
            this.lblThongKe.TabIndex = 5;
            this.lblThongKe.Text = "Tìm thấy 0 sinh viên.";
            // 
            // frmTimKiem
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDong;
            this.ClientSize = new System.Drawing.Size(950, 580);
            this.Controls.Add(this.lblThongKe);
            this.Controls.Add(this.grpKetQua);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.tabControlTimKiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tìm kiếm thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            this.tabControlTimKiem.ResumeLayout(false);
            this.tabCoBan.ResumeLayout(false);
            this.tabCoBan.PerformLayout();
            this.panelKieuTim.ResumeLayout(false);
            this.panelKieuTim.PerformLayout();
            this.tabNangCao.ResumeLayout(false);
            this.tabNangCao.PerformLayout();
            this.grpKetQua.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTimKiem;
        private System.Windows.Forms.TabPage tabCoBan;
        private System.Windows.Forms.TabPage tabNangCao;
        private System.Windows.Forms.Panel panelKieuTim;
        private System.Windows.Forms.RadioButton radTimTheoLop;
        private System.Windows.Forms.RadioButton radTimTheoTen;
        private System.Windows.Forms.RadioButton radTimTheoMSSV;
        private System.Windows.Forms.TextBox txtTuKhoaCoBan;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.GroupBox grpKetQua;
        private System.Windows.Forms.ListView lvKetQua;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoLot;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colCMND;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colMonHoc;
        private System.Windows.Forms.Label lblThongKe;
        private System.Windows.Forms.TextBox txtMSSVNangCao;
        private System.Windows.Forms.Label lblMSSVNC;
        private System.Windows.Forms.TextBox txtHoTenNangCao;
        private System.Windows.Forms.Label lblHoTenNC;
        private System.Windows.Forms.ComboBox cboLopNangCao;
        private System.Windows.Forms.Label lblLopNC;
        private System.Windows.Forms.ComboBox cboGioiTinhNangCao;
        private System.Windows.Forms.Label lblGioiTinhNC;
        private System.Windows.Forms.TextBox txtCMNDNangCao;
        private System.Windows.Forms.Label lblCMNDNC;
        private System.Windows.Forms.TextBox txtSDTNangCao;
        private System.Windows.Forms.Label lblSDTNC;
        private System.Windows.Forms.TextBox txtDiaChiNangCao;
        private System.Windows.Forms.Label lblDiaChiNC;
        private System.Windows.Forms.TextBox txtMonHocNangCao;
        private System.Windows.Forms.Label lblMonHocNC;
    }
}
