namespace Bai_4
{
    partial class FormDanhBa
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

        private void InitializeComponent()
        {
            lstLienHe = new System.Windows.Forms.ListBox();
            txtTen = new System.Windows.Forms.TextBox();
            txtSDT = new System.Windows.Forms.TextBox();
            btnThem = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThoat = new System.Windows.Forms.Button();
            lblTen = new System.Windows.Forms.Label();
            lblSDT = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.ItemHeight = 15;
            lstLienHe.Location = new System.Drawing.Point(12, 12);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new System.Drawing.Size(250, 319);
            lstLienHe.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new System.Drawing.Point(350, 20);
            txtTen.Name = "txtTen";
            txtTen.Size = new System.Drawing.Size(200, 23);
            txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new System.Drawing.Point(350, 60);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new System.Drawing.Size(200, 23);
            txtSDT.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(350, 100);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(90, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm / Lưu";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(460, 100);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(90, 30);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(350, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(90, 30);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new System.Drawing.Point(460, 150);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(90, 30);
            btnThoat.TabIndex = 6;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Location = new System.Drawing.Point(280, 23);
            lblTen.Name = "lblTen";
            lblTen.Size = new System.Drawing.Size(25, 15);
            lblTen.TabIndex = 7;
            lblTen.Text = "Tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new System.Drawing.Point(280, 63);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new System.Drawing.Size(43, 15);
            lblSDT.TabIndex = 8;
            lblSDT.Text = "Số ĐT";
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(584, 361);
            Controls.Add(lblSDT);
            Controls.Add(lblTen);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lstLienHe);
            Name = "FormDanhBa";
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox lstLienHe;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblSDT;
    }
}
