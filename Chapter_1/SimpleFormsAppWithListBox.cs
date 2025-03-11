using System.Windows.Forms;

namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbttn_Click(object sender, EventArgs e)
        {
           
            if (!string.IsNullOrWhiteSpace(txtBox.Text)) 
            {
                
                listBox.Items.Add(txtBox.Text); 
              
                txtBox.Clear(); 
            }
            else
            {
                MessageBox.Show("Please enter a value to add.");
            }
        }

        private void remvbttn_Click(object sender, EventArgs e)
        {
           
            if (listBox.SelectedItem != null)
            {
               
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            
            listBox.Items.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}