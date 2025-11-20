namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Construction");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Load: Form đang được tải (Chưa hiển thị Form)");
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            lblStatus.Text = $"Form đang không được focus";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show($"Form đã hiển thị"); //Sự kiện chỉ xuất hiện 1 lần sau khi Form đã hiện thị lần đầu
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Form đang chuẩn bị đóng");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Form đã đóng");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblStatus.Text = $"Form đang được focus";
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            MessageBox.Show($"Resize Form");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Click vào Form");
        }
    }
}
