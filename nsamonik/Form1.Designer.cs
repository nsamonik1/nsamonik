namespace nsamonik
{
    partial class Form1
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
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.Gumb2btnOcisti = new System.Windows.Forms.Button();
            this.chkSpremi = new System.Windows.Forms.CheckBox();
            this.lblPovrsina = new System.Windows.Forms.Label();
            this.lblPolumjer = new System.Windows.Forms.Label();
            this.lblOpseg = new System.Windows.Forms.Label();
            this.txtPolumjer = new System.Windows.Forms.TextBox();
            this.txtPovrsina = new System.Windows.Forms.TextBox();
            this.txtOpseg = new System.Windows.Forms.TextBox();
            this.lstRezultati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(27, 157);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(75, 23);
            this.btnIzracunaj.TabIndex = 0;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gumb2btnOcisti
            // 
            this.Gumb2btnOcisti.Location = new System.Drawing.Point(27, 186);
            this.Gumb2btnOcisti.Name = "Gumb2btnOcisti";
            this.Gumb2btnOcisti.Size = new System.Drawing.Size(75, 23);
            this.Gumb2btnOcisti.TabIndex = 1;
            this.Gumb2btnOcisti.Text = "Očisti";
            this.Gumb2btnOcisti.UseVisualStyleBackColor = true;
            this.Gumb2btnOcisti.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkSpremi
            // 
            this.chkSpremi.AutoSize = true;
            this.chkSpremi.Location = new System.Drawing.Point(27, 100);
            this.chkSpremi.Name = "chkSpremi";
            this.chkSpremi.Size = new System.Drawing.Size(88, 17);
            this.chkSpremi.TabIndex = 2;
            this.chkSpremi.Text = "Spremi u listu";
            this.chkSpremi.UseVisualStyleBackColor = true;
            this.chkSpremi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblPovrsina
            // 
            this.lblPovrsina.AutoSize = true;
            this.lblPovrsina.Location = new System.Drawing.Point(24, 37);
            this.lblPovrsina.Name = "lblPovrsina";
            this.lblPovrsina.Size = new System.Drawing.Size(48, 13);
            this.lblPovrsina.TabIndex = 3;
            this.lblPovrsina.Text = "Povrsina";
            this.lblPovrsina.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPolumjer
            // 
            this.lblPolumjer.AutoSize = true;
            this.lblPolumjer.Location = new System.Drawing.Point(25, 9);
            this.lblPolumjer.Name = "lblPolumjer";
            this.lblPolumjer.Size = new System.Drawing.Size(47, 13);
            this.lblPolumjer.TabIndex = 4;
            this.lblPolumjer.Text = "Polumjer";
            this.lblPolumjer.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOpseg
            // 
            this.lblOpseg.AutoSize = true;
            this.lblOpseg.Location = new System.Drawing.Point(25, 63);
            this.lblOpseg.Name = "lblOpseg";
            this.lblOpseg.Size = new System.Drawing.Size(38, 13);
            this.lblOpseg.TabIndex = 5;
            this.lblOpseg.Text = "Opseg";
            this.lblOpseg.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPolumjer
            // 
            this.txtPolumjer.Location = new System.Drawing.Point(102, 6);
            this.txtPolumjer.Name = "txtPolumjer";
            this.txtPolumjer.Size = new System.Drawing.Size(100, 20);
            this.txtPolumjer.TabIndex = 6;
            // 
            // txtPovrsina
            // 
            this.txtPovrsina.Location = new System.Drawing.Point(102, 34);
            this.txtPovrsina.Name = "txtPovrsina";
            this.txtPovrsina.Size = new System.Drawing.Size(100, 20);
            this.txtPovrsina.TabIndex = 7;
            // 
            // txtOpseg
            // 
            this.txtOpseg.Location = new System.Drawing.Point(102, 60);
            this.txtOpseg.Name = "txtOpseg";
            this.txtOpseg.Size = new System.Drawing.Size(100, 20);
            this.txtOpseg.TabIndex = 8;
            this.txtOpseg.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lstRezultati
            // 
            this.lstRezultati.FormattingEnabled = true;
            this.lstRezultati.Location = new System.Drawing.Point(152, 114);
            this.lstRezultati.Name = "lstRezultati";
            this.lstRezultati.Size = new System.Drawing.Size(120, 95);
            this.lstRezultati.TabIndex = 9;
            this.lstRezultati.SelectedIndexChanged += new System.EventHandler(this.lstRezultati_SelectedIndexChanged);
            this.lstRezultati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstRezultati_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lstRezultati);
            this.Controls.Add(this.txtOpseg);
            this.Controls.Add(this.txtPovrsina);
            this.Controls.Add(this.txtPolumjer);
            this.Controls.Add(this.lblOpseg);
            this.Controls.Add(this.lblPolumjer);
            this.Controls.Add(this.lblPovrsina);
            this.Controls.Add(this.chkSpremi);
            this.Controls.Add(this.Gumb2btnOcisti);
            this.Controls.Add(this.btnIzracunaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button Gumb2btnOcisti;
        private System.Windows.Forms.CheckBox chkSpremi;
        private System.Windows.Forms.Label lblPovrsina;
        private System.Windows.Forms.Label lblPolumjer;
        private System.Windows.Forms.Label lblOpseg;
        private System.Windows.Forms.TextBox txtPolumjer;
        private System.Windows.Forms.TextBox txtPovrsina;
        private System.Windows.Forms.TextBox txtOpseg;
        private System.Windows.Forms.ListBox lstRezultati;
    }
}

