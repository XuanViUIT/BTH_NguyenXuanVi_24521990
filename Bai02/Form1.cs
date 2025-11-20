using System.Security.Cryptography;

namespace Bai02
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
            int x = RandomNumberGenerator.GetInt32(0, this.ClientSize.Width - 50);
            int y = RandomNumberGenerator.GetInt32(0, this.ClientSize.Height - 50);
            lblPaintEvent.Location = new Point(x, y);
        }
    }
}
