using Business.Abstract;
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
    public partial class FrmPersoneller : Form
    {
        private readonly IPersonelService _personelManager;
        public FrmPersoneller(IPersonelService personelManager)
        {
            InitializeComponent();
            _personelManager = personelManager;
        }


        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = _personelManager.GetAll().Data;
        }

        private void Temizle()
        {
            txtId.Clear();
            txtName.Clear();
            txtMaas.Clear();
            txtTel1.Clear();
            txtMail.Clear();
            txtIl.Clear();
            txtIlce.Clear();
            cmbGorev.Clear();
            txtAdres.Clear();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel
            {
                Adres = txtAdres.Text,
                AdSoyad = txtName.Text,
                Gorev = cmbGorev.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                Maas = decimal.Parse(txtMaas.Text),
                Mail = txtMail.Text,
                Telefon = txtTel1.Text
            };
            var result = _personelManager.Add(personel);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Temizle();
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel
            {
                Id = int.Parse(txtId.Text),
                Adres = txtAdres.Text,
                AdSoyad = txtName.Text,
                Gorev = cmbGorev.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                Maas = decimal.Parse(txtMaas.Text),
                Mail = txtMail.Text,
                Telefon = txtTel1.Text
            };
            var result = _personelManager.Update(personel);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Temizle();
            Listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel
            {
                Id = int.Parse(txtId.Text),
                Adres = txtAdres.Text,
                AdSoyad = txtName.Text,
                Gorev = cmbGorev.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                Maas = decimal.Parse(txtMaas.Text),
                Mail = txtMail.Text,
                Telefon = txtTel1.Text,

            };
            var result = _personelManager.Delete(personel);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Temizle();
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as Personel;
            txtId.Text = selectedRow.Id.ToString();
            txtName.Text = selectedRow.AdSoyad.ToString();
            txtMaas.Text = selectedRow.Maas.ToString();
            txtTel1.Text = selectedRow.Telefon.ToString();
            txtMail.Text = selectedRow.Mail.ToString();
            txtIl.Text = selectedRow.Il.ToString();
            txtIlce.Text = selectedRow.Ilce.ToString();
            cmbGorev.Text = selectedRow.Gorev.ToString();
            txtAdres.Text = selectedRow.Adres.ToString();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }
    }
}
