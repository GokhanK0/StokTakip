using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace demirBasTakipSistemi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        
        SqlCommand command;   
        SqlDataAdapter da;     
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LIDH3US\\SQLEXPRESS;Initial Catalog=demirBas;Integrated Security=True");
        public void personelListe()
        {
            da = new SqlDataAdapter("SELECT *FROM Personel", connection); //DataAdapter köprü işlevi görür
            DataSet ds = new DataSet(); //Verileri Hafızaya alır 
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connection.Close();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirBasDataSet.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.demirBasDataSet.Personel);
        }

        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_personel_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //tablomuzun ilgili satırına tıkladıgımızda, personelin id si ilgili textbox'a gelicek
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //personelin adını textbox'a getirecek ....
            txt_soy_isim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_tc_no.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_telefon_no.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_unvan.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_meslek.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }
        private void Btn_prsnl_ekle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txt_personel_id.Text == dataGridView1.Rows[i].Cells[0].Value.ToString())
                {
                    MessageBox.Show("Aynı ID'den ürün zaten var.Lütfen farklı bir id numarası giriniz", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            connection.Open();
            string addPerson =
                "INSERT INTO Personel" +
                "(PersonelID,Isim, Soyisim, TCNO, EmailAdres, TelefonNo, Meslek, Unvan) " +
                "VALUES(@PersonelID,@Isim,@Soyisim, @TCNO, @EmailAdres, @TelefonNo, @Meslek, @Unvan)";
            //PersonelID @PersonelID ile ilişkilendirildi...    
            command = new SqlCommand(addPerson, connection);   //Bu sekilde yeni personel eklenip kaydedilebilir

            command.Parameters.AddWithValue("@PersonelID", txt_personel_id.Text);
            command.Parameters.AddWithValue("@Isim", txt_isim.Text);
            command.Parameters.AddWithValue("@Soyisim", txt_soy_isim.Text);
            command.Parameters.AddWithValue("@TCNO", txt_tc_no.Text);
            command.Parameters.AddWithValue("@EmailAdres", txt_email.Text);     
            command.Parameters.AddWithValue("@TelefonNo", txt_telefon_no.Text);
            command.Parameters.AddWithValue("@Meslek", txt_meslek.Text);
            command.Parameters.AddWithValue("@Unvan", txt_unvan.Text);
          
            command.ExecuteNonQuery();   //Parametreleri güncellemek için kullandık                
            personelListe();
            connection.Close();            
            
        }

        private void Btn_prsn_update_Click(object sender, EventArgs e)
        {
            connection.Open();
            string updatePerson =
                "UPDATE Personel SET PersonelID = '" + txt_personel_id.Text + "', Isim ='" + txt_isim.Text + "' ,Soyisim = '" + txt_soy_isim.Text +
                "' ,TCNO = '" + txt_tc_no.Text + "',EmailAdres = '" + txt_email.Text + "',TelefonNo ='" + txt_telefon_no.Text +
                "',Meslek ='" + txt_meslek.Text + "',Unvan = '" + txt_unvan.Text + "' where PersonelID ='" + txt_personel_id.Text + "'";
            command = new SqlCommand(updatePerson, connection);
            //where hangi kritere göre güncelleyecegimizi secmemizi saglar (PersonelID'ye göre güncelleyecegim)
            command.ExecuteNonQuery(); // veri göndermek için kullanılır
            personelListe();
            connection.Close();
        }

        private void Btn_prsn_remove_Click(object sender, EventArgs e)
        {
            connection.Open();
            string deletePerson = "DELETE FROM Personel WHERE PersonelID=@PersonelID";
            command = new SqlCommand(deletePerson, connection);
            command.Parameters.AddWithValue("@PersonelID", txt_personel_id.Text);
            command.ExecuteNonQuery();
            connection.Close();
            personelListe();
        }

        private void Btn_prsnl_ara_Click(object sender, EventArgs e)
        {
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
            Microsoft.Office.Interop.Excel.Application exceldosya = new Microsoft.Office.Interop.Excel.Application(); // excel dosyasını oluşturuyor.
            exceldosya.Visible = true; //excel in açılmasını sağlıyor.
            Microsoft.Office.Interop.Excel.Workbook kitap = exceldosya.Workbooks.Add(System.Reflection.Missing.Value); //Çalışma dosyasını oluşturuyor.
            Microsoft.Office.Interop.Excel.Worksheet sayfa = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1]; //Hangi Sayfada çalışacağımızı belirtiyoruz.(1)

            for (int i = 0; i < dataGridView1.Columns.Count; i++) //döngümüz datagridview in sütun sayısı kadar dönsün.
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[1, i + 1]; /* oluşturduğumuz sayfada hangi satır ve sütunda
                çalışacagımızı belirtiyoruz. Ayrıca 0. sütun olmadıgı için [1,i+1]'den başlatmalıyız ki [1,1] => (A1) den başlasın :) */
                myRange.Value2 = dataGridView1.Columns[i].HeaderText; // sütun başlıklarını alır
            }

            //datagridview deki degerleri excele aktarmak için 2 tane iç içe for döngüsü kullanmam gerekli. Birisi satırlar biriside sütunlar için.

            for (int i = 0; i < dataGridView1.Columns.Count; i++) // sütun sayısı kadar döner
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++) // kaç satır varsa o kadar döner
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sayfa.Cells[j + 2, i + 1]; /* 1.satıra sütun başlıklarını yazdık
                    o yüzden j+1, j 0'dan başladıgı ve excelde satırlar 1den başladıgı için bi +1 daha j+2 :) */
                    myRange.Value2 = dataGridView1[i, j].Value; //sütun ve satır indexlerini girdik.
                }
            }

        }
    }
}
