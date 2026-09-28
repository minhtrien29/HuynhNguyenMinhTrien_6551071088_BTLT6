using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên và Số điện thoại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newItem = $"{txtTen.Text} - {txtSDT.Text}";

            if (_indexDangSua >= 0)
            {
                lstLienHe.Items[_indexDangSua] = newItem;
                _indexDangSua = -1;
                MessageBox.Show("Cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items.Add(newItem);
                MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstLienHe.SelectedItem.ToString();
            string ten = selectedItem.Split('-')[0].Trim();

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lstLienHe.Items.RemoveAt(lstLienHe.SelectedIndex);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (_indexDangSua != -1)
                {
                    _indexDangSua = -1;
                    txtTen.Clear();
                    txtSDT.Clear();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một liên hệ để sửa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedItem = lstLienHe.SelectedItem.ToString();
            string[] parts = selectedItem.Split('-');
            
            txtTen.Text = parts[0].Trim();
            if (parts.Length > 1)
            {
                txtSDT.Text = parts[1].Trim();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult result = MessageBox.Show("Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    // Exit 
                }
                else if (result == DialogResult.No)
                {
                    txtTen.Clear();
                    txtSDT.Clear();
                    // Exit
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
