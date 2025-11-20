using System;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnThemCapNhat.Click += btnThemCapNhat_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            lsvTaiKhoan.SelectedIndexChanged += lsvTaiKhoan_SelectedIndexChanged;
        }

        private int GetAccountIndex(string accountNum)
        {
            for (int i = 0; i < lsvTaiKhoan.Items.Count; i++)
            {
                if (lsvTaiKhoan.Items[i].SubItems[1].Text == accountNum)
                {
                    return i;
                }
            }
            return -1;
        }

        private void UpdateSTT()
        {
            for (int i = 0; i < lsvTaiKhoan.Items.Count; i++)
            {
                lsvTaiKhoan.Items[i].Text = (i + 1).ToString();
            }
        }

        private void UpdateTongTien()
        {
            double total = 0;
            foreach (ListViewItem item in lsvTaiKhoan.Items)
            {
                if (double.TryParse(item.SubItems[4].Text, out double val))
                {
                    total += val;
                }
            }
            txtTongTien.Text = total.ToString("#,##0");
        }

        private void btnThemCapNhat_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtTenKhachHang.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSoTien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtSoTien.Text, out double soTien))
            {
                MessageBox.Show("Số tiền phải là một con số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soTK = txtSoTaiKhoan.Text;
            int index = GetAccountIndex(soTK);

            if (index == -1)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (lsvTaiKhoan.Items.Count + 1).ToString();
                item.SubItems.Add(txtSoTaiKhoan.Text);
                item.SubItems.Add(txtTenKhachHang.Text);
                item.SubItems.Add(txtDiaChi.Text);
                item.SubItems.Add(soTien.ToString());

                lsvTaiKhoan.Items.Add(item);

                UpdateTongTien();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListViewItem item = lsvTaiKhoan.Items[index];
                item.SubItems[2].Text = txtTenKhachHang.Text;
                item.SubItems[3].Text = txtDiaChi.Text;
                item.SubItems[4].Text = soTien.ToString();

                UpdateTongTien();
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtSoTaiKhoan.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtSoTien.Text = "";
            txtSoTaiKhoan.Focus();
        }

        private void btnXoa_Click(object? sender, EventArgs e)
        {
            string soTKCanXoa = txtSoTaiKhoan.Text;
            int index = GetAccountIndex(soTKCanXoa);

            if (index != -1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    lsvTaiKhoan.Items.RemoveAt(index);
                    UpdateSTT();
                    UpdateTongTien();
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtSoTaiKhoan.Text = "";
                    txtTenKhachHang.Text = "";
                    txtDiaChi.Text = "";
                    txtSoTien.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvTaiKhoan_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (lsvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvTaiKhoan.SelectedItems[0];
                txtSoTaiKhoan.Text = item.SubItems[1].Text;
                txtTenKhachHang.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoTien.Text = item.SubItems[4].Text;
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}