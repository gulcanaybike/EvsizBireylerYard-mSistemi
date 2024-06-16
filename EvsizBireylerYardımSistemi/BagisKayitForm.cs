using EvsizBireylerYardimSistemi.BLL;
using EvsizBireylerYardimSistemi.MODEL;
using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace EvsizBireylerYardımSistemi
{
    public partial class BagisKayitForm : Form
    {
        private int isAdmin;
        private DataTable dtihtiac;
        public BagisKayitForm(int isAdmin)
        {
            InitializeComponent();
            LoadData();
            cmbIhtiyaclar.SelectedIndexChanged += cmbIhtiyaclar_SelectedIndexChanged;
            this.isAdmin = isAdmin;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIhtiyacid = Convert.ToInt32(cmbIhtiyaclar.SelectedValue);
                var bagislarBL = new BagislarBL();
                bool sonuc = bagislarBL.BagisEkle(new Bagislar { ihtiyacId = Convert.ToInt32(txtIhtiyacid.Text.Trim()), bagisciAdi = txtBagisciAdi.Text.Trim(), bagisciAdet = Convert.ToInt32(txtBagisAdet.Text.Trim()) });

                bool ihtiyacGuncelle = bagislarBL.updateIhtiyaclar(new Bagislar { ihtiyacId = Convert.ToInt32(txtIhtiyacid.Text.Trim()), bagisciAdet = Convert.ToInt32(txtBagisAdet.Text.Trim()) });
                if (ihtiyacGuncelle)
                {
                    bagislarBL.updateTeminDurum(selectedIhtiyacid);
                    RemoveIhtiyacFromComboBox(selectedIhtiyacid);
                }
                MessageBox.Show(sonuc && ihtiyacGuncelle ? "Ekleme Başarılı" : "Ekleme Başarısız!!");

                LoadData();

                txtBagisciAdi.Clear();
                txtBagisAdet.Clear();
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
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!" + ex);
                Console.WriteLine(ex);
            }
        }

        private void cmbIhtiyaclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIhtiyaclar.SelectedItem != null)
            {
                DataRowView drv = cmbIhtiyaclar.SelectedItem as DataRowView;
                if (drv != null)
                {
                    txtIhtiyacid.Text = drv["id"].ToString();
                }
            }
        }
        private void LoadData()
        {
            var bagislarBL = new BagislarBL();
            DataTable dt = bagislarBL.GetAllData();
            dgwBagislar.DataSource = dt;

            dtihtiac = bagislarBL.LoadIhtiyaclar();
            cmbIhtiyaclar.DataSource = dtihtiac;
            cmbIhtiyaclar.DisplayMember = "Adi";
            cmbIhtiyaclar.ValueMember = "id";
        }

        private void RemoveIhtiyacFromComboBox(int ihtiyacId)
        {
            DataRow[] rows = dtihtiac.Select($"id = {ihtiyacId}");
            if (rows.Length > 0)
            {
                foreach (DataRow row in rows)
                {
                    dtihtiac.Rows.Remove(row);
                }
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

        private void dgwBagislar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                txtIhtiyacid.Text = dgwBagislar.Rows[rowIndex].Cells[0].Value.ToString();
                txtBagisciAdi.Text = dgwBagislar.Rows[rowIndex].Cells[2].Value.ToString();
                txtBagisAdet.Text = dgwBagislar.Rows[rowIndex].Cells[3].Value.ToString();
            }
        }
        private void ExportDataGridViewToPDF(DataGridView dgv, string fileName)
        {
            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(fileName, FileMode.Create));
                doc.Open();

                iTextSharp.text.Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA, 18, iTextSharp.text.Font.BOLD);
                Paragraph title = new Paragraph("Bagislar Listesi", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                title.SpacingAfter = 20f;
                doc.Add(title);

                PdfPTable table = new PdfPTable(dgv.Columns.Count);

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dgv.Columns[i].HeaderText));
                }

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
                ExportDataGridViewToPDF(dgwBagislar, saveFileDialog.FileName);
            }
        }
    }
}
