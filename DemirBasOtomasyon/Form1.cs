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
    public partial class Create_Account : Form
    {
        public Create_Account()
        {
            InitializeComponent();
        }
        ConnectionClass bgl = new ConnectionClass();
        private void Btn_create_accnt_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == txt_repeat_psswrd.Text)
            {
                if (txt_nme.Text == "" || txt_surnme.Text == "" || txt_usrname.Text == "" || txt_password.Text == "" || txt_repeat_psswrd.Text == "")
                {
                    MessageBox.Show("Girdilerin hiçbirisi boş geçilemez", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection connection = new SqlConnection(bgl.address); // hangi veritabanında çalışacağımızı belirtmek için bağlantı adresimizi yazdık.
                    connection.Open();
                    string register = "Insert into KayitPanel(Name,SurName,UserName,Password,VerifyPassword) " +
                        "Values('" + txt_nme.Text + "','" + txt_surnme.Text + "','" + txt_usrname.Text + "','" + //veri eklemek için insert into komutunu kullanırız.
                         txt_password.Text + "','" + txt_repeat_psswrd.Text + "')";
                                                                                    //SqlCommand veritabanı işlemlerinin yapılabilmesini sağlar.Veritabanına kayıt getirmek
                    SqlCommand command = new SqlCommand(register, connection);      //kayıt silmek,güncellemek ve kayıt eklemek için bize aracılık yapar.

                    command.ExecuteNonQuery(); //çalıştırılan bağlantı adresimizde geriye veri dönmediğinde bu metod kullanılır.Insert/Update/Delete komutlarını kullanacaksak bu metodu kullanmalıyız.
                    connection.Close();
                    MessageBox.Show("Kayıt Başarılı.", "Kayıt Formu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                txt_password.Text = "Şifreler uyuşmuyor";
                txt_password.ForeColor = Color.Red;

                txt_repeat_psswrd.Text = "Şifreler uyuşmuyor";
                txt_repeat_psswrd.ForeColor = Color.Red;
            }
        }

        private void Btn_sgn_in_Click(object sender, EventArgs e)
        {
            Login_Form loginPanel = new Login_Form();
            this.Hide();
            loginPanel.Show();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form loginPanel = new Login_Form();
            loginPanel.Show();
        }

        private void Create_Account_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                Login_Form loginPanel = new Login_Form();
                loginPanel.Show();
            }
        }

        private void Txt_password_Click(object sender, EventArgs e)
        {
            txt_password.Text = "";
            txt_password.ForeColor = Color.Black;
        }

        private void Txt_repeat_psswrd_Click(object sender, EventArgs e)
        {
            txt_repeat_psswrd.Text = "";
            txt_repeat_psswrd.ForeColor = Color.Black;
        }
    }
}
