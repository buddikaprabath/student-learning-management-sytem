using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Leaning_Management_System
{

    public partial class Form7 : Form
    {
        private string connectionString = "Data Source=DESKTOP-1J23S2A\\SQLEXPRESS;Initial Catalog=SLMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private int selectedFileId;

        public Form7()
        {
            InitializeComponent();
            dataGridView1.DataError += DataGridView1_DataError; // Handle data errors
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void LoadFiles()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT id, file_name, uploaded_time, description, sub_id FROM fiels", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                // Optionally adjust column headers for better readability
                dataGridView1.Columns["id"].HeaderText = "File ID";
                dataGridView1.Columns["file_name"].HeaderText = "File Name";
                dataGridView1.Columns["uploaded_time"].HeaderText = "Uploaded Time";
                dataGridView1.Columns["description"].HeaderText = "Description";
                dataGridView1.Columns["sub_id"].HeaderText = "Subject ID";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedFileId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                DownloadFile(selectedFileId);
            }
            else
            {
                MessageBox.Show("Please select a file to download.");
            }
        }

        private void DownloadFile(int fileId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT [file], file_name FROM fiels WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", fileId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!(reader["file"] is DBNull))
                    {
                        byte[] fileData = (byte[])reader["file"];
                        string fileName = reader["file_name"].ToString();

                        SaveFileDialog saveFileDialog = new SaveFileDialog();
                        saveFileDialog.FileName = fileName;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, fileData);
                            MessageBox.Show("File downloaded successfully.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("File data is null or empty.");
                    }
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // Suppress the default error dialog
            MessageBox.Show($"Error occurred: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle comboBox selected index change if needed
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}