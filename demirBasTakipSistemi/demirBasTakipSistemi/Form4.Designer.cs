﻿namespace demirBasTakipSistemi
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunMarkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunBarkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunAdetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirBasListeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.demirBasDataSet5 = new demirBasTakipSistemi.demirBasDataSet5();
            this.demirBasListeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirBasDataSet1 = new demirBasTakipSistemi.demirBasDataSet1();
            this.demirBasListeTableAdapter = new demirBasTakipSistemi.demirBasDataSet1TableAdapters.demirBasListeTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_urun_id = new System.Windows.Forms.TextBox();
            this.txt_urun_adi = new System.Windows.Forms.TextBox();
            this.txt_urun_barkod = new System.Windows.Forms.TextBox();
            this.txt_urun_adet = new System.Windows.Forms.TextBox();
            this.txt_alim_tarihi = new System.Windows.Forms.TextBox();
            this.btn_urn_ara = new DevExpress.XtraEditors.SimpleButton();
            this.txt_urn_ara = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_urn_marka = new System.Windows.Forms.TextBox();
            this.txt_urn_model = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.demirBasListeTableAdapter1 = new demirBasTakipSistemi.demirBasDataSet5TableAdapters.demirBasListeTableAdapter();
            this.btn_excel_aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urn_add = new DevExpress.XtraEditors.SimpleButton();
            this.btn_pdf = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urn_ara.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunIDDataGridViewTextBoxColumn,
            this.urunAdiDataGridViewTextBoxColumn,
            this.urunMarkaDataGridViewTextBoxColumn,
            this.urunModelDataGridViewTextBoxColumn,
            this.urunBarkodDataGridViewTextBoxColumn,
            this.urunAdetDataGridViewTextBoxColumn,
            this.alimTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.demirBasListeBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.Location = new System.Drawing.Point(421, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(826, 482);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // urunIDDataGridViewTextBoxColumn
            // 
            this.urunIDDataGridViewTextBoxColumn.DataPropertyName = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.HeaderText = "UrunID";
            this.urunIDDataGridViewTextBoxColumn.Name = "urunIDDataGridViewTextBoxColumn";
            this.urunIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunAdiDataGridViewTextBoxColumn
            // 
            this.urunAdiDataGridViewTextBoxColumn.DataPropertyName = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.HeaderText = "UrunAdi";
            this.urunAdiDataGridViewTextBoxColumn.Name = "urunAdiDataGridViewTextBoxColumn";
            this.urunAdiDataGridViewTextBoxColumn.ReadOnly = true;
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
            // alimTarihiDataGridViewTextBoxColumn
            // 
            this.alimTarihiDataGridViewTextBoxColumn.DataPropertyName = "AlimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.HeaderText = "AlimTarihi";
            this.alimTarihiDataGridViewTextBoxColumn.Name = "alimTarihiDataGridViewTextBoxColumn";
            this.alimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demirBasListeBindingSource1
            // 
            this.demirBasListeBindingSource1.DataMember = "demirBasListe";
            this.demirBasListeBindingSource1.DataSource = this.demirBasDataSet5;
            // 
            // demirBasDataSet5
            // 
            this.demirBasDataSet5.DataSetName = "demirBasDataSet5";
            this.demirBasDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demirBasListeBindingSource
            // 
            this.demirBasListeBindingSource.DataMember = "demirBasListe";
            this.demirBasListeBindingSource.DataSource = this.demirBasDataSet1;
            // 
            // demirBasDataSet1
            // 
            this.demirBasDataSet1.DataSetName = "demirBasDataSet1";
            this.demirBasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demirBasListeTableAdapter
            // 
            this.demirBasListeTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(52, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "UrunID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(48, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "UrunAdi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(20, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "UrunBarkod:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(32, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "UrunAdet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(30, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "AlimTarihi:";
            // 
            // txt_urun_id
            // 
            this.txt_urun_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urun_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urun_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urun_id.Location = new System.Drawing.Point(157, 87);
            this.txt_urun_id.Name = "txt_urun_id";
            this.txt_urun_id.Size = new System.Drawing.Size(231, 20);
            this.txt_urun_id.TabIndex = 6;
            // 
            // txt_urun_adi
            // 
            this.txt_urun_adi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urun_adi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urun_adi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urun_adi.Location = new System.Drawing.Point(157, 128);
            this.txt_urun_adi.Name = "txt_urun_adi";
            this.txt_urun_adi.Size = new System.Drawing.Size(231, 20);
            this.txt_urun_adi.TabIndex = 6;
            // 
            // txt_urun_barkod
            // 
            this.txt_urun_barkod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urun_barkod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urun_barkod.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urun_barkod.Location = new System.Drawing.Point(157, 255);
            this.txt_urun_barkod.Name = "txt_urun_barkod";
            this.txt_urun_barkod.Size = new System.Drawing.Size(231, 20);
            this.txt_urun_barkod.TabIndex = 6;
            // 
            // txt_urun_adet
            // 
            this.txt_urun_adet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urun_adet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urun_adet.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urun_adet.Location = new System.Drawing.Point(157, 294);
            this.txt_urun_adet.Name = "txt_urun_adet";
            this.txt_urun_adet.Size = new System.Drawing.Size(231, 20);
            this.txt_urun_adet.TabIndex = 6;
            // 
            // txt_alim_tarihi
            // 
            this.txt_alim_tarihi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_alim_tarihi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_alim_tarihi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_alim_tarihi.Location = new System.Drawing.Point(157, 332);
            this.txt_alim_tarihi.Name = "txt_alim_tarihi";
            this.txt_alim_tarihi.Size = new System.Drawing.Size(231, 20);
            this.txt_alim_tarihi.TabIndex = 6;
            // 
            // btn_urn_ara
            // 
            this.btn_urn_ara.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_ara.Appearance.Options.UseFont = true;
            this.btn_urn_ara.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_urn_ara.ImageOptions.SvgImage")));
            this.btn_urn_ara.Location = new System.Drawing.Point(15, 504);
            this.btn_urn_ara.Name = "btn_urn_ara";
            this.btn_urn_ara.Size = new System.Drawing.Size(373, 45);
            this.btn_urn_ara.TabIndex = 9;
            this.btn_urn_ara.Text = "Ürün Ara";
            this.btn_urn_ara.Click += new System.EventHandler(this.Btn_urn_ara_Click);
            // 
            // txt_urn_ara
            // 
            this.txt_urn_ara.EditValue = "Ü r ü n   A d ı   G i r i n i z";
            this.txt_urn_ara.Location = new System.Drawing.Point(17, 462);
            this.txt_urn_ara.Name = "txt_urn_ara";
            this.txt_urn_ara.Properties.Appearance.BackColor = System.Drawing.Color.SeaShell;
            this.txt_urn_ara.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urn_ara.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_urn_ara.Properties.Appearance.Options.UseBackColor = true;
            this.txt_urn_ara.Properties.Appearance.Options.UseFont = true;
            this.txt_urn_ara.Properties.Appearance.Options.UseForeColor = true;
            this.txt_urn_ara.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.txt_urn_ara.Size = new System.Drawing.Size(371, 32);
            this.txt_urn_ara.TabIndex = 10;
            this.txt_urn_ara.Click += new System.EventHandler(this.Txt_urn_ara_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(157, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 1);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(157, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 1);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(157, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 1);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkCyan;
            this.panel4.Location = new System.Drawing.Point(157, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 1);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkCyan;
            this.panel5.Location = new System.Drawing.Point(157, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 1);
            this.panel5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(24, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "UrunMarka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(29, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "UrunModel:";
            // 
            // txt_urn_marka
            // 
            this.txt_urn_marka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urn_marka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_marka.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urn_marka.Location = new System.Drawing.Point(157, 172);
            this.txt_urn_marka.Name = "txt_urn_marka";
            this.txt_urn_marka.Size = new System.Drawing.Size(231, 20);
            this.txt_urn_marka.TabIndex = 6;
            // 
            // txt_urn_model
            // 
            this.txt_urn_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_urn_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_urn_model.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_urn_model.Location = new System.Drawing.Point(157, 213);
            this.txt_urn_model.Name = "txt_urn_model";
            this.txt_urn_model.Size = new System.Drawing.Size(231, 20);
            this.txt_urn_model.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkCyan;
            this.panel6.Location = new System.Drawing.Point(157, 191);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 1);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkCyan;
            this.panel7.Location = new System.Drawing.Point(157, 232);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(231, 1);
            this.panel7.TabIndex = 12;
            // 
            // demirBasListeTableAdapter1
            // 
            this.demirBasListeTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_excel_aktar
            // 
            this.btn_excel_aktar.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_excel_aktar.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_excel_aktar.Appearance.Options.UseBackColor = true;
            this.btn_excel_aktar.Appearance.Options.UseFont = true;
            this.btn_excel_aktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel_aktar.ImageOptions.Image")));
            this.btn_excel_aktar.Location = new System.Drawing.Point(27, 583);
            this.btn_excel_aktar.Name = "btn_excel_aktar";
            this.btn_excel_aktar.Size = new System.Drawing.Size(173, 55);
            this.btn_excel_aktar.TabIndex = 13;
            this.btn_excel_aktar.Text = "Tabloyu Excel\'e\r\nAktar";
            this.btn_excel_aktar.Click += new System.EventHandler(this.Btn_excel_aktar_Click);
            // 
            // btn_urn_remove
            // 
            this.btn_urn_remove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btn_urn_remove.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_remove.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_remove.Appearance.Options.UseBackColor = true;
            this.btn_urn_remove.Appearance.Options.UseFont = true;
            this.btn_urn_remove.Appearance.Options.UseForeColor = true;
            this.btn_urn_remove.AppearancePressed.BackColor = System.Drawing.Color.Red;
            this.btn_urn_remove.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_urn_remove.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.btn_urn_remove.AppearancePressed.Options.UseBackColor = true;
            this.btn_urn_remove.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_remove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urn_remove.ImageOptions.Image")));
            this.btn_urn_remove.Location = new System.Drawing.Point(277, 371);
            this.btn_urn_remove.Name = "btn_urn_remove";
            this.btn_urn_remove.Size = new System.Drawing.Size(111, 64);
            this.btn_urn_remove.TabIndex = 11;
            this.btn_urn_remove.Text = "Ürün Sil";
            this.btn_urn_remove.Click += new System.EventHandler(this.Btn_urn_remove_Click);
            // 
            // btn_urn_update
            // 
            this.btn_urn_update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_urn_update.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_update.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_update.Appearance.Options.UseBackColor = true;
            this.btn_urn_update.Appearance.Options.UseFont = true;
            this.btn_urn_update.Appearance.Options.UseForeColor = true;
            this.btn_urn_update.AppearancePressed.BackColor = System.Drawing.Color.Lime;
            this.btn_urn_update.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_urn_update.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.btn_urn_update.AppearancePressed.Options.UseBackColor = true;
            this.btn_urn_update.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urn_update.ImageOptions.Image")));
            this.btn_urn_update.Location = new System.Drawing.Point(147, 371);
            this.btn_urn_update.Name = "btn_urn_update";
            this.btn_urn_update.Size = new System.Drawing.Size(111, 64);
            this.btn_urn_update.TabIndex = 11;
            this.btn_urn_update.Text = "Ürün\r\nGüncelle";
            this.btn_urn_update.Click += new System.EventHandler(this.Btn_urn_update_Click);
            // 
            // btn_urn_add
            // 
            this.btn_urn_add.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_urn_add.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_urn_add.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.btn_urn_add.Appearance.Options.UseBackColor = true;
            this.btn_urn_add.Appearance.Options.UseFont = true;
            this.btn_urn_add.Appearance.Options.UseForeColor = true;
            this.btn_urn_add.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_urn_add.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_urn_add.AppearancePressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_urn_add.AppearancePressed.Options.UseBackColor = true;
            this.btn_urn_add.AppearancePressed.Options.UseForeColor = true;
            this.btn_urn_add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urn_add.ImageOptions.Image")));
            this.btn_urn_add.Location = new System.Drawing.Point(15, 371);
            this.btn_urn_add.Name = "btn_urn_add";
            this.btn_urn_add.Size = new System.Drawing.Size(111, 64);
            this.btn_urn_add.TabIndex = 11;
            this.btn_urn_add.Text = "Ürün\r\nEkle";
            this.btn_urn_add.Click += new System.EventHandler(this.Btn_urn_add_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pdf.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_pdf.Appearance.Options.UseBackColor = true;
            this.btn_pdf.Appearance.Options.UseFont = true;
            this.btn_pdf.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_pdf.ImageOptions.Image")));
            this.btn_pdf.Location = new System.Drawing.Point(206, 583);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(173, 55);
            this.btn_pdf.TabIndex = 14;
            this.btn_pdf.Text = "Tabloyu PDF\r\nolarak kaydet";
            this.btn_pdf.Click += new System.EventHandler(this.Btn_pdf_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1259, 711);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_excel_aktar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_urn_remove);
            this.Controls.Add(this.btn_urn_update);
            this.Controls.Add(this.btn_urn_add);
            this.Controls.Add(this.txt_urn_ara);
            this.Controls.Add(this.btn_urn_ara);
            this.Controls.Add(this.txt_alim_tarihi);
            this.Controls.Add(this.txt_urun_adet);
            this.Controls.Add(this.txt_urn_model);
            this.Controls.Add(this.txt_urun_barkod);
            this.Controls.Add(this.txt_urn_marka);
            this.Controls.Add(this.txt_urun_adi);
            this.Controls.Add(this.txt_urun_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasListeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urn_ara.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private demirBasDataSet1 demirBasDataSet1;
        private System.Windows.Forms.BindingSource demirBasListeBindingSource;
        private demirBasDataSet1TableAdapters.demirBasListeTableAdapter demirBasListeTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_urun_id;
        private System.Windows.Forms.TextBox txt_urun_adi;
        private System.Windows.Forms.TextBox txt_urun_barkod;
        private System.Windows.Forms.TextBox txt_urun_adet;
        private System.Windows.Forms.TextBox txt_alim_tarihi;
        private DevExpress.XtraEditors.SimpleButton btn_urn_ara;
        private DevExpress.XtraEditors.TextEdit txt_urn_ara;
        private DevExpress.XtraEditors.SimpleButton btn_urn_add;
        private DevExpress.XtraEditors.SimpleButton btn_urn_update;
        private DevExpress.XtraEditors.SimpleButton btn_urn_remove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_urn_marka;
        private System.Windows.Forms.TextBox txt_urn_model;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private demirBasDataSet5 demirBasDataSet5;
        private System.Windows.Forms.BindingSource demirBasListeBindingSource1;
        private demirBasDataSet5TableAdapters.demirBasListeTableAdapter demirBasListeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunMarkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunBarkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAdetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimTarihiDataGridViewTextBoxColumn;
        private DevExpress.XtraEditors.SimpleButton btn_excel_aktar;
        private DevExpress.XtraEditors.SimpleButton btn_pdf;
    }
}