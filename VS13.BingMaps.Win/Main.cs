using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VS13 {
    //
    public partial class frmMain:Form {
        //Members
        private bool mMapLoaded = false;

        //Interface
        public frmMain() {
            //Constructor
            try {
                InitializeComponent();
                this.wbMap.Url = new Uri(global::VS13.Properties.Settings.Default.MapUrl);
            }
            catch(Exception ex) { App.ReportError(ex, true); }
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            this.Cursor = Cursors.WaitCursor;
            try {
                //Init
                this.txtAddress.Text =  this.txtCity.Text =  this.txtState.Text =  this.txtZip.Text = "";
            }
            catch (Exception ex) { App.ReportError(ex,true); }
            finally { this.Cursor = Cursors.Default; }
        }
        private void OnAddressChanged(object sender,EventArgs e) {
            //Event handler for address (text) changed event
            try {
                //Display the address in a map
                if(this.txtAddress.Text.Length > 0 && this.txtCity.Text.Length > 0 && this.txtState.Text.Length == 2 && this.txtZip.Text.Length == 5) {
                    if(this.mMapLoaded && this.wbMap.Document != null) {
                        string address = this.txtAddress.Text + " " + this.txtCity.Text + ", " + this.txtState.Text + " " + this.txtZip.Text;
                        this.wbMap.Document.InvokeScript("MapLocation", new object[] { address });
                    }
                }
            }
            catch(Exception ex) { App.ReportError(ex, true); }
        }
        private void OnMapDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) { this.mMapLoaded = true; OnAddressChanged(null, EventArgs.Empty); }
        private void OnMapDocumentResized(object sender,EventArgs e) { this.wbMap.Refresh(); }

    }
}
