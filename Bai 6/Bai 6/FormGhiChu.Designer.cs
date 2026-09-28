namespace Bai_6
{
    partial class FormGhiChu
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
            components = new System.ComponentModel.Container();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            lblTieuDeForm = new System.Windows.Forms.Label();
            txtTieuDe = new System.Windows.Forms.TextBox();
            txtNoiDung = new System.Windows.Forms.TextBox();
            cboMucDoUuTien = new System.Windows.Forms.ComboBox();
            btnLuuGhiChu = new System.Windows.Forms.Button();
            lblUuTien = new System.Windows.Forms.Label();
            lblNoiDung = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.BackColor = System.Drawing.Color.LightGray;
            lblTieuDeForm.Dock = System.Windows.Forms.DockStyle.Top;
            lblTieuDeForm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTieuDeForm.Location = new System.Drawing.Point(0, 0);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Size = new System.Drawing.Size(434, 30);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "Tiêu đề";
            lblTieuDeForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // txtTieuDe
            // 
            txtTieuDe.Location = new System.Drawing.Point(12, 40);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new System.Drawing.Size(410, 23);
            txtTieuDe.TabIndex = 1;
            txtTieuDe.TextChanged += txtTieuDe_TextChanged;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new System.Drawing.Point(12, 70);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new System.Drawing.Size(57, 15);
            lblNoiDung.TabIndex = 2;
            lblNoiDung.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.Location = new System.Drawing.Point(12, 90);
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.Size = new System.Drawing.Size(410, 150);
            txtNoiDung.TabIndex = 3;
            txtNoiDung.TextChanged += txtNoiDung_TextChanged;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblUuTien
            // 
            lblUuTien.AutoSize = true;
            lblUuTien.Location = new System.Drawing.Point(12, 250);
            lblUuTien.Name = "lblUuTien";
            lblUuTien.Size = new System.Drawing.Size(45, 15);
            lblUuTien.TabIndex = 4;
            lblUuTien.Text = "Priority:";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Location = new System.Drawing.Point(12, 270);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new System.Drawing.Size(121, 23);
            cboMucDoUuTien.TabIndex = 5;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Location = new System.Drawing.Point(347, 269);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new System.Drawing.Size(75, 25);
            btnLuuGhiChu.TabIndex = 6;
            btnLuuGhiChu.Text = "Lưu";
            btnLuuGhiChu.UseVisualStyleBackColor = true;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 311);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDeForm);
            Name = "FormGhiChu";
            Text = "Ghi chú mới";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblTieuDeForm;
        private System.Windows.Forms.TextBox txtTieuDe;
        private System.Windows.Forms.Label lblNoiDung;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.Label lblUuTien;
        private System.Windows.Forms.ComboBox cboMucDoUuTien;
        private System.Windows.Forms.Button btnLuuGhiChu;
    }
}
