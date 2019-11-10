using LiveCharts;
using LiveCharts.Wpf;
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
    public partial class Statistics : Form
    {
        private Dictionary<string, int> dictionary = new Dictionary<string, int>();

        public Statistics(Dictionary<string, int> dic)
        {
            InitializeComponent();
            this.dictionary = dic;
        }

        Func<ChartPoint, string> label = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        private void Statistics_Load(object sender, EventArgs e)
        {
            SeriesCollection series = new SeriesCollection();
            foreach (var item in dictionary)
            {
                series.Add(new PieSeries() { Title = item.Key, Values = new ChartValues<int> { item.Value }, DataLabels = true, LabelPoint = label });
                pieChart1.Series = series;
            }
        }
    }
}
