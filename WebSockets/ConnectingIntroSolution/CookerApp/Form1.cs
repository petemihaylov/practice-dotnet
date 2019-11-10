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

namespace CookerApp
{
    public partial class App : Form
    {
        WebSocket ws;
        private List<string> list;
        public Dictionary<string, int> dictionary = new Dictionary<string, int>();


        public App()
        {
            InitializeComponent();
            ws = new WebSocket();
            ws.connect(ws.GetLocalIP(), "8081", ws.GetLocalIP(), "8080");
            timerListOreders.Start();
            list = new List<string>();
            myport.PortName = "COM3";
            myport.BaudRate = int.Parse("9600");

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
            ws.sendMsg("ready");
        }

        private void TimerListOreders_Tick(object sender, EventArgs e)
        {
            foreach (var item in ws.messages)
            {
                if(item != "ready") listOrders.Items.Add(item);
            }
               

            ws.messages.Clear();
                
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                tbInfo.Text = listOrders.Items[0].ToString();
                list.Add(tbInfo.Text);
                listOrders.Items.RemoveAt(0);
              

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
            var query = (from x in list
                         select x).Distinct();

            foreach (var result in query)
            {
                int count = list.Count(str => str.Contains(result));
                dayOrders.Items.Add(count.ToString() + " " + result);
                dictionary.Add(result, count);
            }

            list.Clear();
        }

        private void BtnStat_Click(object sender, EventArgs e)
        {

            Statistics st = new Statistics(dictionary);
            st.Show();
        }
    }
}
