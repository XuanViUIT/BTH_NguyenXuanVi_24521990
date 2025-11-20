using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AssignSeatEvents();
        }

        private void AssignSeatEvents()
        {
            foreach (Control c in pnlGhe.Controls)
            {
                if (c is Button)
                {
                    c.Click += Seat_Click;
                    c.BackColor = Color.White;
                }
            }
        }

        private void Seat_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor == Color.Yellow)
                {
                    MessageBox.Show("Ghế này đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Blue;
                }
                else if (btn.BackColor == Color.Blue)
                {
                    btn.BackColor = Color.White;
                }
            }
        }

        private void btnChon_Click(object? sender, EventArgs e)
        {
            double tongTien = 0;

            foreach (Control c in pnlGhe.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;
                        int soGhe = int.Parse(btn.Text);
                        double giaVe = 0;

                        if (soGhe <= 5)
                            giaVe = 5000;
                        else if (soGhe <= 10)
                            giaVe = 6500;
                        else
                            giaVe = 8000;

                        tongTien += giaVe;
                    }
                }
            }
            lblTong.Text = tongTien.ToString("#,##0");
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            foreach (Control c in pnlGhe.Controls)
            {
                if (c is Button btn)
                {
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.White;
                    }
                }
            }
            lblTong.Text = "0";
        }

        private void btnKetThuc_Click(object? sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}