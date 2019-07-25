namespace demirBasTakipSistemi
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ısimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirBasDataSet = new demirBasTakipSistemi.demirBasDataSet();
            this.personelTableAdapter = new demirBasTakipSistemi.demirBasDataSetTableAdapters.PersonelTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_personel_id = new System.Windows.Forms.TextBox();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.txt_soy_isim = new System.Windows.Forms.TextBox();
            this.txt_tc_no = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefon_no = new System.Windows.Forms.TextBox();
            this.txt_unvan = new System.Windows.Forms.TextBox();
            this.txt_meslek = new System.Windows.Forms.TextBox();
            this.btn_prsnl_ekle = new DevExpress.XtraEditors.SimpleButton();
            this.txt_isim_ara = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.demirBasDataSet1 = new demirBasTakipSistemi.demirBasDataSet();
            this.collectionDataSource1 = new DevExpress.Persistent.Base.ReportsV2.CollectionDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_excel_aktar = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prsn_remove = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prsn_update = new DevExpress.XtraEditors.SimpleButton();
            this.btn_prsnl_ara = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isim_ara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.ısimDataGridViewTextBoxColumn,
            this.soyisimDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn,
            this.emailAdresDataGridViewTextBoxColumn,
            this.telefonNoDataGridViewTextBoxColumn,
            this.unvanDataGridViewTextBoxColumn,
            this.meslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(414, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(857, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellEnter);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ısimDataGridViewTextBoxColumn
            // 
            this.ısimDataGridViewTextBoxColumn.DataPropertyName = "Isim";
            this.ısimDataGridViewTextBoxColumn.HeaderText = "Isim";
            this.ısimDataGridViewTextBoxColumn.Name = "ısimDataGridViewTextBoxColumn";
            this.ısimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyisimDataGridViewTextBoxColumn
            // 
            this.soyisimDataGridViewTextBoxColumn.DataPropertyName = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.HeaderText = "Soyisim";
            this.soyisimDataGridViewTextBoxColumn.Name = "soyisimDataGridViewTextBoxColumn";
            this.soyisimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TCNO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TCNO";
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            this.tCNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAdresDataGridViewTextBoxColumn
            // 
            this.emailAdresDataGridViewTextBoxColumn.DataPropertyName = "EmailAdres";
            this.emailAdresDataGridViewTextBoxColumn.HeaderText = "EmailAdres";
            this.emailAdresDataGridViewTextBoxColumn.Name = "emailAdresDataGridViewTextBoxColumn";
            this.emailAdresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonNoDataGridViewTextBoxColumn
            // 
            this.telefonNoDataGridViewTextBoxColumn.DataPropertyName = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.HeaderText = "TelefonNo";
            this.telefonNoDataGridViewTextBoxColumn.Name = "telefonNoDataGridViewTextBoxColumn";
            this.telefonNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unvanDataGridViewTextBoxColumn
            // 
            this.unvanDataGridViewTextBoxColumn.DataPropertyName = "Unvan";
            this.unvanDataGridViewTextBoxColumn.HeaderText = "Unvan";
            this.unvanDataGridViewTextBoxColumn.Name = "unvanDataGridViewTextBoxColumn";
            this.unvanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meslekDataGridViewTextBoxColumn
            // 
            this.meslekDataGridViewTextBoxColumn.DataPropertyName = "Meslek";
            this.meslekDataGridViewTextBoxColumn.HeaderText = "Meslek";
            this.meslekDataGridViewTextBoxColumn.Name = "meslekDataGridViewTextBoxColumn";
            this.meslekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "Personel";
            this.personelBindingSource.DataSource = this.demirBasDataSet;
            // 
            // demirBasDataSet
            // 
            this.demirBasDataSet.DataSetName = "demirBasDataSet";
            this.demirBasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PersonelID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label2.Location = new System.Drawing.Point(58, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Isim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label3.Location = new System.Drawing.Point(42, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyisim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label4.Location = new System.Drawing.Point(53, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "TCNO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label5.Location = new System.Drawing.Point(19, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "EmailAdres:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label6.Location = new System.Drawing.Point(25, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "TelefonNo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label7.Location = new System.Drawing.Point(51, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Unvan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(119)))), ((int)(((byte)(179)))));
            this.label8.Location = new System.Drawing.Point(40, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Meslek:";
            // 
            // txt_personel_id
            // 
            this.txt_personel_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_personel_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_personel_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_personel_id.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_personel_id.Location = new System.Drawing.Point(122, 85);
            this.txt_personel_id.Name = "txt_personel_id";
            this.txt_personel_id.Size = new System.Drawing.Size(265, 20);
            this.txt_personel_id.TabIndex = 2;
            // 
            // txt_isim
            // 
            this.txt_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_isim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_isim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_isim.Location = new System.Drawing.Point(122, 117);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(265, 20);
            this.txt_isim.TabIndex = 2;
            // 
            // txt_soy_isim
            // 
            this.txt_soy_isim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_soy_isim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_soy_isim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soy_isim.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soy_isim.Location = new System.Drawing.Point(122, 149);
            this.txt_soy_isim.Name = "txt_soy_isim";
            this.txt_soy_isim.Size = new System.Drawing.Size(265, 20);
            this.txt_soy_isim.TabIndex = 2;
            // 
            // txt_tc_no
            // 
            this.txt_tc_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_tc_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tc_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tc_no.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tc_no.Location = new System.Drawing.Point(122, 181);
            this.txt_tc_no.Name = "txt_tc_no";
            this.txt_tc_no.Size = new System.Drawing.Size(265, 20);
            this.txt_tc_no.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(122, 213);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(265, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_telefon_no
            // 
            this.txt_telefon_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_telefon_no.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_telefon_no.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefon_no.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefon_no.Location = new System.Drawing.Point(122, 245);
            this.txt_telefon_no.Name = "txt_telefon_no";
            this.txt_telefon_no.Size = new System.Drawing.Size(265, 20);
            this.txt_telefon_no.TabIndex = 2;
            // 
            // txt_unvan
            // 
            this.txt_unvan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_unvan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_unvan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_unvan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unvan.Location = new System.Drawing.Point(122, 277);
            this.txt_unvan.Name = "txt_unvan";
            this.txt_unvan.Size = new System.Drawing.Size(265, 20);
            this.txt_unvan.TabIndex = 2;
            // 
            // txt_meslek
            // 
            this.txt_meslek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.txt_meslek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_meslek.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_meslek.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_meslek.Location = new System.Drawing.Point(122, 310);
            this.txt_meslek.Name = "txt_meslek";
            this.txt_meslek.Size = new System.Drawing.Size(265, 20);
            this.txt_meslek.TabIndex = 2;
            // 
            // btn_prsnl_ekle
            // 
            this.btn_prsnl_ekle.Appearance.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_prsnl_ekle.Appearance.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsnl_ekle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_prsnl_ekle.Appearance.Options.UseBackColor = true;
            this.btn_prsnl_ekle.Appearance.Options.UseFont = true;
            this.btn_prsnl_ekle.Appearance.Options.UseForeColor = true;
            this.btn_prsnl_ekle.AppearancePressed.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_prsnl_ekle.AppearancePressed.BackColor2 = System.Drawing.Color.SteelBlue;
            this.btn_prsnl_ekle.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question;
            this.btn_prsnl_ekle.AppearancePressed.Options.UseBackColor = true;
            this.btn_prsnl_ekle.AppearancePressed.Options.UseForeColor = true;
            this.btn_prsnl_ekle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_prsnl_ekle.ImageOptions.SvgImage")));
            this.btn_prsnl_ekle.Location = new System.Drawing.Point(3, 352);
            this.btn_prsnl_ekle.Name = "btn_prsnl_ekle";
            this.btn_prsnl_ekle.Size = new System.Drawing.Size(125, 65);
            this.btn_prsnl_ekle.TabIndex = 6;
            this.btn_prsnl_ekle.Text = "Personel\r\nEkle";
            this.btn_prsnl_ekle.Click += new System.EventHandler(this.Btn_prsnl_ekle_Click);
            // 
            // txt_isim_ara
            // 
            this.txt_isim_ara.EditValue = "P e r s o n e l   A d ı   G i r i n i z";
            this.txt_isim_ara.Location = new System.Drawing.Point(3, 439);
            this.txt_isim_ara.Name = "txt_isim_ara";
            this.txt_isim_ara.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.txt_isim_ara.Properties.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_isim_ara.Properties.Appearance.Options.UseBackColor = true;
            this.txt_isim_ara.Properties.Appearance.Options.UseFont = true;
            this.txt_isim_ara.Size = new System.Drawing.Size(394, 30);
            this.txt_isim_ara.TabIndex = 5;
            this.txt_isim_ara.Click += new System.EventHandler(this.Txt_isim_ara_Click);
            // 
            // demirBasDataSet1
            // 
            this.demirBasDataSet1.DataSetName = "demirBasDataSet";
            this.demirBasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collectionDataSource1
            // 
            this.collectionDataSource1.Name = "collectionDataSource1";
            this.collectionDataSource1.ObjectTypeName = null;
            this.collectionDataSource1.TopReturnedRecords = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Location = new System.Drawing.Point(122, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Purple;
            this.panel2.Location = new System.Drawing.Point(122, 267);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 1);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Purple;
            this.panel3.Location = new System.Drawing.Point(122, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Purple;
            this.panel4.Location = new System.Drawing.Point(122, 332);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 1);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Purple;
            this.panel5.Location = new System.Drawing.Point(122, 299);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 1);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Location = new System.Drawing.Point(122, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 1);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Purple;
            this.panel7.Location = new System.Drawing.Point(122, 203);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 1);
            this.panel7.TabIndex = 9;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Purple;
            this.panel8.Location = new System.Drawing.Point(122, 139);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(265, 1);
            this.panel8.TabIndex = 9;
            // 
            // btn_excel_aktar
            // 
            this.btn_excel_aktar.Appearance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_excel_aktar.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excel_aktar.Appearance.Options.UseBackColor = true;
            this.btn_excel_aktar.Appearance.Options.UseFont = true;
            this.btn_excel_aktar.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_excel_aktar.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_excel_aktar.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.btn_excel_aktar.AppearancePressed.Options.UseBackColor = true;
            this.btn_excel_aktar.AppearancePressed.Options.UseForeColor = true;
            this.btn_excel_aktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_excel_aktar.ImageOptions.Image")));
            this.btn_excel_aktar.Location = new System.Drawing.Point(274, 478);
            this.btn_excel_aktar.Name = "btn_excel_aktar";
            this.btn_excel_aktar.Size = new System.Drawing.Size(123, 45);
            this.btn_excel_aktar.TabIndex = 10;
            this.btn_excel_aktar.Text = "Excel\'e\r\nAktar";
            this.btn_excel_aktar.Click += new System.EventHandler(this.Btn_excel_aktar_Click);
            // 
            // btn_prsn_remove
            // 
            this.btn_prsn_remove.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_prsn_remove.Appearance.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsn_remove.Appearance.Options.UseBackColor = true;
            this.btn_prsn_remove.Appearance.Options.UseFont = true;
            this.btn_prsn_remove.AppearancePressed.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_prsn_remove.AppearancePressed.BackColor2 = System.Drawing.Color.Red;
            this.btn_prsn_remove.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.btn_prsn_remove.AppearancePressed.Options.UseBackColor = true;
            this.btn_prsn_remove.AppearancePressed.Options.UseForeColor = true;
            this.btn_prsn_remove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_prsn_remove.ImageOptions.Image")));
            this.btn_prsn_remove.ImageOptions.SvgImageSize = new System.Drawing.Size(32, 32);
            this.btn_prsn_remove.Location = new System.Drawing.Point(265, 352);
            this.btn_prsn_remove.Name = "btn_prsn_remove";
            this.btn_prsn_remove.Size = new System.Drawing.Size(130, 65);
            this.btn_prsn_remove.TabIndex = 7;
            this.btn_prsn_remove.Text = "Personel\r\nSil";
            this.btn_prsn_remove.Click += new System.EventHandler(this.Btn_prsn_remove_Click);
            // 
            // btn_prsn_update
            // 
            this.btn_prsn_update.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(250)))), ((int)(((byte)(108)))));
            this.btn_prsn_update.Appearance.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsn_update.Appearance.Options.UseBackColor = true;
            this.btn_prsn_update.Appearance.Options.UseFont = true;
            this.btn_prsn_update.AppearancePressed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_prsn_update.AppearancePressed.BackColor2 = System.Drawing.Color.ForestGreen;
            this.btn_prsn_update.AppearancePressed.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.btn_prsn_update.AppearancePressed.Options.UseBackColor = true;
            this.btn_prsn_update.AppearancePressed.Options.UseForeColor = true;
            this.btn_prsn_update.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_prsn_update.ImageOptions.Image")));
            this.btn_prsn_update.Location = new System.Drawing.Point(134, 352);
            this.btn_prsn_update.Name = "btn_prsn_update";
            this.btn_prsn_update.Size = new System.Drawing.Size(125, 65);
            this.btn_prsn_update.TabIndex = 7;
            this.btn_prsn_update.Text = "Personel\r\nBilgilerini \r\nGüncelle";
            this.btn_prsn_update.Click += new System.EventHandler(this.Btn_prsn_update_Click);
            // 
            // btn_prsnl_ara
            // 
            this.btn_prsnl_ara.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.btn_prsnl_ara.Appearance.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prsnl_ara.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText;
            this.btn_prsnl_ara.Appearance.Options.UseBackColor = true;
            this.btn_prsnl_ara.Appearance.Options.UseFont = true;
            this.btn_prsnl_ara.Appearance.Options.UseForeColor = true;
            this.btn_prsnl_ara.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_prsnl_ara.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_prsnl_ara.AppearanceHovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_prsnl_ara.AppearanceHovered.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.btn_prsnl_ara.AppearanceHovered.Options.UseBackColor = true;
            this.btn_prsnl_ara.AppearanceHovered.Options.UseBorderColor = true;
            this.btn_prsnl_ara.AppearanceHovered.Options.UseForeColor = true;
            this.btn_prsnl_ara.AppearancePressed.BackColor = System.Drawing.Color.Aqua;
            this.btn_prsnl_ara.AppearancePressed.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_prsnl_ara.AppearancePressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_prsnl_ara.AppearancePressed.Options.UseBackColor = true;
            this.btn_prsnl_ara.AppearancePressed.Options.UseBorderColor = true;
            this.btn_prsnl_ara.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_prsnl_ara.ImageOptions.Image")));
            this.btn_prsnl_ara.Location = new System.Drawing.Point(3, 478);
            this.btn_prsnl_ara.Name = "btn_prsnl_ara";
            this.btn_prsnl_ara.Size = new System.Drawing.Size(265, 45);
            this.btn_prsnl_ara.TabIndex = 4;
            this.btn_prsnl_ara.Text = "Personel Ara";
            this.btn_prsnl_ara.Click += new System.EventHandler(this.Btn_prsnl_ara_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1283, 662);
            this.Controls.Add(this.btn_excel_aktar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_prsn_remove);
            this.Controls.Add(this.btn_prsn_update);
            this.Controls.Add(this.btn_prsnl_ekle);
            this.Controls.Add(this.txt_isim_ara);
            this.Controls.Add(this.btn_prsnl_ara);
            this.Controls.Add(this.txt_meslek);
            this.Controls.Add(this.txt_unvan);
            this.Controls.Add(this.txt_telefon_no);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_tc_no);
            this.Controls.Add(this.txt_soy_isim);
            this.Controls.Add(this.txt_isim);
            this.Controls.Add(this.txt_personel_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_isim_ara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirBasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectionDataSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private demirBasDataSet demirBasDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private demirBasDataSetTableAdapters.PersonelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ısimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_personel_id;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.TextBox txt_soy_isim;
        private System.Windows.Forms.TextBox txt_tc_no;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefon_no;
        private System.Windows.Forms.TextBox txt_unvan;
        private System.Windows.Forms.TextBox txt_meslek;
        private DevExpress.XtraEditors.SimpleButton btn_prsnl_ara;
        private DevExpress.XtraEditors.SimpleButton btn_prsnl_ekle;
        private DevExpress.XtraEditors.SimpleButton btn_prsn_update;
        private DevExpress.XtraEditors.SimpleButton btn_prsn_remove;
        private DevExpress.XtraEditors.TextEdit txt_isim_ara;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private demirBasDataSet demirBasDataSet1;
        private DevExpress.Persistent.Base.ReportsV2.CollectionDataSource collectionDataSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.SimpleButton btn_excel_aktar;
    }
}