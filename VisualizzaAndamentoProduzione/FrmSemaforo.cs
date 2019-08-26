using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisualizzaAndamentoProduzione
{
    public partial class FrmSemaforo : Form
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
        public FrmSemaforo()
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


            Timer1.Enabled = true;
            InitializeTimer();

            PictureGreen.Visible = false;
            PictureRed.Visible = false;
            PictureYellow.Visible = false;
            LblPiu.Visible = false;
            LblMeno.Visible = false;
            LblUguale.Visible = false;
        }
        private void InitializeTimer()
        {
            // Call this procedure when the application starts.  
            // Set to 1 second.  
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            Timer1.Enabled = true;

        }
        private void btn_start_Click()
        { 

                InitializeTimer();
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            // Set the caption to the current time. 
#if DEBUG
            LblTempo.Text = "DEBUG :" + DateTime.Now.ToString();
#else
            LblTempo.Text = "Tempo Attuale :" + DateTime.Now.ToString();
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
            DataFine = DataFine.AddHours(1);

            // converte da formato dd/MM/yyyy hh:mm:ss in MM/dd/yyyy hh:mm:ss
            var DataInizioTxt = Datainizio.ToString("MM/dd/yyyy HH:mm:ss");
            var DataFineTxt = DataFine.ToString("MM/dd/yyyy HH:mm:ss");

            int Minuto = 0;
            int Ora = 0;

            int _OraMinuto = Convert.ToInt32(DateTime.Now.ToString("HHmm"));
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
          " where  esito = 'G'  and  Lettua between '" + DataInizioTxt + "' and '" + DataFineTxt + "' " +
      " and line = '" + NumeroLinea + "'" +
          " group by Line,left([Matricola], 7),Lettua order by Line";

#endif
            int _Qta = 0;
            int _Min = 0;
            int _Max = 0;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    Dt.Load(myReader);
                    if (Dt.Rows.Count > 0)
                    {
                        LblDatoNonRilevabile.Visible = false;
                        foreach (DataRow row in Dt.Rows)
                        {
                            _Grf[0].Macchina = row[0].ToString().Trim();
                            _Grf[0].Articolo = row[1].ToString().Trim();
                            _Grf[0].Lettura = 1;
                            Data = Convert.ToDateTime(row[2]);
                            if (_MaxOMa < Convert.ToInt32(Data.ToString("HHmm")))
                                _MaxOMa = Convert.ToInt32(Data.ToString("HHmm"));
                            Minuto = Data.Minute;
                            Ora = Data.Hour;
                            if (Ora == OraIni)
                            {
                                if (Minuto < 20)
                                    _Grf[0].Qta1 += Convert.ToInt16(row[3]);
                                if (Minuto >= 20 && Minuto < 40)
                                    _Grf[0].Qta2 += Convert.ToInt16(row[3]);
                                if (Minuto >= 40)
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

                        var _stdVal = GetStandardValues(_Grf[0].Macchina, _Grf[0].Articolo);
                        LblMin.Text = "Valore Minimo = " + _stdVal.MinValue.ToString();
                        LblMax.Text = "Valore Massimo = " + _stdVal.MaxVlaue.ToString();
                        _Min = _stdVal.MinValue;
                        _Max = _stdVal.MaxVlaue;

                        if (DateTime.Now.Minute < 20)
                            _Qta = _Grf[0].Qta1*3; // da sistemare a secondo dlel momento in cui mi trovo  20 min prec
                        if (DateTime.Now.Minute >= 20 && DateTime.Now.Minute < 20)
                            _Qta = _Grf[0].Qta2*3;
                        if (DateTime.Now.Minute >= 40)
                            _Qta = _Grf[0].Qta3*3;
                        LblProd.Text = "Media = " + _Qta.ToString();
                        LblProd.Text =  _Qta.ToString();
                    }
                    
                }
                else
                    LblDatoNonRilevabile.Visible = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            String ColoreSemaforo = "V";
            if (_Qta < _Min)
                ColoreSemaforo = "R";
            if (_Qta > _Max)
                ColoreSemaforo = "G";
            Semaforo(ColoreSemaforo);
            Color ColoreA = Color.White;
            if (_MaxOMa == 0)
                _MaxOMa = 49;
            if (Convert.ToInt32(_MaxOMa.ToString().Substring(_MaxOMa.ToString().Length - 2)) <= 49)
            {
                if (_MaxOMa > 0 && _MaxOMa + 10 < _OraMinuto)
                { ColoreA = Color.Red; ColoreSemaforo = "R"; }
            }
            else
            {
                if (_MaxOMa > 0 && _MaxOMa + 109 - Convert.ToInt32(_MaxOMa.ToString().Substring(_MaxOMa.ToString().Length - 2)) < _OraMinuto)
                { ColoreA = Color.Red; ColoreSemaforo = "R"; }
            }
            


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
                " on F.Famiglia = C.Famiglia " +
                " where  codice  = '" + Codice.Trim() + "'" +
                " and  linea = '" + Linea.Trim() + "'";
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

                        StdVal.MinValue = Convert.ToInt32(Convert.ToDecimal(row[0].ToString()));
                        StdVal.TargetValue = Convert.ToInt32(Convert.ToDecimal(row[1].ToString()));
                        StdVal.MaxVlaue = Convert.ToInt32(Convert.ToDecimal(row[2].ToString()));
                    }
                }
                conn.Close();
            }
            catch (Exception e) { MessageBox.Show(e.Message); }

            return StdVal;
        }
        private void Semaforo(string ColoreSemaforo)
        {
            
            if (ColoreSemaforo=="V")
            { PictureGreen.Visible = true;
                PictureRed.Visible = false;
                PictureYellow.Visible = false;
                LblPiu.Visible = false;
                LblMeno.Visible = false;
                LblUguale.Visible = true;
                return;
            }
            if (ColoreSemaforo == "R")
            {
                PictureGreen.Visible = false;
                PictureRed.Visible = true;
                PictureYellow.Visible = false;
                LblPiu.Visible = false;
                LblMeno.Visible = true;
                LblUguale.Visible = false;
                return;
            }
            if (ColoreSemaforo == "G")
            {
                PictureGreen.Visible = false;
                PictureRed.Visible = false;
                PictureYellow.Visible = true;
                LblPiu.Visible = true;
                LblMeno.Visible = false;
                LblUguale.Visible = false;
                return;
            }
            PictureGreen.Visible = true;
        }
        public class StandardValue
        {
            public int MinValue { get; set; }
            public int TargetValue { get; set; }
            public int MaxVlaue { get; set; }
        }

    }
}
