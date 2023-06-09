﻿namespace UIWinForm
{
    partial class FrmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtAlisFiyat = new DevExpress.XtraEditors.TextEdit();
            txtAdet = new DevExpress.XtraEditors.TextEdit();
            txtKg = new DevExpress.XtraEditors.TextEdit();
            txtRenk = new DevExpress.XtraEditors.TextEdit();
            txtUrunAd = new DevExpress.XtraEditors.TextEdit();
            txtTur = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            label11 = new System.Windows.Forms.Label();
            txtLotNo = new DevExpress.XtraEditors.TextEdit();
            txtDetay = new System.Windows.Forms.RichTextBox();
            txtSatisFiyat = new DevExpress.XtraEditors.TextEdit();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKg.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtRenk.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtLotNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyat.Properties).BeginInit();
            SuspendLayout();
            // 
            // btnTemizle
            // 
            btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTemizle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnTemizle, 1);
            btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnTemizle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTemizle.ImageOptions.Image");
            btnTemizle.Location = new System.Drawing.Point(122, 639);
            btnTemizle.Name = "btnTemizle";
            tablePanel1.SetRow(btnTemizle, 16);
            btnTemizle.Size = new System.Drawing.Size(222, 31);
            btnTemizle.TabIndex = 20;
            btnTemizle.Text = "Temizle";
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuncelle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnGuncelle, 1);
            btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGuncelle.ImageOptions.Image");
            btnGuncelle.Location = new System.Drawing.Point(122, 569);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 14);
            btnGuncelle.Size = new System.Drawing.Size(222, 31);
            btnGuncelle.TabIndex = 19;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSil.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnSil, 1);
            btnSil.Dock = System.Windows.Forms.DockStyle.Fill;
            btnSil.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnSil.ImageOptions.Image");
            btnSil.Location = new System.Drawing.Point(122, 604);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 15);
            btnSil.Size = new System.Drawing.Size(222, 31);
            btnSil.TabIndex = 18;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnKaydet, 1);
            btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(122, 534);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 13);
            btnKaydet.Size = new System.Drawing.Size(222, 31);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            tablePanel1.SetColumn(label9, 1);
            label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(123, 76);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(220, 36);
            label9.TabIndex = 16;
            label9.Text = "Ürünler";
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 357);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 8);
            label8.Size = new System.Drawing.Size(103, 35);
            label8.TabIndex = 15;
            label8.Text = "Alış Fiyat :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            tablePanel1.SetColumn(label7, 0);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(14, 427);
            label7.Name = "label7";
            tablePanel1.SetRow(label7, 10);
            label7.Size = new System.Drawing.Size(103, 35);
            label7.TabIndex = 14;
            label7.Text = "Detay :";
            label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel1.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 322);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 7);
            label6.Size = new System.Drawing.Size(103, 35);
            label6.TabIndex = 13;
            label6.Text = "Adet :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 287);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 6);
            label5.Size = new System.Drawing.Size(103, 35);
            label5.TabIndex = 12;
            label5.Text = "Kg :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 252);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 5);
            label4.Size = new System.Drawing.Size(103, 35);
            label4.TabIndex = 11;
            label4.Text = "Renk :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 217);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 4);
            label3.Size = new System.Drawing.Size(103, 35);
            label3.TabIndex = 10;
            label3.Text = "Ürün Ad :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 182);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 3);
            label2.Size = new System.Drawing.Size(103, 35);
            label2.TabIndex = 9;
            label2.Text = "Tür :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tablePanel1.SetColumn(label1, 0);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 112);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(103, 35);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAlisFiyat
            // 
            tablePanel1.SetColumn(txtAlisFiyat, 1);
            txtAlisFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAlisFiyat.Location = new System.Drawing.Point(122, 359);
            txtAlisFiyat.Name = "txtAlisFiyat";
            txtAlisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAlisFiyat.Properties.Appearance.Options.UseFont = true;
            txtAlisFiyat.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtAlisFiyat, 8);
            txtAlisFiyat.Size = new System.Drawing.Size(222, 31);
            txtAlisFiyat.TabIndex = 7;
            // 
            // txtAdet
            // 
            tablePanel1.SetColumn(txtAdet, 1);
            txtAdet.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAdet.Location = new System.Drawing.Point(122, 324);
            txtAdet.Name = "txtAdet";
            txtAdet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAdet.Properties.Appearance.Options.UseFont = true;
            txtAdet.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtAdet, 7);
            txtAdet.Size = new System.Drawing.Size(222, 31);
            txtAdet.TabIndex = 5;
            // 
            // txtKg
            // 
            tablePanel1.SetColumn(txtKg, 1);
            txtKg.Dock = System.Windows.Forms.DockStyle.Fill;
            txtKg.Location = new System.Drawing.Point(122, 289);
            txtKg.Name = "txtKg";
            txtKg.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKg.Properties.Appearance.Options.UseFont = true;
            txtKg.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtKg, 6);
            txtKg.Size = new System.Drawing.Size(222, 31);
            txtKg.TabIndex = 4;
            // 
            // txtRenk
            // 
            tablePanel1.SetColumn(txtRenk, 1);
            txtRenk.Dock = System.Windows.Forms.DockStyle.Fill;
            txtRenk.Location = new System.Drawing.Point(122, 254);
            txtRenk.Name = "txtRenk";
            txtRenk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtRenk.Properties.Appearance.Options.UseFont = true;
            txtRenk.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtRenk, 5);
            txtRenk.Size = new System.Drawing.Size(222, 31);
            txtRenk.TabIndex = 3;
            // 
            // txtUrunAd
            // 
            tablePanel1.SetColumn(txtUrunAd, 1);
            txtUrunAd.Dock = System.Windows.Forms.DockStyle.Fill;
            txtUrunAd.Location = new System.Drawing.Point(122, 219);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUrunAd.Properties.Appearance.Options.UseFont = true;
            txtUrunAd.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtUrunAd, 4);
            txtUrunAd.Size = new System.Drawing.Size(222, 31);
            txtUrunAd.TabIndex = 2;
            // 
            // txtTur
            // 
            tablePanel1.SetColumn(txtTur, 1);
            txtTur.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTur.Location = new System.Drawing.Point(122, 184);
            txtTur.Name = "txtTur";
            txtTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTur.Properties.Appearance.Options.UseFont = true;
            txtTur.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTur, 3);
            txtTur.Size = new System.Drawing.Size(222, 31);
            txtTur.TabIndex = 1;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(122, 114);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(222, 31);
            txtId.TabIndex = 0;
            // 
            // gridView1
            // 
            gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(366, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1412, 784);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43512F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56488F));
            tableLayoutPanel1.Controls.Add(gridControl1, 1, 0);
            tableLayoutPanel1.Controls.Add(tablePanel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.40607F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1781, 790);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.52F) });
            tablePanel1.Controls.Add(label11);
            tablePanel1.Controls.Add(txtLotNo);
            tablePanel1.Controls.Add(txtDetay);
            tablePanel1.Controls.Add(txtSatisFiyat);
            tablePanel1.Controls.Add(label10);
            tablePanel1.Controls.Add(btnTemizle);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(btnSil);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label8);
            tablePanel1.Controls.Add(label7);
            tablePanel1.Controls.Add(label6);
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtAlisFiyat);
            tablePanel1.Controls.Add(txtAdet);
            tablePanel1.Controls.Add(txtKg);
            tablePanel1.Controls.Add(txtRenk);
            tablePanel1.Controls.Add(txtUrunAd);
            tablePanel1.Controls.Add(txtTur);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.62F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel1.Size = new System.Drawing.Size(357, 784);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            tablePanel1.SetColumn(label11, 0);
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(14, 147);
            label11.Name = "label11";
            tablePanel1.SetRow(label11, 2);
            label11.Size = new System.Drawing.Size(103, 35);
            label11.TabIndex = 29;
            label11.Text = "Lot Numarası :";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLotNo
            // 
            tablePanel1.SetColumn(txtLotNo, 1);
            txtLotNo.Dock = System.Windows.Forms.DockStyle.Fill;
            txtLotNo.Location = new System.Drawing.Point(122, 149);
            txtLotNo.Name = "txtLotNo";
            txtLotNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLotNo.Properties.Appearance.Options.UseFont = true;
            txtLotNo.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtLotNo, 2);
            txtLotNo.Size = new System.Drawing.Size(222, 31);
            txtLotNo.TabIndex = 28;
            // 
            // txtDetay
            // 
            tablePanel1.SetColumn(txtDetay, 1);
            txtDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDetay.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDetay.Location = new System.Drawing.Point(122, 429);
            txtDetay.Name = "txtDetay";
            tablePanel1.SetRow(txtDetay, 10);
            tablePanel1.SetRowSpan(txtDetay, 2);
            txtDetay.Size = new System.Drawing.Size(222, 66);
            txtDetay.TabIndex = 27;
            txtDetay.Text = "";
            // 
            // txtSatisFiyat
            // 
            tablePanel1.SetColumn(txtSatisFiyat, 1);
            txtSatisFiyat.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSatisFiyat.Location = new System.Drawing.Point(122, 394);
            txtSatisFiyat.Name = "txtSatisFiyat";
            txtSatisFiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSatisFiyat.Properties.Appearance.Options.UseFont = true;
            txtSatisFiyat.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtSatisFiyat, 9);
            txtSatisFiyat.Size = new System.Drawing.Size(222, 31);
            txtSatisFiyat.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            tablePanel1.SetColumn(label10, 0);
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(14, 392);
            label10.Name = "label10";
            tablePanel1.SetRow(label10, 9);
            label10.Size = new System.Drawing.Size(103, 35);
            label10.TabIndex = 22;
            label10.Text = "Satış Fiyat :";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmUrunler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1781, 790);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmUrunler";
            Text = "FrmUrunler";
            Load += FrmUrunler_Load;
            ((System.ComponentModel.ISupportInitialize)txtAlisFiyat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAdet.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKg.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtRenk.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUrunAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtLotNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSatisFiyat.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyat;
        private DevExpress.XtraEditors.TextEdit txtAdet;
        private DevExpress.XtraEditors.TextEdit txtKg;
        private DevExpress.XtraEditors.TextEdit txtRenk;
        private DevExpress.XtraEditors.TextEdit txtUrunAd;
        private DevExpress.XtraEditors.TextEdit txtTur;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyat;
        private System.Windows.Forms.RichTextBox txtDetay;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtLotNo;
    }
}