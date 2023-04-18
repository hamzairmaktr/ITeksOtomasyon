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
        public static int _id;
        public FrmFaturaDetayEkle(int id)
        {
            InitializeComponent();
            _id = id;
        }

        void GetUrun()
        {
            UrunManager urunManager = new UrunManager(new EfUrunDal());
            lookUpEdit1.Properties.DataSource = urunManager.GetAll().Data;
            lookUpEdit1.Properties.DisplayMember = "KumasAd";
            lookUpEdit1.Properties.ValueMember = "Id";
        }

        void GetFiyat()
        {
            UrunManager urunManager = new UrunManager(new EfUrunDal());
            var result = urunManager.Get(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            txtFiyat.Text = result.SatisFiyat.ToString();
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
                Fiyat = decimal.Parse(txtFiyat.Text),
                Kg = decimal.Parse(txtKg.Text),
                TopSayisi = int.Parse(txtAdet.Text),
                Tutar = decimal.Parse(txtTutar.Text),
                UrunId = int.Parse(lookUpEdit1.EditValue.ToString())
            };
            FaturaDetayManager faturaDetayManager = new FaturaDetayManager(new EfFaturaDetayDal());
            var result = faturaDetayManager.Add(faturaDetay);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var get = faturaBilgiManager.Get(_id).Data;
            decimal toplam = get.Tutar + decimal.Parse(txtTutar.Text);
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = _id,
                CariId = get.CariId,
                Date = get.Date,
                PersonelId = get.PersonelId,
                SiraNo = get.SiraNo,
                TeslimAlan = get.TeslimAlan,
                Time = get.Time,
                Tutar = toplam,
                KacOdenecek = toplam,
                KacOdendi = get.KacOdendi
            };
            faturaBilgiManager.Update(faturaBilgi);

            UrunManager urunManager = new UrunManager(new EfUrunDal());
            var get1 = urunManager.Get(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            int topsayi = get1.TopAdet - int.Parse(txtAdet.Text);
            decimal kg = get1.Kg - decimal.Parse(txtKg.Text);
            get1.TopAdet = topsayi;
            get1.Kg = kg;

            urunManager.Update(get1);


        }

        private void txtKdv_EditValueChanged(object sender, EventArgs e)
        {

            decimal fiyat = decimal.Parse(txtFiyat.Text);
            decimal kdv = decimal.Parse(txtKdv.Text);
            decimal toplam = ((fiyat * kdv) / 100) + fiyat;
            txtFiyat.Text = toplam.ToString();
            decimal tutar = decimal.Parse(txtKg.Text) * toplam;
            txtTutar.Text = tutar.ToString();

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            GetFiyat();
        }
    }
}
