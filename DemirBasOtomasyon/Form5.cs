using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace DemirBasOtomasyon
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        ConnectionClass bgl = new ConnectionClass();
        SqlCommand command;
        SqlDataAdapter da;

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirBasDataSet2.DevirListe' table. You can move, or remove it, as needed.
            this.devirListeTableAdapter.Fill(this.demirBasDataSet2.DevirListe);
        }
        void urunDevret()
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            da = new SqlDataAdapter("select *from DevirListe", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_urn_ad.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_urn_barkod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_urn_adet.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_urn_mrka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_urn_model.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_stok_tarih.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_devralan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_tc_no.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_tel_no.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void Btn_urn_dvret_Click(object sender, EventArgs e)
        {
            if (txt_urn_ad.Text == "" || txt_urn_barkod.Text == "" || txt_urn_adet.Text == "" 
                || txt_urn_mrka.Text == ""|| txt_urn_model.Text == "" || txt_stok_tarih.Text == "" 
                || txt_devralan.Text == "" || txt_tc_no.Text == "" || txt_tel_no.Text == "")
            {
                MessageBox.Show("Girdilerin hiçbiri boş geçilemez!\nLütfen bütün alanları doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string devret =
                    "insert into DevirListe" +
                    "(UrunAdi,UrunBarkod,UrunAdet,UrunMarka,UrunModel,StokTarihi,Devralan,TCNO,TelefonNo)" +
                    "values(@UrunAdi,@UrunBarkod,@UrunAdet,@UrunMarka,@UrunModel,@StokTarihi,@Devralan,@TCNO,@TelefonNo)";
                command = new SqlCommand(devret, connection);

                command.Parameters.AddWithValue("@UrunAdi", txt_urn_ad.Text);
                command.Parameters.AddWithValue("@UrunBarkod", txt_urn_barkod.Text);
                command.Parameters.AddWithValue("@UrunAdet", txt_urn_adet.Text);
                command.Parameters.AddWithValue("@UrunMarka", txt_urn_mrka.Text);
                command.Parameters.AddWithValue("@UrunModel", txt_urn_model.Text);
                command.Parameters.AddWithValue("@StokTarihi", txt_stok_tarih.Text);
                command.Parameters.AddWithValue("@Devralan", txt_devralan.Text);
                try
                {
                    command.Parameters.AddWithValue("@TelefonNo", txt_tel_no.Text);
                    command.Parameters.AddWithValue("@TCNO", txt_tc_no.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla zimmetlendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("TC veya Telefon No'yu doğru girdiğinizden emin olunuz", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                urunDevret();
                connection.Close();
            }          
        }

        private void Btn_urn_updte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise güncelleme yapılacak veri olmadığı için güncelleme yapılmasın
            {
                MessageBox.Show("Tabloda Güncellenicek Ürün veya Personel Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string updateUrun =
                    "UPDATE DevirListe SET UrunAdi = '" + txt_urn_ad.Text + "',UrunBarkod = '" + txt_urn_barkod.Text +
                    "',UrunAdet = '" + txt_urn_adet.Text + "',UrunMarka = '" + txt_urn_mrka.Text +
                    "',UrunModel = '" + txt_urn_model.Text + "',StokTarihi = '" + txt_stok_tarih.Text +
                    "',Devralan = '" + txt_devralan.Text + "',TCNO = '" + txt_tc_no.Text + "',TelefonNo = '" + txt_tel_no.Text + "' where UrunAdi = '" + txt_urn_ad.Text + "'";
                command = new SqlCommand(updateUrun, connection);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ürün başarıyla güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ürün başarıyla güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                urunDevret();
                connection.Close();
            }      
        }

        private void Btn_urn_rmove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise silme işlemi yapılacak veri olmadığı için silme yapılmasın
            {
                MessageBox.Show("Tabloda Silinecek Ürün veya Personel Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string removeUrun = "DELETE from DevirListe WHERE UrunBarkod = @UrunBarkod"; //Urun Barkoduna göre silsin.
                command = new SqlCommand(removeUrun, connection);
                command.Parameters.AddWithValue("@UrunBarkod", txt_urn_barkod.Text);
                command.ExecuteNonQuery();
                connection.Close();
                urunDevret();
                MessageBox.Show("Ürün başarıyla silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
        }

        private void Txt_kisi_bul_Click(object sender, EventArgs e)
        {
            txt_kisi_bul.Text = "";
        }     

        private void Txt_urun_bul_Click(object sender, EventArgs e)
        {
            txt_urun_bul.Text = "";
        }

        private void Btn_fnd_kisi_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            connection.Open();
            DataTable tbl = new DataTable();
            string ara = "select * from DevirListe where Devralan like '%" + txt_kisi_bul.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(ara, connection);
            da.Fill(tbl);
            connection.Close();
            dataGridView1.DataSource = tbl;
        }

        private void Btn_fnd_urun_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            connection.Open();
            DataTable tbl = new DataTable();
            string ara = "select * from DevirListe where UrunAdi like '%" + txt_urun_bul.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(ara, connection);
            da.Fill(tbl);
            connection.Close();
            dataGridView1.DataSource = tbl;
        }

        private void Btn_excel_aktar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exceldosya = new Microsoft.Office.Interop.Excel.Application(); //excel dosyası olusturduk.
                exceldosya.Visible = true; //excel dosyasını açmamızı sağlar.
                Microsoft.Office.Interop.Excel.Workbook kitap = exceldosya.Workbooks.Add(System.Reflection.Missing.Value); //çalışma dosyasını oluşturduk.
                Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1]; //1.sayfada çalışacağız.

                for (int i = 0; i < dataGridView1.Columns.Count; i++) //datagridview'in sütunlarını yazdıralım
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                    myRange.Value2 = dataGridView1.Columns[i].HeaderText;
                }

                //datagridview'in satırlarını yazdıralım

                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                        myRange.Value2 = dataGridView1[i, j].Value;
                    }
                }
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void pdfOlustur(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.WidthPercentage = 100;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //Add Header
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                //cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }
            //Add datarow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = filename;
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfac = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfac, stream);
                    pdfac.Open();
                    pdfac.Add(pdfTable);
                    pdfac.Close();
                    stream.Close();
                }
            }
        }
        private void Btn_pdf_Click(object sender, EventArgs e)
        {
            pdfOlustur(dataGridView1, "Urun Devir Listesi");
        }
    }
}
