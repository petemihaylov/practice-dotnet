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
        private string connectionString = "Data Source=DESKTOP-2V6003F\\MSSQLSERVER03;Initial Catalog=IntroDB;Integrated Security=True";
        


        public FormLogin()
        {
            InitializeComponent();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SqlCommand command;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();

            string username = tbUsername.Text;
            string password = tbPassword.Text;


            command = new SqlCommand("Select password from Users where username='" + 
                username + "'", con);

            command.Parameters.AddWithValue("password","");
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {  
                    string decrypt= StringCipher.Decrypt(reader["password"].ToString());
                    if (password == decrypt)
                    {
                        this.Hide();
                        CashierApp cashier = new CashierApp();

                        cashier.Closed += (s, args) => this.Close();  
                        cashier.Show();
                    }
                    else MessageBox.Show("Invalid input!");
                }
            }

            
            command.Dispose();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Closed += (s, args) => this.Close();
            r.Show();
        }
    }
}
