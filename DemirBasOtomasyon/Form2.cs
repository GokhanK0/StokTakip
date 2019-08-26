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

namespace DemirBasOtomasyon
{
    public partial class Login_Form : Form
    {       
        public Login_Form()
        {
            InitializeComponent();
        }
        ConnectionClass bgl = new ConnectionClass();
        private void Btn_sgn_in_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(bgl.address);
            connection.Open();
            string login = "select * from KayitPanel where UserName = '" + txt_usr_nme.Text + "' and Password = '" + txt_psswrd.Text + "'"; 
            //select * from database mizdeki tabloyu seçer. where komutuyla verilerimizi istediğimiz kriterlere göre getirme işlemini yaparız. 
            SqlCommand command = new SqlCommand(login, connection); //veritabanı işlemlerinin yapılabilmesini sağlar.Veritabanından kayıt getirmek,silmek, güncellemek ve kayıt eklemek için bize aracılık yapar.
            SqlDataReader oku = command.ExecuteReader(); //çalıştıran bağlantı adresimizde geriye birden çok değere dönecekse executeReader()metodu kullanılır.
                                                         //ayrıca tablo için select işlemi yaptıysak select attığımız kayıtları okumak için bu metodu kullanırız.
            if (oku.Read())
            {
                AnaForm anaSayfa = new AnaForm();
                anaSayfa.Show();
                this.Hide();
            }
            //okuma işlemi bittikten sonra SqlDataReader bağlantısının kapatılması gerekir.Read() metodu geriye bool türünde değer döndürmektedir.
            //Okunacak satır var ise true yoksa false döndürür.
            else
            {
                MessageBox.Show("Username or Password incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

            if (chk_remember.Checked)
            {
                Properties.Settings.Default.username = txt_usr_nme.Text; //Remember Me işaretli ise varsayılan textbox ımızı en son girilen değer olarak kaydetsin.
                Properties.Settings.Default.password = txt_psswrd.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty && Properties.Settings.Default.password != string.Empty)
            {
                txt_usr_nme.Text = Properties.Settings.Default.username; //varsayılan kullanıcıadı ve sifre boş boş degilse tutulan degerler textboxa atansın.
                txt_psswrd.Text = Properties.Settings.Default.password;
            }
        }

        private void Btn_ext_Click(object sender, EventArgs e)
        {
            this.Close(); // bu sadece ilgili formun kapatılmasına yarar.
            Application.Exit(); // bu uygulamadan çıkar.
        }

        private void Linklbl_create_accnt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Create_Account createAccount = new Create_Account();
            this.Hide();
            createAccount.Show();
        }

        private void Login_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
