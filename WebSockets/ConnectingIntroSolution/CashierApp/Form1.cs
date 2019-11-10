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
        private int count_orders = 1;
        private double sum= 0.0;
        WebSocket ws;

        public App()
        {
            InitializeComponent();
            setSizes();
            ws = new WebSocket();
            
        }
        private void setSizes()
        {
            cmbSIzes.Items.Add("S");
            cmbSIzes.Items.Add("M");
            cmbSIzes.Items.Add("L");
            cmbSIzes.Text = "L";
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
            dataGridView.RowTemplate.Height = 50;
            dataGridView.RowHeadersVisible = false;

            // add columns to datagridview
            dataGridView.Columns.Add(dgvIdColumn);
            dataGridView.Columns.Add(dgvImageColumn);


            dataGridView.Rows.Add("Calzone", CashierApp.Properties.Resources.calzone);
            dataGridView.Rows.Add("Hawaii", CashierApp.Properties.Resources.hawaii);
            dataGridView.Rows.Add("Margarita", CashierApp.Properties.Resources.pizza);
            dataGridView.Rows.Add("Quattro Stagioni", CashierApp.Properties.Resources.some_pizza);

            dataGridView.Rows.Add("Calzone", CashierApp.Properties.Resources.calzone);
            dataGridView.Rows.Add("Hawaii", CashierApp.Properties.Resources.hawaii);
            dataGridView.Rows.Add("Margarita", CashierApp.Properties.Resources.pizza);
            dataGridView.Rows.Add("Quattro Stagioni", CashierApp.Properties.Resources.some_pizza);

            dataGridView.Rows.Add("Calzone", CashierApp.Properties.Resources.calzone);
            dataGridView.Rows.Add("Hawaii", CashierApp.Properties.Resources.hawaii);
            dataGridView.Rows.Add("Margarita", CashierApp.Properties.Resources.pizza);
            dataGridView.Rows.Add("Quattro Stagioni", CashierApp.Properties.Resources.some_pizza);
            ws.connect(ws.GetLocalIP(), "8080",  ws.GetLocalIP(), "8081");
            

        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            var data = dataGridView.CurrentRow;
            selectedPizza.Text = data.Cells[0].Value.ToString();
        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void BtnAsc_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
            count_orders = 1;
            itemsCount.Text = "0";
            sum = 0;
            totalPrice.Text = "";
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            foreach (var item in listOrders.Items){
                ws.sendMsg(item.ToString());
            }

            listOrders.Items.Clear();
            count_orders = 1;
            itemsCount.Text = "0";
            sum = 0;
            totalPrice.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            listOrders.Items.Add(" *" + selectedPizza.Text + ", " + "size: " + cmbSIzes.Text);

            itemsCount.Text = (count_orders++).ToString();
            sum += double.Parse(txtPrice.Text);
            totalPrice.Text = sum.ToString() + "$";
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss") + " HH";
        }

        private void TimerListOrder_Tick(object sender, EventArgs e)
        {
            foreach (var item in ws.messages)
            {
               if(item == "ready")listBox1.Invoke(new Action(() => listBox1.Items.Add(item)));
            }


            ws.messages.Clear();
        }
    }
}
