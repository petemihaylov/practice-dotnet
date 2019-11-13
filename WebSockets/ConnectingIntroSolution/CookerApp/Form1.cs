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

enum portName
{
    COM3,
    COM4,
    COM5
}

namespace CookerApp
{
    public partial class App : Form
    {

        WebSocket ws;
        private int index;
        private List<string> list;
        public Dictionary<string, int> dictionary = new Dictionary<string, int>();
        private string baudRate = "9600";
        
        public App()
        {
            InitializeComponent();

            this.ws = new WebSocket();
            this.ws.connect(ws.GetLocalIP(), "8081", ws.GetLocalIP(), "8080");
            this.list = new List<string>();
            this.index = 0;

            timerListOreders.Start();
   
            myport.PortName = portName.COM3.ToString();
            myport.BaudRate = int.Parse(baudRate);
            myport.DataReceived += Myport_DataReceived;

            try
            {
                myport.Open();
                progressBar.Value = 100;
            }
            catch (Exception) { MessageBox.Show("Could not open port!"); }
        }

        private void Myport_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            String receiveData = myport.ReadLine();
            lbCount.Invoke(new Action(() => lbCount.Text = receiveData));

            try
            {
                ws.sendMsg("# item: " + list[index]);
                index++;
            }catch(Exception)
            {
                MessageBox.Show("No available pizzas!");
            }
        }

        private void TimerListOreders_Tick(object sender, EventArgs e)
        {
            foreach (var item in ws.messages)
            {
                if(item.Substring(0, 4) != "ready") listOrders.Items.Add(item);
            }
               
            ws.messages.Clear();   
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                tbInfo.Text = listOrders.Items[0].ToString();
                listOrders.Items.RemoveAt(0);
                list.Add(tbInfo.Text);

            }
            catch(Exception)
            {
                tbInfo.Text = "";
                ws.messages.Clear();
                listOrders.Items.Clear();
       
            }
            
       
        }

        private void Mytimer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss") + " HH";
        }

        private void BtnTodayOrders_Click(object sender, EventArgs e)
        {
            //Distinct different pizza types
            var query = (from x in list
                         select x).Distinct();

            //geting the count and displaying it ot
            foreach (var result in query)
            {
                int count = list.Count(str => str.Contains(result));
                dayOrders.Items.Add(count.ToString() + " " + result);
                dictionary.Add(result, count);
            }

        }

        private void BtnStat_Click(object sender, EventArgs e)
        {
            Statistics st = new Statistics(dictionary);
            st.Show();
        }
    }
}
