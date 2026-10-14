using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChuDe3_ThaoTacTapTin.BLL;
using ChuDe3_ThaoTacTapTin.Models;

namespace ChuDe3_ThaoTacTapTin.Forms
{
    public partial class frmTimKiem : Form
    {
        private QuanLySinhVien _qlsv;
        public SinhVien SinhVienDuocChon { get; private set; }

        public frmTimKiem(QuanLySinhVien qlsv)
        {
            InitializeComponent();
            _qlsv = qlsv;
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            // Nạp danh sách lớp vào combobox
            cboLopNangCao.Items.Clear();
            cboLopNangCao.Items.Add("Tất cả");
            cboLopNangCao.Items.Add("CTK43");
            cboLopNangCao.Items.Add("CTK44");
            cboLopNangCao.Items.Add("CTK45");
            cboLopNangCao.Items.Add("CTK46");
            cboLopNangCao.Items.Add("CTK47");
            cboLopNangCao.Items.Add("CTK48");
            cboLopNangCao.SelectedIndex = 0;

            cboGioiTinhNangCao.SelectedIndex = 0; // Tất cả

            // Hiển thị toàn bộ sinh viên ban đầu
            HienThiKetQua(_qlsv.DanhSach);
        }

        private void HienThiKetQua(List<SinhVien> danhSach)
        {
            lvKetQua.Items.Clear();
            if (danhSach == null) return;

            foreach (var sv in danhSach)
            {
                var item = new ListViewItem(sv.MSSV);
                item.SubItems.Add(sv.HoLot);
                item.SubItems.Add(sv.Ten);
                item.SubItems.Add(sv.GioiTinh ? "Nam" : "Nữ");
                item.SubItems.Add(sv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(sv.Lop);
                item.SubItems.Add(sv.SoCMND);
                item.SubItems.Add(sv.SoDT);
                item.SubItems.Add(sv.DiaChi);
                item.SubItems.Add(sv.ChuoiMonHoc);
                item.Tag = sv;

                lvKetQua.Items.Add(item);
            }

            lblThongKe.Text = string.Format("Tìm thấy {0} sinh viên.", danhSach.Count);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tabControlTimKiem.SelectedTab == tabCoBan)
            {
                // Tìm kiếm cơ bản theo MSSV / Tên / Lớp
                string tuKhoa = txtTuKhoaCoBan.Text.Trim();
                List<SinhVien> ketQua;

                if (radTimTheoMSSV.Checked)
                {
                    ketQua = _qlsv.TimKiemTheoMSSV(tuKhoa);
                }
                else if (radTimTheoTen.Checked)
                {
                    ketQua = _qlsv.TimKiemTheoTen(tuKhoa);
                }
                else // Theo Lớp
                {
                    ketQua = _qlsv.TimKiemTheoLop(tuKhoa);
                }

                HienThiKetQua(ketQua);
            }
            else
            {
                // Tìm kiếm đa điều kiện (bất kỳ)
                string mssv = txtMSSVNangCao.Text.Trim();
                string hoTen = txtHoTenNangCao.Text.Trim();
                string lop = cboLopNangCao.SelectedItem != null ? cboLopNangCao.SelectedItem.ToString() : "";
                
                bool? gioiTinh = null;
                if (cboGioiTinhNangCao.SelectedIndex == 1) gioiTinh = true; // Nam
                else if (cboGioiTinhNangCao.SelectedIndex == 2) gioiTinh = false; // Nữ

                string cmnd = txtCMNDNangCao.Text.Trim();
                string sdt = txtSDTNangCao.Text.Trim();
                string diaChi = txtDiaChiNangCao.Text.Trim();
                string monHoc = txtMonHocNangCao.Text.Trim();

                var ketQua = _qlsv.TimKiemDaDieuKien(mssv, hoTen, lop, gioiTinh, cmnd, sdt, diaChi, monHoc);
                HienThiKetQua(ketQua);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTuKhoaCoBan.Clear();
            radTimTheoMSSV.Checked = true;

            txtMSSVNangCao.Clear();
            txtHoTenNangCao.Clear();
            cboLopNangCao.SelectedIndex = 0;
            cboGioiTinhNangCao.SelectedIndex = 0;
            txtCMNDNangCao.Clear();
            txtSDTNangCao.Clear();
            txtDiaChiNangCao.Clear();
            txtMonHocNangCao.Clear();

            HienThiKetQua(_qlsv.DanhSach);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (lvKetQua.SelectedItems.Count > 0)
            {
                SinhVienDuocChon = lvKetQua.SelectedItems[0].Tag as SinhVien;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lvKetQua_DoubleClick(object sender, EventArgs e)
        {
            btnChon_Click(sender, e);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
