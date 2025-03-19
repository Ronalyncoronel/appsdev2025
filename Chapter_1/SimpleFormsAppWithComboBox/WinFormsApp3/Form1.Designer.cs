namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            selectbtn = new Button();
            comboBox1 = new ComboBox();
            cuisine = new Label();
            panel2 = new Panel();
            clearbtn = new Button();
            removebtn = new Button();
            listBox1 = new ListBox();
            favfood = new Label();
            panel3 = new Panel();
            addbtn = new Button();
            checkedListBox1 = new CheckedListBox();
            foodlist = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Picker App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Simple Favorite Food";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(selectbtn);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(cuisine);
            panel1.Location = new Point(77, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 103);
            panel1.TabIndex = 2;
            // 
            // selectbtn
            // 
            selectbtn.BackColor = Color.Transparent;
            selectbtn.BackgroundImage = (Image)resources.GetObject("selectbtn.BackgroundImage");
            selectbtn.FlatStyle = FlatStyle.Popup;
            selectbtn.ForeColor = Color.Silver;
            selectbtn.Location = new Point(270, 55);
            selectbtn.Name = "selectbtn";
            selectbtn.Size = new Size(75, 23);
            selectbtn.TabIndex = 2;
            selectbtn.Text = "Select";
            selectbtn.UseVisualStyleBackColor = false;
            selectbtn.Click += selectbtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Silver;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Sitka Display", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(45, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 27);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cuisine
            // 
            cuisine.AutoSize = true;
            cuisine.BackColor = Color.Transparent;
            cuisine.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuisine.ForeColor = Color.FromArgb(192, 192, 0);
            cuisine.Location = new Point(133, 17);
            cuisine.Name = "cuisine";
            cuisine.Size = new Size(81, 21);
            cuisine.TabIndex = 0;
            cuisine.Text = "C u i s i n e";
            cuisine.Click += cuisine_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(clearbtn);
            panel2.Controls.Add(removebtn);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(favfood);
            panel2.Location = new Point(567, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 393);
            panel2.TabIndex = 3;
            // 
            // clearbtn
            // 
            clearbtn.BackgroundImage = (Image)resources.GetObject("clearbtn.BackgroundImage");
            clearbtn.FlatStyle = FlatStyle.Popup;
            clearbtn.ForeColor = Color.Silver;
            clearbtn.Location = new Point(282, 184);
            clearbtn.Name = "clearbtn";
            clearbtn.Size = new Size(75, 23);
            clearbtn.TabIndex = 3;
            clearbtn.Text = "Clear All";
            clearbtn.UseVisualStyleBackColor = true;
            clearbtn.Click += clearbtn_Click;
            // 
            // removebtn
            // 
            removebtn.BackgroundImage = (Image)resources.GetObject("removebtn.BackgroundImage");
            removebtn.FlatStyle = FlatStyle.Popup;
            removebtn.ForeColor = Color.Silver;
            removebtn.Location = new Point(282, 138);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(75, 23);
            removebtn.TabIndex = 2;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += removebtn_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Silver;
            listBox1.Font = new Font("Sitka Display", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(44, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(212, 232);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // favfood
            // 
            favfood.AutoSize = true;
            favfood.BackColor = Color.Transparent;
            favfood.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            favfood.ForeColor = Color.FromArgb(192, 192, 0);
            favfood.Location = new Point(105, 67);
            favfood.Name = "favfood";
            favfood.Size = new Size(176, 21);
            favfood.TabIndex = 0;
            favfood.Text = "M y  F a v o r i t e  F o o d";
            favfood.Click += favfood_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(addbtn);
            panel3.Controls.Add(checkedListBox1);
            panel3.Controls.Add(foodlist);
            panel3.Location = new Point(77, 257);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 255);
            panel3.TabIndex = 4;
            // 
            // addbtn
            // 
            addbtn.BackgroundImage = (Image)resources.GetObject("addbtn.BackgroundImage");
            addbtn.FlatStyle = FlatStyle.Popup;
            addbtn.ForeColor = Color.Silver;
            addbtn.Location = new Point(270, 78);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 2;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Silver;
            checkedListBox1.Font = new Font("Sitka Display", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(45, 78);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(204, 148);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // foodlist
            // 
            foodlist.AutoSize = true;
            foodlist.BackColor = Color.Transparent;
            foodlist.Font = new Font("Sitka Subheading", 11.249999F, FontStyle.Italic, GraphicsUnit.Point, 0);
            foodlist.ForeColor = Color.FromArgb(192, 192, 0);
            foodlist.Location = new Point(133, 27);
            foodlist.Name = "foodlist";
            foodlist.Size = new Size(98, 21);
            foodlist.TabIndex = 0;
            foodlist.Text = "F o o d  L i s t";
            foodlist.Click += foodlist_Click;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.Location = new Point(502, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(13, 393);
            panel4.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1023, 539);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Food Form App";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button selectbtn;
        private ComboBox comboBox1;
        private Label cuisine;
        private Panel panel2;
        private Button clearbtn;
        private Button removebtn;
        private ListBox listBox1;
        private Label favfood;
        private Panel panel3;
        private Button addbtn;
        private CheckedListBox checkedListBox1;
        private Label foodlist;
        private Panel panel4;
    }
}
