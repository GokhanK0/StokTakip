using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace demirBasTakipSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.groupBox1.Width, this.groupBox1.Height);
            groupBox1.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, this.groupBox1.Width, this.groupBox1.Height));
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        
        private void Btn_yazdir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
            this.Hide();
        }
 
    }
}
