namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "The Notebook", "aboutTime", "me before you" };
            MoviecheckedListBox.Items.AddRange(movies);
            MoviecheckedListBox.CheckOnClick = true;
        }

        private void Movielabel_Click(object sender, EventArgs e)
        {

        }

        private void Proglabel_Click(object sender, EventArgs e)
        {

        }

        private void MoviecheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton1_Click(object sender, EventArgs e)
        {
            foreach (var movies in MoviecheckedListBox.Items) {

                bool isSelected = MoviecheckedListBox.GetItemChecked(MoviecheckedListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies)) {
                    listBox.Items.Add(movies);

                }
            }
        }

        private void remvbutton2_Click(object sender, EventArgs e)
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

        private void clearbutton3_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
