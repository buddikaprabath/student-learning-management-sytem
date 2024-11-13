namespace Student_Leaning_Management_System
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;
        private Button button1;
        private DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            saveFileDialog1 = new SaveFileDialog();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button1.Location = new Point(35, 36);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 0;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(162, 133);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(543, 340);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            button2.Location = new Point(755, 39);
            button2.Name = "button2";
            button2.Size = new Size(113, 44);
            button2.TabIndex = 2;
            button2.Text = "LOG OUT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(887, 525);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private SaveFileDialog saveFileDialog1;
        private Button button2;
    }
}