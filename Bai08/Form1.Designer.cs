namespace Bai08
{
    partial class Form1
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
            lblQuanLyTaiKhoan = new Label();
            lblSoTaiKhoan = new Label();
            lblTenKhachHang = new Label();
            lblDiaChi = new Label();
            lblSoTien = new Label();
            txtSoTaiKhoan = new TextBox();
            txtTenKhachHang = new TextBox();
            txtDiaChi = new TextBox();
            txtSoTien = new TextBox();
            lblTongTien = new Label();
            txtTongTien = new TextBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnThemCapNhat = new Button();
            lsvTaiKhoan = new ListView();
            columnSTT = new ColumnHeader();
            columnMaTaiKhoan = new ColumnHeader();
            columnTenKhachHang = new ColumnHeader();
            columnDiaChi = new ColumnHeader();
            columnSoTien = new ColumnHeader();
            SuspendLayout();
            // 
            // lblQuanLyTaiKhoan
            // 
            lblQuanLyTaiKhoan.Dock = DockStyle.Top;
            lblQuanLyTaiKhoan.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuanLyTaiKhoan.ForeColor = Color.Blue;
            lblQuanLyTaiKhoan.Location = new Point(0, 0);
            lblQuanLyTaiKhoan.Name = "lblQuanLyTaiKhoan";
            lblQuanLyTaiKhoan.Size = new Size(800, 67);
            lblQuanLyTaiKhoan.TabIndex = 0;
            lblQuanLyTaiKhoan.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            lblQuanLyTaiKhoan.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSoTaiKhoan
            // 
            lblSoTaiKhoan.AutoSize = true;
            lblSoTaiKhoan.Location = new Point(159, 89);
            lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            lblSoTaiKhoan.Size = new Size(91, 20);
            lblSoTaiKhoan.TabIndex = 1;
            lblSoTaiKhoan.Text = "Số tài khoản";
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(139, 132);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(111, 20);
            lblTenKhachHang.TabIndex = 2;
            lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(116, 175);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(134, 20);
            lblDiaChi.TabIndex = 3;
            lblDiaChi.Text = "Địa chỉ khách hàng";
            // 
            // lblSoTien
            // 
            lblSoTien.AutoSize = true;
            lblSoTien.Location = new Point(90, 218);
            lblSoTien.Name = "lblSoTien";
            lblSoTien.Size = new Size(160, 20);
            lblSoTien.TabIndex = 4;
            lblSoTien.Text = "Số tiền trong tài khoản";
            // 
            // txtSoTaiKhoan
            // 
            txtSoTaiKhoan.Location = new Point(274, 86);
            txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            txtSoTaiKhoan.Size = new Size(431, 27);
            txtSoTaiKhoan.TabIndex = 5;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(274, 132);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(431, 27);
            txtTenKhachHang.TabIndex = 6;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(274, 175);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(431, 27);
            txtDiaChi.TabIndex = 7;
            // 
            // txtSoTien
            // 
            txtSoTien.Location = new Point(274, 218);
            txtSoTien.Name = "txtSoTien";
            txtSoTien.Size = new Size(431, 27);
            txtSoTien.TabIndex = 8;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(470, 472);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(75, 20);
            lblTongTien.TabIndex = 9;
            lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(555, 469);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(233, 27);
            txtTongTien.TabIndex = 10;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(611, 265);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 11;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(491, 265);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThemCapNhat
            // 
            btnThemCapNhat.Location = new Point(334, 265);
            btnThemCapNhat.Name = "btnThemCapNhat";
            btnThemCapNhat.Size = new Size(129, 29);
            btnThemCapNhat.TabIndex = 13;
            btnThemCapNhat.Text = "Thêm/Cập Nhật";
            btnThemCapNhat.UseVisualStyleBackColor = true;
            // 
            // lsvTaiKhoan
            // 
            lsvTaiKhoan.Columns.AddRange(new ColumnHeader[] { columnSTT, columnMaTaiKhoan, columnTenKhachHang, columnDiaChi, columnSoTien });
            lsvTaiKhoan.FullRowSelect = true;
            lsvTaiKhoan.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lsvTaiKhoan.Location = new Point(0, 301);
            lsvTaiKhoan.Name = "lsvTaiKhoan";
            lsvTaiKhoan.Size = new Size(800, 162);
            lsvTaiKhoan.TabIndex = 14;
            lsvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lsvTaiKhoan.View = View.Details;
            // 
            // columnSTT
            // 
            columnSTT.Text = "STT";
            columnSTT.Width = 50;
            // 
            // columnMaTaiKhoan
            // 
            columnMaTaiKhoan.Text = "Mã Tài Khoản";
            columnMaTaiKhoan.Width = 130;
            // 
            // columnTenKhachHang
            // 
            columnTenKhachHang.Text = "Tên Khách Hàng";
            columnTenKhachHang.Width = 200;
            // 
            // columnDiaChi
            // 
            columnDiaChi.Text = "Địa Chỉ";
            columnDiaChi.Width = 250;
            // 
            // columnSoTien
            // 
            columnSoTien.Text = "Số Tiền";
            columnSoTien.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(lsvTaiKhoan);
            Controls.Add(btnThemCapNhat);
            Controls.Add(btnXoa);
            Controls.Add(btnThoat);
            Controls.Add(txtTongTien);
            Controls.Add(lblTongTien);
            Controls.Add(txtSoTien);
            Controls.Add(txtDiaChi);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtSoTaiKhoan);
            Controls.Add(lblSoTien);
            Controls.Add(lblDiaChi);
            Controls.Add(lblTenKhachHang);
            Controls.Add(lblSoTaiKhoan);
            Controls.Add(lblQuanLyTaiKhoan);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuanLyTaiKhoan;
        private Label lblSoTaiKhoan;
        private Label lblTenKhachHang;
        private Label lblDiaChi;
        private Label lblSoTien;
        private TextBox txtSoTaiKhoan;
        private TextBox txtTenKhachHang;
        private TextBox txtDiaChi;
        private TextBox txtSoTien;
        private Label lblTongTien;
        private TextBox txtTongTien;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnThemCapNhat;
        private ListView lsvTaiKhoan;
        private ColumnHeader columnSTT;
        private ColumnHeader columnMaTaiKhoan;
        private ColumnHeader columnTenKhachHang;
        private ColumnHeader columnDiaChi;
        private ColumnHeader columnSoTien;
    }
}
