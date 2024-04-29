using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Loginegistration
{
    public partial class dashboard : Form
    {

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbDataAdapter da;
        DataTable dt;


        public dashboard()
        {
            InitializeComponent();
            LoadData();
        }

        
        private void LoadData()
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tbl_users";
                using (OleDbDataAdapter da = new OleDbDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string register = "INSERT INTO tbl_users (username, [password]) VALUES (@username, @password)";
                using (OleDbCommand cmd = new OleDbCommand(register, con))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Your account has been successfully created!", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh the data grid after adding a new record
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
            if (selectedRowIndex >= 0)
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Username and Password fields are empty", "Update Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string username = txtUsername.Text;
                try
                {
                    con.Open();
                    string update = "UPDATE tbl_users SET [password] = @password WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(update, con))
                    {
                        cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh the data grid after updating a record
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int selectedRowIndex = dataGridView1.CurrentCell?.RowIndex ?? -1;
                if (selectedRowIndex >= 0)
                {
                    string username = dataGridView1.Rows[selectedRowIndex].Cells["username"].Value.ToString();
                    if (MessageBox.Show($"Are you sure you want to delete the record for user '{username}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteRecord(username);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

             void DeleteRecord(string username)
            {
                try
                {
                    con.Open();
                    string query = "DELETE FROM tbl_users WHERE username = @username";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); // Refresh the data grid after deleting a record
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

        }

    }
}

