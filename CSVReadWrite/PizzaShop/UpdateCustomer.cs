using System;
using PizzaShop.Data;
using System.Net.Mail;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class UpdateCustomer : Form
    {
        private Cashier cashier;
        private CustomerData customerData = new CustomerData();

        private Customer customer;
        private int id;
        public UpdateCustomer(Cashier cashier, int id)
        {
            InitializeComponent();
            this.cashier = cashier;
            this.id = id;
            this.customer = customerData.GetCustomerById(id);
            this.txtEmail.Text = customer.Email.Trim();
            this.txtName.Text = customer.Name.Trim();
        }

        private void clearFields()
        {
            this.txtEmail.Text = "";
            this.txtName.Text = "";
        }
        private bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;


            if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(email))
            {
                if (IsEmailValid(email))
                {
                    Customer client = new Customer(id, name, email);
                    customerData.UpdateById(client, customerData.GetCustomers());
                    cashier.UpdateCustomerList();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email!");
                }

            }
            clearFields();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            customerData.DeleteById(this.customer, customerData.GetCustomers());
            cashier.UpdateCustomerList();

            this.Close();
        }
    }
}