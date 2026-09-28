using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;

namespace Bai_2
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt == null) return;

            string errorMsg = "";
            bool isValid = true;

            if (txt == txtHoTen)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    isValid = false;
                    errorMsg = "Họ tên không để trống";
                }
            }
            else if (txt == txtCCCD)
            {
                if (txt.Text.Length != 12 || !txt.Text.All(char.IsDigit))
                {
                    isValid = false;
                    errorMsg = "CCCD phải đúng 12 chữ số";
                }
            }
            else if (txt == txtNgayNhan)
            {
                if (!DateTime.TryParseExact(txt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
                {
                    isValid = false;
                    errorMsg = "Ngày nhận phòng không hợp lệ (dd/MM/yyyy)";
                }
                else if (ngayNhan.Date < DateTime.Today)
                {
                    isValid = false;
                    errorMsg = "Ngày nhận phòng phải >= hôm nay";
                }
            }
            else if (txt == txtNgayTra)
            {
                if (!DateTime.TryParseExact(txt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
                {
                    isValid = false;
                    errorMsg = "Ngày trả phòng không hợp lệ (dd/MM/yyyy)";
                }
                else
                {
                    if (DateTime.TryParseExact(txtNgayNhan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
                    {
                        if (ngayTra.Date <= ngayNhan.Date)
                        {
                            isValid = false;
                            errorMsg = "Ngày trả phòng phải lớn hơn ngày nhận";
                        }
                    }
                }
            }
            else if (txt == txtSoNguoiLon)
            {
                if (!int.TryParse(txt.Text, out int n) || n < 1 || n > 4)
                {
                    isValid = false;
                    errorMsg = "Số người lớn phải là số nguyên từ 1 đến 4";
                }
            }
            else if (txt == txtSoTreEm)
            {
                if (!int.TryParse(txt.Text, out int n) || n < 0 || n > 3)
                {
                    isValid = false;
                    errorMsg = "Số trẻ em phải là số nguyên từ 0 đến 3";
                }
            }

            if (!isValid)
            {
                e.Cancel = true;
                errorProvider1.SetError(txt, errorMsg);
                txt.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txt, "");
                txt.BackColor = Color.Honeydew;
            }
        }

        private void Txt_Validated(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt != null)
            {
                txt.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int soDem = (ngayTra - ngayNhan).Days;
                
                string msg = $"Đặt phòng thành công!\n" +
                             $"Khách hàng: {txtHoTen.Text}\n" +
                             $"Số đêm: {soDem}\n" +
                             $"Số người lớn: {txtSoNguoiLon.Text}, Số trẻ em: {txtSoTreEm.Text}";
                             
                MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
