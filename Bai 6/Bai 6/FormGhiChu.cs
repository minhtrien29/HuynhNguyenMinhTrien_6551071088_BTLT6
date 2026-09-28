using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class FormGhiChu : Form
    {
        private bool isModified = false;

        public FormGhiChu()
        {
            InitializeComponent();
            cboMucDoUuTien.Items.AddRange(new string[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.SelectedIndex = 1; // Trung bình
            this.KeyPreview = true;
            this.KeyDown += FormGhiChu_KeyDown;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnLuuGhiChu.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (isModified)
                {
                    DialogResult result = MessageBox.Show("Nội dung đã thay đổi, bạn có chắc chắn muốn đóng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
                e.Handled = true;
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNoiDung.Text.Length >= 500 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }
        
        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {
            isModified = true;
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightBlue;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTieuDe.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được để trống");
                txtTieuDe.BackColor = Color.MistyRose;
            }
            else if (txtTieuDe.Text.Length > 50)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, "Tiêu đề không được quá 50 ký tự");
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            txtTieuDe.BackColor = Color.White;
            errorProvider1.SetError(txtTieuDe, "");
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }

            this.Text = txtTieuDe.Text;
            isModified = false;
            MessageBox.Show("Đã lưu ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
