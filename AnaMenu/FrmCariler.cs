using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIWinForm
{
    public partial class FrmCariler : Form
    {
        public FrmCariler()
        {
            InitializeComponent();
        }
        

        private void FrmCariler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            CariManager cariManager = new CariManager(new EfCariDal());
            gridControl1.DataSource = cariManager.GetAll().Data;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari
            {
                Adres = txtAdres.Text,
                CariTur = cmbTur.Text,
                Fax = txtFax.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                Ismi = txtName.Text,
                Mail = txtMail.Text,
                Telefon1 = txtTel1.Text,
                Telefon2 = txtTel2.Text,
                VergiDaire = txtVergiDaire.Text,
                YetkiliAdSoyad = txtYetkili.Text,
                YetkiliStatu = txtStatu.Text
            };
            CariManager cariManager = new CariManager(new EfCariDal());
            var result = cariManager.Add(cari);
            if (result.Success == true)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari
            {
                Id = int.Parse(txtId.Text),
                Adres = txtAdres.Text,
                CariTur = cmbTur.Text,
                Fax = txtFax.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                Ismi = txtName.Text,
                Mail = txtMail.Text,
                Telefon1 = txtTel1.Text,
                Telefon2 = txtTel2.Text,
                VergiDaire = txtVergiDaire.Text,
                YetkiliAdSoyad = txtYetkili.Text,
                YetkiliStatu = txtStatu.Text
            };
            CariManager cariManager = new CariManager(new EfCariDal());
            var result = cariManager.Update(cari);
            if (result.Success == true)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as Cari;
            txtId.Text = selectedRow.Id.ToString();
            txtName.Text = selectedRow.Ismi;
            cmbTur.Text = selectedRow.CariTur;
            txtYetkili.Text = selectedRow.YetkiliAdSoyad;
            txtStatu.Text = selectedRow.YetkiliStatu;
            txtTel1.Text = selectedRow.Telefon1;
            txtTel2.Text = selectedRow.Telefon2;
            txtMail.Text = selectedRow.Mail;
            txtFax.Text = selectedRow.Fax;
            txtIl.Text = selectedRow.Il;
            txtIlce.Text = selectedRow.Ilce;
            txtVergiDaire.Text = selectedRow.VergiDaire;
            txtAdres.Text = selectedRow.Adres;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Cari cari = new Cari
            {
                Id = int.Parse(txtId.Text)
            };
            CariManager cariManager = new CariManager(new EfCariDal());
            cariManager.Delete(cari);
            Listele();
            Temizle();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            txtId.Text = "";
            txtName.Text = "";
            cmbTur.Text = "";
            txtYetkili.Text = "";
            txtStatu.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            txtMail.Text = "";
            txtFax.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtVergiDaire.Text = "";
            txtAdres.Text = "";
            txtId.Focus();
        }
    }
}
