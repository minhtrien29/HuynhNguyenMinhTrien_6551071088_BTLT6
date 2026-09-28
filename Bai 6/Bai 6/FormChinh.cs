using System;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void mnuMoGhiChuMoi_Click(object sender, EventArgs e)
        {
            FormGhiChu frm = new FormGhiChu();
            frm.MdiParent = this;
            frm.FormClosed += Frm_FormClosed;
            frm.Show();
            UpdateStatus();
        }

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                lblStatus.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
            }));
        }

        private void UpdateStatus()
        {
            this.BeginInvoke(new Action(() =>
            {
                lblStatus.Text = $"Số ghi chú đang mở: {this.MdiChildren.Length}";
            }));
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuXepTang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuXepNgang_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuXepDoc_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
