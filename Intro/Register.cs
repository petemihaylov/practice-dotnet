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
        private string username;
        private string password;
        private UserDAO dao = new UserDAO();

        public Register()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            username = tbUser.Text;
            password = tbPassword.Text;

            if (dao.IfExists(username))
                MessageBox.Show("Sorry try with a different username!");
            else
            {
                if (tbPasswordValid.Text != tbPassword.Text || string.IsNullOrWhiteSpace(tbPassword.Text) || string.IsNullOrWhiteSpace(tbUser.Text))
                    MessageBox.Show("Password validation is not correct!");
                else {

                    dao.Insert(username, password);

                    this.Hide();
                    FormLogin formLogin = new FormLogin();
                    formLogin.Closed += (s, args) => this.Close();
                    formLogin.Show();
                }
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

    }
}

