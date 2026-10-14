namespace ChuDe3_ThaoTacTapTin.Forms
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNapJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNapXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNapTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuLuuJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuXML = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuTXT = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMoTepKhac = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLuuTepThanh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDemoThucHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.mtxtMSSV = new System.Windows.Forms.MaskedTextBox();
            this.lblHoLot = new System.Windows.Forms.Label();
            this.txtHoLot = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblCMND = new System.Windows.Forms.Label();
            this.mtxtCMND = new System.Windows.Forms.MaskedTextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.cmsMonHoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXoaMon = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lvSinhVien = new System.Windows.Forms.ListView();
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
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuXoaSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBoChonTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblStatusTepTin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTongSo = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain.SuspendLayout();
            this.cmsMonHoc.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuDemoThucHanh,
            this.menuTroGiup});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(840, 29);
            this.menuStripMain.TabIndex = 0;
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNapJSON,
            this.menuNapXML,
            this.menuNapTXT,
            this.toolStripSeparator1,
            this.menuLuuJSON,
            this.menuLuuXML,
            this.menuLuuTXT,
            this.toolStripSeparator2,
            this.menuMoTepKhac,
            this.menuLuuTepThanh,
            this.toolStripSeparator3,
            this.menuThoat});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(71, 25);
            this.menuFile.Text = "&Tập tin";
            // 
            // menuNapJSON
            // 
            this.menuNapJSON.Name = "menuNapJSON";
            this.menuNapJSON.Size = new System.Drawing.Size(289, 26);
            this.menuNapJSON.Text = "Nạp từ JSON (students.json)";
            this.menuNapJSON.Click += new System.EventHandler(this.menuNapJSON_Click);
            // 
            // menuNapXML
            // 
            this.menuNapXML.Name = "menuNapXML";
            this.menuNapXML.Size = new System.Drawing.Size(289, 26);
            this.menuNapXML.Text = "Nạp từ XML (students.xml)";
            this.menuNapXML.Click += new System.EventHandler(this.menuNapXML_Click);
            // 
            // menuNapTXT
            // 
            this.menuNapTXT.Name = "menuNapTXT";
            this.menuNapTXT.Size = new System.Drawing.Size(289, 26);
            this.menuNapTXT.Text = "Nạp từ TXT (students.txt)";
            this.menuNapTXT.Click += new System.EventHandler(this.menuNapTXT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(286, 6);
            // 
            // menuLuuJSON
            // 
            this.menuLuuJSON.Name = "menuLuuJSON";
            this.menuLuuJSON.Size = new System.Drawing.Size(289, 26);
            this.menuLuuJSON.Text = "Lưu vào JSON";
            this.menuLuuJSON.Click += new System.EventHandler(this.menuLuuJSON_Click);
            // 
            // menuLuuXML
            // 
            this.menuLuuXML.Name = "menuLuuXML";
            this.menuLuuXML.Size = new System.Drawing.Size(289, 26);
            this.menuLuuXML.Text = "Lưu vào XML";
            this.menuLuuXML.Click += new System.EventHandler(this.menuLuuXML_Click);
            // 
            // menuLuuTXT
            // 
            this.menuLuuTXT.Name = "menuLuuTXT";
            this.menuLuuTXT.Size = new System.Drawing.Size(289, 26);
            this.menuLuuTXT.Text = "Lưu vào TXT";
            this.menuLuuTXT.Click += new System.EventHandler(this.menuLuuTXT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(286, 6);
            // 
            // menuMoTepKhac
            // 
            this.menuMoTepKhac.Name = "menuMoTepKhac";
            this.menuMoTepKhac.Size = new System.Drawing.Size(289, 26);
            this.menuMoTepKhac.Text = "Mở tệp khác...";
            this.menuMoTepKhac.Click += new System.EventHandler(this.menuMoTepKhac_Click);
            // 
            // menuLuuTepThanh
            // 
            this.menuLuuTepThanh.Name = "menuLuuTepThanh";
            this.menuLuuTepThanh.Size = new System.Drawing.Size(289, 26);
            this.menuLuuTepThanh.Text = "Lưu tệp thành...";
            this.menuLuuTepThanh.Click += new System.EventHandler(this.menuLuuTepThanh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(286, 6);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(289, 26);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // menuDemoThucHanh
            // 
            this.menuDemoThucHanh.Name = "menuDemoThucHanh";
            this.menuDemoThucHanh.Size = new System.Drawing.Size(230, 25);
            this.menuDemoThucHanh.Text = "&Thực hành mẫu (Trang 51-57)";
            this.menuDemoThucHanh.Click += new System.EventHandler(this.menuDemoThucHanh_Click);
            // 
            // menuTroGiup
            // 
            this.menuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuGioiThieu});
            this.menuTroGiup.Name = "menuTroGiup";
            this.menuTroGiup.Size = new System.Drawing.Size(82, 25);
            this.menuTroGiup.Text = "Trợ &giúp";
            // 
            // menuGioiThieu
            // 
            this.menuGioiThieu.Name = "menuGioiThieu";
            this.menuGioiThieu.Size = new System.Drawing.Size(228, 26);
            this.menuGioiThieu.Text = "Giới thiệu Chủ đề 3";
            this.menuGioiThieu.Click += new System.EventHandler(this.menuGioiThieu_Click);
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMSSV.Location = new System.Drawing.Point(25, 42);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(54, 20);
            this.lblMSSV.TabIndex = 1;
            this.lblMSSV.Text = "MSSV :";
            // 
            // mtxtMSSV
            // 
            this.mtxtMSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtMSSV.Location = new System.Drawing.Point(145, 39);
            this.mtxtMSSV.Mask = "0000000";
            this.mtxtMSSV.Name = "mtxtMSSV";
            this.mtxtMSSV.Size = new System.Drawing.Size(240, 27);
            this.mtxtMSSV.TabIndex = 2;
            // 
            // lblHoLot
            // 
            this.lblHoLot.AutoSize = true;
            this.lblHoLot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoLot.Location = new System.Drawing.Point(25, 75);
            this.lblHoLot.Name = "lblHoLot";
            this.lblHoLot.Size = new System.Drawing.Size(102, 20);
            this.lblHoLot.TabIndex = 7;
            this.lblHoLot.Text = "Họ và tên lót :";
            // 
            // txtHoLot
            // 
            this.txtHoLot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoLot.Location = new System.Drawing.Point(145, 72);
            this.txtHoLot.Name = "txtHoLot";
            this.txtHoLot.Size = new System.Drawing.Size(240, 27);
            this.txtHoLot.TabIndex = 8;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(25, 108);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 11;
            this.lblNgaySinh.Text = "Ngày sinh :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(145, 105);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(240, 27);
            this.dtpNgaySinh.TabIndex = 12;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(25, 141);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(81, 20);
            this.lblCMND.TabIndex = 15;
            this.lblCMND.Text = "Số CMND :";
            // 
            // mtxtCMND
            // 
            this.mtxtCMND.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCMND.Location = new System.Drawing.Point(145, 138);
            this.mtxtCMND.Mask = "000000000";
            this.mtxtCMND.Name = "mtxtCMND";
            this.mtxtCMND.Size = new System.Drawing.Size(240, 27);
            this.mtxtCMND.TabIndex = 16;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(25, 174);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(113, 20);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Địa chỉ liên lạc :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(145, 171);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(665, 27);
            this.txtDiaChi.TabIndex = 20;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(445, 42);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(72, 20);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính :";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Checked = true;
            this.radNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(555, 40);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(62, 24);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(650, 40);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(50, 24);
            this.radNu.TabIndex = 5;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(445, 75);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(39, 20);
            this.lblTen.TabIndex = 9;
            this.lblTen.Text = "Tên :";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(550, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(260, 27);
            this.txtTen.TabIndex = 10;
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.Location = new System.Drawing.Point(445, 108);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(41, 20);
            this.lblLop.TabIndex = 13;
            this.lblLop.Text = "Lớp :";
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(550, 105);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(260, 28);
            this.cboLop.TabIndex = 14;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(445, 141);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(56, 20);
            this.lblSDT.TabIndex = 17;
            this.lblSDT.Text = "Số ĐT :";
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSDT.Location = new System.Drawing.Point(550, 138);
            this.mtxtSDT.Mask = "0000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(260, 27);
            this.mtxtSDT.TabIndex = 18;
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHoc.Location = new System.Drawing.Point(25, 208);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(130, 20);
            this.lblMonHoc.TabIndex = 21;
            this.lblMonHoc.Text = "Môn học đăng ký :";
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.CheckOnClick = true;
            this.clbMonHoc.ColumnWidth = 320;
            this.clbMonHoc.ContextMenuStrip = this.cmsMonHoc;
            this.clbMonHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Location = new System.Drawing.Point(161, 204);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(665, 92);
            this.clbMonHoc.TabIndex = 22;
            // 
            // cmsMonHoc
            // 
            this.cmsMonHoc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMonHoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThemMon,
            this.menuXoaMon});
            this.cmsMonHoc.Name = "cmsMonHoc";
            this.cmsMonHoc.Size = new System.Drawing.Size(194, 56);
            // 
            // menuThemMon
            // 
            this.menuThemMon.Name = "menuThemMon";
            this.menuThemMon.Size = new System.Drawing.Size(193, 26);
            this.menuThemMon.Text = "Thêm môn học...";
            this.menuThemMon.Click += new System.EventHandler(this.menuThemMon_Click);
            // 
            // menuXoaMon
            // 
            this.menuXoaMon.Name = "menuXoaMon";
            this.menuXoaMon.Size = new System.Drawing.Size(193, 26);
            this.menuXoaMon.Text = "Xóa môn học";
            this.menuXoaMon.Click += new System.EventHandler(this.menuXoaMon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(320, 310);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 32);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(445, 310);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(105, 32);
            this.btnThemMoi.TabIndex = 24;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(570, 310);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(105, 32);
            this.btnCapNhat.TabIndex = 25;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(705, 310);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 32);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.Location = new System.Drawing.Point(12, 350);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(147, 20);
            this.lblDanhSach.TabIndex = 27;
            this.lblDanhSach.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.lvSinhVien.ContextMenuStrip = this.cmsListView;
            this.lvSinhVien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(12, 375);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(816, 260);
            this.lvSinhVien.TabIndex = 28;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 85;
            // 
            // colHoLot
            // 
            this.colHoLot.Text = "Họ và tên lót";
            this.colHoLot.Width = 120;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên";
            this.colTen.Width = 65;
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
            this.colSDT.Text = "Số điện thoại";
            this.colSDT.Width = 100;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ liên lạc";
            this.colDiaChi.Width = 160;
            // 
            // colMonHoc
            // 
            this.colMonHoc.Text = "Môn học đăng ký";
            this.colMonHoc.Width = 180;
            // 
            // cmsListView
            // 
            this.cmsListView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXoaSinhVien,
            this.toolStripSeparator4,
            this.menuChonTatCa,
            this.menuBoChonTatCa});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(313, 88);
            // 
            // menuXoaSinhVien
            // 
            this.menuXoaSinhVien.Name = "menuXoaSinhVien";
            this.menuXoaSinhVien.Size = new System.Drawing.Size(312, 26);
            this.menuXoaSinhVien.Text = "Xóa sinh viên đã chọn (Checkbox)";
            this.menuXoaSinhVien.Click += new System.EventHandler(this.menuXoaSinhVien_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(309, 6);
            // 
            // menuChonTatCa
            // 
            this.menuChonTatCa.Name = "menuChonTatCa";
            this.menuChonTatCa.Size = new System.Drawing.Size(312, 26);
            this.menuChonTatCa.Text = "Chọn tất cả (Checkbox)";
            this.menuChonTatCa.Click += new System.EventHandler(this.menuChonTatCa_Click);
            // 
            // menuBoChonTatCa
            // 
            this.menuBoChonTatCa.Name = "menuBoChonTatCa";
            this.menuBoChonTatCa.Size = new System.Drawing.Size(312, 26);
            this.menuBoChonTatCa.Text = "Bỏ chọn tất cả";
            this.menuBoChonTatCa.Click += new System.EventHandler(this.menuBoChonTatCa_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusTepTin,
            this.lblStatusTongSo});
            this.statusStripMain.Location = new System.Drawing.Point(0, 645);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(840, 27);
            this.statusStripMain.TabIndex = 29;
            // 
            // lblStatusTepTin
            // 
            this.lblStatusTepTin.Name = "lblStatusTepTin";
            this.lblStatusTepTin.Size = new System.Drawing.Size(128, 21);
            this.lblStatusTepTin.Text = "Tệp tin hiện tại: ...";
            // 
            // lblStatusTongSo
            // 
            this.lblStatusTongSo.Name = "lblStatusTongSo";
            this.lblStatusTongSo.Size = new System.Drawing.Size(697, 21);
            this.lblStatusTongSo.Spring = true;
            this.lblStatusTongSo.Text = "Tổng số: 0 sinh viên";
            this.lblStatusTongSo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 672);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.clbMonHoc);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.mtxtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.mtxtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.txtHoLot);
            this.Controls.Add(this.lblHoLot);
            this.Controls.Add(this.mtxtMSSV);
            this.Controls.Add(this.lblMSSV);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSinhVien_FormClosing);
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.cmsMonHoc.ResumeLayout(false);
            this.cmsListView.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuNapJSON;
        private System.Windows.Forms.ToolStripMenuItem menuNapXML;
        private System.Windows.Forms.ToolStripMenuItem menuNapTXT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuLuuJSON;
        private System.Windows.Forms.ToolStripMenuItem menuLuuXML;
        private System.Windows.Forms.ToolStripMenuItem menuLuuTXT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuMoTepKhac;
        private System.Windows.Forms.ToolStripMenuItem menuLuuTepThanh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuDemoThucHanh;
        private System.Windows.Forms.ToolStripMenuItem menuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem menuGioiThieu;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.MaskedTextBox mtxtMSSV;
        private System.Windows.Forms.Label lblHoLot;
        private System.Windows.Forms.TextBox txtHoLot;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.MaskedTextBox mtxtCMND;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.CheckedListBox clbMonHoc;
        private System.Windows.Forms.ContextMenuStrip cmsMonHoc;
        private System.Windows.Forms.ToolStripMenuItem menuThemMon;
        private System.Windows.Forms.ToolStripMenuItem menuXoaMon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListView lvSinhVien;
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
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem menuXoaSinhVien;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuChonTatCa;
        private System.Windows.Forms.ToolStripMenuItem menuBoChonTatCa;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTepTin;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTongSo;
    }
}
