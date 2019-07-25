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

namespace demirBasTakipSistemi
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LIDH3US\\SQLEXPRESS;Initial Catalog=demirBas;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter da;
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirBasDataSet7.DevirListe' table. You can move, or remove it, as needed.
            this.devirListeTableAdapter.Fill(this.demirBasDataSet7.DevirListe);
            // TODO: This line of code loads data into the 'demirBasDataSet6.demirBasListe' table. You can move, or remove it, as needed.
            this.demirBasListeTableAdapter.Fill(this.demirBasDataSet6.demirBasListe);

            connection.Open();
            command = new SqlCommand("Select TCNO from Personel", connection);
            SqlDataReader dr = command.ExecuteReader();
            //ExecuteNonQuery insert update ve delete komutlarında kullanılıyor.
            //ExecuteReader ise select komutunda kullanılır.
            
            connection.Close();
        }

        void urunDevret()
        {
            da = new SqlDataAdapter("select *from DevirListe", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
       

        private void Btn_urn_dvret_Click(object sender, EventArgs e)
        {
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
            command.Parameters.AddWithValue("@TCNO", txt_tc_no.Text);
            command.Parameters.AddWithValue("@TelefonNo", txt_tel_no.Text);

            command.ExecuteNonQuery();
            urunDevret();
            connection.Close();
        }

        private void Btn_urn_updte_Click(object sender, EventArgs e)
        {
            connection.Open();
            string updateUrun =
                "UPDATE DevirListe SET UrunAdi = '" + txt_urn_ad.Text + "',UrunBarkod = '" + txt_urn_barkod.Text +
                "',UrunAdet = '" + txt_urn_adet.Text + "',UrunMarka = '" + txt_urn_mrka.Text +
                "',UrunModel = '" + txt_urn_model.Text + "',StokTarihi = '" + txt_stok_tarih.Text +
                "',Devralan = '" + txt_devralan.Text + "',TCNO = '" + txt_tc_no.Text + "',TelefonNo = '" + txt_tel_no.Text + "' where UrunAdi = '" + txt_urn_ad.Text + "'";

            command = new SqlCommand(updateUrun, connection);
            command.ExecuteNonQuery();
            urunDevret();
            connection.Close();
        }

        private void Btn_urn_rmove_Click(object sender, EventArgs e)
        {
            connection.Open();
            string removeUrun = "DELETE from DevirListe WHERE UrunBarkod = @UrunBarkod"; //UrunAdina göre silsin.
            command = new SqlCommand(removeUrun, connection);
            command.Parameters.AddWithValue("@UrunBarkod", txt_urn_barkod.Text);
            command.ExecuteNonQuery();
            connection.Close();
            urunDevret();
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
        private void Btn_fnd_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataTable tbl = new DataTable();
            string ara = "select * from DevirListe where Devralan like '%" + txt_demirbas.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(ara, connection);
            da.Fill(tbl);
            connection.Close();
            dataGridView1.DataSource = tbl;
        }
      

        private void Txt_demirbas_Click(object sender, EventArgs e)
        {
            txt_demirbas.Text = "";
        }

        private void Btn_excel_aktar_Click(object sender, EventArgs e)
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
    }
}
