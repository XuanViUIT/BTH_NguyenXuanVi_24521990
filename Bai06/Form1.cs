using System;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Form1 : Form
    {
        // === BIẾN TOÀN CỤC ===
        double soThuNhat;
        char phepToan;
        double soThuHai;
        double ketqua;
        double boNho = 0; // <-- THÊM BIẾN NÀY cho các nút Memory

        public Form1()
        {
            InitializeComponent();
        }

        // === HÀM ĐÃ SỬA LỖI ===

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Cách ép kiểu gọn hơn
            Button clickedButton = (Button)sender;
            string numberPressed = clickedButton.Text;

            // SỬA LỖI LOGIC IF/ELSE:
            // Nếu màn hình là "0" (hoặc rỗng), hãy thay thế nó
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = numberPressed;
            }
            else
            {
                // Ngược lại, nối số mới vào
                txtDisplay.Text += numberPressed;
            }
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // Hàm này của bạn đã ĐÚNG
            soThuNhat = Convert.ToDouble(txtDisplay.Text);
            Button operator_Click = (Button)sender;
            phepToan = operator_Click.Text[0];
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // SỬA LỖI 1: Phải gán cho soThuHai
            soThuHai = Convert.ToDouble(txtDisplay.Text);

            switch (phepToan)
            {
                case '+':
                    ketqua = soThuNhat + soThuHai;
                    break;
                case '-':
                    ketqua = soThuNhat - soThuHai;
                    break;
                case '*':
                    ketqua = soThuNhat * soThuHai;
                    break;
                case '/':
                    // SỬA LỖI 2: Chỉ kiểm tra soThuHai
                    if (soThuHai == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    else
                    {
                        ketqua = soThuNhat / soThuHai;
                    }
                    break;
            }

            txtDisplay.Text = ketqua.ToString();
        }

        // === CÁC HÀM CÒN THIẾU ===

        // Nút 'C' (Clear All) - Xóa toàn bộ phép tính
        private void btnC_Click(object sender, EventArgs e)
        {
            // Sửa lại hàm C: Phải reset mọi thứ
            txtDisplay.Text = "0";
            soThuNhat = 0;
            soThuHai = 0;
            phepToan = '\0'; // Ký tự rỗng
        }

        // Nút 'CE' (Clear Entry) - Chỉ xóa số đang nhập
        // (Bạn cần tạo sự kiện Click cho nút CE và trỏ vào hàm này)
        private void btnCE_Click(object sender, EventArgs e)
        {
            // CE chỉ reset màn hình
            txtDisplay.Text = "0";
        }

        // Nút '.' (Dấu thập phân)
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Chỉ thêm dấu "." NẾU màn hình chưa có
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }

        // Nút '+/-' (Đảo dấu)
        private void btnToggleSign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0")
            {
                double soHienTai = Convert.ToDouble(txtDisplay.Text);
                soHienTai *= -1; // Nhân với -1
                txtDisplay.Text = soHienTai.ToString();
            }
        }

        // Nút 'Backspace' (Xóa lùi)
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                // Lấy chuỗi con, bỏ đi 1 ký tự cuối
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            // Nếu xóa hết, trả về "0"
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        // Nút 'sqrt' (Căn bậc 2)
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double soHienTai = Convert.ToDouble(txtDisplay.Text);
            ketqua = Math.Sqrt(soHienTai);
            txtDisplay.Text = ketqua.ToString();
        }

        // Nút '1/x' (Nghịch đảo)
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double soHienTai = Convert.ToDouble(txtDisplay.Text);
            if (soHienTai == 0)
            {
                MessageBox.Show("Không thể chia cho 0");
                return;
            }
            ketqua = 1 / soHienTai;
            txtDisplay.Text = ketqua.ToString();
        }

        // === CÁC NÚT BỘ NHỚ (MEMORY) ===

        // 'MC' (Memory Clear)
        private void btnMC_Click(object sender, EventArgs e)
        {
            boNho = 0;
        }

        // 'MR' (Memory Recall)
        private void btnMR_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = boNho.ToString();
        }

        // 'MS' (Memory Store)
        private void btnMS_Click(object sender, EventArgs e)
        {
            boNho = Convert.ToDouble(txtDisplay.Text);
        }

        // 'M+' (Memory Add)
        private void btnMPlus_Click(object sender, EventArgs e)
        {
            boNho += Convert.ToDouble(txtDisplay.Text);
        }
    }
}