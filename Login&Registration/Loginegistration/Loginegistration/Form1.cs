using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Loginegistration
{
    public partial class frmRegister : Form
    {


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public frmRegister()
        {
            InitializeComponent();


        }

        public frmRegister(int userId) : this()
        {
            // Additional logic to load user data based on user ID, if needed
            LoadUserData(userId);
        }


        private void LoadUserData(int userId)
        {
            try
            {
                con.Open();
                string query = "SELECT * FROM tbl_users WHERE ID = @ID";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", userId);
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Populate the text boxes with user data
                    txtUsername.Text = reader["username"].ToString();
                    // Assuming you have txtPassword and txtConfirmPassword for password fields
                    // Populate them if needed
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading user data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }



        private void label1_Click(object sender, EventArgs e)
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

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    con.Open();
                    string register = "INSERT INTO tbl_users (username, [password]) VALUES (@username, @password)";
                    cmd = new OleDbCommand(register, con);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtConfirmPassword.Text = "";

                    MessageBox.Show("Your account has been successfully created!", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Password does not match! Please re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }

            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtUsername.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FrmLogin().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
