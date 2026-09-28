namespace Bai_5
{
    public partial class FormChonGhe : Form
    {
        public string GheChon { get; private set; } = string.Empty;
        private readonly string _gheHienTaiBanDau = string.Empty;

        public FormChonGhe() : this(string.Empty)
        {
        }

        public FormChonGhe(string gheHienTai)
        {
            InitializeComponent();
            _gheHienTaiBanDau = gheHienTai ?? string.Empty;
        }

        private void FormChonGhe_Load(object? sender, EventArgs e)
        {
            // Thiết lập kích thước để ListBox hiển thị đúng 3 dòng x 5 cột ghế
            lstGhe.IntegralHeight = false;
            lstGhe.ClientSize = new Size(lstGhe.ColumnWidth * 5, lstGhe.ItemHeight * 3);

            KhoiTaoDanhSachGhe(_gheHienTaiBanDau);
        }

        private void KhoiTaoDanhSachGhe(string gheHienTai)
        {
            lstGhe.Items.Clear();

            // Vì ListBox MultiColumn xếp từ trên xuống dưới theo từng cột,
            // để trên màn hình hiển thị:
            // A1  A2  A3  A4  A5
            // B1  B2  B3  B4  B5
            // C1  C2  C3  C4  C5
            // ta thêm các phần tử theo thứ tự từng cột: (A1, B1, C1), (A2, B2, C2), ...
            string[] cot = { "1", "2", "3", "4", "5" };
            string[] hang = { "A", "B", "C" };

            foreach (var c in cot)
            {
                foreach (var h in hang)
                {
                    lstGhe.Items.Add($"{h}{c}");
                }
            }

            // Nếu có ghế cũ được truyền vào và tồn tại trong danh sách
            if (!string.IsNullOrWhiteSpace(gheHienTai) && lstGhe.Items.Contains(gheHienTai))
            {
                lstGhe.SelectedItem = gheHienTai;
                lblGheDaChon.Text = $"Đang chọn: {gheHienTai}";
            }
            else
            {
                lstGhe.SelectedIndex = -1;
                lblGheDaChon.Text = "Đang chọn:";
            }
        }

        private void lstGhe_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedItem != null)
            {
                lblGheDaChon.Text = $"Đang chọn: {lstGhe.SelectedItem}";
            }
            else
            {
                lblGheDaChon.Text = "Đang chọn:";
            }
        }

        private void btnXacNhan_Click(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString() ?? string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBoQua_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
