using EvsizBireylerYardimSistemi;
using EvsizBireylerYardimSistemi.BLL;
using EvsizBireylerYardimSistemi.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvsizBireylerYardımSistemi
{
    public partial class UyeolForm : Form
    {
        public UyeolForm()
        {
            InitializeComponent();
        }

        private void btn_uyeol_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_sifre.Text.Trim() == txt_tekarSifre.Text.Trim())
                {
                    var kulbl = new KullaniciBL();
                    bool sonuc = kulbl.KullaniciEkle(new Kullanici { Tc_No = txt_tcno.Text.Trim(), Ad = txt_ad.Text.Trim(), Soyad = txt_soyad.Text.Trim(), Sifre = txt_sifre.Text.Trim() });
                    MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");
                    txt_tcno.Text = "";
                    txt_ad.Text = "";
                    txt_soyad.Text = "";
                    txt_sifre.Text = "";
                    txt_tekarSifre.Text = "";

                    var frm = new GirisForm();
                    frm.FormClosed += (s, args) => this.Close();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Şifreler uyumlu değil!");

                }

            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı kullanıcı daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show("Veritabanı Hatası");
                        MessageBox.Show(ex.ToString());
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }

        private void btnGirisDon_Click(object sender, EventArgs e)
        {
            var frm = new GirisForm();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }
    }
}
