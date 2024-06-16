namespace EvsizBireylerYardımSistemi
{
    partial class KullaniciInfroForm
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
            this.btnIhtiyacForm = new System.Windows.Forms.Button();
            this.btnBagisForm = new System.Windows.Forms.Button();
            this.btnCıkısYap = new System.Windows.Forms.Button();
            this.btnYardimYerleriForm = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnIhtiyacForm
            // 
            this.btnIhtiyacForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnIhtiyacForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIhtiyacForm.Location = new System.Drawing.Point(86, 92);
            this.btnIhtiyacForm.Name = "btnIhtiyacForm";
            this.btnIhtiyacForm.Size = new System.Drawing.Size(157, 44);
            this.btnIhtiyacForm.TabIndex = 0;
            this.btnIhtiyacForm.Text = "İhtiyaç Kayıt Form";
            this.btnIhtiyacForm.UseVisualStyleBackColor = false;
            this.btnIhtiyacForm.Click += new System.EventHandler(this.btnIhtiyacForm_Click);
            // 
            // btnBagisForm
            // 
            this.btnBagisForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnBagisForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBagisForm.Location = new System.Drawing.Point(321, 92);
            this.btnBagisForm.Name = "btnBagisForm";
            this.btnBagisForm.Size = new System.Drawing.Size(157, 44);
            this.btnBagisForm.TabIndex = 1;
            this.btnBagisForm.Text = "Bagis Kayıt Form";
            this.btnBagisForm.UseVisualStyleBackColor = false;
            this.btnBagisForm.Click += new System.EventHandler(this.btnBagisForm_Click);
            // 
            // btnCıkısYap
            // 
            this.btnCıkısYap.BackColor = System.Drawing.Color.DarkGray;
            this.btnCıkısYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCıkısYap.Location = new System.Drawing.Point(650, 391);
            this.btnCıkısYap.Name = "btnCıkısYap";
            this.btnCıkısYap.Size = new System.Drawing.Size(138, 47);
            this.btnCıkısYap.TabIndex = 2;
            this.btnCıkısYap.Text = "Çıkış Yap";
            this.btnCıkısYap.UseVisualStyleBackColor = false;
            this.btnCıkısYap.Click += new System.EventHandler(this.btnCıkısYap_Click);
            // 
            // btnYardimYerleriForm
            // 
            this.btnYardimYerleriForm.BackColor = System.Drawing.Color.DarkGray;
            this.btnYardimYerleriForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYardimYerleriForm.Location = new System.Drawing.Point(537, 92);
            this.btnYardimYerleriForm.Name = "btnYardimYerleriForm";
            this.btnYardimYerleriForm.Size = new System.Drawing.Size(153, 43);
            this.btnYardimYerleriForm.TabIndex = 3;
            this.btnYardimYerleriForm.Text = "Yarım Yerleri Form";
            this.btnYardimYerleriForm.UseVisualStyleBackColor = false;
            this.btnYardimYerleriForm.Click += new System.EventHandler(this.btnYardimYerleriForm_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(523, 27);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(51, 20);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "label1";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(646, 27);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(51, 20);
            this.lblSaat.TabIndex = 5;
            this.lblSaat.Text = "label1";
            // 
            // KullaniciInfroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnYardimYerleriForm);
            this.Controls.Add(this.btnCıkısYap);
            this.Controls.Add(this.btnBagisForm);
            this.Controls.Add(this.btnIhtiyacForm);
            this.Name = "KullaniciInfroForm";
            this.Text = "Kullanıcı Bilgilendirme Sayfası";
            this.Load += new System.EventHandler(this.KullaniciInfroForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIhtiyacForm;
        private System.Windows.Forms.Button btnBagisForm;
        private System.Windows.Forms.Button btnCıkısYap;
        private System.Windows.Forms.Button btnYardimYerleriForm;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
    }
}