namespace UIWinForm
{
    partial class FrmCariler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariler));
            cmbTur = new DevExpress.XtraEditors.ComboBoxEdit();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtId = new DevExpress.XtraEditors.TextEdit();
            tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            txtTel2 = new System.Windows.Forms.MaskedTextBox();
            txtTel1 = new System.Windows.Forms.MaskedTextBox();
            txtAdres = new System.Windows.Forms.RichTextBox();
            txtName = new DevExpress.XtraEditors.TextEdit();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtVergiDaire = new DevExpress.XtraEditors.TextEdit();
            txtIlce = new DevExpress.XtraEditors.TextEdit();
            txtIl = new DevExpress.XtraEditors.TextEdit();
            txtFax = new DevExpress.XtraEditors.TextEdit();
            txtMail = new DevExpress.XtraEditors.TextEdit();
            txtStatu = new DevExpress.XtraEditors.TextEdit();
            simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            txtYetkili = new DevExpress.XtraEditors.TextEdit();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)cmbTur.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).BeginInit();
            tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiDaire.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIlce.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtIl.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFax.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStatu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtYetkili.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTur
            // 
            tablePanel1.SetColumn(cmbTur, 1);
            cmbTur.Dock = System.Windows.Forms.DockStyle.Fill;
            cmbTur.EditValue = "Cari Türü";
            cmbTur.Location = new System.Drawing.Point(138, 162);
            cmbTur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbTur.Name = "cmbTur";
            cmbTur.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbTur.Properties.Appearance.Options.UseFont = true;
            cmbTur.Properties.AutoHeight = false;
            cmbTur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTur.Properties.Items.AddRange(new object[] { "Müşteri", "Toptancı", "Kişi", "Esnaf", "Fabrika" });
            cmbTur.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            tablePanel1.SetRow(cmbTur, 3);
            cmbTur.Size = new System.Drawing.Size(228, 42);
            cmbTur.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            tablePanel1.SetColumn(label9, 1);
            label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            label9.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            label9.Location = new System.Drawing.Point(138, 12);
            label9.Name = "label9";
            tablePanel1.SetRow(label9, 0);
            label9.Size = new System.Drawing.Size(228, 46);
            label9.TabIndex = 16;
            label9.Text = "Cariler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            tablePanel1.SetColumn(label4, 0);
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(16, 208);
            label4.Name = "label4";
            tablePanel1.SetRow(label4, 4);
            label4.Size = new System.Drawing.Size(116, 50);
            label4.TabIndex = 11;
            label4.Text = "Yetkili :";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            tablePanel1.SetColumn(label3, 0);
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 158);
            label3.Name = "label3";
            tablePanel1.SetRow(label3, 3);
            label3.Size = new System.Drawing.Size(116, 50);
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
            label2.Location = new System.Drawing.Point(16, 108);
            label2.Name = "label2";
            tablePanel1.SetRow(label2, 2);
            label2.Size = new System.Drawing.Size(116, 50);
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
            label1.Location = new System.Drawing.Point(16, 58);
            label1.Name = "label1";
            tablePanel1.SetRow(label1, 1);
            label1.Size = new System.Drawing.Size(116, 50);
            label1.TabIndex = 8;
            label1.Text = "Id :";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            tablePanel1.SetColumn(txtId, 1);
            txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            txtId.Location = new System.Drawing.Point(138, 62);
            txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtId.Properties.Appearance.Options.UseFont = true;
            txtId.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtId, 1);
            txtId.Size = new System.Drawing.Size(228, 42);
            txtId.TabIndex = 0;
            // 
            // tablePanel1
            // 
            tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] { new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40.04F), new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 59.96F) });
            tablePanel1.Controls.Add(txtTel2);
            tablePanel1.Controls.Add(txtTel1);
            tablePanel1.Controls.Add(txtAdres);
            tablePanel1.Controls.Add(txtName);
            tablePanel1.Controls.Add(label14);
            tablePanel1.Controls.Add(label13);
            tablePanel1.Controls.Add(label12);
            tablePanel1.Controls.Add(label11);
            tablePanel1.Controls.Add(label10);
            tablePanel1.Controls.Add(label8);
            tablePanel1.Controls.Add(label7);
            tablePanel1.Controls.Add(label6);
            tablePanel1.Controls.Add(label5);
            tablePanel1.Controls.Add(txtVergiDaire);
            tablePanel1.Controls.Add(txtIlce);
            tablePanel1.Controls.Add(txtIl);
            tablePanel1.Controls.Add(txtFax);
            tablePanel1.Controls.Add(txtMail);
            tablePanel1.Controls.Add(txtStatu);
            tablePanel1.Controls.Add(simpleButton6);
            tablePanel1.Controls.Add(simpleButton4);
            tablePanel1.Controls.Add(simpleButton3);
            tablePanel1.Controls.Add(simpleButton1);
            tablePanel1.Controls.Add(cmbTur);
            tablePanel1.Controls.Add(label9);
            tablePanel1.Controls.Add(label4);
            tablePanel1.Controls.Add(label3);
            tablePanel1.Controls.Add(label2);
            tablePanel1.Controls.Add(label1);
            tablePanel1.Controls.Add(txtYetkili);
            tablePanel1.Controls.Add(txtId);
            tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tablePanel1.Location = new System.Drawing.Point(3, 4);
            tablePanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tablePanel1.Name = "tablePanel1";
            tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] { new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 35F), new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 35F) });
            tablePanel1.Size = new System.Drawing.Size(382, 989);
            tablePanel1.TabIndex = 1;
            tablePanel1.UseSkinIndents = true;
            // 
            // txtTel2
            // 
            tablePanel1.SetColumn(txtTel2, 1);
            txtTel2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTel2.Location = new System.Drawing.Point(138, 368);
            txtTel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTel2.Mask = "(999) 000-0000";
            txtTel2.Name = "txtTel2";
            tablePanel1.SetRow(txtTel2, 7);
            txtTel2.Size = new System.Drawing.Size(228, 30);
            txtTel2.TabIndex = 50;
            // 
            // txtTel1
            // 
            tablePanel1.SetColumn(txtTel1, 1);
            txtTel1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtTel1.Location = new System.Drawing.Point(138, 318);
            txtTel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTel1.Mask = "(999) 000-0000";
            txtTel1.Name = "txtTel1";
            tablePanel1.SetRow(txtTel1, 6);
            txtTel1.Size = new System.Drawing.Size(228, 30);
            txtTel1.TabIndex = 49;
            // 
            // txtAdres
            // 
            tablePanel1.SetColumn(txtAdres, 1);
            txtAdres.Dock = System.Windows.Forms.DockStyle.Fill;
            txtAdres.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAdres.Location = new System.Drawing.Point(138, 662);
            txtAdres.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtAdres.Name = "txtAdres";
            tablePanel1.SetRow(txtAdres, 13);
            tablePanel1.SetRowSpan(txtAdres, 2);
            txtAdres.Size = new System.Drawing.Size(228, 92);
            txtAdres.TabIndex = 48;
            txtAdres.Text = "";
            // 
            // txtName
            // 
            tablePanel1.SetColumn(txtName, 1);
            txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            txtName.Location = new System.Drawing.Point(138, 112);
            txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Properties.Appearance.Options.UseFont = true;
            txtName.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtName, 2);
            txtName.Size = new System.Drawing.Size(228, 42);
            txtName.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            tablePanel1.SetColumn(label14, 0);
            label14.Dock = System.Windows.Forms.DockStyle.Fill;
            label14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label14.Location = new System.Drawing.Point(16, 658);
            label14.Name = "label14";
            tablePanel1.SetRow(label14, 13);
            label14.Size = new System.Drawing.Size(116, 50);
            label14.TabIndex = 47;
            label14.Text = "Adres :";
            label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            tablePanel1.SetColumn(label13, 0);
            label13.Dock = System.Windows.Forms.DockStyle.Fill;
            label13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label13.Location = new System.Drawing.Point(16, 608);
            label13.Name = "label13";
            tablePanel1.SetRow(label13, 12);
            label13.Size = new System.Drawing.Size(116, 50);
            label13.TabIndex = 46;
            label13.Text = "Vergi Daire :";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            tablePanel1.SetColumn(label12, 0);
            label12.Dock = System.Windows.Forms.DockStyle.Fill;
            label12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.Location = new System.Drawing.Point(16, 558);
            label12.Name = "label12";
            tablePanel1.SetRow(label12, 11);
            label12.Size = new System.Drawing.Size(116, 50);
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
            label11.Location = new System.Drawing.Point(16, 508);
            label11.Name = "label11";
            tablePanel1.SetRow(label11, 10);
            label11.Size = new System.Drawing.Size(116, 50);
            label11.TabIndex = 44;
            label11.Text = "İl :";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            tablePanel1.SetColumn(label10, 0);
            label10.Dock = System.Windows.Forms.DockStyle.Fill;
            label10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(16, 458);
            label10.Name = "label10";
            tablePanel1.SetRow(label10, 9);
            label10.Size = new System.Drawing.Size(116, 50);
            label10.TabIndex = 43;
            label10.Text = "Fax :";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            tablePanel1.SetColumn(label8, 0);
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(16, 408);
            label8.Name = "label8";
            tablePanel1.SetRow(label8, 8);
            label8.Size = new System.Drawing.Size(116, 50);
            label8.TabIndex = 42;
            label8.Text = "Mail :";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            tablePanel1.SetColumn(label7, 0);
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(16, 358);
            label7.Name = "label7";
            tablePanel1.SetRow(label7, 7);
            label7.Size = new System.Drawing.Size(116, 50);
            label7.TabIndex = 41;
            label7.Text = "Telefon2 :";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            tablePanel1.SetColumn(label6, 0);
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(16, 308);
            label6.Name = "label6";
            tablePanel1.SetRow(label6, 6);
            label6.Size = new System.Drawing.Size(116, 50);
            label6.TabIndex = 40;
            label6.Text = "Telefon1 :";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            tablePanel1.SetColumn(label5, 0);
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(16, 258);
            label5.Name = "label5";
            tablePanel1.SetRow(label5, 5);
            label5.Size = new System.Drawing.Size(116, 50);
            label5.TabIndex = 39;
            label5.Text = "Statü :";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtVergiDaire
            // 
            tablePanel1.SetColumn(txtVergiDaire, 1);
            txtVergiDaire.Dock = System.Windows.Forms.DockStyle.Fill;
            txtVergiDaire.Location = new System.Drawing.Point(138, 612);
            txtVergiDaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtVergiDaire.Name = "txtVergiDaire";
            txtVergiDaire.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtVergiDaire.Properties.Appearance.Options.UseFont = true;
            txtVergiDaire.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtVergiDaire, 12);
            txtVergiDaire.Size = new System.Drawing.Size(228, 42);
            txtVergiDaire.TabIndex = 11;
            // 
            // txtIlce
            // 
            tablePanel1.SetColumn(txtIlce, 1);
            txtIlce.Dock = System.Windows.Forms.DockStyle.Fill;
            txtIlce.Location = new System.Drawing.Point(138, 562);
            txtIlce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIlce.Name = "txtIlce";
            txtIlce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIlce.Properties.Appearance.Options.UseFont = true;
            txtIlce.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtIlce, 11);
            txtIlce.Size = new System.Drawing.Size(228, 42);
            txtIlce.TabIndex = 10;
            // 
            // txtIl
            // 
            tablePanel1.SetColumn(txtIl, 1);
            txtIl.Dock = System.Windows.Forms.DockStyle.Fill;
            txtIl.Location = new System.Drawing.Point(138, 512);
            txtIl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtIl.Name = "txtIl";
            txtIl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIl.Properties.Appearance.Options.UseFont = true;
            txtIl.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtIl, 10);
            txtIl.Size = new System.Drawing.Size(228, 42);
            txtIl.TabIndex = 9;
            // 
            // txtFax
            // 
            tablePanel1.SetColumn(txtFax, 1);
            txtFax.Dock = System.Windows.Forms.DockStyle.Fill;
            txtFax.Location = new System.Drawing.Point(138, 462);
            txtFax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFax.Name = "txtFax";
            txtFax.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFax.Properties.Appearance.Options.UseFont = true;
            txtFax.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtFax, 9);
            txtFax.Size = new System.Drawing.Size(228, 42);
            txtFax.TabIndex = 8;
            // 
            // txtMail
            // 
            tablePanel1.SetColumn(txtMail, 1);
            txtMail.Dock = System.Windows.Forms.DockStyle.Fill;
            txtMail.Location = new System.Drawing.Point(138, 412);
            txtMail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMail.Properties.Appearance.Options.UseFont = true;
            txtMail.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtMail, 8);
            txtMail.Size = new System.Drawing.Size(228, 42);
            txtMail.TabIndex = 7;
            // 
            // txtStatu
            // 
            tablePanel1.SetColumn(txtStatu, 1);
            txtStatu.Dock = System.Windows.Forms.DockStyle.Fill;
            txtStatu.Location = new System.Drawing.Point(138, 262);
            txtStatu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtStatu.Name = "txtStatu";
            txtStatu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtStatu.Properties.Appearance.Options.UseFont = true;
            txtStatu.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtStatu, 5);
            txtStatu.Size = new System.Drawing.Size(228, 42);
            txtStatu.TabIndex = 4;
            // 
            // simpleButton6
            // 
            simpleButton6.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton6.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton6, 1);
            simpleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton6.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton6.ImageOptions.Image");
            simpleButton6.Location = new System.Drawing.Point(138, 892);
            simpleButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton6.Name = "simpleButton6";
            tablePanel1.SetRow(simpleButton6, 19);
            simpleButton6.Size = new System.Drawing.Size(228, 27);
            simpleButton6.TabIndex = 16;
            simpleButton6.Text = "Temizle";
            simpleButton6.Click += simpleButton6_Click;
            // 
            // simpleButton4
            // 
            simpleButton4.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton4.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton4, 1);
            simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton4.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton4.ImageOptions.Image");
            simpleButton4.Location = new System.Drawing.Point(138, 822);
            simpleButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton4.Name = "simpleButton4";
            tablePanel1.SetRow(simpleButton4, 17);
            simpleButton4.Size = new System.Drawing.Size(228, 27);
            simpleButton4.TabIndex = 14;
            simpleButton4.Text = "Güncelle";
            simpleButton4.Click += simpleButton4_Click;
            // 
            // simpleButton3
            // 
            simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton3.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton3, 1);
            simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton3.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton3.ImageOptions.Image");
            simpleButton3.Location = new System.Drawing.Point(138, 857);
            simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton3.Name = "simpleButton3";
            tablePanel1.SetRow(simpleButton3, 18);
            simpleButton3.Size = new System.Drawing.Size(228, 27);
            simpleButton3.TabIndex = 15;
            simpleButton3.Text = "Sil";
            simpleButton3.Click += simpleButton3_Click;
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            simpleButton1.Appearance.Options.UseFont = true;
            tablePanel1.SetColumn(simpleButton1, 1);
            simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            simpleButton1.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButton1.Location = new System.Drawing.Point(138, 787);
            simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            simpleButton1.Name = "simpleButton1";
            tablePanel1.SetRow(simpleButton1, 16);
            simpleButton1.Size = new System.Drawing.Size(228, 27);
            simpleButton1.TabIndex = 13;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // txtYetkili
            // 
            tablePanel1.SetColumn(txtYetkili, 1);
            txtYetkili.Dock = System.Windows.Forms.DockStyle.Fill;
            txtYetkili.Location = new System.Drawing.Point(138, 212);
            txtYetkili.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtYetkili.Name = "txtYetkili";
            txtYetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtYetkili.Properties.Appearance.Options.UseFont = true;
            txtYetkili.Properties.AutoHeight = false;
            tablePanel1.SetRow(txtYetkili, 4);
            txtYetkili.Size = new System.Drawing.Size(228, 42);
            txtYetkili.TabIndex = 3;
            // 
            // gridView1
            // 
            gridView1.AppearancePrint.Row.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            gridView1.AppearancePrint.Row.Options.UseFont = true;
            gridView1.DetailHeight = 467;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Location = new System.Drawing.Point(391, 4);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1185, 989);
            gridControl1.TabIndex = 500;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(gridControl1, 1, 0);
            tableLayoutPanel1.Controls.Add(tablePanel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1579, 997);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // FrmCariler
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1579, 997);
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "FrmCariler";
            Text = "FrmCariler";
            Load += FrmCariler_Load;
            ((System.ComponentModel.ISupportInitialize)cmbTur.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtId.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablePanel1).EndInit();
            tablePanel1.ResumeLayout(false);
            tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtVergiDaire.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIlce.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtIl.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFax.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStatu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtYetkili.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTur;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtYetkili;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
        private System.Windows.Forms.RichTextBox txtAdres;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.MaskedTextBox txtTel1;
    }
}