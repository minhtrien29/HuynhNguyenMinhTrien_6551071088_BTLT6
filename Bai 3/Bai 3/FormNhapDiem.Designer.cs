namespace Bai_3
{
    partial class FormNhapDiem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            listBox1 = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 10;
            label1.TabStop = false;
            label1.Text = "Mã hs";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 9);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 11;
            label2.TabStop = false;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 12;
            label3.TabStop = false;
            label3.Text = "Điểm toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 9);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 13;
            label4.TabStop = false;
            label4.Text = "Điểm văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(651, 9);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 14;
            label5.TabStop = false;
            label5.Text = "Điểm anh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(57, 37);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(121, 31);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(207, 37);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(121, 31);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Location = new Point(351, 37);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(121, 31);
            txtToan.TabIndex = 2;
            // 
            // txtVan
            // 
            txtVan.Location = new Point(508, 37);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(121, 31);
            txtVan.TabIndex = 3;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(651, 37);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(121, 31);
            txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(57, 83);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.Location = new Point(175, 83);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(112, 34);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa trắng";
            btnXoaTrang.UseVisualStyleBackColor = true;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(57, 140);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(715, 279);
            listBox1.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhapDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Nhập Điểm Học Sinh";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox listBox1;
        private ErrorProvider errorProvider1;
    }
}
