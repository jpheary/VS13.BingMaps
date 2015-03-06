namespace VS13 {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this._lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this._lblState = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this._lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this._lblAddress = new System.Windows.Forms.Label();
            this.wbMap = new System.Windows.Forms.WebBrowser();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtZip);
            this.grpAddress.Controls.Add(this._lblZip);
            this.grpAddress.Controls.Add(this.txtState);
            this.grpAddress.Controls.Add(this._lblState);
            this.grpAddress.Controls.Add(this.txtCity);
            this.grpAddress.Controls.Add(this._lblCity);
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.Controls.Add(this._lblAddress);
            this.grpAddress.Location = new System.Drawing.Point(14, 14);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(393, 231);
            this.grpAddress.TabIndex = 1;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Bing Map An Address";
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(105, 143);
            this.txtZip.MaxLength = 5;
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(87, 24);
            this.txtZip.TabIndex = 3;
            this.txtZip.TextChanged += new System.EventHandler(this.OnAddressChanged);
            // 
            // _lblZip
            // 
            this._lblZip.Location = new System.Drawing.Point(64, 143);
            this._lblZip.Name = "_lblZip";
            this._lblZip.Size = new System.Drawing.Size(29, 23);
            this._lblZip.TabIndex = 12;
            this._lblZip.Text = "Zip";
            this._lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(105, 113);
            this.txtState.MaxLength = 2;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(58, 24);
            this.txtState.TabIndex = 2;
            this.txtState.TextChanged += new System.EventHandler(this.OnAddressChanged);
            // 
            // _lblState
            // 
            this._lblState.Location = new System.Drawing.Point(6, 113);
            this._lblState.Name = "_lblState";
            this._lblState.Size = new System.Drawing.Size(87, 23);
            this._lblState.TabIndex = 10;
            this._lblState.Text = "State";
            this._lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(105, 83);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(174, 24);
            this.txtCity.TabIndex = 1;
            this.txtCity.TextChanged += new System.EventHandler(this.OnAddressChanged);
            // 
            // _lblCity
            // 
            this._lblCity.Location = new System.Drawing.Point(6, 83);
            this._lblCity.Name = "_lblCity";
            this._lblCity.Size = new System.Drawing.Size(87, 23);
            this._lblCity.TabIndex = 8;
            this._lblCity.Text = "City";
            this._lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(105, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(262, 24);
            this.txtAddress.TabIndex = 0;
            this.txtAddress.TextChanged += new System.EventHandler(this.OnAddressChanged);
            // 
            // _lblAddress
            // 
            this._lblAddress.Location = new System.Drawing.Point(6, 53);
            this._lblAddress.Name = "_lblAddress";
            this._lblAddress.Size = new System.Drawing.Size(87, 23);
            this._lblAddress.TabIndex = 6;
            this._lblAddress.Text = "Address";
            this._lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wbMap
            // 
            this.wbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMap.Location = new System.Drawing.Point(422, 14);
            this.wbMap.MinimumSize = new System.Drawing.Size(23, 23);
            this.wbMap.Name = "wbMap";
            this.wbMap.Size = new System.Drawing.Size(490, 377);
            this.wbMap.TabIndex = 8;
            this.wbMap.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.OnMapDocumentCompleted);
            this.wbMap.Resize += new System.EventHandler(this.OnMapDocumentResized);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 405);
            this.Controls.Add(this.wbMap);
            this.Controls.Add(this.grpAddress);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bing Maps";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label _lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label _lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label _lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label _lblAddress;
        private System.Windows.Forms.WebBrowser wbMap;
    }
}