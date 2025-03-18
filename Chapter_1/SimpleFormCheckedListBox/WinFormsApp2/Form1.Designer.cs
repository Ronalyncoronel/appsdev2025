namespace WinFormsApp2
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
            Movielabel = new Label();
            Proglabel = new Label();
            MoviecheckedListBox = new CheckedListBox();
            listBox = new ListBox();
            listBox2 = new ListBox();
            Addbutton1 = new Button();
            remvbutton2 = new Button();
            clearbutton3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(32, 49);
            label1.Name = "label1";
            label1.Size = new Size(219, 19);
            label1.TabIndex = 0;
            label1.Text = "Simple Favorite Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("SimSun-ExtB", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(32, 19);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 1;
            label2.Text = "Picker App";
            // 
            // Movielabel
            // 
            Movielabel.AutoSize = true;
            Movielabel.BackColor = Color.Transparent;
            Movielabel.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Movielabel.ForeColor = Color.FromArgb(128, 64, 64);
            Movielabel.Location = new Point(136, 124);
            Movielabel.Name = "Movielabel";
            Movielabel.Size = new Size(131, 17);
            Movielabel.TabIndex = 2;
            Movielabel.Text = "Movie/ Series List";
            Movielabel.Click += Movielabel_Click;
            // 
            // Proglabel
            // 
            Proglabel.AutoSize = true;
            Proglabel.BackColor = Color.Transparent;
            Proglabel.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Proglabel.ForeColor = Color.FromArgb(128, 64, 64);
            Proglabel.Location = new Point(508, 124);
            Proglabel.Name = "Proglabel";
            Proglabel.Size = new Size(207, 17);
            Proglabel.TabIndex = 3;
            Proglabel.Text = "My Programming Languages";
            Proglabel.Click += Proglabel_Click;
            // 
            // MoviecheckedListBox
            // 
            MoviecheckedListBox.BackColor = SystemColors.ScrollBar;
            MoviecheckedListBox.BorderStyle = BorderStyle.None;
            MoviecheckedListBox.FormattingEnabled = true;
            MoviecheckedListBox.Location = new Point(136, 160);
            MoviecheckedListBox.Name = "MoviecheckedListBox";
            MoviecheckedListBox.Size = new Size(217, 198);
            MoviecheckedListBox.TabIndex = 4;
            MoviecheckedListBox.SelectedIndexChanged += MoviecheckedListBox_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.ScrollBar;
            listBox.BorderStyle = BorderStyle.None;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(508, 160);
            listBox.Name = "listBox";
            listBox.Size = new Size(275, 195);
            listBox.TabIndex = 5;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(64, 64, 64);
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(425, 124);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(10, 345);
            listBox2.TabIndex = 6;
            // 
            // Addbutton1
            // 
            Addbutton1.Location = new Point(186, 381);
            Addbutton1.Name = "Addbutton1";
            Addbutton1.Size = new Size(109, 37);
            Addbutton1.TabIndex = 7;
            Addbutton1.Text = "Add";
            Addbutton1.UseVisualStyleBackColor = true;
            Addbutton1.Click += Addbutton1_Click;
            // 
            // remvbutton2
            // 
            remvbutton2.Location = new Point(816, 160);
            remvbutton2.Name = "remvbutton2";
            remvbutton2.Size = new Size(109, 37);
            remvbutton2.TabIndex = 8;
            remvbutton2.Text = "Remove";
            remvbutton2.UseVisualStyleBackColor = true;
            remvbutton2.Click += remvbutton2_Click;
            // 
            // clearbutton3
            // 
            clearbutton3.Location = new Point(816, 240);
            clearbutton3.Name = "clearbutton3";
            clearbutton3.Size = new Size(109, 37);
            clearbutton3.TabIndex = 9;
            clearbutton3.Text = "Clear All";
            clearbutton3.UseVisualStyleBackColor = true;
            clearbutton3.Click += clearbutton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 539);
            Controls.Add(clearbutton3);
            Controls.Add(remvbutton2);
            Controls.Add(Addbutton1);
            Controls.Add(listBox2);
            Controls.Add(listBox);
            Controls.Add(MoviecheckedListBox);
            Controls.Add(Proglabel);
            Controls.Add(Movielabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Movie Form App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label Movielabel;
        private Label Proglabel;
        private CheckedListBox MoviecheckedListBox;
        private ListBox listBox;
        private ListBox listBox2;
        private Button Addbutton1;
        private Button remvbutton2;
        private Button clearbutton3;
    }
}
