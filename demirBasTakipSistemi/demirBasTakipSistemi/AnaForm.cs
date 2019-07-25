using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace demirBasTakipSistemi
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        Form3 personelListe;
        Form4 urunListe;
        Form6 demirBasListe;
        Form2 zimmetform;
        private void Brbtn_prsnl_list_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (personelListe == null) //personelListe nesnesi daha once kullanılmamıssa, bilinmiyorsa ;
            {
                personelListe = new Form3();
                personelListe.MdiParent = this; // personelListesinden gelen form degerini suan üzerinde calıstıgım mdi (xtraTabbedMdiManager toolbox'ı) üzerinde aç
                personelListe.Show();
            }
        }

        private void Brbtn_urn_list_ItemClick(object sender, ItemClickEventArgs e)
        {
           //urunListe nesnesi daha önce kullanılmamışsa, yani bilinmiyorsa;
           
                urunListe = new Form4();
                urunListe.MdiParent = this;
                urunListe.Show();
            
        }


        private void Brbtn_exit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Close(); // ilgili Formu Kapatır
            Application.Exit(); // uygulamadan çıkar.
        }

        private void Brbtn_urn_zimmet_ItemClick(object sender, ItemClickEventArgs e)
        {
            demirBasListe = new Form6();
            demirBasListe.MdiParent = this;
            demirBasListe.Show();
        }

        private void Btn_zmmet_form_ItemClick(object sender, ItemClickEventArgs e)
        {
            zimmetform = new Form2();
            //zimmetform.MdiParent = this;
            zimmetform.Show();
        }
    }
}