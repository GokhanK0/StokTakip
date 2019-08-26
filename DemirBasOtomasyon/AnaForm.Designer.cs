namespace DemirBasOtomasyon
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
            this.brbtn_urn_zimmet = new DevExpress.XtraBars.BarButtonItem();
            this.btn_zmmet_form = new DevExpress.XtraBars.BarButtonItem();
            this.Brbtn_exit = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowHtmlText = true;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.brbtn_prsnl_list,
            this.brbtn_urn_list,
            this.brbtn_urn_zimmet,
            this.btn_zmmet_form,
            this.Brbtn_exit,
            this.skinDropDownButtonItem1,
            this.skinDropDownButtonItem2,
            this.barMdiChildrenListItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1235, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // brbtn_prsnl_list
            // 
            this.brbtn_prsnl_list.Caption = "Personeller Listesi\r\n";
            this.brbtn_prsnl_list.Id = 1;
            this.brbtn_prsnl_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_prsnl_list.ImageOptions.Image")));
            this.brbtn_prsnl_list.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_prsnl_list.ImageOptions.LargeImage")));
            this.brbtn_prsnl_list.Name = "brbtn_prsnl_list";
            this.brbtn_prsnl_list.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_prsnl_list_ItemClick);
            // 
            // brbtn_urn_list
            // 
            this.brbtn_urn_list.Caption = "Ürünler Listesi\r\n";
            this.brbtn_urn_list.Id = 2;
            this.brbtn_urn_list.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_list.ImageOptions.Image")));
            this.brbtn_urn_list.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("brbtn_urn_list.ImageOptions.LargeImage")));
            this.brbtn_urn_list.Name = "brbtn_urn_list";
            this.brbtn_urn_list.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_urn_list_ItemClick);
            // 
            // brbtn_urn_zimmet
            // 
            this.brbtn_urn_zimmet.Caption = "Ürünleri Zimmetle\r\n";
            this.brbtn_urn_zimmet.Id = 3;
            this.brbtn_urn_zimmet.ImageOptions.Image = global::DemirBasOtomasyon.Properties.Resources.newsales_16x16;
            this.brbtn_urn_zimmet.ImageOptions.LargeImage = global::DemirBasOtomasyon.Properties.Resources.newsales_32x32;
            this.brbtn_urn_zimmet.Name = "brbtn_urn_zimmet";
            this.brbtn_urn_zimmet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_urn_zimmet_ItemClick);
            // 
            // btn_zmmet_form
            // 
            this.btn_zmmet_form.Caption = "Personel Zimmet Formu\r\n";
            this.btn_zmmet_form.Id = 4;
            this.btn_zmmet_form.ImageOptions.SvgImage = global::DemirBasOtomasyon.Properties.Resources.alignright;
            this.btn_zmmet_form.Name = "btn_zmmet_form";
            this.btn_zmmet_form.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Btn_zmmet_form_ItemClick);
            // 
            // Brbtn_exit
            // 
            this.Brbtn_exit.Caption = "Çıkış";
            this.Brbtn_exit.Id = 5;
            this.Brbtn_exit.ImageOptions.SvgImage = global::DemirBasOtomasyon.Properties.Resources.del;
            this.Brbtn_exit.Name = "Brbtn_exit";
            this.Brbtn_exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Brbtn_exit_ItemClick);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 6;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Id = 7;
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 8;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENU BAR";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.brbtn_prsnl_list);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.brbtn_urn_list);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.brbtn_urn_zimmet);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_zmmet_form);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.Brbtn_exit);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup8.ItemLinks.Add(this.skinDropDownButtonItem2);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Temalar";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 797);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1235, 21);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 818);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbon;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.AnaForm_Load);
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
        private DevExpress.XtraBars.BarButtonItem brbtn_urn_zimmet;
        private DevExpress.XtraBars.BarButtonItem btn_zmmet_form;
        private DevExpress.XtraBars.BarButtonItem Brbtn_exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}