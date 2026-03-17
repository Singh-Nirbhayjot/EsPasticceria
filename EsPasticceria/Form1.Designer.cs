namespace EsPasticceria
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstRicette = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbDecorazioneNo = new System.Windows.Forms.RadioButton();
            this.rdbDecorazioneSi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTempoCottura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOrdina = new System.Windows.Forms.Button();
            this.txtCerca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCerca = new System.Windows.Forms.Button();
            this.txtDiametro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTipoFrolla = new System.Windows.Forms.ComboBox();
            this.cmbTipoMarmellata = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1001 Crostata";
            // 
            // lstRicette
            // 
            this.lstRicette.FormattingEnabled = true;
            this.lstRicette.ItemHeight = 16;
            this.lstRicette.Location = new System.Drawing.Point(255, 38);
            this.lstRicette.Name = "lstRicette";
            this.lstRicette.Size = new System.Drawing.Size(310, 292);
            this.lstRicette.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 300);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nirbhayjot Singh";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTipoMarmellata);
            this.panel2.Controls.Add(this.cmbTipoFrolla);
            this.panel2.Controls.Add(this.txtDiametro);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.btnSalva);
            this.panel2.Controls.Add(this.rdbDecorazioneNo);
            this.panel2.Controls.Add(this.rdbDecorazioneSi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtTempoCottura);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(571, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 292);
            this.panel2.TabIndex = 4;
            // 
            // rdbDecorazioneNo
            // 
            this.rdbDecorazioneNo.AutoSize = true;
            this.rdbDecorazioneNo.Location = new System.Drawing.Point(151, 245);
            this.rdbDecorazioneNo.Name = "rdbDecorazioneNo";
            this.rdbDecorazioneNo.Size = new System.Drawing.Size(48, 20);
            this.rdbDecorazioneNo.TabIndex = 10;
            this.rdbDecorazioneNo.TabStop = true;
            this.rdbDecorazioneNo.Text = "NO";
            this.rdbDecorazioneNo.UseVisualStyleBackColor = true;
            // 
            // rdbDecorazioneSi
            // 
            this.rdbDecorazioneSi.AutoSize = true;
            this.rdbDecorazioneSi.Location = new System.Drawing.Point(105, 245);
            this.rdbDecorazioneSi.Name = "rdbDecorazioneSi";
            this.rdbDecorazioneSi.Size = new System.Drawing.Size(40, 20);
            this.rdbDecorazioneSi.TabIndex = 9;
            this.rdbDecorazioneSi.TabStop = true;
            this.rdbDecorazioneSi.Text = "SI";
            this.rdbDecorazioneSi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Decorazione";
            // 
            // txtTempoCottura
            // 
            this.txtTempoCottura.Location = new System.Drawing.Point(105, 162);
            this.txtTempoCottura.Name = "txtTempoCottura";
            this.txtTempoCottura.Size = new System.Drawing.Size(96, 22);
            this.txtTempoCottura.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tempo cottura";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo marmellata";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo frolla";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 10);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(96, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome ricetta";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(70, 266);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(75, 23);
            this.btnSalva.TabIndex = 11;
            this.btnSalva.Text = "SALVA";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCerca);
            this.panel3.Controls.Add(this.txtCerca);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnOrdina);
            this.panel3.Location = new System.Drawing.Point(200, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 48);
            this.panel3.TabIndex = 5;
            // 
            // btnOrdina
            // 
            this.btnOrdina.Location = new System.Drawing.Point(18, 13);
            this.btnOrdina.Name = "btnOrdina";
            this.btnOrdina.Size = new System.Drawing.Size(75, 23);
            this.btnOrdina.TabIndex = 0;
            this.btnOrdina.Text = "ORDINA";
            this.btnOrdina.UseVisualStyleBackColor = true;
            // 
            // txtCerca
            // 
            this.txtCerca.Location = new System.Drawing.Point(210, 13);
            this.txtCerca.Name = "txtCerca";
            this.txtCerca.Size = new System.Drawing.Size(100, 22);
            this.txtCerca.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(121, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 37);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cerca per marmellata";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(331, 13);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(75, 23);
            this.btnCerca.TabIndex = 14;
            this.btnCerca.Text = "CERCA";
            this.btnCerca.UseVisualStyleBackColor = true;
            // 
            // txtDiametro
            // 
            this.txtDiametro.Location = new System.Drawing.Point(105, 211);
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.Size = new System.Drawing.Size(96, 22);
            this.txtDiametro.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 22);
            this.label9.TabIndex = 12;
            this.label9.Text = "Diametro";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbTipoFrolla
            // 
            this.cmbTipoFrolla.FormattingEnabled = true;
            this.cmbTipoFrolla.Location = new System.Drawing.Point(105, 62);
            this.cmbTipoFrolla.Name = "cmbTipoFrolla";
            this.cmbTipoFrolla.Size = new System.Drawing.Size(96, 24);
            this.cmbTipoFrolla.TabIndex = 14;
            // 
            // cmbTipoMarmellata
            // 
            this.cmbTipoMarmellata.FormattingEnabled = true;
            this.cmbTipoMarmellata.Location = new System.Drawing.Point(105, 121);
            this.cmbTipoMarmellata.Name = "cmbTipoMarmellata";
            this.cmbTipoMarmellata.Size = new System.Drawing.Size(96, 24);
            this.cmbTipoMarmellata.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstRicette);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRicette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTempoCottura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbDecorazioneNo;
        private System.Windows.Forms.RadioButton rdbDecorazioneSi;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.TextBox txtCerca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOrdina;
        private System.Windows.Forms.TextBox txtDiametro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTipoMarmellata;
        private System.Windows.Forms.ComboBox cmbTipoFrolla;
    }
}

