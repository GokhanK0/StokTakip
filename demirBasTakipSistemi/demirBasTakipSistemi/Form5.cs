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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-LIDH3US\\SQLEXPRESS;Initial Catalog=demirBas;Integrated Security=True"); //Sql bağlantı yolumuz.
        private void Btn_sgn_in_Click(object sender, EventArgs e)
        {
          connection.Open();
          SqlCommand command = new SqlCommand("select * from loginPanel where username = '" + txt_usr_nme.Text + "' and password = '" + txt_psswrd.Text + "'", connection);
            SqlDataReader oku = command.ExecuteReader();
            if (oku.Read())
            {
                AnaForm anaSayfa = new AnaForm();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();

          if(chk_remember.Checked)
            {
                Properties.Settings.Default.username = txt_usr_nme.Text;
                Properties.Settings.Default.password = txt_psswrd.Text;
                Properties.Settings.Default.Save();
            }
            
        }

        private void Btn_ext_Click(object sender, EventArgs e)
        {
            this.Close(); // bu sadece ilgili formun kapatılmasına yarar.
            Application.Exit(); // bu uygulamadan çıkar.
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.username != string.Empty && Properties.Settings.Default.password != string.Empty)
            {
                txt_usr_nme.Text = Properties.Settings.Default.username;
                txt_psswrd.Text = Properties.Settings.Default.password;
            }   
            
        }
    }
}

