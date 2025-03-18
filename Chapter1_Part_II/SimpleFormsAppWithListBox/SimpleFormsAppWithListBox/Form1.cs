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
            // Check if the input text box is not empty
            if (!string.IsNullOrWhiteSpace(txtBox.Text)) // Assuming inputTextBox is the name of your TextBox
            {
                // Add the text from the input box to the ListBox
                listBox.Items.Add(txtBox.Text); // Assuming listBox is the name of your ListBox
                // Clear the input box after adding
                txtBox.Clear(); // Clear the input TextBox
            }
            else
            {
                MessageBox.Show("Please enter a value to add.");
            }
        }

        private void remvbttn_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the ListBox
            if (listBox.SelectedItem != null)
            {
                // Remove the selected item from the ListBox
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void clearbttn_Click(object sender, EventArgs e)
        {
            // Clear all items from the ListBox
            listBox.Items.Clear();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method can be used to handle selection changes in the ListBox if needed
        }
    }
}