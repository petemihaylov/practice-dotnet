using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LoginApp
{
    class UserDAO
    {
        private SqlCommand command;
        private SqlDataReader dataReader;
        private SqlConnection con = new SqlConnection();
        private string connectionString = "Data Source=DESKTOP-2V6003F\\MSSQLSERVER03;Initial Catalog=IntroDB;Integrated Security=True";

        public UserDAO()
        {
            con.ConnectionString = connectionString;
            con.Open();
        }

        public string SelectPassword(string username, string password)
        {

            command = new SqlCommand("Select password from Users where username='" + username.Trim(' ', '\t', '\n', '\v', '\f', '\r', '"') + "'", con);
            command.Parameters.AddWithValue("password", "");

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return StringCipher.Decrypt(reader["password"].ToString());
                }
            }
            command.Dispose();
            return "";
        }

        public void Insert(string username, string password)
        {        
            string encryptedstring = StringCipher.Encrypt(password);

            command = new SqlCommand("INSERT INTO dbo.Users([Username],[Password]) VALUES" +
                "(N'" + username + "', N'" + encryptedstring + "')", con);

            dataReader = command.ExecuteReader();
            dataReader.Close();
        }

        public bool IfExists(string username)
        {
            command = new SqlCommand("SELECT count(*) FROM Users WHERE username = '" +
                username.Trim(' ', '\t', '\n', '\v', '\f', '\r', '"') + "'", con);
            if ((int)command.ExecuteScalar() > 0) return true;
            return false;
        }
    }
}
