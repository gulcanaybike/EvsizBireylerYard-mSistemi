namespace EvsizBireylerYardımSistemi
{
    partial class IhtiyaclarKayitForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTeminDurum = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgwihtiyaclar = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnAdminPageDon = new System.Windows.Forms.Button();
            this.btnPdfKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwihtiyaclar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(84, 56);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 26);
            this.txtAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(204, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adet:";
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(208, 56);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 26);
            this.txtAdet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(330, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Temin Edilme Durumu:";
            // 
            // txtTeminDurum
            // 
            this.txtTeminDurum.Location = new System.Drawing.Point(334, 56);
            this.txtTeminDurum.Name = "txtTeminDurum";
            this.txtTeminDurum.Size = new System.Drawing.Size(100, 26);
            this.txtTeminDurum.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(84, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 42);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgwihtiyaclar
            // 
            this.dgwihtiyaclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwihtiyaclar.Location = new System.Drawing.Point(84, 172);
            this.dgwihtiyaclar.Name = "dgwihtiyaclar";
            this.dgwihtiyaclar.RowHeadersWidth = 62;
            this.dgwihtiyaclar.RowTemplate.Height = 28;
            this.dgwihtiyaclar.Size = new System.Drawing.Size(662, 216);
            this.dgwihtiyaclar.TabIndex = 7;
            this.dgwihtiyaclar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwihtiyaclar_CellClick);
            this.dgwihtiyaclar.SelectionChanged += new System.EventHandler(this.dgwihtiyaclar_SelectionChanged);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Blue;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(208, 100);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(91, 42);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(324, 100);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(90, 42);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnAdminPageDon
            // 
            this.btnAdminPageDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminPageDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPageDon.Location = new System.Drawing.Point(814, 396);
            this.btnAdminPageDon.Name = "btnAdminPageDon";
            this.btnAdminPageDon.Size = new System.Drawing.Size(133, 58);
            this.btnAdminPageDon.TabIndex = 10;
            this.btnAdminPageDon.Text = "Bilgi Paneline Dön";
            this.btnAdminPageDon.UseVisualStyleBackColor = false;
            this.btnAdminPageDon.Click += new System.EventHandler(this.btnAdminPageDon_Click);
            // 
            // btnPdfKaydet
            // 
            this.btnPdfKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnPdfKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfKaydet.Location = new System.Drawing.Point(631, 115);
            this.btnPdfKaydet.Name = "btnPdfKaydet";
            this.btnPdfKaydet.Size = new System.Drawing.Size(115, 41);
            this.btnPdfKaydet.TabIndex = 11;
            this.btnPdfKaydet.Text = "PDF Kaydet";
            this.btnPdfKaydet.UseVisualStyleBackColor = false;
            this.btnPdfKaydet.Click += new System.EventHandler(this.btnPdfKaydet_Click);
            // 
            // IhtiyaclarKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(992, 480);
            this.Controls.Add(this.btnPdfKaydet);
            this.Controls.Add(this.btnAdminPageDon);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dgwihtiyaclar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTeminDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Name = "IhtiyaclarKayitForm";
            this.Text = "İhtiyaç Kayıt Formu";
            this.Load += new System.EventHandler(this.IhtiyaclarKayitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwihtiyaclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTeminDurum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgwihtiyaclar;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnAdminPageDon;
        private System.Windows.Forms.Button btnPdfKaydet;
    }
}