namespace EvsizBireylerYardımSistemi
{
    partial class BagisKayitForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIhtiyacid = new System.Windows.Forms.TextBox();
            this.txtBagisciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBagisAdet = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgwBagislar = new System.Windows.Forms.DataGridView();
            this.cmbIhtiyaclar = new System.Windows.Forms.ComboBox();
            this.btnAdminPageDon = new System.Windows.Forms.Button();
            this.btnPdfKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBagislar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(52, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ihtiyac Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(194, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bagisci Adi:";
            // 
            // txtIhtiyacid
            // 
            this.txtIhtiyacid.Enabled = false;
            this.txtIhtiyacid.Location = new System.Drawing.Point(56, 77);
            this.txtIhtiyacid.Name = "txtIhtiyacid";
            this.txtIhtiyacid.Size = new System.Drawing.Size(100, 26);
            this.txtIhtiyacid.TabIndex = 2;
            // 
            // txtBagisciAdi
            // 
            this.txtBagisciAdi.Location = new System.Drawing.Point(198, 77);
            this.txtBagisciAdi.Name = "txtBagisciAdi";
            this.txtBagisciAdi.Size = new System.Drawing.Size(100, 26);
            this.txtBagisciAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(338, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bagis Adet:";
            // 
            // txtBagisAdet
            // 
            this.txtBagisAdet.Location = new System.Drawing.Point(342, 77);
            this.txtBagisAdet.Name = "txtBagisAdet";
            this.txtBagisAdet.Size = new System.Drawing.Size(100, 26);
            this.txtBagisAdet.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(56, 118);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 42);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgwBagislar
            // 
            this.dgwBagislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBagislar.Location = new System.Drawing.Point(46, 167);
            this.dgwBagislar.Name = "dgwBagislar";
            this.dgwBagislar.RowHeadersWidth = 62;
            this.dgwBagislar.RowTemplate.Height = 28;
            this.dgwBagislar.Size = new System.Drawing.Size(738, 266);
            this.dgwBagislar.TabIndex = 7;
            this.dgwBagislar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBagislar_CellClick);
            // 
            // cmbIhtiyaclar
            // 
            this.cmbIhtiyaclar.FormattingEnabled = true;
            this.cmbIhtiyaclar.Location = new System.Drawing.Point(506, 75);
            this.cmbIhtiyaclar.Name = "cmbIhtiyaclar";
            this.cmbIhtiyaclar.Size = new System.Drawing.Size(121, 28);
            this.cmbIhtiyaclar.TabIndex = 8;
            // 
            // btnAdminPageDon
            // 
            this.btnAdminPageDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnAdminPageDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPageDon.Location = new System.Drawing.Point(819, 455);
            this.btnAdminPageDon.Name = "btnAdminPageDon";
            this.btnAdminPageDon.Size = new System.Drawing.Size(149, 54);
            this.btnAdminPageDon.TabIndex = 9;
            this.btnAdminPageDon.Text = "Bilgi Paneline Dön";
            this.btnAdminPageDon.UseVisualStyleBackColor = false;
            this.btnAdminPageDon.Click += new System.EventHandler(this.btnAdminPageDon_Click);
            // 
            // btnPdfKaydet
            // 
            this.btnPdfKaydet.BackColor = System.Drawing.Color.DarkGray;
            this.btnPdfKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfKaydet.Location = new System.Drawing.Point(659, 118);
            this.btnPdfKaydet.Name = "btnPdfKaydet";
            this.btnPdfKaydet.Size = new System.Drawing.Size(125, 43);
            this.btnPdfKaydet.TabIndex = 10;
            this.btnPdfKaydet.Text = "PDF Kaydet";
            this.btnPdfKaydet.UseVisualStyleBackColor = false;
            this.btnPdfKaydet.Click += new System.EventHandler(this.btnPdfKaydet_Click);
            // 
            // BagisKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(1036, 534);
            this.Controls.Add(this.btnPdfKaydet);
            this.Controls.Add(this.btnAdminPageDon);
            this.Controls.Add(this.cmbIhtiyaclar);
            this.Controls.Add(this.dgwBagislar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtBagisAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBagisciAdi);
            this.Controls.Add(this.txtIhtiyacid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BagisKayitForm";
            this.Text = "Bağış Kayıt Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.dgwBagislar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIhtiyacid;
        private System.Windows.Forms.TextBox txtBagisciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBagisAdet;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgwBagislar;
        private System.Windows.Forms.ComboBox cmbIhtiyaclar;
        private System.Windows.Forms.Button btnAdminPageDon;
        private System.Windows.Forms.Button btnPdfKaydet;
    }
}