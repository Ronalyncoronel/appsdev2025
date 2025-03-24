using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] characters = { "Blossom", "Jerry", "Minions", "Snowball" };
            imagepicker.Items.AddRange(characters);
            imagepicker.DropDownStyle = ComboBoxStyle.DropDownList;
            imagepicker.SelectedIndex = 0; 
        }

        private void imagepicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Selectbttn_Click(sender, e);
        }

        private void Selectbttn_Click(object sender, EventArgs e)
        {
            if (imagepicker.SelectedItem is string selectedCharacter)
            {
                string folderPath = @"C:\Users\Rona\source\repos\SimpleFavoriteCartoonFormApp\SimpleFavoriteCartoonFormApp\Properties\image\";
                string imagePath = System.IO.Path.Combine(folderPath, selectedCharacter.ToLower().Replace(" ", "") + ".jpg");

                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Image not found: " + imagePath);
                }
            }
            else
            {
                MessageBox.Show("Please select a character.");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null; 
        }
    }
}