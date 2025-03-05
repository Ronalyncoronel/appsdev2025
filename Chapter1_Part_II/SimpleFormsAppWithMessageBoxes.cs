namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fNameValue = textBox1.Text;
            string middleNameValue = textBox2.Text;
            string lNameValue = textBox3.Text;
            string suffixNameValue = textBox4.Text;

            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmationResult == DialogResult.Yes)
            {
              
                string greetingMessage = $"Hello There! {fNameValue} {middleNameValue} {lNameValue} {suffixNameValue}";
                MessageBox.Show(greetingMessage, "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                MessageBox.Show("Submission canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

             