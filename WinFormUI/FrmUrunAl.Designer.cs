namespace UIWinForm
{
    partial class FrmUrunAl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunAl));
            label4 = new System.Windows.Forms.Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            lblOdenecekTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(168, 13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 20);
            label4.TabIndex = 16;
            label4.Text = "Ödenecek Tutar :";
            // 
            // gridControl1
            // 
            gridControl1.Location = new System.Drawing.Point(0, 47);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1318, 765);
            gridControl1.TabIndex = 9;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton4.Appearance.Options.UseFont = true;
            simpleButton4.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton4.ImageOptions.SvgImage");
            simpleButton4.Location = new System.Drawing.Point(748, 4);
            simpleButton4.Name = "simpleButton4";
            simpleButton4.Size = new System.Drawing.Size(135, 37);
            simpleButton4.TabIndex = 15;
            simpleButton4.Text = "Ödeme";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(59, 14);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 20);
            label2.TabIndex = 14;
            label2.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 13;
            label1.Text = "Tutar :";
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton3.Appearance.Options.UseFont = true;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(889, 4);
            simpleButton3.Name = "simpleButton3";
            simpleButton3.Size = new System.Drawing.Size(135, 37);
            simpleButton3.TabIndex = 12;
            simpleButton3.Text = "Listele";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButton2.Location = new System.Drawing.Point(1030, 4);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(135, 37);
            simpleButton2.TabIndex = 11;
            simpleButton2.Text = "Ekle";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(1171, 4);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(135, 37);
            simpleButton1.TabIndex = 10;
            simpleButton1.Text = "Yazdır";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // lblOdenecekTutar
            // 
            lblOdenecekTutar.AutoSize = true;
            lblOdenecekTutar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblOdenecekTutar.Location = new System.Drawing.Point(287, 14);
            lblOdenecekTutar.Name = "lblOdenecekTutar";
            lblOdenecekTutar.Size = new System.Drawing.Size(25, 20);
            lblOdenecekTutar.TabIndex = 17;
            lblOdenecekTutar.Text = "00";
            // 
            // FrmUrunAl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1318, 817);
            Controls.Add(label4);
            Controls.Add(gridControl1);
            Controls.Add(simpleButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(simpleButton3);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(lblOdenecekTutar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUrunAl";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "UrunAl";
            FormClosing += FrmUrunAl_FormClosing;
            Load += FrmUrunAl_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblOdenecekTutar;
    }
}