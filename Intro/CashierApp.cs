using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class CashierApp : Form
    {
        private List<string> list = new List<string>();
        private int index = 1;
        private double sum = 0.0;

        public CashierApp()
        {
            InitializeComponent();
        }
        private void CashierApp_Load(object sender, EventArgs e)
        {

                        //set a header text to DataGridView Image Column
                        DataGridViewImageColumn dgvImageColumn = new DataGridViewImageColumn();
                        dgvImageColumn.HeaderText = "Image";
                        dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

                        DataGridViewTextBoxColumn dgvIdColumn = new DataGridViewTextBoxColumn();
                        dgvIdColumn.HeaderText = "Id";

                        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                        cmb.HeaderText = "Select Size";
                        cmb.MaxDropDownItems = 3;
                        cmb.Items.Add("L");
                        cmb.Items.Add("M");
                        cmb.Items.Add("S");

                        DataGridViewTextBoxColumn dgvPriceColumn = new DataGridViewTextBoxColumn();
                        dgvPriceColumn.HeaderText = "Price $";

                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView.AllowUserToAddRows = false;
                        dataGridView.AllowUserToAddRows = false;
                        dataGridView.RowTemplate.Height = 50;

                        // add columns to datagridview
                        dataGridView.Columns.Add(dgvIdColumn);
                        dataGridView.Columns.Add(cmb);
                        dataGridView.Columns.Add(dgvImageColumn);
                        dataGridView.Columns.Add(dgvPriceColumn);


                        dataGridView.Rows.Add("Calzone","L",LoginApp.Properties.Resources.calzone, "9.55");
                        dataGridView.Rows.Add("Hawaii", "S",LoginApp.Properties.Resources.hawaii, "4.55");
                        dataGridView.Rows.Add("Margarita", "L", LoginApp.Properties.Resources.pizza, "9.55");
                        dataGridView.Rows.Add("Quattro Stagioni", "M", LoginApp.Properties.Resources.pizza2, "5.55");
                        dataGridView.Rows.Add("Sicilian", "L", LoginApp.Properties.Resources.calzone, "9.55");
                        dataGridView.Rows.Add("Chicago", "S", LoginApp.Properties.Resources.hawaii, "4.55");
                        dataGridView.Rows.Add("Detroit", "L", LoginApp.Properties.Resources.pizza, "9.55");
                        dataGridView.Rows.Add("St. Louis", "M", LoginApp.Properties.Resources.pizza2, "5.55");
                        dataGridView.Rows.Add("Greek", "L", LoginApp.Properties.Resources.calzone, "9.55");
                        dataGridView.Rows.Add("California", "S", LoginApp.Properties.Resources.hawaii, "4.55");
                        dataGridView.Rows.Add("Crust", "L", LoginApp.Properties.Resources.pizza, "9.55");

        }



        private void DataGridView_Click(object sender, EventArgs e)
        {
            var data = dataGridView.CurrentRow;

            if (dataGridView.AreAllCellsSelected(true))
            {
                listOrders.Items.Add(" *" + data.Cells[0].Value.ToString() +
                ",  size:   " + data.Cells[1].Value.ToString());

                itemsCount.Text = (index++).ToString();
                sum += double.Parse(data.Cells[3].Value.ToString());
                totalPrice.Text = sum.ToString() + "$";
            }

        }

        private void BtnDesc_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Descending);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listOrders.Items.Clear();
            index = 1;
            itemsCount.Text = "0";
            sum = 0;
            totalPrice.Text = "";
        }

        private void CashierApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();

            FormLogin formLogin = new FormLogin();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }
    }
}
