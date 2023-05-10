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
    public partial class FrmFaturaDetayEkle : Form
    {
        private readonly IUrunService _urunManager;
        private readonly IFaturaDetayService _faturaDetayManager;
        private readonly IFaturaBilgiService _faturaBilgiManager;
        public FrmFaturaDetayEkle(IUrunService urunManager, IFaturaDetayService faturaDetayManager, IFaturaBilgiService faturaBilgiManager)
        {
            InitializeComponent();
            _faturaBilgiManager = faturaBilgiManager;
            _urunManager = urunManager;
            _faturaDetayManager = faturaDetayManager;
        }


        public int _id;

        void GetUrun()
        {
            lookUpEdit1.Properties.DataSource = _urunManager.GetAll().Data;
            lookUpEdit1.Properties.DisplayMember = "KumasAd";
            lookUpEdit1.Properties.ValueMember = "Id";
        }

        void GetFiyat()
        {
            var result = _urunManager.Get(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            txtFiyat.Text = result.SatisFiyat.ToString();
            txtKdvsizFiyat.Text = result.SatisFiyat.ToString();
        }

        private void FrmFaturaDetayEkle_Load(object sender, EventArgs e)
        {
            txtFaturaId.Text = _id.ToString();
            GetUrun();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FaturaDetay faturaDetay = new FaturaDetay
            {
                FaturaId = int.Parse(txtFaturaId.Text),
                Fiyat = decimal.Parse(txtKdvsizFiyat.Text),
                Kg = decimal.Parse(txtKg.Text),
                TopSayisi = int.Parse(txtAdet.Text),
                Tutar = decimal.Parse(txtKdvsizTutar.Text),
                UrunId = int.Parse(lookUpEdit1.EditValue.ToString()),
                Kdv = decimal.Parse(txtKdvTl.Text),
                KdvFiyat = decimal.Parse(txtFiyat.Text),
                KdvTutar = decimal.Parse(txtTutar.Text),
                KdvOran = byte.Parse(txtKdv.Text),
            };
            var result = _faturaDetayManager.Add(faturaDetay);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var get = _faturaBilgiManager.Get(_id).Data;
            decimal toplam = get.Tutar + decimal.Parse(txtTutar.Text);

            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = _id,
                CariId = get.CariId,
                Date = get.Date,
                PersonelId = get.PersonelId,
                TeslimAlan = get.TeslimAlan,
                Time = get.Time,
                Tutar = toplam,
                KacOdenecek = toplam,
                KacOdendi = get.KacOdendi,
                FaturaTuru = get.FaturaTuru,
                FaturaKesildimi = get.FaturaKesildimi,
                Odendimi = get.Odendimi,
                SeriNo = get.SeriNo
            };
            _faturaBilgiManager.Update(faturaBilgi);

            var get1 = _urunManager.Get(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            int topsayi = get1.TopAdet - int.Parse(txtAdet.Text);
            decimal kg = get1.Kg - decimal.Parse(txtKg.Text);
            get1.TopAdet = topsayi;
            get1.Kg = kg;

            _urunManager.Update(get1);
        }

        private void txtKdv_EditValueChanged(object sender, EventArgs e)
        {

            decimal fiyat = decimal.Parse(txtFiyat.Text);
            decimal kdv = decimal.Parse(txtKdv.Text);
            decimal toplam = ((fiyat * kdv) / 100) + fiyat;
            txtFiyat.Text = toplam.ToString();
            decimal tutar = decimal.Parse(txtKg.Text) * toplam;
            txtTutar.Text = tutar.ToString();

            txtKdvTl.Text = (decimal.Parse(txtTutar.Text) - decimal.Parse(txtKdvsizTutar.Text)).ToString();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GetFiyat();
        }

        private void txtKg_EditValueChanged(object sender, EventArgs e)
        {
            decimal fiyat = decimal.Parse(txtKdvsizFiyat.Text);
            decimal kg = decimal.Parse(txtKg.Text);

            decimal toplam = fiyat * kg;

            txtKdvsizTutar.Text = toplam.ToString();
        }
    }
}
