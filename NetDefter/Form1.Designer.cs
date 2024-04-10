namespace NetDefter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.DurumCubugu = new System.Windows.Forms.StatusStrip();
            this.DurumCubuguLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AracCubugu = new System.Windows.Forms.ToolStrip();
            this.AracCubuguYeni = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguAc = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguKaydet = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguFKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AracCubuguKes = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguKopyala = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguYapýþtýr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AracCubuguKalýn = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguÝtalik = new System.Windows.Forms.ToolStripButton();
            this.AracCubuguAltýCizili = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AracCubuguYazdýr = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAc = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFarkliKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.yazdýrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuJes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYapýstýr = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuYazitipi = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRenk = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuArkaplan = new System.Windows.Forms.ToolStripMenuItem();
            this.yardýmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuYardim = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuHakkinda = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Dosya = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.ýmageList1 = new System.Windows.Forms.ImageList(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.DurumCubugu.SuspendLayout();
            this.AracCubugu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Zengin Metin Biçimi (*.rtf)|*.rtf|Bütün Belgeler (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.Title = "Net Defteri";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Zengin Metin Biçimi (*.rtf)|*.rtf|Bütün Belgeler (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            this.saveFileDialog1.Title = "Net Defteri";
            // 
            // DurumCubugu
            // 
            this.DurumCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DurumCubuguLbl1});
            this.DurumCubugu.Location = new System.Drawing.Point(0, 434);
            this.DurumCubugu.Name = "DurumCubugu";
            this.DurumCubugu.Size = new System.Drawing.Size(469, 22);
            this.DurumCubugu.TabIndex = 1;
            this.DurumCubugu.Text = "statusStrip1";
            // 
            // DurumCubuguLbl1
            // 
            this.DurumCubuguLbl1.Name = "DurumCubuguLbl1";
            this.DurumCubuguLbl1.Size = new System.Drawing.Size(109, 17);
            this.DurumCubuguLbl1.Text = "toolStripStatusLabel1";
            // 
            // AracCubugu
            // 
            this.AracCubugu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.AracCubugu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AracCubuguYeni,
            this.AracCubuguAc,
            this.AracCubuguKaydet,
            this.AracCubuguFKaydet,
            this.toolStripSeparator1,
            this.AracCubuguKes,
            this.AracCubuguKopyala,
            this.AracCubuguYapýþtýr,
            this.toolStripSeparator2,
            this.AracCubuguKalýn,
            this.AracCubuguÝtalik,
            this.AracCubuguAltýCizili,
            this.toolStripSeparator3,
            this.AracCubuguYazdýr});
            this.AracCubugu.Location = new System.Drawing.Point(0, 24);
            this.AracCubugu.Name = "AracCubugu";
            this.AracCubugu.Size = new System.Drawing.Size(469, 25);
            this.AracCubugu.Stretch = true;
            this.AracCubugu.TabIndex = 2;
            this.AracCubugu.Text = "toolStrip1";
            // 
            // AracCubuguYeni
            // 
            this.AracCubuguYeni.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguYeni.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguYeni.Image")));
            this.AracCubuguYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguYeni.Name = "AracCubuguYeni";
            this.AracCubuguYeni.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguYeni.Text = "Yeni";
            this.AracCubuguYeni.Click += new System.EventHandler(this.AracCubuguYeni_Click);
            // 
            // AracCubuguAc
            // 
            this.AracCubuguAc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguAc.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguAc.Image")));
            this.AracCubuguAc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguAc.Name = "AracCubuguAc";
            this.AracCubuguAc.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguAc.Text = "Aç";
            this.AracCubuguAc.Click += new System.EventHandler(this.AracCubuguAc_Click);
            // 
            // AracCubuguKaydet
            // 
            this.AracCubuguKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguKaydet.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguKaydet.Image")));
            this.AracCubuguKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguKaydet.Name = "AracCubuguKaydet";
            this.AracCubuguKaydet.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguKaydet.Text = "Kaydet";
            this.AracCubuguKaydet.Click += new System.EventHandler(this.AracCubuguKaydet_Click);
            // 
            // AracCubuguFKaydet
            // 
            this.AracCubuguFKaydet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguFKaydet.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguFKaydet.Image")));
            this.AracCubuguFKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguFKaydet.Name = "AracCubuguFKaydet";
            this.AracCubuguFKaydet.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguFKaydet.Text = "Farklý Kaydet";
            this.AracCubuguFKaydet.Click += new System.EventHandler(this.AracCubuguFKaydet_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // AracCubuguKes
            // 
            this.AracCubuguKes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguKes.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguKes.Image")));
            this.AracCubuguKes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguKes.Name = "AracCubuguKes";
            this.AracCubuguKes.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguKes.Text = "Kes";
            this.AracCubuguKes.Click += new System.EventHandler(this.AracCubuguKes_Click);
            // 
            // AracCubuguKopyala
            // 
            this.AracCubuguKopyala.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguKopyala.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguKopyala.Image")));
            this.AracCubuguKopyala.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguKopyala.Name = "AracCubuguKopyala";
            this.AracCubuguKopyala.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguKopyala.Text = "Kopyala";
            this.AracCubuguKopyala.Click += new System.EventHandler(this.AracCubuguKopyala_Click);
            // 
            // AracCubuguYapýþtýr
            // 
            this.AracCubuguYapýþtýr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguYapýþtýr.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguYapýþtýr.Image")));
            this.AracCubuguYapýþtýr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguYapýþtýr.Name = "AracCubuguYapýþtýr";
            this.AracCubuguYapýþtýr.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguYapýþtýr.Text = "Yapýþtýr";
            this.AracCubuguYapýþtýr.Click += new System.EventHandler(this.AracCubuguYapýþtýr_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // AracCubuguKalýn
            // 
            this.AracCubuguKalýn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguKalýn.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguKalýn.Image")));
            this.AracCubuguKalýn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguKalýn.Name = "AracCubuguKalýn";
            this.AracCubuguKalýn.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguKalýn.Text = "Kalýn";
            this.AracCubuguKalýn.Click += new System.EventHandler(this.AracCubuguKalýn_Click);
            // 
            // AracCubuguÝtalik
            // 
            this.AracCubuguÝtalik.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguÝtalik.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguÝtalik.Image")));
            this.AracCubuguÝtalik.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguÝtalik.Name = "AracCubuguÝtalik";
            this.AracCubuguÝtalik.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguÝtalik.Text = "Ýtalic";
            this.AracCubuguÝtalik.Click += new System.EventHandler(this.AracCubuguÝtalik_Click);
            // 
            // AracCubuguAltýCizili
            // 
            this.AracCubuguAltýCizili.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguAltýCizili.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguAltýCizili.Image")));
            this.AracCubuguAltýCizili.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguAltýCizili.Name = "AracCubuguAltýCizili";
            this.AracCubuguAltýCizili.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguAltýCizili.Text = "Altý Çizili";
            this.AracCubuguAltýCizili.Click += new System.EventHandler(this.AracCubuguAltýCizili_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AracCubuguYazdýr
            // 
            this.AracCubuguYazdýr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AracCubuguYazdýr.Image = ((System.Drawing.Image)(resources.GetObject("AracCubuguYazdýr.Image")));
            this.AracCubuguYazdýr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AracCubuguYazdýr.Name = "AracCubuguYazdýr";
            this.AracCubuguYazdýr.Size = new System.Drawing.Size(23, 22);
            this.AracCubuguYazdýr.Text = "Yazdýr";
            this.AracCubuguYazdýr.Click += new System.EventHandler(this.AracCubuguYazdýr_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.düzenToolStripMenuItem,
            this.yardýmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(469, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuYeni,
            this.MenuAc,
            this.toolStripMenuItem1,
            this.MenuKaydet,
            this.MenuFarkliKaydet,
            this.toolStripMenuItem2,
            this.yazdýrToolStripMenuItem,
            this.toolStripMenuItem10,
            this.MenuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // MenuYeni
            // 
            this.MenuYeni.Name = "MenuYeni";
            this.MenuYeni.Size = new System.Drawing.Size(147, 22);
            this.MenuYeni.Text = "&Yeni";
            this.MenuYeni.Click += new System.EventHandler(this.MenuYeni_Click);
            // 
            // MenuAc
            // 
            this.MenuAc.Name = "MenuAc";
            this.MenuAc.Size = new System.Drawing.Size(147, 22);
            this.MenuAc.Text = "&Aç";
            this.MenuAc.Click += new System.EventHandler(this.MenuAc_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuKaydet
            // 
            this.MenuKaydet.Name = "MenuKaydet";
            this.MenuKaydet.Size = new System.Drawing.Size(147, 22);
            this.MenuKaydet.Text = "&Kaydet";
            this.MenuKaydet.Click += new System.EventHandler(this.MenuKaydet_Click);
            // 
            // MenuFarkliKaydet
            // 
            this.MenuFarkliKaydet.Name = "MenuFarkliKaydet";
            this.MenuFarkliKaydet.Size = new System.Drawing.Size(147, 22);
            this.MenuFarkliKaydet.Text = "&Farklý Kaydet";
            this.MenuFarkliKaydet.Click += new System.EventHandler(this.MenuFarkliKaydet_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(144, 6);
            // 
            // yazdýrToolStripMenuItem
            // 
            this.yazdýrToolStripMenuItem.Name = "yazdýrToolStripMenuItem";
            this.yazdýrToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.yazdýrToolStripMenuItem.Text = "Yazdýr";
            this.yazdýrToolStripMenuItem.Click += new System.EventHandler(this.yazdýrToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(144, 6);
            // 
            // MenuCikis
            // 
            this.MenuCikis.Name = "MenuCikis";
            this.MenuCikis.Size = new System.Drawing.Size(147, 22);
            this.MenuCikis.Text = "&Çýkýþ";
            this.MenuCikis.Click += new System.EventHandler(this.MenuCikis_Click);
            // 
            // düzenToolStripMenuItem
            // 
            this.düzenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuKopyala,
            this.MenuJes,
            this.MenuYapýstýr,
            this.toolStripMenuItem3,
            this.MenuYazitipi,
            this.MenuRenk,
            this.toolStripMenuItem4,
            this.MenuArkaplan});
            this.düzenToolStripMenuItem.Name = "düzenToolStripMenuItem";
            this.düzenToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.düzenToolStripMenuItem.Text = "Düzen";
            // 
            // MenuKopyala
            // 
            this.MenuKopyala.Name = "MenuKopyala";
            this.MenuKopyala.Size = new System.Drawing.Size(127, 22);
            this.MenuKopyala.Text = "Kopyala";
            this.MenuKopyala.Click += new System.EventHandler(this.MenuKopyala_Click);
            // 
            // MenuJes
            // 
            this.MenuJes.Name = "MenuJes";
            this.MenuJes.Size = new System.Drawing.Size(127, 22);
            this.MenuJes.Text = "Kes";
            this.MenuJes.Click += new System.EventHandler(this.MenuJes_Click);
            // 
            // MenuYapýstýr
            // 
            this.MenuYapýstýr.Name = "MenuYapýstýr";
            this.MenuYapýstýr.Size = new System.Drawing.Size(127, 22);
            this.MenuYapýstýr.Text = "Yapýþtýr";
            this.MenuYapýstýr.Click += new System.EventHandler(this.MenuYapýstýr_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 6);
            // 
            // MenuYazitipi
            // 
            this.MenuYazitipi.Name = "MenuYazitipi";
            this.MenuYazitipi.Size = new System.Drawing.Size(127, 22);
            this.MenuYazitipi.Text = "Yazýtipi";
            this.MenuYazitipi.Click += new System.EventHandler(this.MenuYazitipi_Click);
            // 
            // MenuRenk
            // 
            this.MenuRenk.Name = "MenuRenk";
            this.MenuRenk.Size = new System.Drawing.Size(127, 22);
            this.MenuRenk.Text = "Renk";
            this.MenuRenk.Click += new System.EventHandler(this.MenuRenk_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 6);
            // 
            // MenuArkaplan
            // 
            this.MenuArkaplan.Name = "MenuArkaplan";
            this.MenuArkaplan.Size = new System.Drawing.Size(127, 22);
            this.MenuArkaplan.Text = "Arkaplan";
            this.MenuArkaplan.Click += new System.EventHandler(this.MenuArkaplan_Click);
            // 
            // yardýmToolStripMenuItem
            // 
            this.yardýmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuYardim,
            this.toolStripMenuItem5,
            this.MenuHakkinda});
            this.yardýmToolStripMenuItem.Name = "yardýmToolStripMenuItem";
            this.yardýmToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.yardýmToolStripMenuItem.Text = "Yardým";
            // 
            // MenuYardim
            // 
            this.MenuYardim.Name = "MenuYardim";
            this.MenuYardim.Size = new System.Drawing.Size(152, 22);
            this.MenuYardim.Text = "Yardým";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuHakkinda
            // 
            this.MenuHakkinda.Name = "MenuHakkinda";
            this.MenuHakkinda.Size = new System.Drawing.Size(152, 22);
            this.MenuHakkinda.Text = "Hakkýnda";
            this.MenuHakkinda.Click += new System.EventHandler(this.MenuHakkinda_Click);
            // 
            // Dosya
            // 
            this.Dosya.ContextMenuStrip = this.contextMenuStrip1;
            this.Dosya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dosya.Location = new System.Drawing.Point(0, 49);
            this.Dosya.Name = "Dosya";
            this.Dosya.Size = new System.Drawing.Size(469, 385);
            this.Dosya.TabIndex = 4;
            this.Dosya.Text = "";
            this.Dosya.TextChanged += new System.EventHandler(this.Dosya_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripSeparator4,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 120);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.kesToolStripMenuItem.Text = "Kes";
            this.kesToolStripMenuItem.Click += new System.EventHandler(this.kesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem6.Text = "Kopyala";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem7.Text = "Yapýþtýr";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem8.Text = "Yazý Tipi";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuItem9.Text = "Renk";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem9_Click);
            // 
            // ýmageList1
            // 
            this.ýmageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ýmageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ýmageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "Dosya";
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 456);
            this.Controls.Add(this.Dosya);
            this.Controls.Add(this.AracCubugu);
            this.Controls.Add(this.DurumCubugu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Net Defter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DurumCubugu.ResumeLayout(false);
            this.DurumCubugu.PerformLayout();
            this.AracCubugu.ResumeLayout(false);
            this.AracCubugu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip DurumCubugu;
        private System.Windows.Forms.ToolStrip AracCubugu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuYeni;
        private System.Windows.Forms.ToolStripMenuItem MenuAc;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuKaydet;
        private System.Windows.Forms.ToolStripMenuItem MenuFarkliKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuCikis;
        private System.Windows.Forms.ToolStripMenuItem düzenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuKopyala;
        private System.Windows.Forms.ToolStripMenuItem MenuJes;
        private System.Windows.Forms.ToolStripMenuItem MenuYapýstýr;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem MenuYazitipi;
        private System.Windows.Forms.ToolStripMenuItem MenuRenk;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem MenuArkaplan;
        private System.Windows.Forms.ToolStripMenuItem yardýmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuYardim;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem MenuHakkinda;
        private System.Windows.Forms.RichTextBox Dosya;
        private System.Windows.Forms.ToolStripStatusLabel DurumCubuguLbl1;
        private System.Windows.Forms.ToolStripButton AracCubuguYeni;
        private System.Windows.Forms.ToolStripButton AracCubuguAc;
        private System.Windows.Forms.ToolStripButton AracCubuguKaydet;
        private System.Windows.Forms.ToolStripButton AracCubuguFKaydet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AracCubuguKes;
        private System.Windows.Forms.ToolStripButton AracCubuguKopyala;
        private System.Windows.Forms.ToolStripButton AracCubuguYapýþtýr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton AracCubuguKalýn;
        private System.Windows.Forms.ToolStripButton AracCubuguÝtalik;
        private System.Windows.Forms.ToolStripButton AracCubuguAltýCizili;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList ýmageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem yazdýrToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
        private System.Windows.Forms.ToolStripButton AracCubuguYazdýr;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

