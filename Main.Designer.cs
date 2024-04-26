namespace CS162_Lab4
{
    partial class Main
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
            groupBox1 = new GroupBox();
            contact_ListBox = new ListBox();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(contact_ListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(527, 258);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select A Person";
            // 
            // contact_ListBox
            // 
            contact_ListBox.FormattingEnabled = true;
            contact_ListBox.ItemHeight = 15;
            contact_ListBox.Location = new Point(6, 22);
            contact_ListBox.Name = "contact_ListBox";
            contact_ListBox.Size = new Size(515, 229);
            contact_ListBox.TabIndex = 0;
            contact_ListBox.SelectedIndexChanged += contact_ListBox_SelectedIndexChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(238, 276);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 1;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 308);
            Controls.Add(exitButton);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "Main";
            Load += main_OnLoad;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox contact_ListBox;
        private Button exitButton;
    }
}
