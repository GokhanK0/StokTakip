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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlDataAdapter da;
        ConnectionClass bgl = new ConnectionClass();
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirBasDataSet.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.demirBasDataSet.Personel);
        }

        public void personelListe()
        {
            //Data Source=(localDB)\v11.0;Integrated Security=True;AttachDbFileName='|DataDirectory|\demirBas.mdf'
            SqlConnection connection = new SqlConnection(bgl.address); // üst satırdaki connection stringi text dosyasından alıyoruz 

            da = new SqlDataAdapter("SELECT *FROM Personel", connection); //DataAdapter, DataSet ve Veriler arasındaki köprüdür.
                                                                          //burda önemli olan Open()ve Close()metotları kullanılmamıştır.Çünkü DataAdapter bunu kendi içerisinde gerçekleştirir,gerek yoktur.
                                                                          //DataAdapter verileri DataSet veya DataTable'a Doldurur. (Fill())
            DataSet ds = new DataSet(); //Verileri Hafızaya alır 
            da.Fill(ds); //bir dataset oluşturularak dataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            //connection.Close();
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //tablomuzun ilgili satırına tıkladıgımızda, personelin verileri ilgili textbox'a gelicek
            txt_personel_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soy_isim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //...
            txt_tc_no.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_telefon_no.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_unvan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_meslek.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void Btn_prsnl_ekle_Click(object sender, EventArgs e)
        {
            if (txt_personel_id.Text == "" || txt_isim.Text == "" || txt_soy_isim.Text == ""
                || txt_tc_no.Text == "" || txt_email.Text == "" || txt_telefon_no.Text == ""
                || txt_unvan.Text == "" || txt_meslek.Text == "")
            {
                MessageBox.Show("Girdilerin hiçbiri boş geçilemez!\nLütfen bütün alanları doldurunuz.", "Bilgilendirme", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string addPerson =
                    "INSERT INTO Personel" +
                    "(PersonelID,Isim, Soyisim, TCNO, EmailAdres, TelefonNo, Meslek, Unvan) " +
                    "VALUES(@PersonelID,@Isim,@Soyisim, @TCNO, @EmailAdres, @TelefonNo, @Meslek, @Unvan)";
                //PersonelID @PersonelID ile ilişkilendirildi...    
                command = new SqlCommand(addPerson, connection);//Bu sekilde yeni personel eklenip kaydedilebilir

                command.Parameters.AddWithValue("@PersonelID", txt_personel_id.Text); //değer eklemek için AddWithValue()metodunu kullanırız.
                command.Parameters.AddWithValue("@Isim", txt_isim.Text);
                command.Parameters.AddWithValue("@Soyisim", txt_soy_isim.Text);
                command.Parameters.AddWithValue("@EmailAdres", txt_email.Text);
                command.Parameters.AddWithValue("@Meslek", txt_meslek.Text);
                command.Parameters.AddWithValue("@Unvan", txt_unvan.Text);

                try
                {
                    command.Parameters.AddWithValue("@TCNO", txt_tc_no.Text);
                    command.Parameters.AddWithValue("@TelefonNo", txt_telefon_no.Text);
                    command.ExecuteNonQuery();   //çalıştırılan bağlantı adresimizde geriye veri dönmediğinde bu metod kullanılır.Insert/Update/Delete komutlarını kullanacaksak bu metodu kullanmalıyız. 
                    MessageBox.Show("Personel başarıyla eklendi", "Bilgilendirme",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("TC veya Telefon No'yu doğru girdiğinizden emin olunuz", "INFO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //MessageBox.Show(ex.Message);
                }
                personelListe();
                connection.Close();
            }
        }

        private void Btn_prsn_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise güncelleme yapılacak personel olmadığı için güncelleme yapılmasın
            {
                MessageBox.Show("Tabloda Güncellenicek Personel Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string updatePerson =
                    "UPDATE Personel SET PersonelID = '" + txt_personel_id.Text + "', Isim ='" + txt_isim.Text + "' ,Soyisim = '" + txt_soy_isim.Text +
                    "' ,TCNO = '" + txt_tc_no.Text + "',EmailAdres = '" + txt_email.Text + "',TelefonNo ='" + txt_telefon_no.Text +
                    "',Meslek ='" + txt_meslek.Text + "',Unvan = '" + txt_unvan.Text + "' where PersonelID ='" + txt_personel_id.Text + "'";
                command = new SqlCommand(updatePerson, connection);
                //where hangi kritere göre güncelleyecegimizi secmemizi saglar (PersonelID'ye göre güncelleyecegim)
                try
                {
                    command.ExecuteNonQuery(); //çalıştırılan bağlantı adresimizde geriye veri dönmediğinde bu metod kullanılır.Insert/Update/Delete komutlarını kullanacaksak bu metodu kullanmalıyız. 
                    MessageBox.Show("Personel başarıyla güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("TC veya Telefon No'yu güncellerken hata oluştu", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                personelListe();
                connection.Close();
            }
        }

        private void Btn_prsn_remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0) //eğer tablo boş ise silme işlemi yapılacak personel olmadığı için silme yapılmasın
            {
                MessageBox.Show("Tabloda Silinecek Personel Bulunamadı.\nTablo Boş!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection connection = new SqlConnection(bgl.address);
                connection.Open();
                string deletePerson = "DELETE FROM Personel WHERE PersonelID=@PersonelID";
                command = new SqlCommand(deletePerson, connection);
                command.Parameters.AddWithValue("@PersonelID", txt_personel_id.Text);
                command.ExecuteNonQuery();
                connection.Close();
                personelListe();
                MessageBox.Show("Personel başarıyla silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_prsnl_ara_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            connection.Open();
            DataTable tbl = new DataTable();
            string ara = "select * from Personel where Isim like '%" + txt_isim_ara.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(ara, connection);
            da.Fill(tbl);
            connection.Close();
            dataGridView1.DataSource = tbl;
        }

        private void Txt_isim_ara_Click(object sender, EventArgs e)
        {
            txt_isim_ara.Text = "";
        }

        private void Btn_excel_aktar_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application exceldosya = new Microsoft.Office.Interop.Excel.Application();
                // excel dosyasını oluşturuyor.
                exceldosya.Visible = true; //excel in açılmasını sağlıyor.
                Microsoft.Office.Interop.Excel.Workbook kitap = exceldosya.Workbooks.Add(System.Reflection.Missing.Value);
                //Çalışma dosyasını oluşturuyor.
                Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                //Hangi Sayfada çalışacağımızı belirtiyoruz.(1)

                for (int i = 0; i < dataGridView1.Columns.Count; i++) //döngümüz datagridview in sütun sayısı kadar dönsün.
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1];
                    /* oluşturduğumuz sayfada hangi satır ve sütunda çalışacagımızı belirtiyoruz. 
                   Ayrıca 0. sütun olmadıgı için [1,i+1]'den başlatmalıyız ki [1,1] => (A1) den başlasın :) */
                    myRange.Value2 = dataGridView1.Columns[i].HeaderText; // sütun başlıklarını alır
                }
                //datagridview deki degerleri excele aktarmak için 2 tane iç içe for döngüsü kullanmam gerekli. 
                //Birisi satırlar biriside sütunlar için.

                for (int i = 0; i < dataGridView1.Columns.Count; i++) // sütun sayısı kadar döner
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++) // kaç satır varsa o kadar döner
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1];
                        /* 1.satıra sütun başlıklarını yazdık o yüzden j+1, j 0'dan başladıgı
                        ve excelde satırlar 1den başladıgı için bi +1 daha j+2 :) */
                        myRange.Value2 = dataGridView1[i, j].Value; //sütun ve satır indexlerini girdik.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void pdfOlustur(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            //pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;  //genişlik yüzde 100
            //pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
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
                    Document pdfac = new Document(PageSize.A3.Rotate(), 10f, 10f, 10f, 0f);
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
            pdfOlustur(dataGridView1, "Personel Listesi");
        }
    }
}