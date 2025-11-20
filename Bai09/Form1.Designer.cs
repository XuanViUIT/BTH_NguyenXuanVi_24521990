namespace Bai09
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
            groupBox1 = new GroupBox();
            btnBoChon = new Button();
            btnChon = new Button();
            lsvSinhVien = new ListView();
            columnMSSV = new ColumnHeader();
            columnHoTen = new ColumnHeader();
            columnChuyenNganh = new ColumnHeader();
            columnGioiTinh = new ColumnHeader();
            columnSoMon = new ColumnHeader();
            btnXoa = new Button();
            btnLuu = new Button();
            lstDaChon = new ListBox();
            lstMonHoc = new ListBox();
            chkNu = new CheckBox();
            chkNam = new CheckBox();
            cboChuyenNganh = new ComboBox();
            txtHoTen = new TextBox();
            txtMSSV = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBoChon);
            groupBox1.Controls.Add(btnChon);
            groupBox1.Controls.Add(lsvSinhVien);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(lstDaChon);
            groupBox1.Controls.Add(lstMonHoc);
            groupBox1.Controls.Add(chkNu);
            groupBox1.Controls.Add(chkNam);
            groupBox1.Controls.Add(cboChuyenNganh);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMSSV);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 502);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnBoChon
            // 
            btnBoChon.BackColor = SystemColors.ScrollBar;
            btnBoChon.FlatStyle = FlatStyle.Flat;
            btnBoChon.Location = new Point(418, 249);
            btnBoChon.Name = "btnBoChon";
            btnBoChon.Size = new Size(56, 29);
            btnBoChon.TabIndex = 20;
            btnBoChon.Text = "<";
            btnBoChon.UseVisualStyleBackColor = false;
            // 
            // btnChon
            // 
            btnChon.BackColor = SystemColors.ScrollBar;
            btnChon.FlatStyle = FlatStyle.Flat;
            btnChon.Location = new Point(418, 203);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(56, 29);
            btnChon.TabIndex = 19;
            btnChon.Text = ">";
            btnChon.UseVisualStyleBackColor = false;
            // 
            // lsvSinhVien
            // 
            lsvSinhVien.Columns.AddRange(new ColumnHeader[] { columnMSSV, columnHoTen, columnChuyenNganh, columnGioiTinh, columnSoMon });
            lsvSinhVien.FullRowSelect = true;
            lsvSinhVien.GridLines = true;
            lsvSinhVien.Location = new Point(0, 337);
            lsvSinhVien.Name = "lsvSinhVien";
            lsvSinhVien.Size = new Size(800, 165);
            lsvSinhVien.TabIndex = 18;
            lsvSinhVien.UseCompatibleStateImageBehavior = false;
            lsvSinhVien.View = View.Details;
            // 
            // columnMSSV
            // 
            columnMSSV.Text = "MSSV";
            columnMSSV.Width = 100;
            // 
            // columnHoTen
            // 
            columnHoTen.Text = "Họ Tên";
            columnHoTen.Width = 200;
            // 
            // columnChuyenNganh
            // 
            columnChuyenNganh.Text = "Chuyên Ngành";
            columnChuyenNganh.Width = 200;
            // 
            // columnGioiTinh
            // 
            columnGioiTinh.Text = "Giới Tính";
            columnGioiTinh.Width = 100;
            // 
            // columnSoMon
            // 
            columnSoMon.Text = "Số Môn";
            columnSoMon.Width = 100;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(401, 302);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa Chọn";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(266, 302);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(129, 29);
            btnLuu.TabIndex = 16;
            btnLuu.Text = "Lưu Thông Tin";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // lstDaChon
            // 
            lstDaChon.FormattingEnabled = true;
            lstDaChon.Location = new Point(480, 189);
            lstDaChon.Name = "lstDaChon";
            lstDaChon.Size = new Size(286, 104);
            lstDaChon.TabIndex = 15;
            // 
            // lstMonHoc
            // 
            lstMonHoc.FormattingEnabled = true;
            lstMonHoc.Location = new Point(123, 189);
            lstMonHoc.Name = "lstMonHoc";
            lstMonHoc.Size = new Size(287, 104);
            lstMonHoc.TabIndex = 14;
            // 
            // chkNu
            // 
            chkNu.AutoSize = true;
            chkNu.Location = new Point(371, 130);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(51, 24);
            chkNu.TabIndex = 13;
            chkNu.Text = "Nữ";
            chkNu.UseVisualStyleBackColor = true;
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.Location = new Point(285, 130);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(63, 24);
            chkNam.TabIndex = 12;
            chkNam.Text = "Nam";
            chkNam.UseVisualStyleBackColor = true;
            // 
            // cboChuyenNganh
            // 
            cboChuyenNganh.FormattingEnabled = true;
            cboChuyenNganh.Location = new Point(285, 96);
            cboChuyenNganh.Name = "cboChuyenNganh";
            cboChuyenNganh.Size = new Size(241, 28);
            cboChuyenNganh.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(285, 56);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(241, 27);
            txtHoTen.TabIndex = 8;
            // 
            // txtMSSV
            // 
            txtMSSV.Location = new Point(285, 20);
            txtMSSV.Name = "txtMSSV";
            txtMSSV.Size = new Size(143, 27);
            txtMSSV.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 163);
            label7.Name = "label7";
            label7.Size = new Size(203, 20);
            label7.TabIndex = 6;
            label7.Text = "Chọn Các Môn Học Tham Gia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(123, 128);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 3;
            label4.Text = "Giới Tính";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 93);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "Chuyên Ngành";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 58);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 23);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã Sinh Viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 502);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkNam;
        private ComboBox cboChuyenNganh;
        private TextBox txtHoTen;
        private TextBox txtMSSV;
        private CheckBox chkNu;
        private Button btnXoa;
        private Button btnLuu;
        private ListBox lstDaChon;
        private ListBox lstMonHoc;
        private ListView lsvSinhVien;
        private Button btnBoChon;
        private Button btnChon;
        private ColumnHeader columnMSSV;
        private ColumnHeader columnHoTen;
        private ColumnHeader columnChuyenNganh;
        private ColumnHeader columnGioiTinh;
        private ColumnHeader columnSoMon;
    }
}
