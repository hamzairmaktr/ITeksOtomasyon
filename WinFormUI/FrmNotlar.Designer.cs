﻿namespace UIWinForm
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            chkYapildimi = new DevExpress.XtraEditors.CheckEdit();
            txtDetay = new System.Windows.Forms.RichTextBox();
            btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label9 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtSaat = new DevExpress.XtraEditors.TextEdit();
            txtBaslik = new DevExpress.XtraEditors.TextEdit();
            txtTarih = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            label8 = new System.Windows.Forms.Label();
            comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkYapildimi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSaat.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBaslik.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).BeginInit();
            SuspendLayout();
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
            gridControl1.Location = new System.Drawing.Point(326, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1254, 798);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.52F) });
            tablePanel1.Controls.Add(comboBoxEdit1);
            tablePanel1.Controls.Add(label8);
            tablePanel1.Controls.Add(lookUpEdit1);
            tablePanel1.Controls.Add(chkYapildimi);
            tablePanel1.Controls.Add(txtDetay);
            tablePanel1.Controls.Add(btnTemizle);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(btnSil);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label7);
            tablePanel1.Controls.Add(label6);
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtSaat);
            tablePanel1.Controls.Add(txtBaslik);
            tablePanel1.Controls.Add(txtTarih);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.62F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel1.Size = new System.Drawing.Size(317, 798);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // lookUpEdit1
            // 
            tablePanel1.SetColumn(lookUpEdit1, 1);
            lookUpEdit1.Location = new System.Drawing.Point(109, 291);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.AutoHeight = false;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(lookUpEdit1, 6);
            lookUpEdit1.Size = new System.Drawing.Size(195, 31);
            lookUpEdit1.TabIndex = 29;
            // 
            // chkYapildimi
            // 
            tablePanel1.SetColumn(chkYapildimi, 1);
            chkYapildimi.Dock = System.Windows.Forms.DockStyle.Fill;
            chkYapildimi.Location = new System.Drawing.Point(109, 326);
            chkYapildimi.Name = "chkYapildimi";
            chkYapildimi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            chkYapildimi.Properties.Appearance.Options.UseFont = true;
            chkYapildimi.Properties.Caption = "Yapıldı";
            tablePanel1.SetRow(chkYapildimi, 7);
            chkYapildimi.Size = new System.Drawing.Size(195, 31);
            chkYapildimi.TabIndex = 28;
            // 
            // txtDetay
            // 
            tablePanel1.SetColumn(txtDetay, 1);
            txtDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDetay.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDetay.Location = new System.Drawing.Point(109, 361);
            txtDetay.Name = "txtDetay";
            tablePanel1.SetRow(txtDetay, 8);
            tablePanel1.SetRowSpan(txtDetay, 2);
            txtDetay.Size = new System.Drawing.Size(195, 66);
            txtDetay.TabIndex = 27;
            txtDetay.Text = "";
            // 
            // btnTemizle
            // 
            btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTemizle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnTemizle, 1);
            btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnTemizle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTemizle.ImageOptions.Image");
            btnTemizle.Location = new System.Drawing.Point(109, 571);
            btnTemizle.Name = "btnTemizle";
            tablePanel1.SetRow(btnTemizle, 14);
            btnTemizle.Size = new System.Drawing.Size(195, 31);
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
            btnGuncelle.Location = new System.Drawing.Point(109, 501);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 12);
            btnGuncelle.Size = new System.Drawing.Size(195, 31);
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
            btnSil.Location = new System.Drawing.Point(109, 536);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 13);
            btnSil.Size = new System.Drawing.Size(195, 31);
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
            btnKaydet.Location = new System.Drawing.Point(109, 466);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 11);
            btnKaydet.Size = new System.Drawing.Size(195, 31);
            btnKaydet.TabIndex = 17;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(110, 73);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(193, 36);
            label9.TabIndex = 16;
            label9.Text = "Notlar";
            // 
            // label7
            // 
            label7.AutoSize = true;
            tablePanel1.SetColumn(label7, 0);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(14, 359);
            label7.Name = "label7";
            tablePanel1.SetRow(label7, 8);
            label7.Size = new System.Drawing.Size(90, 35);
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
            label6.Location = new System.Drawing.Point(14, 324);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 7);
            label6.Size = new System.Drawing.Size(90, 35);
            label6.TabIndex = 13;
            label6.Text = "Yapıldımı :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 289);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 6);
            label5.Size = new System.Drawing.Size(90, 35);
            label5.TabIndex = 12;
            label5.Text = "Personel :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 254);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 5);
            label4.Size = new System.Drawing.Size(90, 35);
            label4.TabIndex = 11;
            label4.Text = "Başlık :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 184);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 3);
            label3.Size = new System.Drawing.Size(90, 35);
            label3.TabIndex = 10;
            label3.Text = "Saat :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 149);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 2);
            label2.Size = new System.Drawing.Size(90, 35);
            label2.TabIndex = 9;
            label2.Text = "Tarih :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tablePanel1.SetColumn(label1, 0);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 114);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(90, 35);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSaat
            // 
            tablePanel1.SetColumn(txtSaat, 1);
            txtSaat.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSaat.Location = new System.Drawing.Point(109, 186);
            txtSaat.Name = "txtSaat";
            txtSaat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSaat.Properties.Appearance.Options.UseFont = true;
            txtSaat.Properties.AutoHeight = false;
            txtSaat.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            txtSaat.Properties.MaskSettings.Set("mask", "t");
            tablePanel1.SetRow(txtSaat, 3);
            txtSaat.Size = new System.Drawing.Size(195, 31);
            txtSaat.TabIndex = 3;
            // 
            // txtBaslik
            // 
            tablePanel1.SetColumn(txtBaslik, 1);
            txtBaslik.Dock = System.Windows.Forms.DockStyle.Fill;
            txtBaslik.Location = new System.Drawing.Point(109, 256);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBaslik.Properties.Appearance.Options.UseFont = true;
            txtBaslik.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtBaslik, 5);
            txtBaslik.Size = new System.Drawing.Size(195, 31);
            txtBaslik.TabIndex = 2;
            // 
            // txtTarih
            // 
            tablePanel1.SetColumn(txtTarih, 1);
            txtTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTarih.Location = new System.Drawing.Point(109, 151);
            txtTarih.Name = "txtTarih";
            txtTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTarih.Properties.Appearance.Options.UseFont = true;
            txtTarih.Properties.AutoHeight = false;
            txtTarih.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeOffsetMaskManager));
            txtTarih.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            txtTarih.Properties.MaskSettings.Set("mask", "D");
            tablePanel1.SetRow(txtTarih, 2);
            txtTarih.Size = new System.Drawing.Size(195, 31);
            txtTarih.TabIndex = 1;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(109, 116);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(195, 31);
            txtId.TabIndex = 0;
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1583, 804);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 219);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 4);
            label8.Size = new System.Drawing.Size(90, 35);
            label8.TabIndex = 30;
            label8.Text = "Önem :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxEdit1
            // 
            tablePanel1.SetColumn(comboBoxEdit1, 1);
            comboBoxEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            comboBoxEdit1.Location = new System.Drawing.Point(109, 221);
            comboBoxEdit1.Name = "comboBoxEdit1";
            comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            comboBoxEdit1.Properties.AutoHeight = false;
            comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            comboBoxEdit1.Properties.Items.AddRange(new object[] { "Önemli", "Günlük", "Süresiz" });
            comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel1.SetRow(comboBoxEdit1, 4);
            comboBoxEdit1.Size = new System.Drawing.Size(195, 31);
            comboBoxEdit1.TabIndex = 31;
            // 
            // FrmNotlar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1583, 804);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmNotlar";
            Text = "FrmNotlar";
            Load += FrmNotlar_Load;
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkYapildimi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSaat.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBaslik.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)comboBoxEdit1.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.RichTextBox txtDetay;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtSaat;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtBaslik;
        private DevExpress.XtraEditors.TextEdit txtTarih;
        private DevExpress.XtraEditors.CheckEdit chkYapildimi;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label8;
    }
}