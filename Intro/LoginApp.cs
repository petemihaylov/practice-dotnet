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
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            this.username = tbUsername.Text;
            this.password = tbPassword.Text;

            UserDAO dao = new UserDAO();
            string decrypt = dao.SelectPassword(username, password);

            if (password == decrypt){


                if (username == "cooker")
                {
                    this.Hide();

                    CookApp cookApp = new CookApp();
                    cookApp.Closed += (s, args) => this.Close();
                    cookApp.Show();
                }
                else {
                    this.Hide();

                    CashierApp cashier = new CashierApp();
                    cashier.Closed += (s, args) => this.Close();
                    cashier.Show();
                }
                
            }
            else MessageBox.Show("ERROR! Invalid input!");

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.Closed += (s, args) => this.Close();
            register.Show();
        }

    }
}
