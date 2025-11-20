namespace Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
