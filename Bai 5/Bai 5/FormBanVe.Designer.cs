namespace Bai_5
{
    partial class FormBanVe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGheDaChon = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhach.Location = new Point(30, 18);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(74, 19);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhach.Location = new Point(30, 42);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(335, 25);
            txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhim.Location = new Point(30, 78);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(43, 19);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(30, 102);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(335, 25);
            cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuatChieu.Location = new Point(30, 138);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(75, 19);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(30, 162);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(335, 25);
            cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGheDaChon.Location = new Point(30, 198);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(90, 19);
            lblGheDaChon.TabIndex = 6;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.BackColor = Color.White;
            txtGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtGheDaChon.Location = new Point(30, 222);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(335, 25);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonGhe.Location = new Point(80, 275);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(88, 33);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatVe.Location = new Point(180, 275);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(85, 33);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(278, 275);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 33);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 332);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(lblGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(lblPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblTenKhach);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblSuatChieu;
        private ComboBox cboSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
