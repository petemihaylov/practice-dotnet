using chatApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CashierApp
{
    public partial class App : Form
    {
        private int countOrders;
        private double priceSummation;
        WebSocket ws;

        public App()
        {
            InitializeComponent();
            setSizes();

            //set up web sockets
            this.ws = new WebSocket();
            ws.connect(ws.GetLocalIP(), "8080", ws.GetLocalIP(), "8081");

            this.countOrders = 1;
            this.priceSummation = 0.0;
            cmbSIzes.Text = "L";
        }
        private void setSizes()
        {
            cmbSIzes.Items.Add("S");
            cmbSIzes.Items.Add("M");
            cmbSIzes.Items.Add("L");
        }
        private void ResetElements()
        {
            listOrders.Items.Clear();
            countOrders = 1;
            itemsCount.Text = "0";
            priceSummation = 0;
            totalPrice.Text = "";
        }


        private void CashierApp_Load(object sender, EventArgs e)
        {
            //set a header text to DataGridView Image Column
            DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
            dgvImageColumn.HeaderText = "Image";
            dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
            dgvIdColumn.HeaderText = "Id";

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 50;

            // add columns to datagridview
            dataGridView.Columns.Add(dgvIdColumn);
            dataGridView.Columns.Add(dgvImageColumn);

            // add rows from DB for example
            dataGridView.Rows.Add("Calzone", CashierApp.Properties.Resources.calzone);
            dataGridView.Rows.Add("Hawaii", CashierApp.Properties.Resources.hawaii);
            dataGridView.Rows.Add("Margarita", CashierApp.Properties.Resources.pizza);
            dataGridView.Rows.Add("Quattro Stagioni", CashierApp.Properties.Resources.some_pizza);

            dataGridView.Rows.Add("Vegan", CashierApp.Properties.Resources.vegan);
            dataGridView.Rows.Add("Neapolitan", CashierApp.Properties.Resources.hawaii);
            dataGridView.Rows.Add("Sicilian", CashierApp.Properties.Resources.pizza);
            dataGridView.Rows.Add("Maltese", CashierApp.Properties.Resources.some_pizza);

            dataGridView.Rows.Add("Fanta", CashierApp.Properties.Resources.fanta);
            dataGridView.Rows.Add("Coca-Cola", CashierApp.Properties.Resources.cola);
            dataGridView.Rows.Add("Sprite", CashierApp.Properties.Resources.sprite);
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            var data = dataGridView.CurrentRow;
            selectedPizza.Text = data.Cells[0].Value.ToString();
        }

        //Filtering
        private void BtnDesc_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void BtnAsc_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
        }

        // Delete and reset
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ResetElements();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            foreach (var item in listOrders.Items)
                ws.sendMsg(item.ToString());
            
            ResetElements();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            listOrders.Items.Add(" *" + selectedPizza.Text + ", " + "size: " + cmbSIzes.Text);

            itemsCount.Text = (countOrders++).ToString();
            priceSummation += double.Parse(txtPrice.Text);
            totalPrice.Text = priceSummation.ToString() + "$";
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss") + " HH";
        }

        // Display received data to the listBox
        private void TimerListOrder_Tick(object sender, EventArgs e)
        {
            foreach (var item in ws.messages)
            {
                 listBox.Invoke(new Action(() => listBox.Items.Add(item)));
            }
            ws.messages.Clear();
        }
    }
}
