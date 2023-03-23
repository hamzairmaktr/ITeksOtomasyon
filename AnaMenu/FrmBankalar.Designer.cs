namespace UIWinForm
{
    partial class FrmBankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankalar));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            dateTarih = new DevExpress.XtraEditors.DateEdit();
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
            txtHesapTuru = new DevExpress.XtraEditors.TextEdit();
            txtYetkili = new DevExpress.XtraEditors.TextEdit();
            txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            txtIban = new DevExpress.XtraEditors.TextEdit();
            txtSube = new DevExpress.XtraEditors.TextEdit();
            txtAd = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHesapTuru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYetkili.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtHesapNo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIban.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSube.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            SuspendLayout();
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1684, 760);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(347, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1334, 754);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged_1;
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.52F) });
            tablePanel1.Controls.Add(dateTarih);
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
            tablePanel1.Controls.Add(txtHesapTuru);
            tablePanel1.Controls.Add(txtYetkili);
            tablePanel1.Controls.Add(txtHesapNo);
            tablePanel1.Controls.Add(txtIban);
            tablePanel1.Controls.Add(txtSube);
            tablePanel1.Controls.Add(txtAd);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.62F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F) });
            tablePanel1.Size = new System.Drawing.Size(338, 754);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // dateTarih
            // 
            tablePanel1.SetColumn(dateTarih, 1);
            dateTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTarih.EditValue = null;
            dateTarih.Location = new System.Drawing.Point(116, 282);
            dateTarih.Name = "dateTarih";
            dateTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTarih.Properties.Appearance.Options.UseFont = true;
            dateTarih.Properties.AutoHeight = false;
            dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(dateTarih, 7);
            dateTarih.Size = new System.Drawing.Size(209, 24);
            dateTarih.TabIndex = 21;
            // 
            // btnTemizle
            // 
            btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTemizle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnTemizle, 1);
            btnTemizle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnTemizle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnTemizle.ImageOptions.Image");
            btnTemizle.Location = new System.Drawing.Point(116, 478);
            btnTemizle.Name = "btnTemizle";
            tablePanel1.SetRow(btnTemizle, 13);
            btnTemizle.Size = new System.Drawing.Size(209, 31);
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
            btnGuncelle.Location = new System.Drawing.Point(116, 408);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 11);
            btnGuncelle.Size = new System.Drawing.Size(209, 31);
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
            btnSil.Location = new System.Drawing.Point(116, 443);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 12);
            btnSil.Size = new System.Drawing.Size(209, 31);
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
            btnKaydet.Location = new System.Drawing.Point(116, 373);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 10);
            btnKaydet.Size = new System.Drawing.Size(209, 31);
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
            label9.Location = new System.Drawing.Point(117, 76);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(207, 36);
            label9.TabIndex = 16;
            label9.Text = "Bankalar";
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 308);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 8);
            label8.Size = new System.Drawing.Size(97, 28);
            label8.TabIndex = 15;
            label8.Text = "Hesap Turu :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            tablePanel1.SetColumn(label7, 0);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(14, 280);
            label7.Name = "label7";
            tablePanel1.SetRow(label7, 7);
            label7.Size = new System.Drawing.Size(97, 28);
            label7.TabIndex = 14;
            label7.Text = "Tarih :";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel1.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 252);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 6);
            label6.Size = new System.Drawing.Size(97, 28);
            label6.TabIndex = 13;
            label6.Text = "Yetkili :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 224);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 5);
            label5.Size = new System.Drawing.Size(97, 28);
            label5.TabIndex = 12;
            label5.Text = "Hesap No :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 196);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 4);
            label4.Size = new System.Drawing.Size(97, 28);
            label4.TabIndex = 11;
            label4.Text = "Iban :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 168);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 3);
            label3.Size = new System.Drawing.Size(97, 28);
            label3.TabIndex = 10;
            label3.Text = "Sube :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 140);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 2);
            label2.Size = new System.Drawing.Size(97, 28);
            label2.TabIndex = 9;
            label2.Text = "Ad :";
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
            label1.Size = new System.Drawing.Size(97, 28);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtHesapTuru
            // 
            tablePanel1.SetColumn(txtHesapTuru, 1);
            txtHesapTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            txtHesapTuru.Location = new System.Drawing.Point(116, 310);
            txtHesapTuru.Name = "txtHesapTuru";
            txtHesapTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHesapTuru.Properties.Appearance.Options.UseFont = true;
            txtHesapTuru.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtHesapTuru, 8);
            txtHesapTuru.Size = new System.Drawing.Size(209, 24);
            txtHesapTuru.TabIndex = 7;
            // 
            // txtYetkili
            // 
            tablePanel1.SetColumn(txtYetkili, 1);
            txtYetkili.Dock = System.Windows.Forms.DockStyle.Fill;
            txtYetkili.Location = new System.Drawing.Point(116, 254);
            txtYetkili.Name = "txtYetkili";
            txtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtYetkili.Properties.Appearance.Options.UseFont = true;
            txtYetkili.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtYetkili, 6);
            txtYetkili.Size = new System.Drawing.Size(209, 24);
            txtYetkili.TabIndex = 5;
            // 
            // txtHesapNo
            // 
            tablePanel1.SetColumn(txtHesapNo, 1);
            txtHesapNo.Dock = System.Windows.Forms.DockStyle.Fill;
            txtHesapNo.Location = new System.Drawing.Point(116, 226);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHesapNo.Properties.Appearance.Options.UseFont = true;
            txtHesapNo.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtHesapNo, 5);
            txtHesapNo.Size = new System.Drawing.Size(209, 24);
            txtHesapNo.TabIndex = 4;
            // 
            // txtIban
            // 
            tablePanel1.SetColumn(txtIban, 1);
            txtIban.Dock = System.Windows.Forms.DockStyle.Fill;
            txtIban.Location = new System.Drawing.Point(116, 198);
            txtIban.Name = "txtIban";
            txtIban.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIban.Properties.Appearance.Options.UseFont = true;
            txtIban.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtIban, 4);
            txtIban.Size = new System.Drawing.Size(209, 24);
            txtIban.TabIndex = 3;
            // 
            // txtSube
            // 
            tablePanel1.SetColumn(txtSube, 1);
            txtSube.Dock = System.Windows.Forms.DockStyle.Fill;
            txtSube.Location = new System.Drawing.Point(116, 170);
            txtSube.Name = "txtSube";
            txtSube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSube.Properties.Appearance.Options.UseFont = true;
            txtSube.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtSube, 3);
            txtSube.Size = new System.Drawing.Size(209, 24);
            txtSube.TabIndex = 2;
            // 
            // txtAd
            // 
            tablePanel1.SetColumn(txtAd, 1);
            txtAd.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAd.Location = new System.Drawing.Point(116, 142);
            txtAd.Name = "txtAd";
            txtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAd.Properties.Appearance.Options.UseFont = true;
            txtAd.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtAd, 2);
            txtAd.Size = new System.Drawing.Size(209, 24);
            txtAd.TabIndex = 1;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(116, 114);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(209, 24);
            txtId.TabIndex = 0;
            // 
            // FrmBankalar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1684, 760);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmBankalar";
            Text = "FrmBankalar";
            Load += FrmBankalar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHesapTuru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYetkili.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtHesapNo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIban.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSube.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtAd.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtHesapTuru;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.TextEdit txtIban;
        private DevExpress.XtraEditors.TextEdit txtSube;
        private DevExpress.XtraEditors.TextEdit txtAd;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.DateEdit dateTarih;
    }
}