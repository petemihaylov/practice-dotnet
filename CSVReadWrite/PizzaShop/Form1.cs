using PizzaShop.Data;
using PizzaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;

namespace PizzaShop
{
    public partial class Cashier : Form
    {
        private int customerId;
        private int orderId;
        private int itemId;

        private CustomerData customerData = new CustomerData();
        private OrderData orderData = new OrderData();
        private ItemData itemData = new ItemData();

        public Cashier()
        {
            InitializeComponent();

            // Getting the largest ids
            this.customerId = customerData.GetLargestId(customerData.GetCustomers());
            this.orderId = orderData.GetLargestId(orderData.GetOrders());
            this.itemId = itemData.GetLargestId(itemData.GetItems());

            UpdateCustomerList();
            GetPizzasToppings();
            GetPizzasCrust();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;


            if (!string.IsNullOrWhiteSpace(name) || !string.IsNullOrWhiteSpace(email))
            {
                if (IsEmailValid(email))
                {
                    Customer client = new Customer(++this.customerId, name, email);

                    if (notExists(client))
                        customerData.Add(client);
                    else
                        customerData.UpdateById(client, customerData.GetCustomers());

                    UpdateCustomerList();
                }
                else
                {
                    MessageBox.Show("Invalid email!");
                }

            }
            clearFields();
        }
        public void UpdateCustomerList()
        {
            lbCustomers.Items.Clear();
            List<Customer> list = customerData.GetCustomers();

            list.Reverse();
            list.ForEach(c => lbCustomers.Items.Add(String.Format("{0, -3} {1,-25}   {2,-20}", c.ID, c.Name.Trim(), c.Email.Trim())));

            cbClients.Items.Clear();
            list.ForEach(c => cbClients.Items.Add(String.Format("{0, -3} {1, -25}", c.ID, c.Name.Trim())));
        }
        private void clearFields()
        {
            this.txtEmail.Text = "";
            this.txtName.Text = "";
        }
        private bool notExists(Customer customer)
        {
            List<Customer> list = customerData.GetCustomers();
            if (list.Find(c => c.ID == customer.ID) != null) return false;
            return true;
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
  
        private void lbCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                String item = lbCustomers.SelectedItem.ToString();
                UpdateCustomer update = new UpdateCustomer(this, int.Parse(item.Substring(0, 2)));
                update.Show();
            }
            catch (Exception ex)
            {
                // Save exception in a log file
            }

        }
        private void GetPizzasToppings()
        {
            cbPizzas.Items.Add(Topping.margherita.ToString());
            cbPizzas.Items.Add(Topping.stagioni.ToString());
            cbPizzas.Items.Add(Topping.formaggi.ToString());
            cbPizzas.Items.Add(Topping.pepperoni.ToString());
            cbPizzas.Items.Add(Topping.chicken.ToString());
        }
        private void GetPizzasCrust()
        {
            cbCrust.Items.Add(Crust.thin);
            cbCrust.Items.Add(Crust.thick);
            cbCrust.Items.Add(Crust.filled);
        }


        private void UpdatelbOrders(int orderId)
        {
            double orderTotal = 0;
            lbOrders.Items.Clear();

            Order order = orderData.GetOrderById(orderId);


            Dictionary<string, int> nameCount = new Dictionary<string, int>();
            Dictionary<string, double> namePrice = new Dictionary<string, double>();

            List<Item> list = itemData.GetItemsByOrderId(orderId);
            // Check if are there any orders
            if (list.Count > 0)
            {

                Customer customer = customerData.GetCustomerById(order.CustomerId);
                lbOrders.Items.Add("");
                lbOrders.Items.Add(" The Mario and Luigi Pizza shop");
                lbOrders.Items.Add("");
                lbOrders.Items.Add(" " + String.Concat(Enumerable.Repeat("-", 65)));


                // getting all the items
                foreach (var item in list)
                {

                    if(item.Pizza != null)
                    {

                        // only for pizzas
                        string pizzaName = item.Pizza.GetPizzaName().Trim();
                        if (nameCount.ContainsKey(pizzaName))
                        {
                            nameCount[pizzaName]++;
                        }
                        else 
                        {
                            nameCount.Add(pizzaName, 1);
                            namePrice.Add(pizzaName, item.Pizza.GetPizzaPrice());
                        }
                    }


                    if (item.Drink != null)
                    {
                        // only for drinks
                        if (nameCount.ContainsKey(item.Drink))
                        {
                            nameCount[item.Drink]++;
                        }
                        else
                        {
                            nameCount.Add(item.Drink, 1);
                            namePrice.Add(item.Drink, Drink.GetPriceByName(item.Drink));
                        }
                    }

                }

                // printing
                foreach (KeyValuePair<string, int> entry in nameCount)
                {

                    lbOrders.Items.Add(""); // new line
                    lbOrders.Items.Add(" " + entry.Key);
                
                    double productTotal = entry.Value * namePrice[entry.Key];
                    
                    lbOrders.Items.Add(string.Format(" {0, -35}{1, 20}",$"    { entry.Value} x € {namePrice[entry.Key]}",  $"€ { productTotal}"));

                    orderTotal += productTotal;
                }


                lbOrders.Items.Add("");
                
                lbOrders.Items.Add(" " + String.Concat(Enumerable.Repeat("-", 65)));
                lbOrders.Items.Add(String.Format(" {0, -35}{1,20}", "TOTAL", $"€ {orderTotal.ToString()}"));
                lbOrders.Items.Add(" " + String.Concat(Enumerable.Repeat("-", 65)));

                lbOrders.Items.Add("");
                lbOrders.Items.Add($" ORDERED BY  {customer.Name} ON {order.Timestamp.ToString("MM/dd/yyyy H:mm")}");

                order.TotalPrice = orderTotal;
                orderData.Update(order);
            }
        }
        private void cbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComboOrders();
        }
        
        private void UpdateComboOrders()
        {
            int selectedCustomerId = int.Parse(cbClients.SelectedItem.ToString().Substring(0, 2));
            cbOrder.Items.Clear();
            orderData.GetOrdersByClient(selectedCustomerId).ForEach(o => cbOrder.Items.Add(o.ID));

            // Clearing the text of order
            if (cbOrder.Items.Count > 0) cbOrder.Text = cbOrder.Text = cbOrder.Items[0].ToString();
            else cbOrder.Text = "";
        }


        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if(cbClients.SelectedIndex > -1)
            {
                int selectedCustomerId = int.Parse(cbClients.SelectedItem.ToString().Substring(0, 2));
                Order order = new Order(++orderId, selectedCustomerId, DateTime.Now);
                orderData.Add(order);
                cbOrder.Items.Add(order.ID);
                cbOrder.Text = order.ID.ToString();
            }
        }
        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            // Validation
            if(cbOrder.SelectedIndex > -1 && cbPizzas.SelectedIndex > -1 && cbCrust.SelectedIndex > -1)
            {
                try {

                    int selectedOrderId = int.Parse(cbOrder.Text);
                    Enum.TryParse(cbPizzas.SelectedItem.ToString().Trim(), out Topping topping);
                    Enum.TryParse(cbCrust.SelectedItem.ToString().Trim(), out Crust crust);

                    Item item = new Item(++itemId, selectedOrderId, new Pizza(crust, topping), null);
                    itemData.Add(item);

                    UpdatelbOrders(selectedOrderId);

                }
                catch (Exception ex)
                {
                    // Write it in a Log file
                }

            }
        }
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            // Validation
            if (cbOrder.SelectedIndex > -1 && cbDrinks.SelectedIndex > -1)
            {
                try
                {
                    int selectedOrderId = int.Parse(cbOrder.Text);
                    Item item = new Item(++itemId, selectedOrderId, null, cbDrinks.Text);
                    itemData.Add(item);

                    UpdatelbOrders(selectedOrderId);
                }
                catch (Exception ex)
                {
                    // Write it in a Log file
                }

            }
        }

        private void cbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbOrder.SelectedIndex > -1)
            {
                try { 
                     UpdatelbOrders(int.Parse(cbOrder.Text));
                }catch(FormatException ex)
                {
                    // Write it in a Log file
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbClients.SelectedIndex > -1 && cbOrder.SelectedIndex > -1)
            {
                try
                {
                    int selectedOrderId = int.Parse(cbOrder.Text);
                    lbOrders.Items.Clear();

                    itemData.DeleteByOrderId(selectedOrderId);
                    orderData.DeleteById(selectedOrderId);
                    UpdateComboOrders();

                }catch(FormatException ex)
                {
                    // Write it in a Log file
                }
            }

        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            
            string date = this.dateTimePicker.Value.ToString("MM/dd/yyyy");

            double totalRevenue = 0;
            int countOrders = 0;
            foreach (var order in orderData.GetOrders())
            {
                if(order.Timestamp.ToString("MM/dd/yyyy") == date)
                {
                    totalRevenue += order.TotalPrice;
                    countOrders++;
                }
            }
            this.lbRevenue.Visible = true;
            this.lbRevenue.Text = $"MADE:   €{totalRevenue}      FOR      {date}      ORDERS: {countOrders}";
        }

        private void btnOverview_Click(object sender, EventArgs e)
        {
            List<Order> list = orderData.GetOrders();

            list.Sort((a, b) => a.TotalPrice.CompareTo(b.TotalPrice));

            lbOrders.Items.Clear();
            lbOrders.Items.Add("");
            list.Reverse();

            foreach (var l in list)
            {
                Customer c = customerData.GetCustomerById(l.CustomerId);

                lbOrders.Items.Add(String.Format("Order: ID #{0,-10} by  {1,-30}{2,25}", l.ID, c.Name.Trim(), "€" + l.TotalPrice.ToString()));
            }
        }

        private void bntReceipt_Click(object sender, EventArgs e)
        {
            List<string> list = lbOrders.Items.Cast<string>().ToList();
            if (TxtFileWriter.PrintReceiptFor(list))
            {
                MessageBox.Show("Successfully printed in Receipt.txt");
            }
        }
    }
}
