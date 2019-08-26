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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlDataAdapter da;
        ConnectionClass bgl = new ConnectionClass();
        void urunListe()
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            da = new SqlDataAdapter("select *from demirBasListe", connection); //DataAdapter köprü işlevi görür.DataAdapter kendi içerisinde otomatik olarak bağlantıyı açıp kapattığı için Open ve Close() metotlarını kullanmaaya gerek yoktur.
            DataSet ds = new DataSet(); //verileri hafızaya alır.
            da.Fill(ds); // Bir DataSet oluşturularak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            //connection.Close();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirBasDataSet1.demirBasListe' table. You can move, or remove it, as needed.
            this.demirBasListeTableAdapter.Fill(this.demirBasDataSet1.demirBasListe);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_urun_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_urun_adi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_urn_marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_urn_model.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();    
            txt_urun_barkod.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_urun_adet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_alim_tarihi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void Btn_urn_add_Click(object sender, EventArgs e)
        {
            if (txt_urun_id.Text == "" || txt_urun_adi.Text == "" || txt_urn_marka.Text == ""|| txt_urn_model.Text == "" 
                || txt_urun_barkod.Text == "" || txt_urun_adet.Text == "" || txt_alim_tarihi.Text == "")
            {
                MessageBox.Show("Girdilerin hiçbiri boş geçilemez!\nLütfen bütün alanları doldurunuz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string addUrun =
                    "insert into demirBasListe" +
                    "(UrunID,UrunAdi,UrunMarka,UrunModel,UrunBarkod,UrunAdet,AlimTarihi)" +
                    "values(@UrunID,@UrunAdi,@UrunMarka,@UrunModel,@UrunBarkod,@UrunAdet,@AlimTarihi)"; //UrunID @UrunID ile ilişkilendirildi.  

                command = new SqlCommand(addUrun, connection); // Yeni ürün ekleyip kaydedebiliriz.

                command.Parameters.AddWithValue("@UrunID", txt_urun_id.Text);
                command.Parameters.AddWithValue("@UrunAdi", txt_urun_adi.Text);
                command.Parameters.AddWithValue("@UrunMarka", txt_urn_marka.Text);
                command.Parameters.AddWithValue("@UrunModel", txt_urn_model.Text);
                command.Parameters.AddWithValue("@UrunBarkod", txt_urun_barkod.Text);
                command.Parameters.AddWithValue("@UrunAdet", txt_urun_adet.Text);
                command.Parameters.AddWithValue("@AlimTarihi", txt_alim_tarihi.Text);
                try
                {
                    command.ExecuteNonQuery(); //parametreleri güncellemek için kullandık    
                    MessageBox.Show("Ürün başarıyla eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Aynı ID'den ürün zaten var.Lütfen farklı bir id numarası giriniz", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                urunListe();
                connection.Close();
            }   
        }

        private void Btn_urn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise güncelleme yapılacak ürün olmadığı için güncelleme yapılmasın
            {
                MessageBox.Show("Tabloda Güncellenicek Ürün Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string updateUrun =
                    "UPDATE demirBasListe SET UrunID = '" + txt_urun_id.Text + "',UrunAdi = '" + txt_urun_adi.Text +
                    "',UrunMarka = '" + txt_urn_marka.Text + "',UrunModel = '" + txt_urn_model.Text +
                    "',UrunBarkod = '" + txt_urun_barkod.Text + "',UrunAdet = '" + txt_urun_adet.Text +
                    "',AlimTarihi = '" + txt_alim_tarihi.Text + "'where UrunID = '" + txt_urun_id.Text + "'"; //where hangi kritere göre sorgulama yapacagımızı saglar.

                command = new SqlCommand(updateUrun, connection);
                command.ExecuteNonQuery(); // executenonquery veri göndermek için kullanılır.
                urunListe();
                connection.Close();
                MessageBox.Show("Ürün başarıyla güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }         
        }

        private void Btn_urn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise silme işlemi yapılacak personel olmadığı için silme yapılmasın
            {
                MessageBox.Show("Tabloda Silinecek Ürün Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string removeUrun = "DELETE FROM demirBasListe WHERE UrunID = @UrunID"; //where urunıd diyerek urunun id'sini kullanarak sileceğiz.
                command = new SqlCommand(removeUrun, connection);
                command.Parameters.AddWithValue("@UrunID", txt_urun_id.Text);
                command.ExecuteNonQuery(); // veri göndermek için kullanılır
                connection.Close();
                urunListe();
                MessageBox.Show("Ürün başarıyla silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void Txt_urn_ara_Click(object sender, EventArgs e)
        {
            txt_urn_ara.Text = "";
        }

        private void Btn_urn_ara_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            connection.Open();
            DataTable tbl = new DataTable();
            string ara = "select * from demirBasListe where UrunAdi like '%" + txt_urn_ara.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(ara, connection);
            da.Fill(tbl);
            connection.Close();
            dataGridView1.DataSource = tbl;
        }

        private void Btn_excel_aktar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exceldosya = new Microsoft.Office.Interop.Excel.Application(); //excel dosyasını oluşturuyor.
                exceldosya.Visible = true; //excelin açılmasını sağlıyor.
                Microsoft.Office.Interop.Excel.Workbook kitap = exceldosya.Workbooks.Add(System.Reflection.Missing.Value); //Çalışma dosyasını oluşturuyor.
                Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1]; //1.Sayfada çalışacağımızı belirtiyoruz.

                for (int i = 0; i < dataGridView1.Columns.Count; i++) //sütun başlıklarını yazdıralım.
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1]; //i+1den başlamasının sebebi excel'de sütun 1den başlar 
                    myRange.Value2 = dataGridView1.Columns[i].HeaderText; //sütun başlıklarını yazdırdık.
                }

                //datagridview deki degerleri excele aktarmak için 2 tane iç içe for döngüsü kullanmam gerekli. Birisi satırlar biriside sütunlar için.

                for (int i = 0; i < dataGridView1.Columns.Count; i++) //sütun sayısı kadar döner
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++) //satır sayısı kadar döner
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1]; /* 1.satıra sütun başlıklarını yazdık
                    o yüzden j+1, j 0'dan başladıgı ve excelde satırlar 1den başladıgı için bi +1 daha j+2 :) */
                        myRange.Value2 = dataGridView1[i, j].Value; //sütun ve satır indexlerini girdik.
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
            pdfOlustur(dataGridView1, "Urun Listesi");
        }
    }
}
