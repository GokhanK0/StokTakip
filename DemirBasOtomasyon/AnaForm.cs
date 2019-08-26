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

namespace DemirBasOtomasyon
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        Form3 personelListe;
        Form4 urunListe;
        Form5 demirBasListe;
        Form6 zimmetform;
        private void Brbtn_prsnl_list_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personelListe == null) // bu şekilde butona tıklandıgında form birden fazla açılmayacak
            {
                personelListe = new Form3();
                personelListe.MdiParent = this; 
                // personelListesinden gelen form degerini suan üzerinde calıstıgım mdi (xtraTabbedMdiManager toolbox'ı) üzerinde aç
                personelListe.Show();
            }

        }

        private void Brbtn_urn_list_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (urunListe == null)
            {
                urunListe = new Form4();
                urunListe.MdiParent = this;
                urunListe.Show();
            }       
        }

        private void Brbtn_urn_zimmet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (demirBasListe == null)
            {
                demirBasListe = new Form5();
                demirBasListe.MdiParent = this;
                demirBasListe.Show();
            }       
        }

        private void Btn_zmmet_form_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (zimmetform == null)
            {
                zimmetform = new Form6();
                //zimmetform.MdiParent = this;
                zimmetform.Show();
            }        
        }

        private void Brbtn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close(); // ilgili Formu Kapatır
            Application.Exit(); // uygulamadan çıkar.
        }

        private void AnaForm_Load(object sender, EventArgs e)
        { 

        }
    }
}