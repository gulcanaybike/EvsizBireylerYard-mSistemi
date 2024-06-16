using DAL;
using EvsizBireylerYardımSistemi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EvsizBireylerYardimSistemi.BLL;
using EvsizBireylerYardimSistemi.MODEL;

namespace EvsizBireylerYardimSistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();

            string[] rol = { "Admin", "Kullanici" };
            cmbRol.Items.AddRange(rol);
            cmbRol.SelectedIndex = 0;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(GirisForm_KeyDown);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            /*using (var context = new ())
            {
                var user = context.tbl_Kullanici.FirstOrDefault(u => u.tc_no == txtTcNo.Text && u.sifre == txtSifre.Text);
                if (user != null)
                {
                    var frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                }
            }*/
            try
            {
                var kulbl = new KullaniciBL();
                int rolDeger = cmbRol.SelectedItem.Equals("Admin") ? 1 : 0;
                //bool isAdmin = Convert.ToBoolean(rolDeger);
                if (kulbl.KullaniciGirisi(txtTcNo.Text.Trim(), txtSifre.Text.Trim(), rolDeger, out Kullanici kullanici))
                {
                    if (rolDeger == 1)
                    {
                        var frm = new AdminInfoForm(rolDeger);

                        //var frm = new EvsizBireyKayitForm();
                        frm.Show();
                        this.Hide();
                        frm.FormClosed += (s, args) =>
                        {
                            this.Close(); // AdminInfoForm kapandığında mevcut formu kapat
                        };
                    }
                    else
                    {
                        var frm = new KullaniciInfroForm(rolDeger);
                        frm.Show();
                        this.Hide();
                        frm.FormClosed += (s, args) =>
                        {
                            this.Close();
                        };
                    }

                }

                else
                {
                    MessageBox.Show("Hatalı Giriş!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Uyeol_Click(object sender, EventArgs e)
        {
            var frm = new UyeolForm();
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) =>
            {
                this.Close();
            };
        }

        private void GirisForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGiris.PerformClick(); 
            }
        }
    }
}
