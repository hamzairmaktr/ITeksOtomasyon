namespace UIWinForm
{
    partial class FrmSatis2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSatis2));
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            label11 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            txtNakit = new DevExpress.XtraEditors.TextEdit();
            txtOdenen = new DevExpress.XtraEditors.TextEdit();
            label5 = new System.Windows.Forms.Label();
            txtBorc = new DevExpress.XtraEditors.TextEdit();
            label2 = new System.Windows.Forms.Label();
            txtKalan = new DevExpress.XtraEditors.TextEdit();
            label4 = new System.Windows.Forms.Label();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            label1 = new System.Windows.Forms.Label();
            txtCari = new DevExpress.XtraEditors.TextEdit();
            lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            txtCariId = new DevExpress.XtraEditors.TextEdit();
            txtTutar = new DevExpress.XtraEditors.TextEdit();
            txtKasaTutar = new DevExpress.XtraEditors.TextEdit();
            dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            label12 = new System.Windows.Forms.Label();
            lblBorc = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            lblBorcTur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)txtNakit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtOdenen.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtBorc.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKalan.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCari.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCariId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtKasaTutar.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton1.ImageOptions.SvgImage");
            simpleButton1.Location = new System.Drawing.Point(408, 222);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(153, 46);
            simpleButton1.TabIndex = 42;
            simpleButton1.Text = "Borç Ver";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(427, 405);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(106, 18);
            label11.TabIndex = 41;
            label11.Text = "Nakit Ödenen :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(479, 118);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(54, 18);
            label7.TabIndex = 37;
            label7.Text = "Tutar :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(423, 357);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(110, 18);
            label10.TabIndex = 40;
            label10.Text = "Ödenen Tutar :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(8, 405);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(111, 18);
            label9.TabIndex = 39;
            label9.Text = "Borca Ödenen :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(435, 87);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(98, 18);
            label6.TabIndex = 36;
            label6.Text = "Teslim Tarih :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(25, 357);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 18);
            label8.TabIndex = 38;
            label8.Text = "Kalan Tutar :";
            // 
            // txtNakit
            // 
            txtNakit.Location = new System.Drawing.Point(539, 402);
            txtNakit.Name = "txtNakit";
            txtNakit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNakit.Properties.Appearance.Options.UseFont = true;
            txtNakit.Size = new System.Drawing.Size(232, 24);
            txtNakit.TabIndex = 28;
            // 
            // txtOdenen
            // 
            txtOdenen.Location = new System.Drawing.Point(539, 354);
            txtOdenen.Name = "txtOdenen";
            txtOdenen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtOdenen.Properties.Appearance.Options.UseFont = true;
            txtOdenen.Size = new System.Drawing.Size(232, 24);
            txtOdenen.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(491, 58);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(42, 18);
            label5.TabIndex = 35;
            label5.Text = "Cari :";
            // 
            // txtBorc
            // 
            txtBorc.Location = new System.Drawing.Point(125, 402);
            txtBorc.Name = "txtBorc";
            txtBorc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtBorc.Properties.Appearance.Options.UseFont = true;
            txtBorc.Size = new System.Drawing.Size(232, 24);
            txtBorc.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(65, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 18);
            label2.TabIndex = 27;
            label2.Text = "Tutar :";
            // 
            // txtKalan
            // 
            txtKalan.Location = new System.Drawing.Point(125, 354);
            txtKalan.Name = "txtKalan";
            txtKalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKalan.Properties.Appearance.Options.UseFont = true;
            txtKalan.Size = new System.Drawing.Size(232, 24);
            txtKalan.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(472, 28);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 18);
            label4.TabIndex = 30;
            label4.Text = "Cari Id :";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("simpleButton2.ImageOptions.SvgImage");
            simpleButton2.Location = new System.Drawing.Point(239, 222);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(153, 46);
            simpleButton2.TabIndex = 31;
            simpleButton2.Text = "Nakit Sat";
            simpleButton2.Click += simpleButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(69, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 18);
            label1.TabIndex = 23;
            label1.Text = "Kasa :";
            // 
            // txtCari
            // 
            txtCari.Enabled = false;
            txtCari.Location = new System.Drawing.Point(539, 55);
            txtCari.Name = "txtCari";
            txtCari.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCari.Properties.Appearance.Options.UseFont = true;
            txtCari.Size = new System.Drawing.Size(232, 24);
            txtCari.TabIndex = 25;
            // 
            // lookUpEdit1
            // 
            lookUpEdit1.Location = new System.Drawing.Point(125, 25);
            lookUpEdit1.Name = "lookUpEdit1";
            lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEdit1.Size = new System.Drawing.Size(232, 24);
            lookUpEdit1.TabIndex = 19;
            // 
            // txtCariId
            // 
            txtCariId.Enabled = false;
            txtCariId.Location = new System.Drawing.Point(539, 25);
            txtCariId.Name = "txtCariId";
            txtCariId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtCariId.Properties.Appearance.Options.UseFont = true;
            txtCariId.Size = new System.Drawing.Size(232, 24);
            txtCariId.TabIndex = 43;
            // 
            // txtTutar
            // 
            txtTutar.Location = new System.Drawing.Point(539, 114);
            txtTutar.Name = "txtTutar";
            txtTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTutar.Properties.Appearance.Options.UseFont = true;
            txtTutar.Size = new System.Drawing.Size(232, 24);
            txtTutar.TabIndex = 44;
            // 
            // txtKasaTutar
            // 
            txtKasaTutar.Location = new System.Drawing.Point(125, 55);
            txtKasaTutar.Name = "txtKasaTutar";
            txtKasaTutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKasaTutar.Properties.Appearance.Options.UseFont = true;
            txtKasaTutar.Size = new System.Drawing.Size(232, 24);
            txtKasaTutar.TabIndex = 45;
            // 
            // dateEdit2
            // 
            dateEdit2.EditValue = null;
            dateEdit2.Location = new System.Drawing.Point(539, 84);
            dateEdit2.Name = "dateEdit2";
            dateEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateEdit2.Properties.Appearance.Options.UseFont = true;
            dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit2.Size = new System.Drawing.Size(232, 24);
            dateEdit2.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(432, 149);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(101, 20);
            label12.TabIndex = 47;
            label12.Text = "Kişinin Borcu :";
            // 
            // lblBorc
            // 
            lblBorc.AutoSize = true;
            lblBorc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBorc.Location = new System.Drawing.Point(539, 149);
            lblBorc.Name = "lblBorc";
            lblBorc.Size = new System.Drawing.Size(74, 20);
            lblBorc.TabIndex = 48;
            lblBorc.Text = "Borcu Yok";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(432, 178);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(101, 20);
            label13.TabIndex = 49;
            label13.Text = "Kişinin Borcu :";
            // 
            // lblBorcTur
            // 
            lblBorcTur.AutoSize = true;
            lblBorcTur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBorcTur.Location = new System.Drawing.Point(539, 178);
            lblBorcTur.Name = "lblBorcTur";
            lblBorcTur.Size = new System.Drawing.Size(53, 20);
            lblBorcTur.TabIndex = 50;
            lblBorcTur.Text = "Alacak";
            // 
            // FrmSatis2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblBorcTur);
            Controls.Add(label13);
            Controls.Add(lblBorc);
            Controls.Add(label12);
            Controls.Add(dateEdit2);
            Controls.Add(txtKasaTutar);
            Controls.Add(txtTutar);
            Controls.Add(txtCariId);
            Controls.Add(simpleButton1);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(txtNakit);
            Controls.Add(txtOdenen);
            Controls.Add(label5);
            Controls.Add(txtBorc);
            Controls.Add(label2);
            Controls.Add(txtKalan);
            Controls.Add(label4);
            Controls.Add(simpleButton2);
            Controls.Add(label1);
            Controls.Add(txtCari);
            Controls.Add(lookUpEdit1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSatis2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmSatis2";
            Load += FrmSatis2_Load;
            ((System.ComponentModel.ISupportInitialize)txtNakit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtOdenen.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtBorc.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKalan.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCari.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)lookUpEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCariId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtKasaTutar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit2.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtNakit;
        private DevExpress.XtraEditors.TextEdit txtOdenen;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtBorc;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtKalan;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit txtCari;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit txtCariId;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.TextEdit txtKasaTutar;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBorc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBorcTur;
    }
}