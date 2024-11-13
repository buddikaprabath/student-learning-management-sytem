namespace Student_Leaning_Management_System
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
            label2 = new Label();
            label3 = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 15.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(221, 240);
            label2.Name = "label2";
            label2.Size = new Size(129, 24);
            label2.TabIndex = 1;
            label2.Text = "User Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 15.75F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(221, 348);
            label3.Name = "label3";
            label3.Size = new Size(117, 24);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            label3.Click += label3_Click;
            // 
            // txtuser
            // 
            txtuser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtuser.Location = new Point(396, 240);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(237, 33);
            txtuser.TabIndex = 3;
            txtuser.TextChanged += textBox1_TextChanged;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(396, 345);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(237, 33);
            txtpass.TabIndex = 4;
            txtpass.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Arial Rounded MT Bold", 15.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(164, 147);
            label4.Name = "label4";
            label4.Size = new Size(182, 26);
            label4.TabIndex = 5;
            label4.Text = "Select User Type";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "teacher", "student" });
            comboBox1.Location = new Point(396, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(237, 33);
            comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkGreen;
            button1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(368, 449);
            button1.Name = "button1";
            button1.Size = new Size(115, 48);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(871, 546);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtuser;
        private TextBox txtpass;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
    }
}
