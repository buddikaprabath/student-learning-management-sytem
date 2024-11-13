namespace Student_Leaning_Management_System
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 25);
            label1.Name = "label1";
            label1.Size = new Size(251, 22);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label2.Location = new Point(78, 88);
            label2.Name = "label2";
            label2.Size = new Size(24, 17);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label3.Location = new Point(59, 144);
            label3.Name = "label3";
            label3.Size = new Size(50, 17);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label4.Location = new Point(59, 198);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 3;
            label4.Text = "DOB ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label5.Location = new Point(48, 260);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 4;
            label5.Text = "Address";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F);
            label6.Location = new Point(48, 316);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 5;
            label6.Text = "Contact";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 25);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 141);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 25);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(134, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 25);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 25);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(129, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(225, 25);
            textBox5.TabIndex = 10;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(32, 398);
            button1.Name = "button1";
            button1.Size = new Size(111, 42);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(150, 396);
            button2.Name = "button2";
            button2.Size = new Size(109, 42);
            button2.TabIndex = 12;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button3.Location = new Point(265, 396);
            button3.Name = "button3";
            button3.Size = new Size(97, 42);
            button3.TabIndex = 13;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button4.Location = new Point(369, 396);
            button4.Name = "button4";
            button4.Size = new Size(109, 42);
            button4.TabIndex = 14;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button5.Location = new Point(485, 399);
            button5.Name = "button5";
            button5.Size = new Size(103, 41);
            button5.TabIndex = 15;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button6.Location = new Point(594, 399);
            button6.Name = "button6";
            button6.Size = new Size(99, 39);
            button6.TabIndex = 16;
            button6.Text = "Refresh";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(381, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 284);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button7.Location = new Point(723, 399);
            button7.Name = "button7";
            button7.Size = new Size(110, 36);
            button7.TabIndex = 18;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(886, 536);
            Controls.Add(button7);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private Button button7;
    }
}