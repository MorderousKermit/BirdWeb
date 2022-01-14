namespace Browser
{
    partial class RudzikNET
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RudzikNET));
            this.TxtURL = new System.Windows.Forms.TextBox();
            this.MyWebBrowser = new System.Windows.Forms.WebBrowser();
            this.btngo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnforward = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtURL
            // 
            this.TxtURL.Location = new System.Drawing.Point(12, 12);
            this.TxtURL.Name = "TxtURL";
            this.TxtURL.Size = new System.Drawing.Size(576, 20);
            this.TxtURL.TabIndex = 0;
            this.TxtURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MyWebBrowser
            // 
            this.MyWebBrowser.Location = new System.Drawing.Point(-5, 66);
            this.MyWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MyWebBrowser.Name = "MyWebBrowser";
            this.MyWebBrowser.ScriptErrorsSuppressed = true;
            this.MyWebBrowser.Size = new System.Drawing.Size(1912, 893);
            this.MyWebBrowser.TabIndex = 1;
            this.MyWebBrowser.Url = new System.Uri("http://google.com", System.UriKind.Absolute);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(594, 11);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(34, 20);
            this.btngo.TabIndex = 2;
            this.btngo.Text = "GO";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(48, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(210, 39);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnforward
            // 
            this.btnforward.Location = new System.Drawing.Point(373, 39);
            this.btnforward.Name = "btnforward";
            this.btnforward.Size = new System.Drawing.Size(75, 23);
            this.btnforward.TabIndex = 5;
            this.btnforward.Text = "Forward";
            this.btnforward.UseVisualStyleBackColor = true;
            this.btnforward.Click += new System.EventHandler(this.btnforward_Click);
            // 
            // btnhome
            // 
            this.btnhome.Location = new System.Drawing.Point(551, 38);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(75, 23);
            this.btnhome.TabIndex = 6;
            this.btnhome.Text = "Go Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(692, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 64);
            this.label1.TabIndex = 7;
            this.label1.Text = "RudzikNET";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1778, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Wróć";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RudzikNET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1904, 951);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MyWebBrowser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnforward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btngo);
            this.Controls.Add(this.TxtURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RudzikNET";
            this.Text = "Przeglądarka RudzikNET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtURL;
        private System.Windows.Forms.WebBrowser MyWebBrowser;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnforward;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

