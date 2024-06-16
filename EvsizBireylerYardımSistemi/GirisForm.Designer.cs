namespace EvsizBireylerYardimSistemi
{
    partial class GirisForm
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
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Uyeol = new System.Windows.Forms.Button();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(231, 90);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(129, 26);
            this.txtTcNo.TabIndex = 0;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(231, 160);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(129, 26);
            this.txtSifre.TabIndex = 1;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Location = new System.Drawing.Point(241, 208);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(107, 37);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(159, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TC No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(174, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // btn_Uyeol
            // 
            this.btn_Uyeol.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Uyeol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Uyeol.Location = new System.Drawing.Point(241, 274);
            this.btn_Uyeol.Name = "btn_Uyeol";
            this.btn_Uyeol.Size = new System.Drawing.Size(107, 37);
            this.btn_Uyeol.TabIndex = 5;
            this.btn_Uyeol.Text = "Üye Ol";
            this.btn_Uyeol.UseVisualStyleBackColor = false;
            this.btn_Uyeol.Click += new System.EventHandler(this.btn_Uyeol_Click);
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(416, 88);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 28);
            this.cmbRol.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(200, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hoş Geldiniz!";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EvsizBireylerYardımSistemi.Properties.Resources.forrest_cavale_jwIk4Z3Msi4_unsplash;
            this.ClientSize = new System.Drawing.Size(607, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.btn_Uyeol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTcNo);
            this.Name = "GirisForm";
            this.Text = "Giriş Sayfası";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GirisForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Uyeol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label3;
    }
}

