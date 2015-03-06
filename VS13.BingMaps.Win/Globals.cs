using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13 {
    static class Program {
        /// <summary>The main entry point for the application.</summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }

    //Global application object
    public class App {
        //Members

        //Interface
        static App() { }
        private App() { }
        public static void ReportError(Exception ex,bool displayMessage) {
            //Report an exception to the user
            try {
                string src = (ex.Source != null) ? ex.Source + "-\n" : "";
                string msg = src + ex.Message;
                if (ex.InnerException != null) {
                    if ((ex.InnerException.Source != null)) src = ex.InnerException.Source + "-\n";
                    msg = src + ex.Message + "\n\n NOTE: " + ex.InnerException.Message;
                }
                if (displayMessage) MessageBox.Show(msg,"VS13.BingMaps.Win",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception) { }
        }
    }
}
