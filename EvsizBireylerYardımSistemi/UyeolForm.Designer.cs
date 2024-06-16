namespace EvsizBireylerYardımSistemi
{
    partial class UyeolForm
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
            this.txt_tcno = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tekarSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_uyeol = new System.Windows.Forms.Button();
            this.btnGirisDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tcno
            // 
            this.txt_tcno.Location = new System.Drawing.Point(242, 25);
            this.txt_tcno.Name = "txt_tcno";
            this.txt_tcno.Size = new System.Drawing.Size(100, 26);
            this.txt_tcno.TabIndex = 0;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(242, 73);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 26);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(242, 118);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(100, 26);
            this.txt_soyad.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(242, 166);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 26);
            this.txt_sifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(179, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(190, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(178, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(190, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Şifre:";
            // 
            // txt_tekarSifre
            // 
            this.txt_tekarSifre.Location = new System.Drawing.Point(242, 211);
            this.txt_tekarSifre.Name = "txt_tekarSifre";
            this.txt_tekarSifre.Size = new System.Drawing.Size(100, 26);
            this.txt_tekarSifre.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(141, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tekrar Şifre:";
            // 
            // btn_uyeol
            // 
            this.btn_uyeol.BackColor = System.Drawing.Color.Blue;
            this.btn_uyeol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uyeol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_uyeol.Location = new System.Drawing.Point(242, 259);
            this.btn_uyeol.Name = "btn_uyeol";
            this.btn_uyeol.Size = new System.Drawing.Size(100, 32);
            this.btn_uyeol.TabIndex = 10;
            this.btn_uyeol.Text = "Üye Ol";
            this.btn_uyeol.UseVisualStyleBackColor = false;
            this.btn_uyeol.Click += new System.EventHandler(this.btn_uyeol_Click);
            // 
            // btnGirisDon
            // 
            this.btnGirisDon.BackColor = System.Drawing.Color.DarkGray;
            this.btnGirisDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGirisDon.Location = new System.Drawing.Point(215, 317);
            this.btnGirisDon.Name = "btnGirisDon";
            this.btnGirisDon.Size = new System.Drawing.Size(159, 39);
            this.btnGirisDon.TabIndex = 11;
            this.btnGirisDon.Text = "Giriş Sayfasına Dön";
            this.btnGirisDon.UseVisualStyleBackColor = false;
            this.btnGirisDon.Click += new System.EventHandler(this.btnGirisDon_Click);
            // 
            // UyeolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(574, 381);
            this.Controls.Add(this.btnGirisDon);
            this.Controls.Add(this.btn_uyeol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tekarSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_tcno);
            this.Name = "UyeolForm";
            this.Text = "Üye Olma Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tcno;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tekarSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_uyeol;
        private System.Windows.Forms.Button btnGirisDon;
    }
}