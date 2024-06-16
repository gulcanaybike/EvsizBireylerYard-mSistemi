using EvsizBireylerYardimSistemi.BLL;
using EvsizBireylerYardimSistemi.MODEL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Font = iTextSharp.text.Font;

namespace EvsizBireylerYardımSistemi
{
    public partial class IhtiyaclarKayitForm : Form
    {
        private int isAdmin;
        public int selectedihtiyacid { get; set; }
        private List<TextBox> textBoxList;
        public IhtiyaclarKayitForm(int isAdmin)
        {
            InitializeComponent();
            LoadData();
            this.isAdmin = isAdmin;
            textBoxList = new List<TextBox> { txtAdi, txtAdet, txtTeminDurum };
            //btnSil.Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var ihtiyaclarBL = new IhtiyaclarBL();
                bool sonuc = ihtiyaclarBL.IhtiyacEkle(new Ihtiyaclar { Adi = txtAdi.Text.Trim(), Adet = Convert.ToInt32(txtAdet.Text.Trim()), TeminDurumu = txtTeminDurum.Text.Trim() });
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

        private void LoadData()
        {
            var ihtiyaclarBL = new IhtiyaclarBL();
            DataTable dt = ihtiyaclarBL.GetAllData();
            dgwihtiyaclar.DataSource = dt;
        }

        private void dgwihtiyaclar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string ihtiyacid;
            if (rowIndex >= 0)
            {
                ihtiyacid = dgwihtiyaclar.Rows[rowIndex].Cells[0].Value.ToString();
                txtAdi.Text = dgwihtiyaclar.Rows[rowIndex].Cells[1].Value.ToString();
                txtAdet.Text = dgwihtiyaclar.Rows[rowIndex].Cells[2].Value.ToString();
                txtTeminDurum.Text = dgwihtiyaclar.Rows[rowIndex].Cells[3].Value.ToString();

                selectedihtiyacid = Convert.ToInt32(ihtiyacid);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var ihtiyaclarBL = new IhtiyaclarBL();
                MessageBox.Show(ihtiyaclarBL.IhtiyacGuncelle(new Ihtiyaclar { Adi = txtAdi.Text.Trim(), Adet = Convert.ToInt32(txtAdet.Text.Trim()), TeminDurumu = txtTeminDurum.Text.Trim(), id = selectedihtiyacid }) ? "Güncelleme Başarılı" : "Güncelleme Başrısız!!");
                LoadData();
                foreach (var textBox in textBoxList)
                {
                    textBox.Clear();
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
                if (MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var ihtiyaclarBL = new IhtiyaclarBL();
                    bool silmeSonucu = ihtiyaclarBL.IhtiyacSil(selectedihtiyacid);
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
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu!!");
                Console.WriteLine(ex);
            }
        }

        private void btnAdminPageDon_Click(object sender, EventArgs e)
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

        private void IhtiyaclarKayitForm_Load(object sender, EventArgs e)
        {
            //if (isAdmin != 1)
            //{
            //    btnAdminPageDon.Visible = false;
            //}

            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgwihtiyaclar.SelectionChanged += dgwihtiyaclar_SelectionChanged;
        }

        private void CheckButtons()
        {
            bool isCellSelected = dgwihtiyaclar.SelectedCells.Count > 0;

            btnGuncelle.Enabled = isCellSelected;
            btnSil.Enabled = isCellSelected;
        }

        private void dgwihtiyaclar_SelectionChanged(object sender, EventArgs e)
        {
            CheckButtons();
        }
        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
            try
            {
                //Document nesnesini yarat
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open();


                //Başlık 
                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                Paragraph title = new Paragraph("Ihtiyaçlar Listesi", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f; //Başlık sonrası boşluk için
                doc.Add(title);

                //DataGridView da olan kolon sayısı kadar kolon oluştur
                PdfPTable table = new PdfPTable(dgv.Columns.Count);
               
                // DataGridView'den başlıkları ekle
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgv.Columns[i].HeaderText));
                }

                // DataGridView'den satırları ekle
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (dgv[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dgv[j, i].Value.ToString()));
                        }
                    }
                }
                //Tabloyu ekle
                doc.Add(table);
                doc.Close();

                MessageBox.Show("PDF dosyası başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPdfKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportDataGridViewToPDF(dgwihtiyaclar, saveFileDialog.FileName);
            }
        }
    }
}
