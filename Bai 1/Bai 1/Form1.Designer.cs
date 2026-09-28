namespace Bai_1
{
    partial class FormDangKy
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtXacNhanMK = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();

            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(370, 54);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký tài khoản mới";

            label2.AutoSize = true;
            label2.Location = new Point(12, 39);
            label2.Name = "label2";
            label2.Size = new Size(261, 25);
            label2.TabIndex = 1;
            label2.Text = "Vui lòng nhập thông tin đầy đủ";

            txtHoTen.Location = new Point(284, 116);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(198, 31);
            txtHoTen.TabIndex = 2;

            txtSDT.Location = new Point(284, 163);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(198, 31);
            txtSDT.TabIndex = 3;

            txtEmail.Location = new Point(284, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(198, 31);
            txtEmail.TabIndex = 4;

            txtMatKhau.Location = new Point(284, 262);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(198, 31);
            txtMatKhau.TabIndex = 5;

            txtXacNhanMK.Location = new Point(284, 316);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.Size = new Size(198, 31);
            txtXacNhanMK.TabIndex = 6;

            label3.AutoSize = true;
            label3.Location = new Point(207, 119);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 7;
            label3.Text = "Họ tên";

            label4.AutoSize = true;
            label4.Location = new Point(156, 163);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại";

            label5.AutoSize = true;
            label5.Location = new Point(219, 216);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "Email";

            label6.AutoSize = true;
            label6.Location = new Point(187, 265);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 10;
            label6.Text = "Mật khẩu";

            label7.AutoSize = true;
            label7.Location = new Point(114, 316);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 11;
            label7.Text = "Xác thực mật khẩu";

            btnDangKy.BackColor = Color.Cyan;
            btnDangKy.ForeColor = SystemColors.ActiveCaptionText;
            btnDangKy.Location = new Point(257, 384);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(112, 34);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;

            btnHuy.BackColor = SystemColors.ButtonShadow;
            btnHuy.CausesValidation = false;
            btnHuy.Location = new Point(379, 384);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(112, 34);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;

            errorProvider1.ContainerControl = this;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDangKy";
            Text = "FormDangKy";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMK;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
