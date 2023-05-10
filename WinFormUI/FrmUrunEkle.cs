using Business.Abstract;
using DevExpress.XtraEditors;
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
    public partial class FrmUrunEkle : Form
    {
        private readonly IUrunService _urunManager;
        private readonly IFaturaDetayService _faturaDetayManager;
        private readonly IFaturaBilgiService _faturaBilgiManager;

        public int _id;

        public FrmUrunEkle(IUrunService urunService, IFaturaDetayService faturaDetayService, IFaturaBilgiService faturaBilgiService)
        {
            InitializeComponent();
            _faturaBilgiManager = faturaBilgiService;
            _urunManager = urunService;
            _faturaDetayManager = faturaDetayService;
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
        int id;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun
            {
                AlisFiyat = decimal.Parse(txtFiyat.Text),
                Detay = rchUrunDetay.Text,
                Finish = false,
                Kg = decimal.Parse(txtKg.Text),
                KumasAd = txtUrunIsim.Text,
                KumasTur = txtUrunIsim.Text,
                Renk = txtRenk.Text,
                SatisFiyat = decimal.Parse(txtSatisFiyat.Text),
                TopAdet = int.Parse(txtAdet.Text),
                LotNo = txtLotNo.Text,
            };

            var result1 = _urunManager.Add(urun);

            var get1 = _urunManager.GetAll().Data;
            foreach (var item in get1)
            {
                id = item.Id;
            }
            id = id + 1;
            FaturaDetay faturaDetay = new FaturaDetay
            {
                FaturaId = int.Parse(txtFaturaId.Text),
                Fiyat = decimal.Parse(txtKdvsizFiyat.Text),
                Kg = decimal.Parse(txtKg.Text),
                TopSayisi = int.Parse(txtAdet.Text),
                Tutar = decimal.Parse(txtKdvsizTutar.Text),
                UrunId = id,
                Kdv = decimal.Parse(txtKdvTl.Text),
                KdvFiyat = decimal.Parse(txtFiyat.Text),
                KdvTutar = decimal.Parse(txtTutar.Text),
                KdvOran = byte.Parse(txtKdv.Text),
            };
            

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

            
            var result = _faturaDetayManager.Add(faturaDetay);
            if (result.Success && result1.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(result1.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(result1.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
