namespace EvsizBireylerYardımSistemi
{
    partial class YardimYerleriInfoForm
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
            this.dgwYardimYerleri = new System.Windows.Forms.DataGridView();
            this.txtYerAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaddeAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSehirAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUlkeAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnInfoPageDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYardimYerleri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwYardimYerleri
            // 
            this.dgwYardimYerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwYardimYerleri.Location = new System.Drawing.Point(67, 173);
            this.dgwYardimYerleri.Name = "dgwYardimYerleri";
            this.dgwYardimYerleri.RowHeadersWidth = 62;
            this.dgwYardimYerleri.RowTemplate.Height = 28;
            this.dgwYardimYerleri.Size = new System.Drawing.Size(861, 247);
            this.dgwYardimYerleri.TabIndex = 0;
            this.dgwYardimYerleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYardimYerleri_CellClick);
            this.dgwYardimYerleri.SelectionChanged += new System.EventHandler(this.dgwYardimYerleri_SelectionChanged);
            // 
            // txtYerAdi
            // 
            this.txtYerAdi.Location = new System.Drawing.Point(67, 76);
            this.txtYerAdi.Name = "txtYerAdi";
            this.txtYerAdi.Size = new System.Drawing.Size(109, 26);
            this.txtYerAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(67, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yerin Adı:";
            // 
            // txtCaddeAdi
            // 
            this.txtCaddeAdi.Location = new System.Drawing.Point(216, 76);
            this.txtCaddeAdi.Name = "txtCaddeAdi";
            this.txtCaddeAdi.Size = new System.Drawing.Size(109, 26);
            this.txtCaddeAdi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(212, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cadde Adı:";
            // 
            // txtSehirAdi
            // 
            this.txtSehirAdi.Location = new System.Drawing.Point(360, 76);
            this.txtSehirAdi.Name = "txtSehirAdi";
            this.txtSehirAdi.Size = new System.Drawing.Size(109, 26);
            this.txtSehirAdi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(360, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şehir Adi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(503, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ülke Adı:";
            // 
            // txtUlkeAdi
            // 
            this.txtUlkeAdi.Location = new System.Drawing.Point(507, 75);
            this.txtUlkeAdi.Name = "txtUlkeAdi";
            this.txtUlkeAdi.Size = new System.Drawing.Size(100, 26);
            this.txtUlkeAdi.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(71, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(83, 39);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(187, 108);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(86, 38);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(307, 109);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 38);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnInfoPageDon
            // 
            this.btnInfoPageDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnInfoPageDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPageDon.Location = new System.Drawing.Point(844, 426);
            this.btnInfoPageDon.Name = "btnInfoPageDon";
            this.btnInfoPageDon.Size = new System.Drawing.Size(158, 48);
            this.btnInfoPageDon.TabIndex = 11;
            this.btnInfoPageDon.Text = "Bilgi Paneline Dön";
            this.btnInfoPageDon.UseVisualStyleBackColor = false;
            this.btnInfoPageDon.Click += new System.EventHandler(this.btnInfoPageDon_Click);
            // 
            // YardimYerleriInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(1014, 486);
            this.Controls.Add(this.btnInfoPageDon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtUlkeAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSehirAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaddeAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYerAdi);
            this.Controls.Add(this.dgwYardimYerleri);
            this.Name = "YardimYerleriInfoForm";
            this.Text = "Yardım Yerleri Bilgilendirme Form";
            this.Load += new System.EventHandler(this.YardimYerleriInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwYardimYerleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwYardimYerleri;
        private System.Windows.Forms.TextBox txtYerAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaddeAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSehirAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUlkeAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnInfoPageDon;
    }
}