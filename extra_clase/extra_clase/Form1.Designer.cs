
namespace extra_clase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.tabas_datos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabas_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "primer_trimestr";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabas_datos
            // 
            chartArea3.Name = "ChartArea1";
            this.tabas_datos.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.tabas_datos.Legends.Add(legend3);
            this.tabas_datos.Location = new System.Drawing.Point(368, 60);
            this.tabas_datos.Name = "tabas_datos";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.tabas_datos.Series.Add(series3);
            this.tabas_datos.Size = new System.Drawing.Size(300, 300);
            this.tabas_datos.TabIndex = 1;
            this.tabas_datos.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(92, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "segundo_trimestre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "tercer_trimesttr";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabas_datos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabas_datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart tabas_datos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

