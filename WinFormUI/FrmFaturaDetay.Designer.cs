﻿namespace UIWinForm
{
    partial class FrmFaturaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaDetay));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblOdenecekTutar = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Location = new System.Drawing.Point(0, 73);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1506, 1020);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.DetailHeight = 467;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(1338, 16);
            simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(154, 49);
            simpleButton1.TabIndex = 1;
            simpleButton1.Text = "Yazdır";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new System.Drawing.Point(1177, 16);
            simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(154, 49);
            simpleButton2.TabIndex = 2;
            simpleButton2.Text = "Ekle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(1016, 16);
            simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(154, 49);
            simpleButton3.TabIndex = 3;
            simpleButton3.Text = "Listele";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(14, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 25);
            label1.TabIndex = 4;
            label1.Text = "Tutar :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(67, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(32, 25);
            label2.TabIndex = 5;
            label2.Text = "00";
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton4.Appearance.Options.UseFont = true;
            simpleButton4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton4.ImageOptions.SvgImage");
            simpleButton4.Location = new System.Drawing.Point(855, 16);
            simpleButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new System.Drawing.Size(154, 49);
            simpleButton4.TabIndex = 6;
            simpleButton4.Text = "Ödeme";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // lblOdenecekTutar
            // 
            lblOdenecekTutar.AutoSize = true;
            lblOdenecekTutar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOdenecekTutar.Location = new System.Drawing.Point(328, 29);
            lblOdenecekTutar.Name = "lblOdenecekTutar";
            lblOdenecekTutar.Size = new System.Drawing.Size(32, 25);
            lblOdenecekTutar.TabIndex = 8;
            lblOdenecekTutar.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(192, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(154, 25);
            label4.TabIndex = 7;
            label4.Text = "Ödenecek Tutar :";
            label4.Click += label4_Click;
            // 
            // FrmFaturaDetay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1506, 1055);
            Controls.Add(lblOdenecekTutar);
            Controls.Add(label4);
            Controls.Add(simpleButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(gridControl1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFaturaDetay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmFaturaDetay";
            FormClosing += FrmFaturaDetay_FormClosing;
            Load += FrmFaturaDetay_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblOdenecekTutar;
        private System.Windows.Forms.Label label4;
    }
}