namespace CS162_Lab4
{
    partial class PersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            name_Label = new Label();
            groupBox2 = new GroupBox();
            email_Label = new Label();
            groupBox3 = new GroupBox();
            phone_Label = new Label();
            close_Button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(name_Label);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Name";
            // 
            // name_Label
            // 
            name_Label.BackColor = SystemColors.ControlLight;
            name_Label.Location = new Point(6, 19);
            name_Label.Name = "name_Label";
            name_Label.Size = new Size(295, 36);
            name_Label.TabIndex = 0;
            name_Label.Text = "label1";
            name_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(email_Label);
            groupBox2.Location = new Point(12, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 62);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Email";
            // 
            // email_Label
            // 
            email_Label.BackColor = SystemColors.ControlLight;
            email_Label.Location = new Point(6, 19);
            email_Label.Name = "email_Label";
            email_Label.Size = new Size(295, 36);
            email_Label.TabIndex = 0;
            email_Label.Text = "label2";
            email_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(phone_Label);
            groupBox3.Location = new Point(12, 148);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 62);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Phone";
            // 
            // phone_Label
            // 
            phone_Label.BackColor = SystemColors.ControlLight;
            phone_Label.Location = new Point(6, 19);
            phone_Label.Name = "phone_Label";
            phone_Label.Size = new Size(295, 36);
            phone_Label.TabIndex = 0;
            phone_Label.Text = "label3";
            phone_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // close_Button
            // 
            close_Button.Location = new Point(122, 216);
            close_Button.Name = "close_Button";
            close_Button.Size = new Size(75, 23);
            close_Button.TabIndex = 3;
            close_Button.Text = "Close";
            close_Button.UseVisualStyleBackColor = true;
            close_Button.Click += close_Button_Click;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 250);
            Controls.Add(close_Button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PersonForm";
            Text = "PersonForm";
            Load += form_OnLoad;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label name_Label;
        private GroupBox groupBox2;
        private Label email_Label;
        private GroupBox groupBox3;
        private Label phone_Label;
        private Button close_Button;
    }
}