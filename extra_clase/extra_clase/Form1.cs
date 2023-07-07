using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace extra_clase
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabas_datos.Series.Clear();

            // Crear la serie y agregar puntos de datos
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("agua", 120);
            series.Points.AddXY("luz", 85);
            series.Points.AddXY("gas", 180);

            // Agregar la serie al control Chart
            tabas_datos.Series.Add(series);

            // Actualizar el gráfico
            tabas_datos.Update();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabas_datos.Series.Clear();

            // Crear la serie y agregar puntos de datos
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("agua", 420);
            series.Points.AddXY("luz", 105);
            series.Points.AddXY("gas", 225);

            // Agregar la serie al control Chart
            tabas_datos.Series.Add(series);

            // Actualizar el gráfico
            tabas_datos.Update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabas_datos.Series.Clear();
            // Crear la serie y agregar puntos de datos
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.Points.AddXY("agua", 369);
            series.Points.AddXY("luz", 90);
            series.Points.AddXY("gas", 160);

            // Agregar la serie al control Chart
            tabas_datos.Series.Add(series);

            // Actualizar el gráfico
            tabas_datos.Update();
        }
    }
}
