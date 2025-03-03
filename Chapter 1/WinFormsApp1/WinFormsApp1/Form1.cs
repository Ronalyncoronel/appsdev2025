namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = firstName.Text;
            string lNameValue = lastName.Text;
            MessageBox.Show($"Hello World {fNameValue} {lNameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
