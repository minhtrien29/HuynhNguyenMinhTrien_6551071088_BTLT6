namespace Bai_5
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object? sender, EventArgs e)
        {
            // Nạp danh sách phim
            cboPhim.Items.AddRange(new object[]
            {
                "Chiến binh cuối cùng",
                "Avatar: Dòng chảy của nước",
                "Dune: Hành tinh cát",
                "Oppenheimer",
                "Thám tử lừng danh Conan"
            });
            cboPhim.SelectedIndex = 0;

            // Nạp danh sách suất chiếu
            cboSuatChieu.Items.AddRange(new object[]
            {
                "09:00",
                "11:30",
                "14:00",
                "16:30",
                "19:00",
                "21:30"
            });
            cboSuatChieu.SelectedIndex = 4; // Mặc định 19:00 giống ảnh mẫu
        }

        private void btnChonGhe_Click(object? sender, EventArgs e)
        {
            // Mở dialog chọn ghế bằng ShowDialog() trong khối using()
            // Truyền ghế đã chọn hiện tại để dialog tô sáng sẵn ghế cũ
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text.Trim()))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object? sender, EventArgs e)
        {
            // Kiểm tra thông tin tên khách
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenKhach.Focus();
                return;
            }

            // Kiểm tra chọn phim
            if (cboPhim.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboPhim.Text))
            {
                MessageBox.Show("Vui lòng chọn phim!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPhim.Focus();
                return;
            }

            // Kiểm tra chọn suất chiếu
            if (cboSuatChieu.SelectedIndex == -1 || string.IsNullOrWhiteSpace(cboSuatChieu.Text))
            {
                MessageBox.Show("Vui lòng chọn suất chiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSuatChieu.Focus();
                return;
            }

            // Kiểm tra chọn ghế
            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi đặt vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnChonGhe.Focus();
                return;
            }

            // Hiển thị thông báo xác nhận đặt vé thành công
            string thongTin = "XÁC NHẬN ĐẶT VÉ THÀNH CÔNG\n\n" +
                              $"- Tên khách: {txtTenKhach.Text.Trim()}\n" +
                              $"- Phim: {cboPhim.Text}\n" +
                              $"- Suất chiếu: {cboSuatChieu.Text}\n" +
                              $"- Ghế: {txtGheDaChon.Text.Trim()}\n" +
                              "- Giá vé: 75.000đ/vé";

            MessageBox.Show(thongTin, "Thông tin đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            txtTenKhach.Clear();
            if (cboPhim.Items.Count > 0) cboPhim.SelectedIndex = 0;
            if (cboSuatChieu.Items.Count > 0) cboSuatChieu.SelectedIndex = 4;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}
