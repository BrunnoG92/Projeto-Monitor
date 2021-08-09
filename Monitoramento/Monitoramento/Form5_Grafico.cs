using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monitoramento
{
    public partial class Form5_Grafico : Form
    {
        public Form5_Grafico()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Init data
            LiveChar1.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            var years = (from o in dataGridView1.DataSource as List<Revenue>
                         select new { Year = o.Year }).Distinct();
            foreach (var year in years)
            {
                List<double> values = new List<double>();
                for (int month = 1; month <= 12; month++)
                {
                    double value = 0;
                    var data = from o in dataGridView1.DataSource as List<Revenue>
                               where o.Year.Equals(year.Year) && o.Month.Equals(month)
                               orderby o.Month ascending
                               select new { o.Value, o.Month };
                    if (data.SingleOrDefault() != null)
                        value = data.SingleOrDefault().Value;
                    values.Add(value);
                }
                series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<double>(values) });
            }
            LiveChar1.Series = series;

        }

        private void Form5_Grafico_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<Revenue>();
            LiveChar1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
            });
            LiveChar1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            LiveChar1.LegendLocation = LiveCharts.LegendLocation.Right;
        }
    }
}
