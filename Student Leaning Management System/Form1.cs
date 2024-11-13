using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Student_Leaning_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-1J23S2A\\SQLEXPRESS;Initial Catalog=SLMS_DB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Corrected SQL query with parameters to prevent SQL injection
                string query = "SELECT * FROM login WHERE username = @Username AND password = @Password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", txtuser.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Check if user credentials are correct
                if (dt.Rows.Count > 0)
                {
                    string userType = dt.Rows[0]["usertype"].ToString();

                    // Check selected user type from ComboBox
                    string cmbItemValue = comboBox1.SelectedItem?.ToString();
                    if (cmbItemValue != null && userType == cmbItemValue)
                    {
                        MessageBox.Show("You are logged in as: " + dt.Rows[0]["username"]);

                        // Open respective forms based on user type
                        switch (comboBox1.SelectedIndex)
                        {
                            case 0:
                                Form2 f = new Form2();
                                f.Show();
                                break;
                            case 1:

                                TeacherForm f7 = new TeacherForm();
                                f7.Show();
                                break;
                            default:
                                Form7 F7 = new Form7();
                                F7.Show();
                                break;
                        }

                        this.Hide(); // Hide the current login form after successful login
                    }
                    else
                    {
                        MessageBox.Show("Selected user type does not match the user's role.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}