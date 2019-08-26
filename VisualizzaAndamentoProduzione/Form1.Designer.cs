namespace VisualizzaAndamentoProduzione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_start = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.Lbl_caricamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 14);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1090, 888);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Location = new System.Drawing.Point(987, 931);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 39);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(124, 953);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 17);
            this.label19.TabIndex = 29;
            // 
            // Lbl_caricamento
            // 
            this.Lbl_caricamento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_caricamento.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_caricamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_caricamento.Location = new System.Drawing.Point(82, 260);
            this.Lbl_caricamento.Name = "Lbl_caricamento";
            this.Lbl_caricamento.Size = new System.Drawing.Size(939, 448);
            this.Lbl_caricamento.TabIndex = 30;
            this.Lbl_caricamento.Text = "Attendere Caricamento in corso ......";
            this.Lbl_caricamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 985);
            this.Controls.Add(this.Lbl_caricamento);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Rel. 190621.1645";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label Lbl_caricamento;
    }
}

