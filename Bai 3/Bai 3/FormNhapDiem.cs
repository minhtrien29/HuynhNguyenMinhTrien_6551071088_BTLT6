namespace Bai_3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();

            // Đăng ký sự kiện Enter (nhận focus) cho 3 ô điểm số
            txtToan.Enter += TxtDiem_Enter;
            txtVan.Enter += TxtDiem_Enter;
            txtAnh.Enter += TxtDiem_Enter;
        }

        /// <summary>
        /// Duyệt tất cả TextBox trên form, đăng ký KeyPress:
        /// - Nhấn Enter -> chuyển focus sang control kế tiếp.
        /// - Riêng txtAnh khi Enter -> gọi btnLuu.PerformClick().
        /// </summary>
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;
                            if (sender == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else if (sender is Control ctl)
                            {
                                SelectNextControl(ctl, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        /// <summary>
        /// Khi nhận focus vào ô điểm số -> bôi đen toàn bộ để gõ đè không cần xóa tay.
        /// </summary>
        private void TxtDiem_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
                // Dùng BeginInvoke để đảm bảo bôi đen thành công cả khi focus bằng chuột
                this.BeginInvoke((Action)(() => txt.SelectAll()));
            }
        }

        /// <summary>
        /// Xử lý lưu điểm: kiểm tra 3 điểm từ 0.0 - 10.0 bằng decimal.TryParse.
        /// Hợp lệ -> thêm vào ListBox, xóa trắng, focus về txtMaHS.
        /// Không hợp lệ -> hiển thị ErrorProvider.
        /// </summary>
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Vui lòng nhập Mã học sinh!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập Họ tên!");
                hopLe = false;
            }

            bool ParseDiem(string text, out decimal diem)
            {
                // Hỗ trợ cả định dạng dấu chấm '.' và dấu phẩy ','
                string normalized = text.Trim().Replace(',', '.');
                return decimal.TryParse(normalized, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out diem);
            }

            if (!ParseDiem(txtToan.Text, out decimal diemToan) || diemToan < 0 || diemToan > 10)
            {
                errorProvider1.SetError(txtToan, "Điểm Toán phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!ParseDiem(txtVan.Text, out decimal diemVan) || diemVan < 0 || diemVan > 10)
            {
                errorProvider1.SetError(txtVan, "Điểm Văn phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!ParseDiem(txtAnh.Text, out decimal diemAnh) || diemAnh < 0 || diemAnh > 10)
            {
                errorProvider1.SetError(txtAnh, "Điểm Anh phải từ 0.0 đến 10.0!");
                hopLe = false;
            }

            if (!hopLe)
            {
                return;
            }

            // Định dạng: [MaHS] | [HoTen] | T:[Toan] V:[Van] A:[Anh]
            string item = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{txtToan.Text.Trim().Replace(',', '.')} V:{txtVan.Text.Trim().Replace(',', '.')} A:{txtAnh.Text.Trim().Replace(',', '.')}";
            listBox1.Items.Add(item);

            // Xóa trắng form và focus về txtMaHS
            XoaTrang();
        }

        private void btnXoaTrang_Click(object? sender, EventArgs e)
        {
            XoaTrang();
        }

        private void XoaTrang()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }
    }

    // Lớp phụ hỗ trợ tương thích nếu có code gọi Form1
    public class Form1 : FormNhapDiem
    {
    }
}
