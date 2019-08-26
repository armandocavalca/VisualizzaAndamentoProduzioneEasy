using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VisualizzaAndamentoProduzione
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Screen[] schermo = System.Windows.Forms.Screen.AllScreens;
            var owin = new FrmSemaforo();
            owin.StartPosition = FormStartPosition.Manual;
            if (schermo.Count() > 1)
                owin.Location = schermo[1].WorkingArea.Location;
            else
                owin.Location = schermo[0].WorkingArea.Location;
            owin.WindowState = FormWindowState.Maximized;
            owin.ShowDialog();
        }
    }
}
