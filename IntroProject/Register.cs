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

namespace LoginApp
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=DESKTOP-2V6003F\\MSSQLSERVER03;Initial Catalog=IntroDB;Integrated Security=True";

        private SqlConnection con;


        public Register()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPassword.Text;


            if (checkIfExists(username, con))
            {
                MessageBox.Show("Sorry try with different name!");
            }
            else
            {
                if (tbPasswordValid.Text != tbPassword.Text || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbUser.Text))
                    MessageBox.Show("Validation is not correct!");
                else executeInsert(username, password);
            }
        }

        private void CbView_CheckedChanged(object sender, EventArgs e)
        {
            if (cbView.Checked)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbPasswordValid.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbPasswordValid.UseSystemPasswordChar = true;
            }
        }
        private bool checkIfExists(string username, SqlConnection con)
        {
            SqlCommand command = new SqlCommand("SELECT count(*) FROM Users WHERE username = '" +
                username + "'", con);

            if ((int)command.ExecuteScalar() > 0) return true;
            return false;
        }
        private void executeInsert(string username, string password)
        {

            SqlCommand command;
            SqlDataReader dataReader;

            string encryptedstring = StringCipher.Encrypt(password);

            command = new SqlCommand("INSERT INTO dbo.Users([Username],[Password]) VALUES" +
                "(N'" + username + "', N'" + encryptedstring + "')", con);

            MessageBox.Show(encryptedstring);
                dataReader = command.ExecuteReader();
                dataReader.Close();

                FormLogin formLogin = new FormLogin();

                this.Close();
                formLogin.Show();

        }

    }
}

