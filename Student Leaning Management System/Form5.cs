using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Student_Leaning_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1J23S2A\SQLEXPRESS;Initial Catalog=SLMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string id = textBox1.Text;
                string name = textBox2.Text;
                string dob = textBox3.Text;
                string address = textBox4.Text;
                string contact = textBox5.Text;

                string sql_insert = "INSERT INTO student_r(ID,Name,DOB,Address,Contact)VALUES(@ID, @Name, @DOB, @Address, @Contact)";

                SqlCommand cmd = new SqlCommand(sql_insert, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Contact", contact);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string id = textBox1.Text;
            string sql_search = "SELECT * from student_r WHERE ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql_search, con);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox2.Text = r[1].ToString();
                textBox3.Text = r[2].ToString();
                textBox4.Text = r[3].ToString();
                textBox5.Text = r[4].ToString();
                MessageBox.Show("Found Successfully");
            }
            else
            {

                textBox2.Text = null;
                textBox3 = null;
                textBox4 = null;
                textBox5 = null;
                MessageBox.Show("NOT Found");

                con.Close();
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = textBox1.Text;
                string name = textBox2.Text;
                string dob = textBox3.Text;
                string address = textBox4.Text;
                string contact = textBox5.Text;

                string sql_update = "UPDATE student_r SET Name=@Name, DOB=@DOB, Address=@Address, Contact=@Contact WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql_update, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Contact", contact);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated Successfully");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string id = textBox1.Text;

                string sql_delete = "DELETE FROM student_r WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql_delete, con);
                cmd.Parameters.AddWithValue("@ID", id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("No records found to delete.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM student_r", con);
                DataTable t = new DataTable();
                data.Fill(t);

                dataGridView1.DataSource = t;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

