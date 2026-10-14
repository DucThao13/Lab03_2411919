using System;
using System.Windows.Forms;

namespace ChuDe3_ThaoTacTapTin.Forms
{
    public partial class frmThemMonHoc : Form
    {
        public string TenMonHoc { get; private set; }

        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMonHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonHoc.Focus();
                return;
            }

            TenMonHoc = txtTenMonHoc.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
