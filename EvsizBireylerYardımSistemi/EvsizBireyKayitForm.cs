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
using DAL;
using EvsizBireylerYardimSistemi.BLL;
using EvsizBireylerYardimSistemi.MODEL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EvsizBireylerYardımSistemi
{
    public partial class EvsizBireyKayitForm : Form
    {
        //EvsizBireylerBL bireylerBL;
        public int selectedBireyid { get; set; }
        private int isAdmin;
        public EvsizBireyKayitForm(int isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void EvsizBireyKayitForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                btnGuncelle.Enabled = false;
                btnSil.Enabled = false;
                dgwEvsizBireyler.SelectionChanged += DgwEvsizBireyler_SelectionChanged;

                VeriAra("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DgwEvsizBireyler_SelectionChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var bireylerBL = new EvsizBireylerBL();
                bool sonuc = bireylerBL.EvsizBireyEkle(new EvsizBireyler { Tc_No = txtTcNo.Text.Trim(), Adi = txtAdi.Text.Trim(), Yas = Convert.ToInt32(txtYas.Text.Trim()), Cinsiyet = Convert.ToChar(txtCinsiyet.Text.Trim()), Bolge = txtBolge.Text.Trim(), DogumTarihi = dtpDogumTarih.Value.Date, GelirDurumu = txtGelirDurum.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");

                LoadData();

                txtTcNo.Text = "";
                txtAdi.Text = "";
                txtYas.Text = "";
                txtCinsiyet.Text = "";
                txtBolge.Text = "";
                dtpDogumTarih.CustomFormat = null;
                txtGelirDurum.Text = "";
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("Bu numaralı kayıt daha önce kayıtlı");
                        break;
                    default:
                        MessageBox.Show(ex.ToString());
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hata oluştu!");
            }
        }

        private void dgwEvsizBireyler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string bireyid;

            if (rowIndex >= 0)
            {
                bireyid = dgwEvsizBireyler.Rows[rowIndex].Cells[0].Value.ToString();
                txtTcNo.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[1].Value.ToString();
                txtAdi.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[2].Value.ToString();
                txtYas.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[3].Value.ToString();
                txtCinsiyet.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[4].Value.ToString();
                txtBolge.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[5].Value.ToString();
                string dateValue = dgwEvsizBireyler.Rows[rowIndex].Cells[6].Value.ToString();
                txtGelirDurum.Text = dgwEvsizBireyler.Rows[rowIndex].Cells[7].Value.ToString();

                DateTime parseDate;
                if (DateTime.TryParse(dateValue, out parseDate))
                {
                    dtpDogumTarih.Value = parseDate;
                }
                else
                {
                    MessageBox.Show("Geçersiz tarih formatı.");
                }

                selectedBireyid = Convert.ToInt32(bireyid);
            }
        }

        private void LoadData()
        {
            var bireylerBL = new EvsizBireylerBL();
            DataTable dt = bireylerBL.GetAllData();
            dgwEvsizBireyler.DataSource = dt;
            CheckButtons();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var bireylerBL = new EvsizBireylerBL();
                MessageBox.Show(bireylerBL.EvsizBireyGuncelle(new EvsizBireyler { Tc_No = txtTcNo.Text.Trim(), Adi = txtAdi.Text.Trim(), Yas = Convert.ToInt32(txtYas.Text.Trim()), Cinsiyet = Convert.ToChar(txtCinsiyet.Text.Trim()), Bolge = txtBolge.Text.Trim(), DogumTarihi = dtpDogumTarih.Value, GelirDurumu = txtGelirDurum.Text.Trim(), id = selectedBireyid }) ? "Güncelleme Başarılı" : "Güncelleme Başrısız!!");
                LoadData();

                txtTcNo.Text = "";
                txtAdi.Text = "";
                txtYas.Text = "";
                txtCinsiyet.Text = "";
                txtBolge.Text = "";
                dtpDogumTarih.CustomFormat = null;
                txtGelirDurum.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu!!");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var bireylerBL = new EvsizBireylerBL();
                //MessageBox.Show(bireylerBL.EvsizBireySil(selectedBireyid) ? "Silme Başarılı" : "Silme Başarısız!!");
                DialogResult result = MessageBox.Show("Bu kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool isDeleted = bireylerBL.EvsizBireySil(selectedBireyid);
                    string message = isDeleted ? "Silme Başarılı" : "Silme Başarısız!!";
                    MessageBox.Show(message, "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Hayır'a tıklandıysa, işlem iptal edildi mesajı göster
                    MessageBox.Show("İşlem iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadData();
                txtTcNo.Text = "";
                txtAdi.Text = "";
                txtYas.Text = "";
                txtCinsiyet.Text = "";
                txtBolge.Text = "";
                dtpDogumTarih.CustomFormat = null;
                txtGelirDurum.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu!!");
            }

        }

        private void btnAdminPageDon_Click(object sender, EventArgs e)
        {
            var frm = new AdminInfoForm(isAdmin);
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void CheckButtons()
        {
            bool isCellSelected = dgwEvsizBireyler.SelectedCells.Count > 0;

            btnGuncelle.Enabled = isCellSelected;
            btnSil.Enabled = isCellSelected;
        }
        private void dgwEvsizBireyler_SelectionChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void VeriAra(string filter)
        {
            var bireylerBL = new EvsizBireylerBL();
            DataTable dataTable = bireylerBL.GetFilteredData(filter);
            dgwEvsizBireyler.DataSource = dataTable;
        }
        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtAra.Text;
            VeriAra(filterText);
        }
    }
}
