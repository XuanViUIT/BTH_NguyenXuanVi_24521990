namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int r = random.Next(0, 256);
            int g = random.Next(0, 256);
            int b = random.Next(0, 256);
            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
