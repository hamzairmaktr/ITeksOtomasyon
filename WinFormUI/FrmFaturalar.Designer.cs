namespace UIWinForm
{
    partial class FrmFaturalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturalar));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            txtSiraNo = new DevExpress.XtraEditors.TextEdit();
            txtTAlan = new DevExpress.XtraEditors.TextEdit();
            txtTVeren = new DevExpress.XtraEditors.TextEdit();
            lookPersonel = new DevExpress.XtraEditors.LookUpEdit();
            lookCari = new DevExpress.XtraEditors.LookUpEdit();
            txtSaat = new DevExpress.XtraEditors.TextEdit();
            txtTarih = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSiraNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTAlan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTVeren.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookPersonel.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookCari.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSaat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl2).BeginInit();
            xtraTabControl2.SuspendLayout();
            xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43512F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56488F));
            tableLayoutPanel1.Controls.Add(xtraTabControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(xtraTabControl2, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.40607F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1924, 706);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            xtraTabControl1.Size = new System.Drawing.Size(387, 700);
            xtraTabControl1.TabIndex = 501;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage2 });
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(tablePanel1);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(385, 675);
            xtraTabPage2.Text = "Fatura Bilgi";
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.22F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 71.78F) });
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label8);
            tablePanel1.Controls.Add(label7);
            tablePanel1.Controls.Add(label6);
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(btnTemizle);
            tablePanel1.Controls.Add(btnSil);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtSiraNo);
            tablePanel1.Controls.Add(txtTAlan);
            tablePanel1.Controls.Add(txtTVeren);
            tablePanel1.Controls.Add(lookPersonel);
            tablePanel1.Controls.Add(lookCari);
            tablePanel1.Controls.Add(txtSaat);
            tablePanel1.Controls.Add(txtTarih);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel1.Size = new System.Drawing.Size(385, 675);
            tablePanel1.TabIndex = 2;
            tablePanel1.UseSkinIndents = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            tablePanel1.SetColumn(label9, 0);
            label9.Dock = System.Windows.Forms.DockStyle.Fill;
            label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(14, 290);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 10);
            label9.Size = new System.Drawing.Size(96, 28);
            label9.TabIndex = 28;
            label9.Text = "Sıra No :";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 262);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 9);
            label8.Size = new System.Drawing.Size(96, 28);
            label8.TabIndex = 27;
            label8.Text = "T.Alan :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            tablePanel1.SetColumn(label7, 0);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(14, 234);
            label7.Name = "label7";
            tablePanel1.SetRow(label7, 8);
            label7.Size = new System.Drawing.Size(96, 28);
            label7.TabIndex = 26;
            label7.Text = "T.Veren :";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel1.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 206);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 7);
            label6.Size = new System.Drawing.Size(96, 28);
            label6.TabIndex = 25;
            label6.Text = "Personel :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 178);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 6);
            label5.Size = new System.Drawing.Size(96, 28);
            label5.TabIndex = 24;
            label5.Text = "Cari :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 150);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 5);
            label4.Size = new System.Drawing.Size(96, 28);
            label4.TabIndex = 23;
            label4.Text = "Saat :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 122);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 4);
            label3.Size = new System.Drawing.Size(96, 28);
            label3.TabIndex = 22;
            label3.Text = "Tarih :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 94);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 3);
            label2.Size = new System.Drawing.Size(96, 28);
            label2.TabIndex = 21;
            label2.Text = "Id :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTemizle
            // 
            btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTemizle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnTemizle, 1);
            btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnTemizle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTemizle.ImageOptions.Image");
            btnTemizle.Location = new System.Drawing.Point(115, 432);
            btnTemizle.Name = "btnTemizle";
            tablePanel1.SetRow(btnTemizle, 15);
            btnTemizle.Size = new System.Drawing.Size(257, 24);
            btnTemizle.TabIndex = 20;
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSil.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnSil, 1);
            btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSil.ImageOptions.Image");
            btnSil.Location = new System.Drawing.Point(115, 404);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 14);
            btnSil.Size = new System.Drawing.Size(257, 24);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuncelle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnGuncelle, 1);
            btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGuncelle.ImageOptions.Image");
            btnGuncelle.Location = new System.Drawing.Point(115, 376);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 13);
            btnGuncelle.Size = new System.Drawing.Size(257, 24);
            btnGuncelle.TabIndex = 18;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnKaydet, 1);
            btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(115, 348);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 12);
            btnKaydet.Size = new System.Drawing.Size(257, 24);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            tablePanel1.SetColumn(label1, 0);
            tablePanel1.SetColumnSpan(label1, 2);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.Highlight;
            label1.Location = new System.Drawing.Point(14, 38);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(357, 28);
            label1.TabIndex = 16;
            label1.Text = "Fatura Bilgi";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSiraNo
            // 
            tablePanel1.SetColumn(txtSiraNo, 1);
            txtSiraNo.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSiraNo.Location = new System.Drawing.Point(115, 292);
            txtSiraNo.Name = "txtSiraNo";
            txtSiraNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSiraNo.Properties.Appearance.Options.UseFont = true;
            txtSiraNo.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtSiraNo, 10);
            txtSiraNo.Size = new System.Drawing.Size(257, 24);
            txtSiraNo.TabIndex = 15;
            // 
            // txtTAlan
            // 
            tablePanel1.SetColumn(txtTAlan, 1);
            txtTAlan.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTAlan.Location = new System.Drawing.Point(115, 264);
            txtTAlan.Name = "txtTAlan";
            txtTAlan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTAlan.Properties.Appearance.Options.UseFont = true;
            txtTAlan.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTAlan, 9);
            txtTAlan.Size = new System.Drawing.Size(257, 24);
            txtTAlan.TabIndex = 13;
            // 
            // txtTVeren
            // 
            tablePanel1.SetColumn(txtTVeren, 1);
            txtTVeren.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTVeren.Location = new System.Drawing.Point(115, 236);
            txtTVeren.Name = "txtTVeren";
            txtTVeren.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTVeren.Properties.Appearance.Options.UseFont = true;
            txtTVeren.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTVeren, 8);
            txtTVeren.Size = new System.Drawing.Size(257, 24);
            txtTVeren.TabIndex = 11;
            // 
            // lookPersonel
            // 
            tablePanel1.SetColumn(lookPersonel, 1);
            lookPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            lookPersonel.Location = new System.Drawing.Point(115, 208);
            lookPersonel.Name = "lookPersonel";
            lookPersonel.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lookPersonel.Properties.Appearance.Options.UseFont = true;
            lookPersonel.Properties.AutoHeight = false;
            lookPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(lookPersonel, 7);
            lookPersonel.Size = new System.Drawing.Size(257, 24);
            lookPersonel.TabIndex = 9;
            // 
            // lookCari
            // 
            tablePanel1.SetColumn(lookCari, 1);
            lookCari.Dock = System.Windows.Forms.DockStyle.Fill;
            lookCari.Location = new System.Drawing.Point(115, 180);
            lookCari.Name = "lookCari";
            lookCari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lookCari.Properties.Appearance.Options.UseFont = true;
            lookCari.Properties.AutoHeight = false;
            lookCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(lookCari, 6);
            lookCari.Size = new System.Drawing.Size(257, 24);
            lookCari.TabIndex = 7;
            // 
            // txtSaat
            // 
            tablePanel1.SetColumn(txtSaat, 1);
            txtSaat.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSaat.Location = new System.Drawing.Point(115, 152);
            txtSaat.Name = "txtSaat";
            txtSaat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSaat.Properties.Appearance.Options.UseFont = true;
            txtSaat.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtSaat, 5);
            txtSaat.Size = new System.Drawing.Size(257, 24);
            txtSaat.TabIndex = 5;
            // 
            // txtTarih
            // 
            tablePanel1.SetColumn(txtTarih, 1);
            txtTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTarih.Location = new System.Drawing.Point(115, 124);
            txtTarih.Name = "txtTarih";
            txtTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTarih.Properties.Appearance.Options.UseFont = true;
            txtTarih.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTarih, 4);
            txtTarih.Size = new System.Drawing.Size(257, 24);
            txtTarih.TabIndex = 3;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(115, 96);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 3);
            txtId.Size = new System.Drawing.Size(257, 24);
            txtId.TabIndex = 1;
            // 
            // xtraTabControl2
            // 
            xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl2.Location = new System.Drawing.Point(396, 3);
            xtraTabControl2.Name = "xtraTabControl2";
            xtraTabControl2.SelectedTabPage = xtraTabPage3;
            xtraTabControl2.Size = new System.Drawing.Size(1525, 700);
            xtraTabControl2.TabIndex = 502;
            xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage3 });
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(gridControl1);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new System.Drawing.Size(1523, 675);
            xtraTabPage3.Text = "Fatura Bilgi";
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1523, 675);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, gridView3 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            gridView1.DoubleClick += gridView1_DoubleClick;
            // 
            // gridView3
            // 
            gridView3.GridControl = gridControl1;
            gridView3.Name = "gridView3";
            // 
            // FrmFaturalar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 706);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "FrmFaturalar";
            Text = "FrmFaturalar";
            Load += FrmFaturalar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSiraNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTAlan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTVeren.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookPersonel.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookCari.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSaat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl2).EndInit();
            xtraTabControl2.ResumeLayout(false);
            xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.LookUpEdit lookCari;
        private DevExpress.XtraEditors.TextEdit txtSaat;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSiraNo;
        private DevExpress.XtraEditors.TextEdit txtTAlan;
        private DevExpress.XtraEditors.TextEdit txtTVeren;
        private DevExpress.XtraEditors.LookUpEdit lookPersonel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
    }
}