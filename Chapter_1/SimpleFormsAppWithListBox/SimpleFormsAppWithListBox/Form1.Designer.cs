namespace SimpleFormsAppWithListBox
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
            listBox = new ListBox();
            txtBox = new TextBox();
            addbttn = new Button();
            remvbttn = new Button();
            clearbttn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(278, 29);
            label1.Name = "label1";
            label1.Size = new Size(252, 31);
            label1.TabIndex = 0;
            label1.Text = "Simple Name Viewer";
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.BackColor = Color.Gray;
            listBox.ForeColor = SystemColors.Info;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(278, 150);
            listBox.Name = "listBox";
            listBox.Size = new Size(256, 304);
            listBox.TabIndex = 1;
            listBox.SelectedIndexChanged += this.listBox_SelectedIndexChanged;
            // 
            // txtBox
            // 
            txtBox.Font = new Font("Perpetua", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBox.Location = new Point(278, 82);
            txtBox.Name = "txtBox";
            txtBox.Size = new Size(256, 26);
            txtBox.TabIndex = 2;
            // 
            // addbttn
            // 
            addbttn.BackColor = Color.FromArgb(64, 64, 64);
            addbttn.ForeColor = Color.Silver;
            addbttn.Location = new Point(552, 82);
            addbttn.Name = "addbttn";
            addbttn.Size = new Size(71, 26);
            addbttn.TabIndex = 3;
            addbttn.Text = "Add";
            addbttn.UseVisualStyleBackColor = false;
            addbttn.Click += this.addbttn_Click;
            // 
            // remvbttn
            // 
            remvbttn.BackColor = Color.FromArgb(64, 64, 64);
            remvbttn.ForeColor = Color.Silver;
            remvbttn.Location = new Point(552, 150);
            remvbttn.Name = "remvbttn";
            remvbttn.Size = new Size(71, 26);
            remvbttn.TabIndex = 4;
            remvbttn.Text = "Remove";
            remvbttn.UseVisualStyleBackColor = false;
            remvbttn.Click += this.remvbttn_Click;
            // 
            // clearbttn
            // 
            clearbttn.BackColor = Color.Silver;
            clearbttn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearbttn.Location = new Point(278, 124);
            clearbttn.Name = "clearbttn";
            clearbttn.Size = new Size(60, 20);
            clearbttn.TabIndex = 5;
            clearbttn.Text = "Clear";
            clearbttn.UseVisualStyleBackColor = false;
            clearbttn.Click += this.clearbttn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 551);
            Controls.Add(clearbttn);
            Controls.Add(remvbttn);
            Controls.Add(addbttn);
            Controls.Add(txtBox);
            Controls.Add(listBox);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox;
        private TextBox txtBox;
        private Button addbttn;
        private Button remvbttn;
        private Button clearbttn;
    }
}
