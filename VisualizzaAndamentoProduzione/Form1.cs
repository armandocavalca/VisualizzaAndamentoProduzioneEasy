using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Data.SqlClient;

namespace VisualizzaAndamentoProduzione
{
    public partial class Form1 : Form
    {
        static string _myConnectionString;
        public static string myConnectionString;
        public static string LottoParm
        {
            get
            {
                return _myConnectionString;
            }
            set
            {
                _myConnectionString = value;
            }

        }
        public static string NumeroLinea;

        public Form1()
        {
            InitializeComponent();

            // definisco la connessione
            this.WindowState = FormWindowState.Maximized;
            string appPath = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            StreamReader sw = new StreamReader(appPath + "\\connection.txt");
            myConnectionString = sw.ReadLine();
// leggo linea
            StreamReader sw1 = new StreamReader(appPath + "\\Postazione.txt");
            NumeroLinea = sw1.ReadLine();

            btn_start.Text = "Stop";
            Timer1.Enabled = true;
            InitializeTimer();

            Lbl_caricamento.Visible = true;

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Stop")
            {
                btn_start.Text = "Start";
                Timer1.Enabled = false;
            }
            else
            {
                btn_start.Text = "Stop";
                Timer1.Enabled = true;
                InitializeTimer();
            }


            #region sopressa
            //// definisco struttura
            //List<Grafo> _Grf = new List<Grafo>();
            //_Grf.Add(new Grafo());
            //_Grf.Add(new Grafo());
            //_Grf.Add(new Grafo());
            //_Grf.Add(new Grafo());

            //DateTime Data;
            //int Minuto = 0;

            //// mi connetto al db
            //System.Data.DataTable Dt = new System.Data.DataTable();
            //string strConnection = myConnectionString;
            //SqlConnection conn = new SqlConnection(strConnection);
            //string query = @"SELECT [Line],left([Matricola], 9),lettua,count(*) " +
            //    "FROM [GSM].[dbo].[TabLogLabel] " +
            //    " where  esito = 'G'  and  Lettua between '15/12/2018 08:00' and '15/12/2018 08:59:59'" +
            //    " group by Line,left([Matricola], 9),Lettua order by Line";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //try
            //{
            //    conn.Open();
            //    SqlDataReader myReader = cmd.ExecuteReader();
            //    Dt.Load(myReader);
            //    if (Dt.Rows.Count > 0)
            //    {
            //        foreach (DataRow row in Dt.Rows)
            //        {
            //            switch (row[0].ToString().Trim())
            //            {
            //                case "A":
            //                    _Grf[0].Macchina = row[0].ToString().Trim();
            //                    _Grf[0].Articolo = row[1].ToString().Trim();
            //                    _Grf[0].Lettura = 1;
            //                    Data = Convert.ToDateTime(row[2]);
            //                    Minuto = Data.Minute;
            //                    if (Minuto < 10)
            //                        _Grf[0].Qta1 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 10 && Minuto < 20)
            //                        _Grf[0].Qta2 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 20 && Minuto < 30)
            //                        _Grf[0].Qta3 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 30 && Minuto < 40)
            //                        _Grf[0].Qta4 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 40 && Minuto < 50)
            //                        _Grf[0].Qta5 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 50 && Minuto <= 59)
            //                        _Grf[0].Qta6 += Convert.ToInt16(row[3]);
            //                    break;
            //                case "B":
            //                    _Grf[1].Macchina = row[0].ToString().Trim();
            //                    _Grf[1].Articolo = row[1].ToString().Trim();
            //                    _Grf[1].Lettura = 2;
            //                    Data = Convert.ToDateTime(row[2]);
            //                    Minuto = Data.Minute;
            //                    if (Minuto < 10)
            //                        _Grf[1].Qta1 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 10 && Minuto < 20)
            //                        _Grf[1].Qta2 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 20 && Minuto < 30)
            //                        _Grf[1].Qta3 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 30 && Minuto < 40)
            //                        _Grf[1].Qta4 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 40 && Minuto < 50)
            //                        _Grf[1].Qta5 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 50 && Minuto <= 59)
            //                        _Grf[1].Qta6 += Convert.ToInt16(row[3]);
            //                    break;
            //                case "C":
            //                    _Grf[2].Macchina = row[0].ToString().Trim();
            //                    _Grf[2].Articolo = row[1].ToString().Trim();
            //                    _Grf[2].Lettura = 3;
            //                    Data = Convert.ToDateTime(row[2]);
            //                    Minuto = Data.Minute;
            //                    if (Minuto < 10)
            //                        _Grf[2].Qta1 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 10 && Minuto < 20)
            //                        _Grf[2].Qta2 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 20 && Minuto < 30)
            //                        _Grf[2].Qta3 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 30 && Minuto < 40)
            //                        _Grf[2].Qta4 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 40 && Minuto < 50)
            //                        _Grf[2].Qta5 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 50 && Minuto <= 59)
            //                        _Grf[2].Qta6 += Convert.ToInt16(row[3]);
            //                    break;
            //                case "D":
            //                    _Grf[3].Macchina = row[0].ToString().Trim();
            //                    _Grf[3].Articolo = row[1].ToString().Trim();
            //                    _Grf[3].Lettura = 4;
            //                    Data = Convert.ToDateTime(row[2]);
            //                    Minuto = Data.Minute;
            //                    if (Minuto < 10)
            //                        _Grf[3].Qta1 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 10 && Minuto < 20)
            //                        _Grf[3].Qta2 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 20 && Minuto < 30)
            //                        _Grf[3].Qta3 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 30 && Minuto < 40)
            //                        _Grf[3].Qta4 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 40 && Minuto < 50)
            //                        _Grf[3].Qta5 += Convert.ToInt16(row[3]);
            //                    if (Minuto >= 50 && Minuto <= 59)
            //                        _Grf[3].Qta6 += Convert.ToInt16(row[3]);
            //                    break;
            //            }

            //        }


            //    }

            //    conn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            
            //SplineChartExample(this.chart1, _Grf[0]);
            //SplineChartExample(this.chart2, _Grf[1]);
            //SplineChartExample(this.chart3, _Grf[2]);
            //SplineChartExample(this.chart4, _Grf[3]);
            #endregion
        }

        private Grafo CaricaGrf(DataRow row)
        {

            Grafo _Grf = new Grafo();

            _Grf.Macchina = row[0].ToString().Trim();
            _Grf.Articolo = row[1].ToString().Trim();
            _Grf.Lettura = 1;

            return _Grf;
        }
        private void SplineChartExample(Chart _chart, Grafo _Grf, string _linea, Color Colore, int _Ul)
        {
            _chart.Series.Clear();
            _chart.Titles.Clear();

            //if(_chart.Name=="chart1")
            //{
                var _StdValue = GetStandardValues(_Grf.Macchina, _Grf.Articolo);
                    _chart.Titles.Add("Linea " + _linea + " Produzione del " + DateTime.Now.Date.ToString("dd/MM/yyyy") +
                        " " + DateTime.Now.ToString("HH:mm:ss"));
                    _chart.Titles.Add("Articolo " + _Grf.Articolo + "      (ul: " + _Ul.ToString("00:00") + ")" +
                        "   ( " + _Grf.Qta1.ToString() +
                        " - " + _Grf.Qta2.ToString() +
                        " - " + _Grf.Qta3.ToString()  +
                        " - " + _Grf.Qta4.ToString() +
                        " - " + _Grf.Qta5.ToString() +
                        " - " + _Grf.Qta6.ToString() +
                        ")");

                    _chart.ChartAreas[0].AxisY.Maximum = _StdValue.MaxVlaue + 3;
                    _chart.ChartAreas[0].AxisY.Minimum = _StdValue.MinValue -3;
                    _chart.ChartAreas[0].AxisY.Interval = _chart.ChartAreas[0].AxisY.Maximum - _chart.ChartAreas[0].AxisY.Minimum;
                    _chart.ChartAreas[0].BackColor = Colore;    

             if (_Grf.Qta6 >0 )
            {
                if(_Grf.Qta6 * 3 < _StdValue.MinValue -3)
                    _chart.ChartAreas[0].BackColor=Color.Yellow;
            }
            else if (_Grf.Qta5 > 0)
            {
                if(_Grf.Qta5 * 3 < _StdValue.MinValue -3)
                    _chart.ChartAreas[0].BackColor=Color.Yellow;
            }
             else if (_Grf.Qta4 > 0)
             {
                 if (_Grf.Qta4 * 3 < _StdValue.MinValue - 3)
                     _chart.ChartAreas[0].BackColor = Color.Yellow;
             }
                    
                    string Oradaconsiderare = DateTime.Now.TimeOfDay.ToString("hh");

                    Series series = _chart.Series.Add("Produzione");
                    series.ChartType = SeriesChartType.Spline;
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":00", _Grf.Qta1 * 3);
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":20", _Grf.Qta2 * 3);
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":40", _Grf.Qta3 * 3);
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":00", _Grf.Qta4 * 3);
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":20", _Grf.Qta5 * 3);
                    series.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":40", _Grf.Qta6 * 3);
                    Series seriesm = _chart.Series.Add("Minimo " + _StdValue.MinValue);
                    seriesm.ChartType = SeriesChartType.Spline;
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":00", _StdValue.MinValue);
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":20", _StdValue.MinValue);
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":40", _StdValue.MinValue);
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":00", _StdValue.MinValue);
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":20", _StdValue.MinValue);
                    seriesm.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":40", _StdValue.MinValue);

                    Series seriesT = _chart.Series.Add("Target " + _StdValue.TargetValue);
                    seriesT.ChartType = SeriesChartType.Spline;
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":00", _StdValue.TargetValue);
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":20", _StdValue.TargetValue);
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":40", _StdValue.TargetValue);
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":00", _StdValue.TargetValue);
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":20", _StdValue.TargetValue);
                    seriesT.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":40", _StdValue.TargetValue);

                    Series seriesM = _chart.Series.Add("Massimo " + _StdValue.MaxVlaue);
                    seriesM.ChartType = SeriesChartType.Spline;
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":00", _StdValue.MaxVlaue);
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":20", _StdValue.MaxVlaue);
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare) -1) + ":40", _StdValue.MaxVlaue);
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":00", _StdValue.MaxVlaue);
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare) ) + ":20", _StdValue.MaxVlaue);
                    seriesM.Points.AddXY((Convert.ToInt32(Oradaconsiderare)) + ":40", _StdValue.MaxVlaue);
            //}

            #region Inutile

            //if (_chart.Name == "chart2")
            //{
            //    var _StdValue = GetStandardValues(_Grf.Macchina, _Grf.Articolo);
            //    _chart.Titles.Add("Linea B Produzione del " + DateTime.Now.Date.ToString("dd/MM/yyyy"));
            //    _chart.ChartAreas[0].AxisY.Maximum = _StdValue.MaxVlaue + 10;
            //    _chart.ChartAreas[0].AxisY.Minimum = _StdValue.MinValue - 10;
            //    _chart.ChartAreas[0].AxisY.Interval = _chart.ChartAreas[0].AxisY.Maximum;

            //    string Oradaconsiderare = DateTime.Now.TimeOfDay.ToString("hh");

            //    Series series = _chart.Series.Add("Produzione");
            //    series.ChartType = SeriesChartType.Spline;
            //    series.Points.AddXY(Oradaconsiderare + ":00", _Grf.Qta1*6);
            //    series.Points.AddXY(Oradaconsiderare + ":10", _Grf.Qta2 * 6);
            //    series.Points.AddXY(Oradaconsiderare + ":20", _Grf.Qta3 * 6);
            //    series.Points.AddXY(Oradaconsiderare + ":30", _Grf.Qta4 * 6);
            //    series.Points.AddXY(Oradaconsiderare + ":40", _Grf.Qta5 * 6);
            //    series.Points.AddXY(Oradaconsiderare + ":50", _Grf.Qta6 * 6);
            //    Series seriesm = _chart.Series.Add("Minimo " + _StdValue.MinValue);
            //    seriesm.ChartType = SeriesChartType.Spline;
            //    seriesm.Points.AddXY(Oradaconsiderare + ":00", _StdValue.MinValue);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":10", _StdValue.MinValue);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":20", _StdValue.MinValue);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":30", _StdValue.MinValue);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":40", _StdValue.MinValue);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":50", _StdValue.MinValue);

            //    Series seriesT = _chart.Series.Add("Target " + _StdValue.TargetValue);
            //    seriesT.ChartType = SeriesChartType.Spline;
            //    seriesT.Points.AddXY(Oradaconsiderare + ":00", _StdValue.TargetValue);
            //    seriesT.Points.AddXY(Oradaconsiderare + ":10", _StdValue.TargetValue);
            //    seriesT.Points.AddXY(Oradaconsiderare + ":20", _StdValue.TargetValue);
            //    seriesT.Points.AddXY(Oradaconsiderare + ":30", _StdValue.TargetValue);
            //    seriesT.Points.AddXY(Oradaconsiderare + ":40", _StdValue.TargetValue);
            //    seriesT.Points.AddXY(Oradaconsiderare + ":50", _StdValue.TargetValue);

            //    Series seriesM = _chart.Series.Add("Massimo " + _StdValue.MaxVlaue);
            //    seriesM.ChartType = SeriesChartType.Spline;
            //    seriesM.Points.AddXY(Oradaconsiderare + ":00", _StdValue.MaxVlaue);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":10", _StdValue.MaxVlaue);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":20", _StdValue.MaxVlaue);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":30", _StdValue.MaxVlaue);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":40", _StdValue.MaxVlaue);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":50", _StdValue.MaxVlaue);
            //}


            //if (_chart.Name == "chart3")
            //{
            //    var _StdValue = GetStandardValues(_Grf.Macchina, _Grf.Articolo);
            //    _chart.Titles.Add("Linea C Produzione del " + DateTime.Now.Date.ToString("dd/MM/yyyy"));
            //    _chart.ChartAreas[0].AxisY.Maximum = 15;
            //    _chart.ChartAreas[0].AxisY.Minimum = 0;
            //    _chart.ChartAreas[0].AxisY.Interval = _chart.ChartAreas[0].AxisY.Maximum;

            //    string Oradaconsiderare = DateTime.Now.TimeOfDay.ToString("hh");

            //    Series series = _chart.Series.Add("Produzione");
            //    series.ChartType = SeriesChartType.Spline;
            //    series.Points.AddXY(Oradaconsiderare + ":00", _Grf.Qta1);
            //    series.Points.AddXY(Oradaconsiderare + ":10", _Grf.Qta2);
            //    series.Points.AddXY(Oradaconsiderare + ":20", _Grf.Qta3);
            //    series.Points.AddXY(Oradaconsiderare + ":30", _Grf.Qta4);
            //    series.Points.AddXY(Oradaconsiderare + ":40", _Grf.Qta5);
            //    series.Points.AddXY(Oradaconsiderare + ":50", _Grf.Qta6);

            //    Series seriesm = _chart.Series.Add("Minimo 5");
            //    seriesm.ChartType = SeriesChartType.Spline;
            //    seriesm.Points.AddXY(Oradaconsiderare + ":00", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":10", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":20", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":30", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":40", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":50", 5);

            //    Series seriesM = _chart.Series.Add("Massimo 10");
            //    seriesM.ChartType = SeriesChartType.Spline;
            //    seriesM.Points.AddXY(Oradaconsiderare + ":00", 10);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":10", 10);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":20", 10);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":30", 10);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":40", 10);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":50", 10);
            //}


            //if (_chart.Name == "chart4")
            //{
            //    var _StdValue = GetStandardValues(_Grf.Macchina, _Grf.Articolo);
            //    _chart.Titles.Add("Linea D Produzione del " + DateTime.Now.Date.ToString("dd/MM/yyyy"));
            //    _chart.ChartAreas[0].AxisY.Maximum = 25;
            //    _chart.ChartAreas[0].AxisY.Minimum = 0;
            //    _chart.ChartAreas[0].AxisY.Interval = _chart.ChartAreas[0].AxisY.Maximum;

            //    string Oradaconsiderare = DateTime.Now.TimeOfDay.ToString("hh");

            //    Series series = _chart.Series.Add("Produzione");
            //    series.ChartType = SeriesChartType.Spline;
            //    series.Points.AddXY(Oradaconsiderare + ":00", _Grf.Qta1);
            //    series.Points.AddXY(Oradaconsiderare + ":10", _Grf.Qta2);
            //    series.Points.AddXY(Oradaconsiderare + ":20", _Grf.Qta3);
            //    series.Points.AddXY(Oradaconsiderare + ":30", _Grf.Qta4);
            //    series.Points.AddXY(Oradaconsiderare + ":40", _Grf.Qta5);
            //    series.Points.AddXY(Oradaconsiderare + ":50", _Grf.Qta6);

            //    Series seriesm = _chart.Series.Add("Minimo 5");
            //    seriesm.ChartType = SeriesChartType.Spline;
            //    seriesm.Points.AddXY(Oradaconsiderare + ":00", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":10", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":20", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":30", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":40", 5);
            //    seriesm.Points.AddXY(Oradaconsiderare + ":50", 5);

            //    Series seriesM = _chart.Series.Add("Massimo 20");
            //    seriesM.ChartType = SeriesChartType.Spline;
            //    seriesM.Points.AddXY(Oradaconsiderare + ":00", 20);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":10", 20);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":20", 20);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":30", 20);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":40", 20);
            //    seriesM.Points.AddXY(Oradaconsiderare + ":50", 20);
            //}

            #endregion

        }
        public StandardValue GetStandardValues(string Linea, string Codice)
        {
            StandardValue StdVal = new StandardValue();

            // in attesa di aggiiornamenti da BRAMI taglio gli ultimi due caratteri del codice
            // confermato da mail luca brami del 13/02/19 primi 7 caratteri
            if (Codice == null)
                return StdVal;
            Codice = Codice.Substring(0, 7);

            StdVal.MinValue = 0;
            StdVal.TargetValue = 0;
            StdVal.MaxVlaue = 0;

            System.Data.DataTable Dt = new System.Data.DataTable();
            string strConnection = myConnectionString;
            SqlConnection conn = new SqlConnection(strConnection);
            string query = @"SELECT min, target, max " +
                "FROM [GSM].[dbo].[Famiglie_Prod] F join [GSM].[dbo].[Codici_Famiglie] C " +
                " on F.Famiglia = C.Famiglia "+
                " where  codice  = '" + Codice.Trim() + "'" +
                " and  linea = '" + Linea.Trim() + "'" ;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader myReader = cmd.ExecuteReader();
                Dt.Load(myReader);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow row in Dt.Rows)
                    {
                         
                        StdVal.MinValue = Convert.ToInt32( Convert.ToDecimal(row[0].ToString()));
                        StdVal.TargetValue = Convert.ToInt32(Convert.ToDecimal(row[1].ToString()));
                        StdVal.MaxVlaue = Convert.ToInt32(Convert.ToDecimal(row[2].ToString()));
                    }
                }
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }
            
            return StdVal;
        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            Timer1.Enabled = true;

            btn_start.Text = "Stop";
            btn_start.Click += new EventHandler(btn_start_Click);
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time. 
#if DEBUG
            label19.Text = "DEBUG :" + DateTime.Now.ToString();
#else
            label19.Text = "Tempo Attuale :" + DateTime.Now.ToString();
#endif
            // definisco struttura
            List<Grafo> _Grf = new List<Grafo>();
            _Grf.Add(new Grafo());
            _Grf.Add(new Grafo());
            _Grf.Add(new Grafo());
            _Grf.Add(new Grafo());

            DateTime Data;
            DateTime Datainizio = DateTime.Now;
            Datainizio = Datainizio.Subtract(new TimeSpan(0, 0, Datainizio.Minute, Datainizio.Second, Datainizio.Millisecond));
            Datainizio = Datainizio.AddHours(-1);

            DateTime DataFine = DateTime.Now;
            DataFine = DataFine.Subtract(new TimeSpan(0, 0, DataFine.Minute, DataFine.Second, DataFine.Millisecond));
            DataFine= DataFine.AddHours(1);

            // converte da formato dd/MM/yyyy hh:mm:ss in MM/dd/yyyy hh:mm:ss
            var DataInizioTxt = Datainizio.ToString("MM/dd/yyyy HH:mm:ss");
            var DataFineTxt = DataFine.ToString("MM/dd/yyyy HH:mm:ss");

            int Minuto = 0;
            int Ora=0;

            int _OraMinuto = Convert.ToInt32( DateTime.Now.ToString("HHmm"));
            int _MaxOMa = 0;

#if DEBUG
            int OraIni = 8;
            int OraFin = 9;
#else
            int OraIni = Datainizio.Hour;
            int OraFin = DataFine.Hour;
            OraFin -= 1;
#endif

            // mi connetto al db
            System.Data.DataTable Dt = new System.Data.DataTable();
            string strConnection = myConnectionString;
            SqlConnection conn = new SqlConnection(strConnection);
#if DEBUG
            string query = @"SELECT [Line],left([Matricola], 7),lettua,count(*) " +
                "FROM [GSM].[dbo].[TabLogLabel] " +
                " where  esito = 'G'  and  Lettua between '15/12/2018 08:00:00' and '15/12/2018 09:59:59'" +
                " and line = '"+NumeroLinea +"'" + 
                " group by Line,left([Matricola], 7),Lettua order by Line";
            //                " where  esito = 'G'  and  Lettua between '" + Datainizio.ToString() + "' and '" + DataFine.ToString() + "' "+
            //" where  esito = 'G'  and  Lettua between '15/12/2018 08:00:00' and '15/12/2018 08:59:59'" +
#else
                  string query = @"SELECT [Line],left([Matricola], 7),lettua,count(*) " +
                "FROM [GSM].[dbo].[TabLogLabel] " +
                " where  esito = 'G'  and  Lettua between '" + DataInizioTxt + "' and '" + DataFineTxt + "' "+
            " and line = '"+NumeroLinea +"'" + 
                " group by Line,left([Matricola], 7),Lettua order by Line";
                      
#endif
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader myReader = cmd.ExecuteReader();
                Dt.Load(myReader);
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow row in Dt.Rows)
                    {
                                _Grf[0].Macchina = row[0].ToString().Trim();
                                _Grf[0].Articolo = row[1].ToString().Trim();
                                _Grf[0].Lettura = 1;
                                Data = Convert.ToDateTime(row[2]);
                                if(_MaxOMa < Convert.ToInt32( Data.ToString("HHmm")))
                                    _MaxOMa=Convert.ToInt32( Data.ToString("HHmm"));
                                Minuto = Data.Minute;
                                Ora = Data.Hour;
                                if (Ora == OraIni)
                                {
                                    if (Minuto < 20)
                                        _Grf[0].Qta1 += Convert.ToInt16(row[3]);
                                    if (Minuto >= 20 && Minuto < 40)
                                        _Grf[0].Qta2 += Convert.ToInt16(row[3]);
                                    if (Minuto >= 40 )
                                        _Grf[0].Qta3 += Convert.ToInt16(row[3]);
                                }
                                if (Ora == OraFin)
                                {
                                    if (Minuto < 20)
                                        _Grf[0].Qta4 += Convert.ToInt16(row[3]);
                                    if (Minuto >= 20 && Minuto < 40)
                                        _Grf[0].Qta5 += Convert.ToInt16(row[3]);
                                    if (Minuto >= 40)
                                        _Grf[0].Qta6 += Convert.ToInt16(row[3]);
                                }

                    }


                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Color ColoreA = Color.White;
            if (_MaxOMa == 0)
                _MaxOMa = 49;
            if (Convert.ToInt32(_MaxOMa.ToString().Substring(_MaxOMa.ToString().Length - 2)) <= 49)
            {
                if (_MaxOMa > 0 && _MaxOMa + 10 < _OraMinuto)
                    ColoreA = Color.Red;
            }
            else
            {
                if (_MaxOMa > 0 && _MaxOMa + 109 - Convert.ToInt32(_MaxOMa.ToString().Substring(_MaxOMa.ToString().Length - 2)) < _OraMinuto)
                    ColoreA = Color.Red;
            }
            SplineChartExample(this.chart1, _Grf[0], NumeroLinea, ColoreA, _MaxOMa);


            if(Lbl_caricamento.Visible )
            Lbl_caricamento.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Lbl_caricamento.Left = ActiveForm.Width / 2 - Lbl_caricamento.Width / 2;
            Lbl_caricamento.Top = ActiveForm.Height / 2 - Lbl_caricamento.Height / 2;
        }
    }
    public class Grafo
    {
        public string Macchina { get; set; }
        public string Articolo { get; set; }
        public int Lettura { get; set; }
        public int Qta1 { get; set; }
        public int Qta2 { get; set; }
        public int Qta3 { get; set; }
        public int Qta4 { get; set; }
        public int Qta5 { get; set; }
        public int Qta6 { get; set; }
    }
    public class StandardValue
    {
        public int MinValue { get; set; }
        public int TargetValue { get; set; }
        public int MaxVlaue { get; set; } 
    }


}
