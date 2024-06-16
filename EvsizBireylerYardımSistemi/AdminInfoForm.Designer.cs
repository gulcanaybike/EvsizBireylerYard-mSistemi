namespace EvsizBireylerYardımSistemi
{
    partial class AdminInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.btnEvsizBireyKayit = new System.Windows.Forms.Button();
            this.btnIhtiyacForm = new System.Windows.Forms.Button();
            this.dgwKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnGirisFormDon = new System.Windows.Forms.Button();
            this.btnBagisForm = new System.Windows.Forms.Button();
            this.btnYardimYerleriForm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEvsizBireyKayit
            // 
            this.btnEvsizBireyKayit.BackColor = System.Drawing.Color.DarkGray;
            this.btnEvsizBireyKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvsizBireyKayit.Location = new System.Drawing.Point(73, 81);
            this.btnEvsizBireyKayit.Name = "btnEvsizBireyKayit";
            this.btnEvsizBireyKayit.Size = new System.Drawing.Size(188, 51);
            this.btnEvsizBireyKayit.TabIndex = 0;
            this.btnEvsizBireyKayit.Text = "Evsiz Birey Kayıt Formu";
            this.btnEvsizBireyKayit.UseVisualStyleBackColor = false;
            this.btnEvsizBireyKayit.Click += new System.EventHandler(this.btnEvsizBireyKayit_Click);
            // 
            // btnIhtiyacForm
            // 
            this.btnIhtiyacForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnIhtiyacForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIhtiyacForm.Location = new System.Drawing.Point(294, 81);
            this.btnIhtiyacForm.Name = "btnIhtiyacForm";
            this.btnIhtiyacForm.Size = new System.Drawing.Size(148, 51);
            this.btnIhtiyacForm.TabIndex = 1;
            this.btnIhtiyacForm.Text = "İhtiyaç Kayıt Form";
            this.btnIhtiyacForm.UseVisualStyleBackColor = false;
            this.btnIhtiyacForm.Click += new System.EventHandler(this.btnIhtiyacForm_Click);
            // 
            // dgwKullanicilar
            // 
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanicilar.Location = new System.Drawing.Point(73, 164);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.RowHeadersWidth = 62;
            this.dgwKullanicilar.RowTemplate.Height = 28;
            this.dgwKullanicilar.Size = new System.Drawing.Size(587, 253);
            this.dgwKullanicilar.TabIndex = 2;
            // 
            // btnGirisFormDon
            // 
            this.btnGirisFormDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnGirisFormDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisFormDon.Location = new System.Drawing.Point(785, 394);
            this.btnGirisFormDon.Name = "btnGirisFormDon";
            this.btnGirisFormDon.Size = new System.Drawing.Size(122, 53);
            this.btnGirisFormDon.TabIndex = 3;
            this.btnGirisFormDon.Text = "Giris Ekranına Don";
            this.btnGirisFormDon.UseVisualStyleBackColor = false;
            this.btnGirisFormDon.Click += new System.EventHandler(this.btnGirisFormDon_Click);
            // 
            // btnBagisForm
            // 
            this.btnBagisForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnBagisForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBagisForm.Location = new System.Drawing.Point(486, 81);
            this.btnBagisForm.Name = "btnBagisForm";
            this.btnBagisForm.Size = new System.Drawing.Size(148, 51);
            this.btnBagisForm.TabIndex = 4;
            this.btnBagisForm.Text = "Bagis Kayıt Form";
            this.btnBagisForm.UseVisualStyleBackColor = false;
            this.btnBagisForm.Click += new System.EventHandler(this.btnBagisForm_Click);
            // 
            // btnYardimYerleriForm
            // 
            this.btnYardimYerleriForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnYardimYerleriForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYardimYerleriForm.Location = new System.Drawing.Point(669, 81);
            this.btnYardimYerleriForm.Name = "btnYardimYerleriForm";
            this.btnYardimYerleriForm.Size = new System.Drawing.Size(150, 51);
            this.btnYardimYerleriForm.TabIndex = 5;
            this.btnYardimYerleriForm.Text = "Yarım Yerleri Form";
            this.btnYardimYerleriForm.UseVisualStyleBackColor = false;
            this.btnYardimYerleriForm.Click += new System.EventHandler(this.btnYardimYerleriForm_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(674, 32);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(51, 20);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "label1";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(805, 32);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(51, 20);
            this.lblSaat.TabIndex = 7;
            this.lblSaat.Text = "label1";
            // 
            // AdminInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(936, 482);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnYardimYerleriForm);
            this.Controls.Add(this.btnBagisForm);
            this.Controls.Add(this.btnGirisFormDon);
            this.Controls.Add(this.dgwKullanicilar);
            this.Controls.Add(this.btnIhtiyacForm);
            this.Controls.Add(this.btnEvsizBireyKayit);
            this.Name = "AdminInfoForm";
            this.Text = "Admin Bilgilendirme Sayfası";
            this.Load += new System.EventHandler(this.AdminInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEvsizBireyKayit;
        private System.Windows.Forms.Button btnIhtiyacForm;
        private System.Windows.Forms.DataGridView dgwKullanicilar;
        private System.Windows.Forms.Button btnGirisFormDon;
        private System.Windows.Forms.Button btnBagisForm;
        private System.Windows.Forms.Button btnYardimYerleriForm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
    }
}