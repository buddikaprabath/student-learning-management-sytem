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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Leaning_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1J23S2A\SQLEXPRESS;Initial Catalog=SLMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string id = textBox1.Text;
                string sub_name = textBox2.Text;


                string sql_insert = "INSERT INTO Subjects(ID,Sub_Name)VALUES(@ID, @Name)";

                SqlCommand cmd = new SqlCommand(sql_insert, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", sub_name);


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
            string sql_search = "SELECT * from Subjects WHERE ID='" + id + "'";
            SqlCommand cmd = new SqlCommand(sql_search, con);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox2.Text = r[1].ToString();

                MessageBox.Show("Found Successfully");
            }
            else
            {

                textBox2.Text = null;

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
                string sub_name = textBox2.Text;


                string sql_update = "UPDATE Subjects SET Sub_Name=@Name WHERE ID=@ID";

                SqlCommand cmd = new SqlCommand(sql_update, con);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Name", sub_name);


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

                string sql_delete = "DELETE FROM Subjects WHERE ID=@ID";

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

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Subjects", con);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
