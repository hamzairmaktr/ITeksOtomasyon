namespace UIWinForm
{
    partial class FrmBorcOde
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
            txtCariId = new DevExpress.XtraEditors.TextEdit();
            label3 = new System.Windows.Forms.Label();
            txtKasaId = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            txtId = new DevExpress.XtraEditors.TextEdit();
            label1 = new System.Windows.Forms.Label();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupControl2 = new DevExpress.XtraEditors.GroupControl();
            btnTemizle = new System.Windows.Forms.Button();
            btnEkle = new System.Windows.Forms.Button();
            txtTutar = new DevExpress.XtraEditors.TextEdit();
            groupControl4 = new DevExpress.XtraEditors.GroupControl();
            gridControl3 = new DevExpress.XtraGrid.GridControl();
            gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            label4 = new System.Windows.Forms.Label();
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)txtCariId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKasaId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).BeginInit();
            groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl4).BeginInit();
            groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            SuspendLayout();
            // 
            // txtCariId
            // 
            txtCariId.Location = new System.Drawing.Point(101, 182);
            txtCariId.Name = "txtCariId";
            txtCariId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCariId.Properties.Appearance.Options.UseFont = true;
            txtCariId.Size = new System.Drawing.Size(326, 24);
            txtCariId.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(34, 185);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(61, 18);
            label3.TabIndex = 4;
            label3.Text = "Cari Id :";
            // 
            // txtKasaId
            // 
            txtKasaId.Location = new System.Drawing.Point(101, 152);
            txtKasaId.Name = "txtKasaId";
            txtKasaId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKasaId.Properties.Appearance.Options.UseFont = true;
            txtKasaId.Size = new System.Drawing.Size(326, 24);
            txtKasaId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(26, 155);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 18);
            label2.TabIndex = 2;
            label2.Text = "Kasa Id :";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(101, 122);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Size = new System.Drawing.Size(326, 24);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(63, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(32, 18);
            label1.TabIndex = 0;
            label1.Text = "Id :";
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(2, 23);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(754, 278);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // groupControl2
            // 
            groupControl2.Controls.Add(gridControl1);
            groupControl2.Location = new System.Drawing.Point(470, 3);
            groupControl2.Name = "groupControl2";
            groupControl2.Size = new System.Drawing.Size(758, 303);
            groupControl2.TabIndex = 9;
            groupControl2.Text = "Borç";
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnTemizle.Location = new System.Drawing.Point(301, 255);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(126, 48);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            btnEkle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEkle.Location = new System.Drawing.Point(101, 255);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new System.Drawing.Size(126, 48);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Borç Öde";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtTutar
            // 
            txtTutar.Location = new System.Drawing.Point(101, 212);
            txtTutar.Name = "txtTutar";
            txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutar.Properties.Appearance.Options.UseFont = true;
            txtTutar.Size = new System.Drawing.Size(326, 24);
            txtTutar.TabIndex = 7;
            // 
            // groupControl4
            // 
            groupControl4.Controls.Add(gridControl3);
            groupControl4.Location = new System.Drawing.Point(470, 312);
            groupControl4.Name = "groupControl4";
            groupControl4.Size = new System.Drawing.Size(758, 312);
            groupControl4.TabIndex = 10;
            groupControl4.Text = "Kasa";
            // 
            // gridControl3
            // 
            gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl3.Location = new System.Drawing.Point(2, 23);
            gridControl3.MainView = gridView3;
            gridControl3.Name = "gridControl3";
            gridControl3.Size = new System.Drawing.Size(754, 287);
            gridControl3.TabIndex = 0;
            gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView3 });
            // 
            // gridView3
            // 
            gridView3.GridControl = gridControl3;
            gridView3.Name = "gridView3";
            gridView3.FocusedRowChanged += gridView3_FocusedRowChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(41, 215);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 18);
            label4.TabIndex = 6;
            label4.Text = "Tutar :";
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(btnTemizle);
            groupControl1.Controls.Add(btnEkle);
            groupControl1.Controls.Add(txtTutar);
            groupControl1.Controls.Add(label4);
            groupControl1.Controls.Add(txtCariId);
            groupControl1.Controls.Add(label3);
            groupControl1.Controls.Add(txtKasaId);
            groupControl1.Controls.Add(label2);
            groupControl1.Controls.Add(txtId);
            groupControl1.Controls.Add(label1);
            groupControl1.Location = new System.Drawing.Point(1, 3);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new System.Drawing.Size(465, 621);
            groupControl1.TabIndex = 8;
            groupControl1.Text = "İşlem";
            // 
            // FrmBorcOde
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(1229, 627);
            Controls.Add(groupControl2);
            Controls.Add(groupControl4);
            Controls.Add(groupControl1);
            Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBorcOde";
            Text = "FrmBorcOde";
            Load += FrmBorcOde_Load;
            ((System.ComponentModel.ISupportInitialize)txtCariId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKasaId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl2).EndInit();
            groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl4).EndInit();
            groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl3).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCariId;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtKasaId;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}