namespace BusTicketSelling
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.mtbTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAdminGirisi = new System.Windows.Forms.Button();
            this.lblKoltukSecimi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(364, 62);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(37, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(364, 154);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(66, 20);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(364, 255);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(78, 20);
            this.lblTc.TabIndex = 1;
            this.lblTc.Text = "T.C. No:";
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbErkek.Location = new System.Drawing.Point(502, 468);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(72, 24);
            this.rdbErkek.TabIndex = 2;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbKadin.Location = new System.Drawing.Point(601, 468);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(72, 24);
            this.rdbKadin.TabIndex = 2;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(364, 362);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(106, 20);
            this.lblTel.TabIndex = 1;
            this.lblTel.Text = "Telefon No:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.Location = new System.Drawing.Point(364, 472);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(83, 20);
            this.lblCinsiyet.TabIndex = 1;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // mtbTel
            // 
            this.mtbTel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mtbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtbTel.Location = new System.Drawing.Point(505, 356);
            this.mtbTel.Mask = "(999) 000-0000";
            this.mtbTel.Name = "mtbTel";
            this.mtbTel.Size = new System.Drawing.Size(131, 26);
            this.mtbTel.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(502, 56);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(161, 26);
            this.txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(502, 148);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(161, 26);
            this.txtSoyad.TabIndex = 4;
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTc.Location = new System.Drawing.Point(502, 249);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(161, 26);
            this.txtTc.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRezervasyonYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezervasyonYap.Location = new System.Drawing.Point(368, 561);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(206, 35);
            this.btnRezervasyonYap.TabIndex = 5;
            this.btnRezervasyonYap.Text = "Rezervasyon Yap";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(368, 616);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(206, 35);
            this.btnTemizle.TabIndex = 5;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            // 
            // btnAdminGirisi
            // 
            this.btnAdminGirisi.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdminGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminGirisi.Location = new System.Drawing.Point(752, 12);
            this.btnAdminGirisi.Name = "btnAdminGirisi";
            this.btnAdminGirisi.Size = new System.Drawing.Size(111, 38);
            this.btnAdminGirisi.TabIndex = 6;
            this.btnAdminGirisi.Text = "Admin Girişi";
            this.btnAdminGirisi.UseVisualStyleBackColor = false;
            this.btnAdminGirisi.Click += new System.EventHandler(this.btnAdminGirisi_Click);
            // 
            // lblKoltukSecimi
            // 
            this.lblKoltukSecimi.AutoSize = true;
            this.lblKoltukSecimi.Location = new System.Drawing.Point(12, 15);
            this.lblKoltukSecimi.Name = "lblKoltukSecimi";
            this.lblKoltukSecimi.Size = new System.Drawing.Size(87, 16);
            this.lblKoltukSecimi.TabIndex = 8;
            this.lblKoltukSecimi.Text = "Koltuk Seçimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(875, 699);
            this.Controls.Add(this.lblKoltukSecimi);
            this.Controls.Add(this.btnAdminGirisi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRezervasyonYap);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mtbTel);
            this.Controls.Add(this.rdbKadin);
            this.Controls.Add(this.rdbErkek);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "NYolculuk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.MaskedTextBox mtbTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAdminGirisi;
        private System.Windows.Forms.Label lblKoltukSecimi;
    }
}

