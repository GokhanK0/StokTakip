namespace DemirBasOtomasyon
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_urun_bul = new System.Windows.Forms.TextBox();
            this.btn_urn_updte = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_dvret = new DevExpress.XtraEditors.SimpleButton();
            this.txt_kisi_bul = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tc_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_devralan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_stok_tarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_urn_model = new System.Windows.Forms.TextBox();
            this.txt_urn_mrka = new System.Windows.Forms.TextBox();
            this.txt_urn_adet = new System.Windows.Forms.TextBox();
            this.txt_urn_barkod = new System.Windows.Forms.TextBox();
            this.txt_urn_ad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBarkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devralanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devirListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirBasDataSet2 = new DemirBasOtomasyon.demirBasDataSet2();
            this.devirListeTableAdapter = new DemirBasOtomasyon.demirBasDataSet2TableAdapters.DevirListeTableAdapter();
            this.btn_fnd_urun = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pdf = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excel_aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_fnd_kisi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_rmove = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devirListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_urun_bul
            // 
            this.txt_urun_bul.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_urun_bul.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_urun_bul.ForeColor = System.Drawing.Color.LightCyan;
            this.txt_urun_bul.Location = new System.Drawing.Point(974, 135);
            this.txt_urun_bul.Name = "txt_urun_bul";
            this.txt_urun_bul.Size = new System.Drawing.Size(148, 28);
            this.txt_urun_bul.TabIndex = 30;
            this.txt_urun_bul.Text = "Ürün Adı Giriniz";
            this.txt_urun_bul.Click += new System.EventHandler(this.Txt_urun_bul_Click);
            // 
            // btn_urn_updte
            // 
            this.btn_urn_updte.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_urn_updte.Appearance.BackColor2 = System.Drawing.Color.MediumSpringGreen;
            this.btn_urn_updte.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_urn_updte.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_updte.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_updte.Appearance.Options.UseBackColor = true;
            this.btn_urn_updte.Appearance.Options.UseBorderColor = true;
            this.btn_urn_updte.Appearance.Options.UseFont = true;
            this.btn_urn_updte.Appearance.Options.UseForeColor = true;
            this.btn_urn_updte.AppearancePressed.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_urn_updte.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_updte.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_urn_updte.ImageOptions.SvgImage")));
            this.btn_urn_updte.Location = new System.Drawing.Point(640, 108);
            this.btn_urn_updte.Name = "btn_urn_updte";
            this.btn_urn_updte.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_updte.TabIndex = 23;
            this.btn_urn_updte.Text = "Ürünü Güncelle";
            this.btn_urn_updte.Click += new System.EventHandler(this.Btn_urn_updte_Click);
            // 
            // btn_urn_dvret
            // 
            this.btn_urn_dvret.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_urn_dvret.Appearance.BackColor2 = System.Drawing.Color.LightGreen;
            this.btn_urn_dvret.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_urn_dvret.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_dvret.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_dvret.Appearance.Options.UseBackColor = true;
            this.btn_urn_dvret.Appearance.Options.UseBorderColor = true;
            this.btn_urn_dvret.Appearance.Options.UseFont = true;
            this.btn_urn_dvret.Appearance.Options.UseForeColor = true;
            this.btn_urn_dvret.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_urn_dvret.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_dvret.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_urn_dvret.ImageOptions.SvgImage")));
            this.btn_urn_dvret.Location = new System.Drawing.Point(640, 35);
            this.btn_urn_dvret.Name = "btn_urn_dvret";
            this.btn_urn_dvret.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_dvret.TabIndex = 22;
            this.btn_urn_dvret.Text = "Ürünü Devret";
            this.btn_urn_dvret.Click += new System.EventHandler(this.Btn_urn_dvret_Click);
            // 
            // txt_kisi_bul
            // 
            this.txt_kisi_bul.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_kisi_bul.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kisi_bul.ForeColor = System.Drawing.Color.LightCyan;
            this.txt_kisi_bul.Location = new System.Drawing.Point(813, 135);
            this.txt_kisi_bul.Name = "txt_kisi_bul";
            this.txt_kisi_bul.Size = new System.Drawing.Size(148, 28);
            this.txt_kisi_bul.TabIndex = 27;
            this.txt_kisi_bul.Text = "Devralan Adı Giriniz";
            this.txt_kisi_bul.Click += new System.EventHandler(this.Txt_kisi_bul_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_tel_no);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_tc_no);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_devralan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_stok_tarih);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Location = new System.Drawing.Point(322, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 206);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Bilgileri";
            // 
            // txt_tel_no
            // 
            this.txt_tel_no.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_tel_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tel_no.Location = new System.Drawing.Point(122, 141);
            this.txt_tel_no.Name = "txt_tel_no";
            this.txt_tel_no.Size = new System.Drawing.Size(146, 16);
            this.txt_tel_no.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(31, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "TelefonNo:";
            // 
            // txt_tc_no
            // 
            this.txt_tc_no.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_tc_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tc_no.Location = new System.Drawing.Point(122, 105);
            this.txt_tc_no.Name = "txt_tc_no";
            this.txt_tc_no.Size = new System.Drawing.Size(146, 16);
            this.txt_tc_no.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(31, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "TCNO:";
            // 
            // txt_devralan
            // 
            this.txt_devralan.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_devralan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_devralan.Location = new System.Drawing.Point(122, 72);
            this.txt_devralan.Name = "txt_devralan";
            this.txt_devralan.Size = new System.Drawing.Size(146, 16);
            this.txt_devralan.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(31, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Devralan:";
            // 
            // txt_stok_tarih
            // 
            this.txt_stok_tarih.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_stok_tarih.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_stok_tarih.Location = new System.Drawing.Point(122, 41);
            this.txt_stok_tarih.Name = "txt_stok_tarih";
            this.txt_stok_tarih.Size = new System.Drawing.Size(146, 16);
            this.txt_stok_tarih.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(29, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "StokTarihi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_urn_model);
            this.groupBox1.Controls.Add(this.txt_urn_mrka);
            this.groupBox1.Controls.Add(this.txt_urn_adet);
            this.groupBox1.Controls.Add(this.txt_urn_barkod);
            this.groupBox1.Controls.Add(this.txt_urn_ad);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 206);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(33, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "UrunModel:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(31, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "UrunMarka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(40, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "UrunAdet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(27, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UrunBarkod:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(49, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "UrunAdı:";
            // 
            // txt_urn_model
            // 
            this.txt_urn_model.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_model.Location = new System.Drawing.Point(121, 177);
            this.txt_urn_model.Name = "txt_urn_model";
            this.txt_urn_model.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_model.TabIndex = 5;
            // 
            // txt_urn_mrka
            // 
            this.txt_urn_mrka.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_mrka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_mrka.Location = new System.Drawing.Point(121, 140);
            this.txt_urn_mrka.Name = "txt_urn_mrka";
            this.txt_urn_mrka.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_mrka.TabIndex = 4;
            // 
            // txt_urn_adet
            // 
            this.txt_urn_adet.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_adet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_adet.Location = new System.Drawing.Point(121, 102);
            this.txt_urn_adet.Name = "txt_urn_adet";
            this.txt_urn_adet.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_adet.TabIndex = 3;
            // 
            // txt_urn_barkod
            // 
            this.txt_urn_barkod.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_barkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_barkod.Location = new System.Drawing.Point(121, 65);
            this.txt_urn_barkod.Name = "txt_urn_barkod";
            this.txt_urn_barkod.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_barkod.TabIndex = 2;
            // 
            // txt_urn_ad
            // 
            this.txt_urn_ad.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_ad.Location = new System.Drawing.Point(121, 27);
            this.txt_urn_ad.Name = "txt_urn_ad";
            this.txt_urn_ad.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_ad.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunBarkodDataGridViewTextBoxColumn,
            this.urunAdetDataGridViewTextBoxColumn,
            this.urunMarkaDataGridViewTextBoxColumn,
            this.urunModelDataGridViewTextBoxColumn,
            this.stokTarihiDataGridViewTextBoxColumn,
            this.devralanDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.devirListeBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 309);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            // 
            // urunBarkodDataGridViewTextBoxColumn
            // 
            this.urunBarkodDataGridViewTextBoxColumn.DataPropertyName = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.HeaderText = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.Name = "urunBarkodDataGridViewTextBoxColumn";
            // 
            // urunAdetDataGridViewTextBoxColumn
            // 
            this.urunAdetDataGridViewTextBoxColumn.DataPropertyName = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.HeaderText = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.Name = "urunAdetDataGridViewTextBoxColumn";
            // 
            // urunMarkaDataGridViewTextBoxColumn
            // 
            this.urunMarkaDataGridViewTextBoxColumn.DataPropertyName = "UrunMarka";
            this.urunMarkaDataGridViewTextBoxColumn.HeaderText = "UrunMarka";
            this.urunMarkaDataGridViewTextBoxColumn.Name = "urunMarkaDataGridViewTextBoxColumn";
            // 
            // urunModelDataGridViewTextBoxColumn
            // 
            this.urunModelDataGridViewTextBoxColumn.DataPropertyName = "UrunModel";
            this.urunModelDataGridViewTextBoxColumn.HeaderText = "UrunModel";
            this.urunModelDataGridViewTextBoxColumn.Name = "urunModelDataGridViewTextBoxColumn";
            // 
            // stokTarihiDataGridViewTextBoxColumn
            // 
            this.stokTarihiDataGridViewTextBoxColumn.DataPropertyName = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.HeaderText = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.Name = "stokTarihiDataGridViewTextBoxColumn";
            // 
            // devralanDataGridViewTextBoxColumn
            // 
            this.devralanDataGridViewTextBoxColumn.DataPropertyName = "Devralan";
            this.devralanDataGridViewTextBoxColumn.HeaderText = "Devralan";
            this.devralanDataGridViewTextBoxColumn.Name = "devralanDataGridViewTextBoxColumn";
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TCNO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TCNO";
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            // 
            // devirListeBindingSource
            // 
            this.devirListeBindingSource.DataMember = "DevirListe";
            this.devirListeBindingSource.DataSource = this.demirBasDataSet2;
            // 
            // demirBasDataSet2
            // 
            this.demirBasDataSet2.DataSetName = "demirBasDataSet2";
            this.demirBasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devirListeTableAdapter
            // 
            this.devirListeTableAdapter.ClearBeforeFill = true;
            // 
            // btn_fnd_urun
            // 
            this.btn_fnd_urun.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_fnd_urun.Appearance.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btn_fnd_urun.Appearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_fnd_urun.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fnd_urun.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fnd_urun.Appearance.Options.UseBackColor = true;
            this.btn_fnd_urun.Appearance.Options.UseBorderColor = true;
            this.btn_fnd_urun.Appearance.Options.UseFont = true;
            this.btn_fnd_urun.Appearance.Options.UseForeColor = true;
            this.btn_fnd_urun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_fnd_urun.ImageOptions.Image")));
            this.btn_fnd_urun.Location = new System.Drawing.Point(974, 182);
            this.btn_fnd_urun.Name = "btn_fnd_urun";
            this.btn_fnd_urun.Size = new System.Drawing.Size(148, 54);
            this.btn_fnd_urun.TabIndex = 29;
            this.btn_fnd_urun.Text = "Ürünü Bul";
            this.btn_fnd_urun.Click += new System.EventHandler(this.Btn_fnd_urun_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_pdf.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pdf.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pdf.Appearance.Options.UseBackColor = true;
            this.btn_pdf.Appearance.Options.UseFont = true;
            this.btn_pdf.Appearance.Options.UseForeColor = true;
            this.btn_pdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pdf.ImageOptions.Image")));
            this.btn_pdf.Location = new System.Drawing.Point(974, 35);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(148, 54);
            this.btn_pdf.TabIndex = 26;
            this.btn_pdf.Text = "Tabloyu PDF\r\nolarak kaydet";
            this.btn_pdf.Click += new System.EventHandler(this.Btn_pdf_Click);
            // 
            // btn_excel_aktar
            // 
            this.btn_excel_aktar.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btn_excel_aktar.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_excel_aktar.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_excel_aktar.Appearance.Options.UseBackColor = true;
            this.btn_excel_aktar.Appearance.Options.UseFont = true;
            this.btn_excel_aktar.Appearance.Options.UseForeColor = true;
            this.btn_excel_aktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel_aktar.ImageOptions.Image")));
            this.btn_excel_aktar.Location = new System.Drawing.Point(813, 35);
            this.btn_excel_aktar.Name = "btn_excel_aktar";
            this.btn_excel_aktar.Size = new System.Drawing.Size(148, 54);
            this.btn_excel_aktar.TabIndex = 25;
            this.btn_excel_aktar.Text = "Tabloyu Excel\'e\r\nAktar";
            this.btn_excel_aktar.Click += new System.EventHandler(this.Btn_excel_aktar_Click);
            // 
            // btn_fnd_kisi
            // 
            this.btn_fnd_kisi.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_fnd_kisi.Appearance.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btn_fnd_kisi.Appearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_fnd_kisi.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_fnd_kisi.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fnd_kisi.Appearance.Options.UseBackColor = true;
            this.btn_fnd_kisi.Appearance.Options.UseBorderColor = true;
            this.btn_fnd_kisi.Appearance.Options.UseFont = true;
            this.btn_fnd_kisi.Appearance.Options.UseForeColor = true;
            this.btn_fnd_kisi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_fnd_kisi.ImageOptions.Image")));
            this.btn_fnd_kisi.Location = new System.Drawing.Point(813, 182);
            this.btn_fnd_kisi.Name = "btn_fnd_kisi";
            this.btn_fnd_kisi.Size = new System.Drawing.Size(148, 54);
            this.btn_fnd_kisi.TabIndex = 28;
            this.btn_fnd_kisi.Text = "Kişiyi Bul";
            this.btn_fnd_kisi.Click += new System.EventHandler(this.Btn_fnd_kisi_Click);
            // 
            // btn_urn_rmove
            // 
            this.btn_urn_rmove.Appearance.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_urn_rmove.Appearance.BackColor2 = System.Drawing.Color.Chartreuse;
            this.btn_urn_rmove.Appearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_urn_rmove.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_rmove.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_rmove.Appearance.Options.UseBackColor = true;
            this.btn_urn_rmove.Appearance.Options.UseBorderColor = true;
            this.btn_urn_rmove.Appearance.Options.UseFont = true;
            this.btn_urn_rmove.Appearance.Options.UseForeColor = true;
            this.btn_urn_rmove.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_urn_rmove.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_rmove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urn_rmove.ImageOptions.Image")));
            this.btn_urn_rmove.Location = new System.Drawing.Point(640, 182);
            this.btn_urn_rmove.Name = "btn_urn_rmove";
            this.btn_urn_rmove.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_rmove.TabIndex = 24;
            this.btn_urn_rmove.Text = "Ürünü Kaldır";
            this.btn_urn_rmove.Click += new System.EventHandler(this.Btn_urn_rmove_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1145, 595);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_urun_bul);
            this.Controls.Add(this.btn_fnd_urun);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_excel_aktar);
            this.Controls.Add(this.btn_fnd_kisi);
            this.Controls.Add(this.btn_urn_rmove);
            this.Controls.Add(this.btn_urn_updte);
            this.Controls.Add(this.btn_urn_dvret);
            this.Controls.Add(this.txt_kisi_bul);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Zimmet Listesi";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devirListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_urun_bul;
        private DevExpress.XtraEditors.SimpleButton btn_fnd_urun;
        private DevExpress.XtraEditors.SimpleButton btn_pdf;
        private DevExpress.XtraEditors.SimpleButton btn_excel_aktar;
        private DevExpress.XtraEditors.SimpleButton btn_fnd_kisi;
        private DevExpress.XtraEditors.SimpleButton btn_urn_rmove;
        private DevExpress.XtraEditors.SimpleButton btn_urn_updte;
        private DevExpress.XtraEditors.SimpleButton btn_urn_dvret;
        private System.Windows.Forms.TextBox txt_kisi_bul;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_tc_no;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_devralan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_stok_tarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_urn_model;
        private System.Windows.Forms.TextBox txt_urn_mrka;
        private System.Windows.Forms.TextBox txt_urn_adet;
        private System.Windows.Forms.TextBox txt_urn_barkod;
        private System.Windows.Forms.TextBox txt_urn_ad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private demirBasDataSet2 demirBasDataSet2;
        private System.Windows.Forms.BindingSource devirListeBindingSource;
        private demirBasDataSet2TableAdapters.DevirListeTableAdapter devirListeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devralanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
    }
}