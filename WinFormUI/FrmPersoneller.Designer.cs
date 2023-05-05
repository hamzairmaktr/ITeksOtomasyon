namespace UIWinForm
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            cmbGorev = new DevExpress.XtraEditors.ComboBoxEdit();
            label3 = new System.Windows.Forms.Label();
            txtMaas = new DevExpress.XtraEditors.TextEdit();
            txtTel1 = new System.Windows.Forms.MaskedTextBox();
            txtAdres = new System.Windows.Forms.RichTextBox();
            txtName = new DevExpress.XtraEditors.TextEdit();
            label14 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtIlce = new DevExpress.XtraEditors.TextEdit();
            txtIl = new DevExpress.XtraEditors.TextEdit();
            txtMail = new DevExpress.XtraEditors.TextEdit();
            simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label9 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbGorev.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMaas.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIlce.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).BeginInit();
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1607, 769);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(331, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1273, 763);
            gridControl1.TabIndex = 500;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.52F) });
            tablePanel1.Controls.Add(simpleButton1);
            tablePanel1.Controls.Add(cmbGorev);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(txtMaas);
            tablePanel1.Controls.Add(txtTel1);
            tablePanel1.Controls.Add(txtAdres);
            tablePanel1.Controls.Add(txtName);
            tablePanel1.Controls.Add(label14);
            tablePanel1.Controls.Add(label12);
            tablePanel1.Controls.Add(label11);
            tablePanel1.Controls.Add(label8);
            tablePanel1.Controls.Add(label6);
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(txtIlce);
            tablePanel1.Controls.Add(txtIl);
            tablePanel1.Controls.Add(txtMail);
            tablePanel1.Controls.Add(simpleButton6);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(simpleButton3);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.04F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F) });
            tablePanel1.Size = new System.Drawing.Size(322, 763);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // simpleButton1
            // 
            tablePanel1.SetColumn(simpleButton1, 1);
            simpleButton1.Location = new System.Drawing.Point(110, 602);
            simpleButton1.Name = "simpleButton1";
            tablePanel1.SetRow(simpleButton1, 16);
            simpleButton1.Size = new System.Drawing.Size(199, 23);
            simpleButton1.TabIndex = 53;
            simpleButton1.Text = "simpleButton1";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // cmbGorev
            // 
            tablePanel1.SetColumn(cmbGorev, 1);
            cmbGorev.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbGorev.Location = new System.Drawing.Point(110, 335);
            cmbGorev.Name = "cmbGorev";
            cmbGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbGorev.Properties.Appearance.Options.UseFont = true;
            cmbGorev.Properties.AutoHeight = false;
            cmbGorev.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbGorev.Properties.Items.AddRange(new object[] { "Sahibi", "Personel", "Müdür", "Temizlikçi", "Muhasebeci" });
            cmbGorev.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel1.SetRow(cmbGorev, 8);
            cmbGorev.Size = new System.Drawing.Size(199, 29);
            cmbGorev.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 333);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 8);
            label3.Size = new System.Drawing.Size(91, 33);
            label3.TabIndex = 51;
            label3.Text = "Görev :";
            label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMaas
            // 
            tablePanel1.SetColumn(txtMaas, 1);
            txtMaas.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMaas.EditValue = "0";
            txtMaas.Location = new System.Drawing.Point(110, 170);
            txtMaas.Name = "txtMaas";
            txtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMaas.Properties.Appearance.Options.UseFont = true;
            txtMaas.Properties.AutoHeight = false;
            txtMaas.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            txtMaas.Properties.MaskSettings.Set("mask", "c");
            tablePanel1.SetRow(txtMaas, 3);
            txtMaas.Size = new System.Drawing.Size(199, 29);
            txtMaas.TabIndex = 50;
            txtMaas.EditValueChanged += txtMaas_EditValueChanged;
            // 
            // txtTel1
            // 
            tablePanel1.SetColumn(txtTel1, 1);
            txtTel1.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTel1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTel1.Location = new System.Drawing.Point(110, 203);
            txtTel1.Mask = "(999) 000-0000";
            txtTel1.Name = "txtTel1";
            tablePanel1.SetRow(txtTel1, 4);
            txtTel1.Size = new System.Drawing.Size(199, 25);
            txtTel1.TabIndex = 49;
            // 
            // txtAdres
            // 
            tablePanel1.SetColumn(txtAdres, 1);
            txtAdres.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAdres.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAdres.Location = new System.Drawing.Point(110, 368);
            txtAdres.Name = "txtAdres";
            tablePanel1.SetRow(txtAdres, 9);
            tablePanel1.SetRowSpan(txtAdres, 2);
            txtAdres.Size = new System.Drawing.Size(199, 62);
            txtAdres.TabIndex = 48;
            txtAdres.Text = "";
            // 
            // txtName
            // 
            tablePanel1.SetColumn(txtName, 1);
            txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtName.Location = new System.Drawing.Point(110, 137);
            txtName.Name = "txtName";
            txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Properties.Appearance.Options.UseFont = true;
            txtName.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtName, 2);
            txtName.Size = new System.Drawing.Size(199, 29);
            txtName.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            tablePanel1.SetColumn(label14, 0);
            label14.Dock = System.Windows.Forms.DockStyle.Fill;
            label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(14, 366);
            label14.Name = "label14";
            tablePanel1.SetRow(label14, 9);
            label14.Size = new System.Drawing.Size(91, 33);
            label14.TabIndex = 47;
            label14.Text = "Adres :";
            label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            tablePanel1.SetColumn(label12, 0);
            label12.Dock = System.Windows.Forms.DockStyle.Fill;
            label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(14, 300);
            label12.Name = "label12";
            tablePanel1.SetRow(label12, 7);
            label12.Size = new System.Drawing.Size(91, 33);
            label12.TabIndex = 45;
            label12.Text = "İlçe :";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            tablePanel1.SetColumn(label11, 0);
            label11.Dock = System.Windows.Forms.DockStyle.Fill;
            label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(14, 267);
            label11.Name = "label11";
            tablePanel1.SetRow(label11, 6);
            label11.Size = new System.Drawing.Size(91, 33);
            label11.TabIndex = 44;
            label11.Text = "İl :";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(14, 234);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 5);
            label8.Size = new System.Drawing.Size(91, 33);
            label8.TabIndex = 42;
            label8.Text = "Mail :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel1.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 201);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 4);
            label6.Size = new System.Drawing.Size(91, 33);
            label6.TabIndex = 40;
            label6.Text = "Telefon :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 168);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 3);
            label5.Size = new System.Drawing.Size(91, 33);
            label5.TabIndex = 39;
            label5.Text = "Maaş :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtIlce
            // 
            tablePanel1.SetColumn(txtIlce, 1);
            txtIlce.Dock = System.Windows.Forms.DockStyle.Fill;
            txtIlce.Location = new System.Drawing.Point(110, 302);
            txtIlce.Name = "txtIlce";
            txtIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIlce.Properties.Appearance.Options.UseFont = true;
            txtIlce.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtIlce, 7);
            txtIlce.Size = new System.Drawing.Size(199, 29);
            txtIlce.TabIndex = 10;
            // 
            // txtIl
            // 
            tablePanel1.SetColumn(txtIl, 1);
            txtIl.Dock = System.Windows.Forms.DockStyle.Fill;
            txtIl.Location = new System.Drawing.Point(110, 269);
            txtIl.Name = "txtIl";
            txtIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIl.Properties.Appearance.Options.UseFont = true;
            txtIl.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtIl, 6);
            txtIl.Size = new System.Drawing.Size(199, 29);
            txtIl.TabIndex = 9;
            // 
            // txtMail
            // 
            tablePanel1.SetColumn(txtMail, 1);
            txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMail.Location = new System.Drawing.Point(110, 236);
            txtMail.Name = "txtMail";
            txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMail.Properties.Appearance.Options.UseFont = true;
            txtMail.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtMail, 5);
            txtMail.Size = new System.Drawing.Size(199, 29);
            txtMail.TabIndex = 7;
            // 
            // simpleButton6
            // 
            simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton6.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton6, 1);
            simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton6.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton6.ImageOptions.Image");
            simpleButton6.Location = new System.Drawing.Point(110, 566);
            simpleButton6.Name = "simpleButton6";
            tablePanel1.SetRow(simpleButton6, 15);
            simpleButton6.Size = new System.Drawing.Size(199, 29);
            simpleButton6.TabIndex = 16;
            simpleButton6.Text = "Temizle";
            simpleButton6.Click += simpleButton6_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuncelle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnGuncelle, 1);
            btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGuncelle.ImageOptions.Image");
            btnGuncelle.Location = new System.Drawing.Point(110, 500);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 13);
            btnGuncelle.Size = new System.Drawing.Size(199, 29);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton3.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton3, 1);
            simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(110, 533);
            simpleButton3.Name = "simpleButton3";
            tablePanel1.SetRow(simpleButton3, 14);
            simpleButton3.Size = new System.Drawing.Size(199, 29);
            simpleButton3.TabIndex = 15;
            simpleButton3.Text = "Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnKaydet, 1);
            btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(110, 467);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 12);
            btnKaydet.Size = new System.Drawing.Size(199, 29);
            btnKaydet.TabIndex = 13;
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
            label9.Location = new System.Drawing.Point(111, 66);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(197, 36);
            label9.TabIndex = 16;
            label9.Text = "Personeller";
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 135);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 2);
            label2.Size = new System.Drawing.Size(91, 33);
            label2.TabIndex = 9;
            label2.Text = "İsim :";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tablePanel1.SetColumn(label1, 0);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 102);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(91, 33);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(110, 104);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(199, 29);
            txtId.TabIndex = 0;
            // 
            // FrmPersoneller
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1607, 769);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmPersoneller";
            Text = "FrmPersoneller";
            Load += FrmPersoneller_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbGorev.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMaas.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIlce.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtMaas;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.ComboBoxEdit cmbGorev;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}