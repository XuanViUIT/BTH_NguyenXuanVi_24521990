namespace Lab02_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double thuong;
                thuong = double.Parse(txtNum1.Text) / double.Parse(txtNum2.Text);
                lblRes.Text = thuong.ToString("0.0.0");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Khong the chia cho 0", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            int tong;
            tong = int.Parse(txtNum1.Text) + int.Parse(txtNum2.Text);
            lblRes.Text = tong.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int hieu;
            hieu = int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text);
            lblRes.Text = hieu.ToString();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            int tich;
            tich = int.Parse(txtNum1.Text) * int.Parse(txtNum2.Text);
            lblRes.Text = tich.ToString();
        }
    }
}
