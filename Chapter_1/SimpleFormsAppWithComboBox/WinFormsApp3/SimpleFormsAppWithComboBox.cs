namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] cuisine = {"Filipino", "Italian", "Japanese", "American"};
            comboBox1.Items.AddRange(cuisine);

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;    
        }

        private void cuisine_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            string[] Filipino = { "Adobo", "Sinigang", "Lechon", "Kare-Kare" };
            string[] Italian = { "Pizza", "Pasta", "Risotto", "Lasagna" };
            string[] Japanese = { "Sushi", "Ramen", "Tempura", "Sashimi" };
            string[] American = { "Burger", "Hotdog", "Steak", "Fried Chicken" };

            checkedListBox1.Items.Clear();

            if (comboBox1.SelectedItem is string selectedcuisine)
            {
                if(selectedcuisine == "Filipino")
                {
                    checkedListBox1.Items.AddRange(Filipino);
                }
                else if (selectedcuisine == "Italian")
                {
                    checkedListBox1.Items.AddRange(Italian);
                }
                else if (selectedcuisine == "Japanese")
                {
                    checkedListBox1.Items.AddRange(Japanese);
                }
                else if (selectedcuisine == "American")
                {
                    checkedListBox1.Items.AddRange(American);
                }
            }
        }

        private void foodlist_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void favfood_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }   
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
