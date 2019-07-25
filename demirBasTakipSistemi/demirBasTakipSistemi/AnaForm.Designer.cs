namespace demirBasTakipSistemi
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.brbtn_prsnl_list = new DevExpress.XtraBars.BarButtonItem();
            this.brbtn_urn_list = new DevExpress.XtraBars.BarButtonItem();
            this.brbtn_user = new DevExpress.XtraBars.BarButtonItem();
            this.brbtn_urn_zimmet = new DevExpress.XtraBars.BarButtonItem();
            this.brbtn_excel = new DevExpress.XtraBars.BarButtonItem();
            this.Brbtn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_zmmet_form = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowHtmlText = true;
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.brbtn_prsnl_list,
            this.brbtn_urn_list,
            this.brbtn_user,
            this.brbtn_urn_zimmet,
            this.brbtn_excel,
            this.Brbtn_exit,
            this.btn_zmmet_form});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1304, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // brbtn_prsnl_list
            // 
            this.brbtn_prsnl_list.Caption = "Personel Listesi";
            this.brbtn_prsnl_list.Id = 1;
            this.brbtn_prsnl_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_prsnl_list.ImageOptions.Image")));
            this.brbtn_prsnl_list.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_prsnl_list.ImageOptions.LargeImage")));
            this.brbtn_prsnl_list.Name = "brbtn_prsnl_list";
            this.brbtn_prsnl_list.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_prsnl_list_ItemClick);
            // 
            // brbtn_urn_list
            // 
            this.brbtn_urn_list.Caption = "Ürün Listesi";
            this.brbtn_urn_list.Id = 2;
            this.brbtn_urn_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_list.ImageOptions.Image")));
            this.brbtn_urn_list.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_list.ImageOptions.LargeImage")));
            this.brbtn_urn_list.Name = "brbtn_urn_list";
            this.brbtn_urn_list.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_urn_list_ItemClick);
            // 
            // brbtn_user
            // 
            this.brbtn_user.Caption = "Kullanıcılar";
            this.brbtn_user.Id = 3;
            this.brbtn_user.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_user.ImageOptions.Image")));
            this.brbtn_user.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_user.ImageOptions.LargeImage")));
            this.brbtn_user.Name = "brbtn_user";
            // 
            // brbtn_urn_zimmet
            // 
            this.brbtn_urn_zimmet.Caption = "Ürün Zimmetle";
            this.brbtn_urn_zimmet.Id = 4;
            this.brbtn_urn_zimmet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_zimmet.ImageOptions.Image")));
            this.brbtn_urn_zimmet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_zimmet.ImageOptions.LargeImage")));
            this.brbtn_urn_zimmet.Name = "brbtn_urn_zimmet";
            this.brbtn_urn_zimmet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_urn_zimmet_ItemClick);
            // 
            // brbtn_excel
            // 
            this.brbtn_excel.Caption = "Excele Aktar";
            this.brbtn_excel.Id = 5;
            this.brbtn_excel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_excel.ImageOptions.Image")));
            this.brbtn_excel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_excel.ImageOptions.LargeImage")));
            this.brbtn_excel.Name = "brbtn_excel";
            // 
            // Brbtn_exit
            // 
            this.Brbtn_exit.Caption = "Çıkış";
            this.Brbtn_exit.Id = 7;
            this.Brbtn_exit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Brbtn_exit.ImageOptions.Image")));
            this.Brbtn_exit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Brbtn_exit.ImageOptions.LargeImage")));
            this.Brbtn_exit.Name = "Brbtn_exit";
            this.Brbtn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_exit_ItemClick_1);
            // 
            // btn_zmmet_form
            // 
            this.btn_zmmet_form.Caption = "Personel\r\nZimmet Formu";
            this.btn_zmmet_form.Id = 8;
            this.btn_zmmet_form.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_zmmet_form.ImageOptions.SvgImage")));
            this.btn_zmmet_form.Name = "btn_zmmet_form";
            this.btn_zmmet_form.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_zmmet_form_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENU BAR";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.brbtn_prsnl_list);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.brbtn_user);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.brbtn_urn_list, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.brbtn_urn_zimmet);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_zmmet_form);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.Brbtn_exit);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 925);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1304, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 956);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem brbtn_prsnl_list;
        private DevExpress.XtraBars.BarButtonItem brbtn_urn_list;
        private DevExpress.XtraBars.BarButtonItem brbtn_user;
        private DevExpress.XtraBars.BarButtonItem brbtn_urn_zimmet;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem brbtn_excel;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem Brbtn_exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btn_zmmet_form;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}