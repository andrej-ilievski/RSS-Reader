namespace RSSReader
{
    partial class VremenskaPrognoza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSledni5dena = new System.Windows.Forms.Button();
            this.tbLokacija = new System.Windows.Forms.TextBox();
            this.lblXML = new System.Windows.Forms.Label();
            this.lbGrad = new System.Windows.Forms.Label();
            this.tbXML = new System.Windows.Forms.TextBox();
            this.btMomentalnaTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSledni5dena
            // 
            this.btSledni5dena.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSledni5dena.Location = new System.Drawing.Point(195, 38);
            this.btSledni5dena.Name = "btSledni5dena";
            this.btSledni5dena.Size = new System.Drawing.Size(131, 23);
            this.btSledni5dena.TabIndex = 2;
            this.btSledni5dena.Text = "Следни 5 дена";
            this.btSledni5dena.UseVisualStyleBackColor = true;
            this.btSledni5dena.Click += new System.EventHandler(this.btnForecast_Click);
            // 
            // tbLokacija
            // 
            this.tbLokacija.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLokacija.Location = new System.Drawing.Point(69, 12);
            this.tbLokacija.Name = "tbLokacija";
            this.tbLokacija.Size = new System.Drawing.Size(303, 20);
            this.tbLokacija.TabIndex = 0;
            // 
            // lblXML
            // 
            this.lblXML.AutoSize = true;
            this.lblXML.Location = new System.Drawing.Point(12, 79);
            this.lblXML.Name = "lblXML";
            this.lblXML.Size = new System.Drawing.Size(32, 13);
            this.lblXML.TabIndex = 2;
            this.lblXML.Text = "XML:";
            // 
            // lbGrad
            // 
            this.lbGrad.AutoSize = true;
            this.lbGrad.Location = new System.Drawing.Point(12, 15);
            this.lbGrad.Name = "lbGrad";
            this.lbGrad.Size = new System.Drawing.Size(31, 13);
            this.lbGrad.TabIndex = 3;
            this.lbGrad.Text = "Град";
            // 
            // tbXML
            // 
            this.tbXML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXML.Location = new System.Drawing.Point(12, 95);
            this.tbXML.Multiline = true;
            this.tbXML.Name = "tbXML";
            this.tbXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbXML.Size = new System.Drawing.Size(360, 154);
            this.tbXML.TabIndex = 3;
            this.tbXML.WordWrap = false;
            // 
            // btMomentalnaTemp
            // 
            this.btMomentalnaTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btMomentalnaTemp.Location = new System.Drawing.Point(114, 38);
            this.btMomentalnaTemp.Name = "btMomentalnaTemp";
            this.btMomentalnaTemp.Size = new System.Drawing.Size(75, 23);
            this.btMomentalnaTemp.TabIndex = 1;
            this.btMomentalnaTemp.Text = "Време сега";
            this.btMomentalnaTemp.UseVisualStyleBackColor = true;
            this.btMomentalnaTemp.Click += new System.EventHandler(this.btnConditions_Click);
            // 
            // VremenskaPrognoza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btMomentalnaTemp);
            this.Controls.Add(this.tbXML);
            this.Controls.Add(this.lbGrad);
            this.Controls.Add(this.lblXML);
            this.Controls.Add(this.tbLokacija);
            this.Controls.Add(this.btSledni5dena);
            this.Name = "VremenskaPrognoza";
            this.Text = "Временска Прогноза";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSledni5dena;
        private System.Windows.Forms.TextBox tbLokacija;
        private System.Windows.Forms.Label lblXML;
        private System.Windows.Forms.Label lbGrad;
        private System.Windows.Forms.TextBox tbXML;
        private System.Windows.Forms.Button btMomentalnaTemp;
    }
}