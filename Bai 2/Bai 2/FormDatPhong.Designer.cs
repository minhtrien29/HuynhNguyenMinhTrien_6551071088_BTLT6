namespace Bai_2
{
    partial class FormDatPhong
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
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            txtHoTen = new System.Windows.Forms.TextBox();
            txtCCCD = new System.Windows.Forms.TextBox();
            txtNgayNhan = new System.Windows.Forms.TextBox();
            txtNgayTra = new System.Windows.Forms.TextBox();
            txtSoNguoiLon = new System.Windows.Forms.TextBox();
            txtSoTreEm = new System.Windows.Forms.TextBox();
            btnDatPhong = new System.Windows.Forms.Button();
            lblHoTen = new System.Windows.Forms.Label();
            lblCCCD = new System.Windows.Forms.Label();
            lblNgayNhan = new System.Windows.Forms.Label();
            lblNgayTra = new System.Windows.Forms.Label();
            lblSoNguoiLon = new System.Windows.Forms.Label();
            lblSoTreEm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new System.Drawing.Point(170, 30);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new System.Drawing.Size(200, 23);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += Txt_Validating;
            txtHoTen.Validated += Txt_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new System.Drawing.Point(170, 70);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(200, 23);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += Txt_Validating;
            txtCCCD.Validated += Txt_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new System.Drawing.Point(170, 110);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new System.Drawing.Size(200, 23);
            txtNgayNhan.TabIndex = 2;
            txtNgayNhan.Validating += Txt_Validating;
            txtNgayNhan.Validated += Txt_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new System.Drawing.Point(170, 150);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new System.Drawing.Size(200, 23);
            txtNgayTra.TabIndex = 3;
            txtNgayTra.Validating += Txt_Validating;
            txtNgayTra.Validated += Txt_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new System.Drawing.Point(170, 190);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new System.Drawing.Size(200, 23);
            txtSoNguoiLon.TabIndex = 4;
            txtSoNguoiLon.Validating += Txt_Validating;
            txtSoNguoiLon.Validated += Txt_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new System.Drawing.Point(170, 230);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new System.Drawing.Size(200, 23);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += Txt_Validating;
            txtSoTreEm.Validated += Txt_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.Location = new System.Drawing.Point(170, 270);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new System.Drawing.Size(200, 30);
            btnDatPhong.TabIndex = 6;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = true;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new System.Drawing.Point(50, 33);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new System.Drawing.Size(46, 15);
            lblHoTen.TabIndex = 7;
            lblHoTen.Text = "Họ tên";
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Location = new System.Drawing.Point(50, 73);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new System.Drawing.Size(55, 15);
            lblCCCD.TabIndex = 8;
            lblCCCD.Text = "Số CCCD";
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Location = new System.Drawing.Point(50, 113);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new System.Drawing.Size(101, 15);
            lblNgayNhan.TabIndex = 9;
            lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Location = new System.Drawing.Point(50, 153);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new System.Drawing.Size(92, 15);
            lblNgayTra.TabIndex = 10;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Location = new System.Drawing.Point(50, 193);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new System.Drawing.Size(73, 15);
            lblSoNguoiLon.TabIndex = 11;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Location = new System.Drawing.Point(50, 233);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new System.Drawing.Size(57, 15);
            lblSoTreEm.TabIndex = 12;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 350);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblSoTreEm);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(lblNgayTra);
            Controls.Add(lblNgayNhan);
            Controls.Add(lblCCCD);
            Controls.Add(lblHoTen);
            Name = "FormDatPhong";
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtSoNguoiLon;
        private System.Windows.Forms.TextBox txtSoTreEm;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblNgayNhan;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblSoNguoiLon;
        private System.Windows.Forms.Label lblSoTreEm;
    }
}
