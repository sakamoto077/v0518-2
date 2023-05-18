namespace v0518_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "(..)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top = 100;
            label1.Text = "( .  .)";

            MessageBox.Show("");
        }
    }
}