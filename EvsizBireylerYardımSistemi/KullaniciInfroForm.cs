using EvsizBireylerYardimSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvsizBireylerYardımSistemi
{
    public partial class KullaniciInfroForm : Form
    {
        private int isAdmin;
        public KullaniciInfroForm(int isAdmin)
        {
            InitializeComponent();
            InitializeTimer();
            this.isAdmin = isAdmin;
        }

        private void InitializeTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 saniye
            timer.Tick += new EventHandler(UpdateDateTime);
            UpdateDateTime(null, null); // Form yüklenirken hemen tarih ve saat bilgilerini güncelle
            timer.Start();
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss");
            lblTarih.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        private void btnIhtiyacForm_Click(object sender, EventArgs e)
        {
            var frm = new IhtiyaclarKayitForm(isAdmin);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btnBagisForm_Click(object sender, EventArgs e)
        {
            var frm = new BagisKayitForm(isAdmin);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btnCıkısYap_Click(object sender, EventArgs e)
        {
            var frm = new GirisForm();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void btnYardimYerleriForm_Click(object sender, EventArgs e)
        {
            var frm = new YardimYerleriInfoForm(isAdmin);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void KullaniciInfroForm_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }
    }
}
