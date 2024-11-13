namespace Student_Leaning_Management_System
{
    partial class TeacherForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            textBox1 = new TextBox();
            btnDelete = new Button();
            comboBox1 = new ComboBox();
            ofd = new OpenFileDialog();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(243, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(478, 317);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(61, 212);
            button1.Name = "button1";
            button1.Size = new Size(96, 45);
            button1.TabIndex = 1;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnDelete.Location = new Point(61, 318);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 99);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 4;
            // 
            // ofd
            // 
            ofd.FileName = "openFileDialog1";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(638, 12);
            button2.Name = "button2";
            button2.Size = new Size(83, 48);
            button2.TabIndex = 5;
            button2.Text = "LOG OUT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(btnDelete);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "TeacherForm";
            Text = "Form8";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox textBox1;
        private Button btnDelete;
        private ComboBox comboBox1;
        private OpenFileDialog ofd;
        private Button button2;
    }
}