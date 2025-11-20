using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lsvSinhVien.View = View.Details;
            lsvSinhVien.GridLines = true;
            lsvSinhVien.FullRowSelect = true;

            KhoiTaoDuLieu();

            btnChon.Click += btnChon_Click;
            btnBoChon.Click += btnBoChon_Click;
            btnLuu.Click += btnLuu_Click;
            btnXoa.Click += btnXoa_Click;
        }

        private void KhoiTaoDuLieu()
        {
            cboChuyenNganh.Items.Add("Hệ Thống Thông Tin");
            cboChuyenNganh.Items.Add("Kỹ Thuật Phần Mềm");
            cboChuyenNganh.Items.Add("Mạng Máy Tính và Truyền Thông dữ liệu");
            cboChuyenNganh.Items.Add("An Toàn Thông Tin");
            cboChuyenNganh.Items.Add("Thiết kế Vi mạch");
            cboChuyenNganh.Items.Add("Kỹ thuật máy tính");
            cboChuyenNganh.Items.Add("Khoa Học Máy Tính");
            cboChuyenNganh.Items.Add("Trí Tuệ Nhân tạo");
            cboChuyenNganh.Items.Add("Công nghệ Thông tin");
            cboChuyenNganh.Items.Add("Khoa học Dữ liệu");
            cboChuyenNganh.Items.Add("Truyền thông đa phương tiện");
            cboChuyenNganh.SelectedIndex = 0;

            lstMonHoc.Items.Add("Cơ Sở Dữ Liệu");
            lstMonHoc.Items.Add("Cấu Trúc Dữ Liệu Và Giải Thuật");
            lstMonHoc.Items.Add("Lập Trình Hướng Đối Tượng");
            lstMonHoc.Items.Add("Nhập Môn Mạng Máy Tính");
            lstMonHoc.Items.Add("Nhập môn lập trình");
        }

        private void btnChon_Click(object? sender, EventArgs e)
        {
            while (lstMonHoc.SelectedItems.Count > 0)
            {
                var item = lstMonHoc.SelectedItems[0];
                if (item != null) 
                {
                    lstDaChon.Items.Add(item);
                    lstMonHoc.Items.Remove(item);
                }
            }
        }

        private void btnBoChon_Click(object? sender, EventArgs e)
        {
            while (lstDaChon.SelectedItems.Count > 0)
            {
                var item = lstDaChon.SelectedItems[0];
                if (item != null) 
                {
                    lstMonHoc.Items.Add(item);
                    lstDaChon.Items.Remove(item);
                }
            }
        }

        private void btnLuu_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV và Họ Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = txtMSSV.Text;
            string hoTen = txtHoTen.Text;
            string chuyenNganh = cboChuyenNganh.Text;

            List<string> gtList = new List<string>();
            if (chkNam.Checked) gtList.Add("Nam");
            if (chkNu.Checked) gtList.Add("Nữ");

            string gioiTinh = string.Join(", ", gtList);

            string soMon = lstDaChon.Items.Count.ToString();

            ListViewItem item = new ListViewItem(mssv);
            item.SubItems.Add(hoTen);
            item.SubItems.Add(chuyenNganh);
            item.SubItems.Add(gioiTinh);
            item.SubItems.Add(soMon);

            lsvSinhVien.Items.Add(item);

            txtMSSV.Text = "";
            txtHoTen.Text = "";
            chkNam.Checked = false;
            chkNu.Checked = false;

            foreach (var mon in lstDaChon.Items)
            {
                if (mon != null) 
                {
                    lstMonHoc.Items.Add(mon);
                }
            }
            lstDaChon.Items.Clear();
            txtMSSV.Focus();
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            if (lsvSinhVien.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sinh viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lsvSinhVien.SelectedItems)
                    {
                        lsvSinhVien.Items.Remove(item);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}