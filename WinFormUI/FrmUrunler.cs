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
    public partial class FrmUrunler : Form
    {
        private readonly IUrunService _urunManager;

        public FrmUrunler(IUrunService urunManager)
        {
            InitializeComponent();
            _urunManager = urunManager;
        }

        private void Listele()
        {
            gridControl1.DataSource = _urunManager.GetAll().Data;
        }

        void Temizle()
        {
            txtId.Clear();
            txtTur.Clear();
            txtUrunAd.Clear();
            txtRenk.Clear();
            txtKg.Clear();
            txtAdet.Clear();
            txtDetay.Clear();
            txtAlisFiyat.Clear();
            txtSatisFiyat.Clear();
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                KumasTur = txtTur.Text,
                KumasAd = txtUrunAd.Text,
                Detay = txtDetay.Text,
                AlisFiyat = decimal.Parse(txtAlisFiyat.Text),
                Kg = decimal.Parse(txtKg.Text),
                Renk = txtRenk.Text,
                SatisFiyat = decimal.Parse(txtSatisFiyat.Text),
                TopAdet = int.Parse(txtAdet.Text)
            };
            var result = _urunManager.Add(urun);
            if (result.Success)
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                Id = int.Parse(txtId.Text),
                KumasTur = txtTur.Text,
                KumasAd = txtUrunAd.Text,
                Detay = txtDetay.Text,
                AlisFiyat = decimal.Parse(txtAlisFiyat.Text),
                Kg = decimal.Parse(txtKg.Text),
                Renk = txtRenk.Text,
                SatisFiyat = decimal.Parse(txtSatisFiyat.Text),
                TopAdet = int.Parse(txtAdet.Text)
            };
            var result = _urunManager.Update(urun);
            if (result.Success)
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                Id = int.Parse(txtId.Text)
            };
            var result = _urunManager.Delete(urun);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as Urun;
            txtId.Text = selectedRow.Id.ToString();
            txtTur.Text = selectedRow.KumasTur;
            txtUrunAd.Text = selectedRow.KumasAd;
            txtRenk.Text = selectedRow.Renk;
            txtKg.Text = selectedRow.Kg.ToString();
            txtAdet.Text = selectedRow.TopAdet.ToString();
            txtDetay.Text = selectedRow.Detay.ToString();
            txtAlisFiyat.Text = selectedRow.AlisFiyat.ToString();
            txtSatisFiyat.Text = selectedRow.SatisFiyat.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void btnUrunAl_Click(object sender, EventArgs e)
        {
            FrmUrunAl frmUrunAl = new FrmUrunAl();
            frmUrunAl.ShowDialog();
        }
    }
}
