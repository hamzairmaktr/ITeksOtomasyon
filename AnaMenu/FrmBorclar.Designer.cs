﻿namespace UIWinForm
{
    partial class FrmBorclar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBorclar));
            simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            btnCari = new DevExpress.XtraEditors.SimpleButton();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            cmbTur = new DevExpress.XtraEditors.ComboBoxEdit();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtTutar = new DevExpress.XtraEditors.TextEdit();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            SuspendLayout();
            // 
            // simpleButton6
            // 
            simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton6.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton6, 1);
            simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton6.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton6.ImageOptions.Image");
            simpleButton6.Location = new System.Drawing.Point(91, 442);
            simpleButton6.Name = "simpleButton6";
            tablePanel1.SetRow(simpleButton6, 10);
            simpleButton6.Size = new System.Drawing.Size(159, 33);
            simpleButton6.TabIndex = 29;
            simpleButton6.Text = "Temizle";
            // 
            // simpleButton5
            // 
            simpleButton5.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton5.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton5, 1);
            simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton5.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton5.ImageOptions.Image");
            simpleButton5.Location = new System.Drawing.Point(91, 405);
            simpleButton5.Name = "simpleButton5";
            tablePanel1.SetRow(simpleButton5, 9);
            simpleButton5.Size = new System.Drawing.Size(159, 33);
            simpleButton5.TabIndex = 28;
            simpleButton5.Text = "Borç Eksilti";
            simpleButton5.Click += simpleButton5_Click;
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton4.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton4, 1);
            simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton4.ImageOptions.Image");
            simpleButton4.Location = new System.Drawing.Point(91, 368);
            simpleButton4.Name = "simpleButton4";
            tablePanel1.SetRow(simpleButton4, 8);
            simpleButton4.Size = new System.Drawing.Size(159, 33);
            simpleButton4.TabIndex = 27;
            simpleButton4.Text = "Ekstra Borç";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton3.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton3, 1);
            simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(91, 331);
            simpleButton3.Name = "simpleButton3";
            tablePanel1.SetRow(simpleButton3, 7);
            simpleButton3.Size = new System.Drawing.Size(159, 33);
            simpleButton3.TabIndex = 26;
            simpleButton3.Text = "Sil";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton1, 1);
            simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(91, 294);
            simpleButton1.Name = "simpleButton1";
            tablePanel1.SetRow(simpleButton1, 6);
            simpleButton1.Size = new System.Drawing.Size(159, 33);
            simpleButton1.TabIndex = 25;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // btnCari
            // 
            btnCari.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCari.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(btnCari, 1);
            btnCari.Dock = System.Windows.Forms.DockStyle.Fill;
            btnCari.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("btnCari.ImageOptions.Image");
            btnCari.Location = new System.Drawing.Point(91, 153);
            btnCari.Name = "btnCari";
            tablePanel1.SetRow(btnCari, 2);
            btnCari.Size = new System.Drawing.Size(159, 33);
            btnCari.TabIndex = 30;
            btnCari.Text = "Cari Seç";
            btnCari.Click += btnCari_Click;
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
            tableLayoutPanel1.Size = new System.Drawing.Size(1319, 787);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(272, 3);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1044, 781);
            gridControl1.TabIndex = 0;
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
            tablePanel1.Controls.Add(simpleButton6);
            tablePanel1.Controls.Add(simpleButton5);
            tablePanel1.Controls.Add(simpleButton4);
            tablePanel1.Controls.Add(simpleButton3);
            tablePanel1.Controls.Add(simpleButton1);
            tablePanel1.Controls.Add(cmbTur);
            tablePanel1.Controls.Add(btnCari);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtTutar);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 3);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 14.04F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 4F) });
            tablePanel1.Size = new System.Drawing.Size(263, 781);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // cmbTur
            // 
            tablePanel1.SetColumn(cmbTur, 1);
            cmbTur.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbTur.EditValue = "Borç Türü";
            cmbTur.Location = new System.Drawing.Point(91, 190);
            cmbTur.Name = "cmbTur";
            cmbTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbTur.Properties.Appearance.Options.UseFont = true;
            cmbTur.Properties.AutoHeight = false;
            cmbTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTur.Properties.Items.AddRange(new object[] { "Alacak", "Verecek" });
            cmbTur.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel1.SetRow(cmbTur, 3);
            cmbTur.Size = new System.Drawing.Size(159, 33);
            cmbTur.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            tablePanel1.SetColumn(label9, 1);
            label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(92, 78);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(157, 36);
            label9.TabIndex = 16;
            label9.Text = "Borçlar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(14, 225);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 4);
            label4.Size = new System.Drawing.Size(72, 37);
            label4.TabIndex = 11;
            label4.Text = "Tutar :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(14, 188);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 3);
            label3.Size = new System.Drawing.Size(72, 37);
            label3.TabIndex = 10;
            label3.Text = "Tur :";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            tablePanel1.SetColumn(label2, 0);
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(14, 151);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 2);
            label2.Size = new System.Drawing.Size(72, 37);
            label2.TabIndex = 9;
            label2.Text = "Cari :";
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
            label1.Size = new System.Drawing.Size(72, 37);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTutar
            // 
            tablePanel1.SetColumn(txtTutar, 1);
            txtTutar.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTutar.Location = new System.Drawing.Point(91, 227);
            txtTutar.Name = "txtTutar";
            txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutar.Properties.Appearance.Options.UseFont = true;
            txtTutar.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtTutar, 4);
            txtTutar.Size = new System.Drawing.Size(159, 33);
            txtTutar.TabIndex = 3;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(91, 116);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(159, 33);
            txtId.TabIndex = 0;
            // 
            // FrmBorclar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1319, 787);
            Controls.Add(tableLayoutPanel1);
            Name = "FrmBorclar";
            Text = "FrmBorclar";
            Load += FrmBorclar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTur;
        private DevExpress.XtraEditors.SimpleButton btnCari;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}