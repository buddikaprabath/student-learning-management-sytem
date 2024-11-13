
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Student_Leaning_Management_System
    {
    public partial class TeacherForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-1J23S2A\SQLEXPRESS;Initial Catalog=SLMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public TeacherForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadFiles();
            dataGridView1.DataError += DataGridView1_DataError;
            btnDelete.Click += BtnDelete_Click;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadSubjects()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, sub_name FROM Subjects", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DisplayMember = "sub_name";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = dt;
            }
        }

        private void LoadFiles()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Alias the id columns to avoid ambiguity
                SqlDataAdapter da = new SqlDataAdapter("SELECT f.id AS file_id, f.file_name, f.uploaded_time, f.description, s.sub_name " +
                                                        "FROM fiels f " +
                                                        "JOIN Subjects s ON f.sub_id = s.id", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
       

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Use the alias "file_id" instead of "id"
                int fileId = (int)dataGridView1.SelectedRows[0].Cells["file_id"].Value;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM fiels WHERE id = @id", con);
                    cmd.Parameters.AddWithValue("@id", fileId);
                    cmd.ExecuteNonQuery();
                }

                LoadFiles();
                MessageBox.Show("File deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a file to delete.");
            }
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;  // Suppress the default error dialog
            MessageBox.Show($"Error occurred: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    byte[] fileData = File.ReadAllBytes(ofd.FileName);
                    string fileName = Path.GetFileName(ofd.FileName);
                    string description = textBox1.Text;
                    int subId = (int)comboBox1.SelectedValue;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO fiels ([file], file_name, uploaded_time, description, sub_id) " +
                                                        "VALUES (@file, @file_name, @uploaded_time, @description, @sub_id)", con);
                        cmd.Parameters.AddWithValue("@file", fileData);
                        cmd.Parameters.AddWithValue("@file_name", fileName);
                        cmd.Parameters.AddWithValue("@uploaded_time", DateTime.Now);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@sub_id", subId);
                        cmd.ExecuteNonQuery();
                    }

                    LoadFiles();
                    MessageBox.Show("File uploaded successfully.");
                }
            }
        }
    }
}
