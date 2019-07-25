namespace demirBasTakipSistemi
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.demirBasDataSet6 = new demirBasTakipSistemi.demirBasDataSet6();
            this.demirBasListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirBasListeTableAdapter = new demirBasTakipSistemi.demirBasDataSet6TableAdapters.demirBasListeTableAdapter();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_tel_no = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tc_no = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_devralan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_stok_tarih = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.demirBasDataSet7 = new demirBasTakipSistemi.demirBasDataSet7();
            this.devirListeTableAdapter = new demirBasTakipSistemi.demirBasDataSet7TableAdapters.DevirListeTableAdapter();
            this.txt_demirbas = new System.Windows.Forms.TextBox();
            this.btn_urn_dvret = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_updte = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_rmove = new DevExpress.XtraEditors.SimpleButton();
            this.btn_fnd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_excel_aktar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devirListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // demirBasDataSet6
            // 
            this.demirBasDataSet6.DataSetName = "demirBasDataSet6";
            this.demirBasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demirBasListeBindingSource
            // 
            this.demirBasListeBindingSource.DataMember = "demirBasListe";
            this.demirBasListeBindingSource.DataSource = this.demirBasDataSet6;
            // 
            // demirBasListeTableAdapter
            // 
            this.demirBasListeTableAdapter.ClearBeforeFill = true;
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
            this.groupBox1.Location = new System.Drawing.Point(48, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 206);
            this.groupBox1.TabIndex = 6;
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
            this.txt_urn_model.TabIndex = 4;
            // 
            // txt_urn_mrka
            // 
            this.txt_urn_mrka.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_mrka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_mrka.Location = new System.Drawing.Point(121, 140);
            this.txt_urn_mrka.Name = "txt_urn_mrka";
            this.txt_urn_mrka.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_mrka.TabIndex = 3;
            // 
            // txt_urn_adet
            // 
            this.txt_urn_adet.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_adet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_adet.Location = new System.Drawing.Point(121, 102);
            this.txt_urn_adet.Name = "txt_urn_adet";
            this.txt_urn_adet.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_adet.TabIndex = 2;
            // 
            // txt_urn_barkod
            // 
            this.txt_urn_barkod.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_barkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_barkod.Location = new System.Drawing.Point(121, 65);
            this.txt_urn_barkod.Name = "txt_urn_barkod";
            this.txt_urn_barkod.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_barkod.TabIndex = 1;
            // 
            // txt_urn_ad
            // 
            this.txt_urn_ad.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_urn_ad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_ad.Location = new System.Drawing.Point(121, 27);
            this.txt_urn_ad.Name = "txt_urn_ad";
            this.txt_urn_ad.Size = new System.Drawing.Size(143, 16);
            this.txt_urn_ad.TabIndex = 0;
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
            this.groupBox2.Location = new System.Drawing.Point(358, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 206);
            this.groupBox2.TabIndex = 7;
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
            this.txt_tel_no.TabIndex = 12;
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
            this.txt_tc_no.TabIndex = 11;
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
            this.txt_devralan.TabIndex = 10;
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
            this.txt_stok_tarih.TabIndex = 9;
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
            this.dataGridView1.Location = new System.Drawing.Point(48, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 371);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunBarkodDataGridViewTextBoxColumn
            // 
            this.urunBarkodDataGridViewTextBoxColumn.DataPropertyName = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.HeaderText = "UrunBarkod";
            this.urunBarkodDataGridViewTextBoxColumn.Name = "urunBarkodDataGridViewTextBoxColumn";
            this.urunBarkodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdetDataGridViewTextBoxColumn
            // 
            this.urunAdetDataGridViewTextBoxColumn.DataPropertyName = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.HeaderText = "UrunAdet";
            this.urunAdetDataGridViewTextBoxColumn.Name = "urunAdetDataGridViewTextBoxColumn";
            this.urunAdetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunMarkaDataGridViewTextBoxColumn
            // 
            this.urunMarkaDataGridViewTextBoxColumn.DataPropertyName = "UrunMarka";
            this.urunMarkaDataGridViewTextBoxColumn.HeaderText = "UrunMarka";
            this.urunMarkaDataGridViewTextBoxColumn.Name = "urunMarkaDataGridViewTextBoxColumn";
            this.urunMarkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunModelDataGridViewTextBoxColumn
            // 
            this.urunModelDataGridViewTextBoxColumn.DataPropertyName = "UrunModel";
            this.urunModelDataGridViewTextBoxColumn.HeaderText = "UrunModel";
            this.urunModelDataGridViewTextBoxColumn.Name = "urunModelDataGridViewTextBoxColumn";
            this.urunModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokTarihiDataGridViewTextBoxColumn
            // 
            this.stokTarihiDataGridViewTextBoxColumn.DataPropertyName = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.HeaderText = "StokTarihi";
            this.stokTarihiDataGridViewTextBoxColumn.Name = "stokTarihiDataGridViewTextBoxColumn";
            this.stokTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devralanDataGridViewTextBoxColumn
            // 
            this.devralanDataGridViewTextBoxColumn.DataPropertyName = "Devralan";
            this.devralanDataGridViewTextBoxColumn.HeaderText = "Devralan";
            this.devralanDataGridViewTextBoxColumn.Name = "devralanDataGridViewTextBoxColumn";
            this.devralanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TCNO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TCNO";
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            this.tCNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // devirListeBindingSource
            // 
            this.devirListeBindingSource.DataMember = "DevirListe";
            this.devirListeBindingSource.DataSource = this.demirBasDataSet7;
            // 
            // demirBasDataSet7
            // 
            this.demirBasDataSet7.DataSetName = "demirBasDataSet7";
            this.demirBasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // devirListeTableAdapter
            // 
            this.devirListeTableAdapter.ClearBeforeFill = true;
            // 
            // txt_demirbas
            // 
            this.txt_demirbas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.txt_demirbas.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demirbas.ForeColor = System.Drawing.Color.LightCyan;
            this.txt_demirbas.Location = new System.Drawing.Point(855, 114);
            this.txt_demirbas.Name = "txt_demirbas";
            this.txt_demirbas.Size = new System.Drawing.Size(296, 33);
            this.txt_demirbas.TabIndex = 11;
            this.txt_demirbas.Text = "Devralan Adı Giriniz";
            this.txt_demirbas.Click += new System.EventHandler(this.Txt_demirbas_Click);
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
            this.btn_urn_dvret.Location = new System.Drawing.Point(676, 32);
            this.btn_urn_dvret.Name = "btn_urn_dvret";
            this.btn_urn_dvret.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_dvret.TabIndex = 12;
            this.btn_urn_dvret.Text = "Ürünü Devret";
            this.btn_urn_dvret.Click += new System.EventHandler(this.Btn_urn_dvret_Click);
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
            this.btn_urn_updte.Location = new System.Drawing.Point(676, 105);
            this.btn_urn_updte.Name = "btn_urn_updte";
            this.btn_urn_updte.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_updte.TabIndex = 12;
            this.btn_urn_updte.Text = "Ürünü Güncelle";
            this.btn_urn_updte.Click += new System.EventHandler(this.Btn_urn_updte_Click);
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
            this.btn_urn_rmove.Location = new System.Drawing.Point(676, 179);
            this.btn_urn_rmove.Name = "btn_urn_rmove";
            this.btn_urn_rmove.Size = new System.Drawing.Size(155, 54);
            this.btn_urn_rmove.TabIndex = 12;
            this.btn_urn_rmove.Text = "Ürünü Kaldır";
            this.btn_urn_rmove.Click += new System.EventHandler(this.Btn_urn_rmove_Click);
            // 
            // btn_fnd
            // 
            this.btn_fnd.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_fnd.Appearance.BackColor2 = System.Drawing.Color.DarkGreen;
            this.btn_fnd.Appearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_fnd.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fnd.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_fnd.Appearance.Options.UseBackColor = true;
            this.btn_fnd.Appearance.Options.UseBorderColor = true;
            this.btn_fnd.Appearance.Options.UseFont = true;
            this.btn_fnd.Appearance.Options.UseForeColor = true;
            this.btn_fnd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_fnd.ImageOptions.Image")));
            this.btn_fnd.Location = new System.Drawing.Point(855, 161);
            this.btn_fnd.Name = "btn_fnd";
            this.btn_fnd.Size = new System.Drawing.Size(192, 72);
            this.btn_fnd.TabIndex = 13;
            this.btn_fnd.Text = "Demirbaş\r\nAra";
            this.btn_fnd.Click += new System.EventHandler(this.Btn_fnd_Click);
            // 
            // btn_excel_aktar
            // 
            this.btn_excel_aktar.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_excel_aktar.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_excel_aktar.Appearance.Options.UseBackColor = true;
            this.btn_excel_aktar.Appearance.Options.UseFont = true;
            this.btn_excel_aktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel_aktar.ImageOptions.Image")));
            this.btn_excel_aktar.Location = new System.Drawing.Point(1053, 161);
            this.btn_excel_aktar.Name = "btn_excel_aktar";
            this.btn_excel_aktar.Size = new System.Drawing.Size(98, 72);
            this.btn_excel_aktar.TabIndex = 14;
            this.btn_excel_aktar.Text = "Tabloyu\r\nExcel\'e\r\nAktar";
            this.btn_excel_aktar.Click += new System.EventHandler(this.Btn_excel_aktar_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1207, 647);
            this.Controls.Add(this.btn_excel_aktar);
            this.Controls.Add(this.btn_fnd);
            this.Controls.Add(this.btn_urn_rmove);
            this.Controls.Add(this.btn_urn_updte);
            this.Controls.Add(this.btn_urn_dvret);
            this.Controls.Add(this.txt_demirbas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Zimmetlenen Ürünler";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devirListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private demirBasDataSet6 demirBasDataSet6;
        private System.Windows.Forms.BindingSource demirBasListeBindingSource;
        private demirBasDataSet6TableAdapters.demirBasListeTableAdapter demirBasListeTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_urn_model;
        private System.Windows.Forms.TextBox txt_urn_mrka;
        private System.Windows.Forms.TextBox txt_urn_adet;
        private System.Windows.Forms.TextBox txt_urn_barkod;
        private System.Windows.Forms.TextBox txt_urn_ad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private demirBasDataSet7 demirBasDataSet7;
        private System.Windows.Forms.BindingSource devirListeBindingSource;
        private demirBasDataSet7TableAdapters.DevirListeTableAdapter devirListeTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tel_no;
        private System.Windows.Forms.TextBox txt_tc_no;
        private System.Windows.Forms.TextBox txt_devralan;
        private System.Windows.Forms.TextBox txt_stok_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devralanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_demirbas;
        private DevExpress.XtraEditors.SimpleButton btn_urn_dvret;
        private DevExpress.XtraEditors.SimpleButton btn_urn_updte;
        private DevExpress.XtraEditors.SimpleButton btn_urn_rmove;
        private DevExpress.XtraEditors.SimpleButton btn_fnd;
        private DevExpress.XtraEditors.SimpleButton btn_excel_aktar;
    }
}