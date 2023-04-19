namespace UIWinForm
{
    partial class FrmGider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGider));
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            txtId = new DevExpress.XtraEditors.TextEdit();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            label5 = new System.Windows.Forms.Label();
            txtTutar = new DevExpress.XtraEditors.TextEdit();
            dateTarih = new DevExpress.XtraEditors.DateEdit();
            label4 = new System.Windows.Forms.Label();
            txtNot = new DevExpress.XtraEditors.TextEdit();
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            dateFiltre = new DevExpress.XtraEditors.DateEdit();
            cmbFiltreTuru = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbTarihAraligi = new DevExpress.XtraEditors.ComboBoxEdit();
            lblTutar = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            label18 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl2).BeginInit();
            xtraTabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtNot.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablePanel2).BeginInit();
            tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateFiltre.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateFiltre.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltreTuru.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTarihAraligi.Properties).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gridView3
            // 
            gridView3.GridControl = gridControl1;
            gridView3.Name = "gridView3";
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(0, 0);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1523, 709);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1, gridView3 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // xtraTabPage3
            // 
            xtraTabPage3.Controls.Add(gridControl1);
            xtraTabPage3.Name = "xtraTabPage3";
            xtraTabPage3.Size = new System.Drawing.Size(1523, 709);
            xtraTabPage3.Text = "Gider";
            // 
            // xtraTabControl2
            // 
            xtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl2.Location = new System.Drawing.Point(396, 3);
            xtraTabControl2.Name = "xtraTabControl2";
            xtraTabControl2.SelectedTabPage = xtraTabPage3;
            xtraTabControl2.Size = new System.Drawing.Size(1525, 734);
            xtraTabControl2.TabIndex = 502;
            xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage3 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 160);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 5);
            label3.Size = new System.Drawing.Size(96, 30);
            label3.TabIndex = 22;
            label3.Text = "Not :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 100);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 3);
            label2.Size = new System.Drawing.Size(96, 30);
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
            btnTemizle.Location = new System.Drawing.Point(115, 342);
            btnTemizle.Name = "btnTemizle";
            tablePanel1.SetRow(btnTemizle, 11);
            btnTemizle.Size = new System.Drawing.Size(257, 26);
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
            btnSil.Location = new System.Drawing.Point(115, 312);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 10);
            btnSil.Size = new System.Drawing.Size(257, 26);
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
            btnGuncelle.Location = new System.Drawing.Point(115, 282);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 9);
            btnGuncelle.Size = new System.Drawing.Size(257, 26);
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
            btnKaydet.Location = new System.Drawing.Point(115, 252);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 8);
            btnKaydet.Size = new System.Drawing.Size(257, 26);
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
            label1.Location = new System.Drawing.Point(14, 40);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(357, 30);
            label1.TabIndex = 16;
            label1.Text = "Fatura Bilgi";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(115, 102);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 3);
            txtId.Size = new System.Drawing.Size(257, 26);
            txtId.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Controls.Add(tablePanel1);
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(385, 709);
            xtraTabPage2.Text = "İşlemler";
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.22F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 71.78F) });
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(txtTutar);
            tablePanel1.Controls.Add(dateTarih);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(btnTemizle);
            tablePanel1.Controls.Add(btnSil);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtNot);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(0, 0);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel1.Size = new System.Drawing.Size(385, 709);
            tablePanel1.TabIndex = 2;
            tablePanel1.UseSkinIndents = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(14, 190);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 6);
            label5.Size = new System.Drawing.Size(96, 30);
            label5.TabIndex = 26;
            label5.Text = "Tutar :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTutar
            // 
            tablePanel1.SetColumn(txtTutar, 1);
            txtTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTutar.Location = new System.Drawing.Point(115, 192);
            txtTutar.Name = "txtTutar";
            txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutar.Properties.Appearance.Options.UseFont = true;
            txtTutar.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTutar, 6);
            txtTutar.Size = new System.Drawing.Size(257, 26);
            txtTutar.TabIndex = 25;
            // 
            // dateTarih
            // 
            tablePanel1.SetColumn(dateTarih, 1);
            dateTarih.Dock = System.Windows.Forms.DockStyle.Fill;
            dateTarih.EditValue = null;
            dateTarih.Location = new System.Drawing.Point(115, 132);
            dateTarih.Name = "dateTarih";
            dateTarih.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTarih.Properties.Appearance.Options.UseFont = true;
            dateTarih.Properties.AutoHeight = false;
            dateTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(dateTarih, 4);
            dateTarih.Size = new System.Drawing.Size(257, 26);
            dateTarih.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 130);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 4);
            label4.Size = new System.Drawing.Size(96, 30);
            label4.TabIndex = 23;
            label4.Text = "Tarih :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNot
            // 
            tablePanel1.SetColumn(txtNot, 1);
            txtNot.Dock = System.Windows.Forms.DockStyle.Fill;
            txtNot.Location = new System.Drawing.Point(115, 162);
            txtNot.Name = "txtNot";
            txtNot.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNot.Properties.Appearance.Options.UseFont = true;
            txtNot.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtNot, 5);
            txtNot.Size = new System.Drawing.Size(257, 26);
            txtNot.TabIndex = 3;
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(3, 3);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage2;
            xtraTabControl1.Size = new System.Drawing.Size(387, 734);
            xtraTabControl1.TabIndex = 501;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage2, xtraTabPage1 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(tablePanel2);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(385, 709);
            xtraTabPage1.Text = "Filtrele";
            // 
            // tablePanel2
            // 
            tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.02F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 68.98F) });
            tablePanel2.Controls.Add(dateFiltre);
            tablePanel2.Controls.Add(cmbFiltreTuru);
            tablePanel2.Controls.Add(cmbTarihAraligi);
            tablePanel2.Controls.Add(lblTutar);
            tablePanel2.Controls.Add(label6);
            tablePanel2.Controls.Add(label15);
            tablePanel2.Controls.Add(label16);
            tablePanel2.Controls.Add(label17);
            tablePanel2.Controls.Add(btnFiltrele);
            tablePanel2.Controls.Add(label18);
            tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel2.Location = new System.Drawing.Point(0, 0);
            tablePanel2.Name = "tablePanel2";
            tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F) });
            tablePanel2.Size = new System.Drawing.Size(385, 709);
            tablePanel2.TabIndex = 3;
            tablePanel2.UseSkinIndents = true;
            // 
            // dateFiltre
            // 
            tablePanel2.SetColumn(dateFiltre, 1);
            dateFiltre.Dock = System.Windows.Forms.DockStyle.Fill;
            dateFiltre.EditValue = null;
            dateFiltre.Location = new System.Drawing.Point(126, 132);
            dateFiltre.Name = "dateFiltre";
            dateFiltre.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateFiltre.Properties.Appearance.Options.UseFont = true;
            dateFiltre.Properties.AutoHeight = false;
            dateFiltre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateFiltre.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel2.SetRow(dateFiltre, 4);
            dateFiltre.Size = new System.Drawing.Size(246, 26);
            dateFiltre.TabIndex = 28;
            // 
            // cmbFiltreTuru
            // 
            tablePanel2.SetColumn(cmbFiltreTuru, 1);
            cmbFiltreTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbFiltreTuru.Location = new System.Drawing.Point(126, 162);
            cmbFiltreTuru.Name = "cmbFiltreTuru";
            cmbFiltreTuru.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbFiltreTuru.Properties.Appearance.Options.UseFont = true;
            cmbFiltreTuru.Properties.AutoHeight = false;
            cmbFiltreTuru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbFiltreTuru.Properties.Items.AddRange(new object[] { "Hiçbiri", "Belirli Bir Tarih", "Tarih Aralığı" });
            cmbFiltreTuru.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel2.SetRow(cmbFiltreTuru, 5);
            cmbFiltreTuru.Size = new System.Drawing.Size(246, 26);
            cmbFiltreTuru.TabIndex = 27;
            // 
            // cmbTarihAraligi
            // 
            tablePanel2.SetColumn(cmbTarihAraligi, 1);
            cmbTarihAraligi.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbTarihAraligi.Location = new System.Drawing.Point(126, 102);
            cmbTarihAraligi.Name = "cmbTarihAraligi";
            cmbTarihAraligi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbTarihAraligi.Properties.Appearance.Options.UseFont = true;
            cmbTarihAraligi.Properties.AutoHeight = false;
            cmbTarihAraligi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTarihAraligi.Properties.Items.AddRange(new object[] { "Hiçbiri", "7 Gün", "30 Gün", "365 Gün" });
            cmbTarihAraligi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel2.SetRow(cmbTarihAraligi, 3);
            cmbTarihAraligi.Size = new System.Drawing.Size(246, 26);
            cmbTarihAraligi.TabIndex = 26;
            // 
            // lblTutar
            // 
            lblTutar.AutoSize = true;
            tablePanel2.SetColumn(lblTutar, 1);
            lblTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            lblTutar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTutar.Location = new System.Drawing.Point(127, 190);
            lblTutar.Name = "lblTutar";
            tablePanel2.SetRow(lblTutar, 6);
            lblTutar.Size = new System.Drawing.Size(244, 30);
            lblTutar.TabIndex = 25;
            lblTutar.Text = "00";
            lblTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel2.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(14, 190);
            label6.Name = "label6";
            tablePanel2.SetRow(label6, 6);
            label6.Size = new System.Drawing.Size(107, 30);
            label6.TabIndex = 24;
            label6.Text = "Toplam Gider :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            tablePanel2.SetColumn(label15, 0);
            label15.Dock = System.Windows.Forms.DockStyle.Fill;
            label15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(14, 160);
            label15.Name = "label15";
            tablePanel2.SetRow(label15, 5);
            label15.Size = new System.Drawing.Size(107, 30);
            label15.TabIndex = 23;
            label15.Text = "Filtre Türü :";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            label16.AutoSize = true;
            tablePanel2.SetColumn(label16, 0);
            label16.Dock = System.Windows.Forms.DockStyle.Fill;
            label16.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label16.Location = new System.Drawing.Point(14, 130);
            label16.Name = "label16";
            tablePanel2.SetRow(label16, 4);
            label16.Size = new System.Drawing.Size(107, 30);
            label16.TabIndex = 22;
            label16.Text = "Tarih :";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            label17.AutoSize = true;
            tablePanel2.SetColumn(label17, 0);
            label17.Dock = System.Windows.Forms.DockStyle.Fill;
            label17.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label17.Location = new System.Drawing.Point(14, 100);
            label17.Name = "label17";
            tablePanel2.SetRow(label17, 3);
            label17.Size = new System.Drawing.Size(107, 30);
            label17.TabIndex = 21;
            label17.Text = "Tarih Aralığı :";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFiltrele
            // 
            btnFiltrele.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFiltrele.Appearance.Options.UseFont = true;
            tablePanel2.SetColumn(btnFiltrele, 1);
            btnFiltrele.Dock = System.Windows.Forms.DockStyle.Fill;
            btnFiltrele.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnFiltrele.ImageOptions.Image");
            btnFiltrele.Location = new System.Drawing.Point(126, 252);
            btnFiltrele.Name = "btnFiltrele";
            tablePanel2.SetRow(btnFiltrele, 8);
            btnFiltrele.Size = new System.Drawing.Size(246, 26);
            btnFiltrele.TabIndex = 17;
            btnFiltrele.Text = "Filtrele";
            // 
            // label18
            // 
            tablePanel2.SetColumn(label18, 0);
            tablePanel2.SetColumnSpan(label18, 2);
            label18.Dock = System.Windows.Forms.DockStyle.Fill;
            label18.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label18.ForeColor = System.Drawing.SystemColors.Highlight;
            label18.Location = new System.Drawing.Point(14, 40);
            label18.Name = "label18";
            tablePanel2.SetRow(label18, 1);
            label18.Size = new System.Drawing.Size(357, 30);
            label18.TabIndex = 16;
            label18.Text = "Fatura Bilgi";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1924, 740);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // FrmGider
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 740);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmGider";
            Text = "FrmGider";
            Load += FrmGider_Load;
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabControl2).EndInit();
            xtraTabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateTarih.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtNot.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablePanel2).EndInit();
            tablePanel2.ResumeLayout(false);
            tablePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateFiltre.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateFiltre.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltreTuru.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTarihAraligi.Properties).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNot;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.DateEdit dateTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dateFiltre;
        private DevExpress.XtraEditors.ComboBoxEdit cmbFiltreTuru;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTarihAraligi;
    }
}