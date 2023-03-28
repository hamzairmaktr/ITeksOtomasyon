namespace UIWinForm
{
    partial class FrmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasa));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKasaTur = new DevExpress.XtraEditors.SimpleButton();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtBakiye = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBakiye.Properties).BeginInit();
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1358, 746);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(280, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1075, 740);
            gridControl1.TabIndex = 500;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 32.48F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 67.52F) });
            tablePanel1.Controls.Add(lookUpEdit1);
            tablePanel1.Controls.Add(btnKaydet);
            tablePanel1.Controls.Add(btnGuncelle);
            tablePanel1.Controls.Add(btnSil);
            tablePanel1.Controls.Add(btnKasaTur);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtBakiye);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.04F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F) });
            tablePanel1.Size = new System.Drawing.Size(271, 740);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // lookUpEdit1
            // 
            tablePanel1.SetColumn(lookUpEdit1, 1);
            lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            lookUpEdit1.Location = new System.Drawing.Point(94, 133);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.AutoHeight = false;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            tablePanel1.SetRow(lookUpEdit1, 2);
            lookUpEdit1.Size = new System.Drawing.Size(164, 28);
            lookUpEdit1.TabIndex = 22;
            // 
            // btnKaydet
            // 
            btnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKaydet.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnKaydet, 1);
            btnKaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            btnKaydet.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKaydet.ImageOptions.Image");
            btnKaydet.Location = new System.Drawing.Point(94, 229);
            btnKaydet.Name = "btnKaydet";
            tablePanel1.SetRow(btnKaydet, 5);
            btnKaydet.Size = new System.Drawing.Size(164, 28);
            btnKaydet.TabIndex = 21;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGuncelle.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnGuncelle, 1);
            btnGuncelle.Dock = System.Windows.Forms.DockStyle.Fill;
            btnGuncelle.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnGuncelle.ImageOptions.Image");
            btnGuncelle.Location = new System.Drawing.Point(94, 261);
            btnGuncelle.Name = "btnGuncelle";
            tablePanel1.SetRow(btnGuncelle, 6);
            btnGuncelle.Size = new System.Drawing.Size(164, 28);
            btnGuncelle.TabIndex = 20;
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
            btnSil.Location = new System.Drawing.Point(94, 293);
            btnSil.Name = "btnSil";
            tablePanel1.SetRow(btnSil, 7);
            btnSil.Size = new System.Drawing.Size(164, 28);
            btnSil.TabIndex = 19;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnKasaTur
            // 
            btnKasaTur.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnKasaTur.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnKasaTur, 1);
            btnKasaTur.Dock = System.Windows.Forms.DockStyle.Fill;
            btnKasaTur.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnKasaTur.ImageOptions.Image");
            btnKasaTur.Location = new System.Drawing.Point(94, 325);
            btnKasaTur.Name = "btnKasaTur";
            tablePanel1.SetRow(btnKasaTur, 8);
            btnKasaTur.Size = new System.Drawing.Size(164, 28);
            btnKasaTur.TabIndex = 17;
            btnKasaTur.Text = "Kasa Tür";
            // 
            // label9
            // 
            label9.AutoSize = true;
            tablePanel1.SetColumn(label9, 1);
            label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(95, 63);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(162, 36);
            label9.TabIndex = 16;
            label9.Text = "Kasa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 163);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 3);
            label4.Size = new System.Drawing.Size(75, 32);
            label4.TabIndex = 11;
            label4.Text = "Bakiye :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 131);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 2);
            label3.Size = new System.Drawing.Size(75, 32);
            label3.TabIndex = 10;
            label3.Text = "Tur :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            tablePanel1.SetColumn(label1, 0);
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 99);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(75, 32);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBakiye
            // 
            tablePanel1.SetColumn(txtBakiye, 1);
            txtBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            txtBakiye.Location = new System.Drawing.Point(94, 165);
            txtBakiye.Name = "txtBakiye";
            txtBakiye.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBakiye.Properties.Appearance.Options.UseFont = true;
            txtBakiye.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtBakiye, 3);
            txtBakiye.Size = new System.Drawing.Size(164, 28);
            txtBakiye.TabIndex = 3;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(94, 101);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(164, 28);
            txtId.TabIndex = 0;
            // 
            // FrmKasa
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1358, 746);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmKasa";
            Text = "FrmKasa";
            Load += FrmKasa_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBakiye.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtVergiDaire;
        private DevExpress.XtraEditors.TextEdit txtIlce;
        private DevExpress.XtraEditors.TextEdit txtIl;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit txtStatu;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.SimpleButton btnKasaTur;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}