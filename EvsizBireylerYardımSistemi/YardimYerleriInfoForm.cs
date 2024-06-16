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
    public partial class YardimYerleriInfoForm : Form
    {
        public int selectedYardimYeriid { get; set; }
        private int isAdmin;
        private List<TextBox> textBoxList;
        public YardimYerleriInfoForm(int isAdmin)
        {
            InitializeComponent();
            LoadData();
            this.isAdmin = isAdmin;
            textBoxList = new List<TextBox> { txtYerAdi, txtCaddeAdi, txtSehirAdi, txtUlkeAdi };
        }

        private void LoadData()
        {
            try
            {
                var yardimYerleriBL = new YardimYerleriBL();
                DataTable dt = yardimYerleriBL.GetAllData();
                dgwYardimYerleri.DataSource = dt;


                if (dgwYardimYerleri.Columns["btn"] == null)
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Konum";
                    btn.Text = "Göster";
                    btn.Name = "btn";
                    btn.UseColumnTextForButtonValue = true;
                    dgwYardimYerleri.Columns.Add(btn);
                }
                CheckButtons();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private void dgwYardimYerleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                string yardimyeriid;
                if (rowIndex >= 0)
                {
                    yardimyeriid = dgwYardimYerleri.Rows[rowIndex].Cells[1].Value.ToString();
                    txtYerAdi.Text = dgwYardimYerleri.Rows[rowIndex].Cells[2].Value.ToString();
                    txtCaddeAdi.Text = dgwYardimYerleri.Rows[rowIndex].Cells[3].Value.ToString();
                    txtSehirAdi.Text = dgwYardimYerleri.Rows[rowIndex].Cells[4].Value.ToString();
                    txtUlkeAdi.Text = dgwYardimYerleri.Rows[rowIndex].Cells[5].Value.ToString();

                    selectedYardimYeriid = Convert.ToInt32(yardimyeriid);
                }

                if (e.ColumnIndex >= 0 && e.ColumnIndex < dgwYardimYerleri.Columns.Count && dgwYardimYerleri.Columns[e.ColumnIndex].Name == "btn")
                {

                    string caddeAdi = dgwYardimYerleri.Rows[e.RowIndex].Cells["caddeAdi"].Value.ToString();
                    string sehirAdi = dgwYardimYerleri.Rows[e.RowIndex].Cells["sehirAdi"].Value.ToString();
                    string ulkeAdi = dgwYardimYerleri.Rows[e.RowIndex].Cells["UlkeAdi"].Value.ToString();
                    string fullAddress = $"{caddeAdi}, {sehirAdi}, {ulkeAdi}";
                    ShowInGoogleMaps(fullAddress);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }

        }

        private void ShowInGoogleMaps(string address)
        {
            string url = "https://www.google.com/maps/search/?api=1&query=" + Uri.EscapeDataString(address);
            System.Diagnostics.Process.Start(url);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var yardimYerleriBL = new YardimYerleriBL();
                bool sonuc = yardimYerleriBL.YardimYeriEkle(new YardimYerleri { yerAdi = txtYerAdi.Text.Trim(), caddeAdi = txtCaddeAdi.Text.Trim(), sehirAdi = txtSehirAdi.Text.Trim(), ulkeAdi = txtUlkeAdi.Text.Trim() });
                MessageBox.Show(sonuc ? "Ekleme Başarılı" : "Ekleme Başarısız!!");
                LoadData();
                foreach (var textBox in textBoxList)
                {
                    textBox.Clear();
                }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwYardimYerleri.SelectedCells.Count > 0)
                {

                    var yardimYerleriBL = new YardimYerleriBL();
                    MessageBox.Show(yardimYerleriBL.YardimYeriGuncelle(new YardimYerleri { yerAdi = txtYerAdi.Text.Trim(), caddeAdi = txtCaddeAdi.Text.Trim(), sehirAdi = txtSehirAdi.Text.Trim(), ulkeAdi = txtUlkeAdi.Text.Trim(), id = selectedYardimYeriid }) ? "Güncelleme Başarılı" : "Güncelleme Başrısız!!");
                    LoadData();
                    foreach (var textBox in textBoxList)
                    {
                        textBox.Clear();
                    }
                }

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
                //var yardimYerleriBL = new YardimYerleriBL();
                //MessageBox.Show(yardimYerleriBL.YardimYeriSil(selectedYardimYeriid) ? "Silme Başarılı" : "Silme Başarısız!!");
                //LoadData();

                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var yardimYerleriBL = new YardimYerleriBL();
                    bool silmeSonucu = yardimYerleriBL.YardimYeriSil(selectedYardimYeriid);
                    MessageBox.Show(silmeSonucu ? "Silme Başarılı" : "Silme Başarısız!!");

                    if (silmeSonucu)
                    {
                        LoadData();
                    }
                    foreach (var textBox in textBoxList)
                    {
                        textBox.Clear();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu!!");
            }

        }
        private void YardimYerleriInfoForm_Load(object sender, EventArgs e)
        {
            if (isAdmin != 1)
            {
                btnGuncelle.Visible = false;
                btnSil.Visible = false;

            }
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgwYardimYerleri.SelectionChanged += dgwYardimYerleri_SelectionChanged;
        }

        private void CheckButtons()
        {
            // DataGridView'da seçili hücre olup olmadığını kontrol et
            bool isCellSelected = dgwYardimYerleri.SelectedCells.Count > 0;

            // Güncelleme ve silme düğmelerini duruma göre etkinleştir veya devre dışı bırak
            btnGuncelle.Enabled = isCellSelected;
            btnSil.Enabled = isCellSelected;
        }

        private void dgwYardimYerleri_SelectionChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }

        private void btnInfoPageDon_Click(object sender, EventArgs e)
        {
            if (isAdmin == 1)
            {
                var frm = new AdminInfoForm(isAdmin);
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
                this.Hide();
            }
            else
            {
                var frm = new KullaniciInfroForm(isAdmin);
                frm.FormClosed += (s, args) => this.Close();
                frm.Show();
                this.Hide();
            }
        }
    }
}
