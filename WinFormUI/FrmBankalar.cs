using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraSpreadsheet.Model;
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
    public partial class FrmBankalar : Form
    {
        private readonly IBankaService _bankaService;
        public FrmBankalar(IBankaService bankaService)
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        void Listele()
        {
            
            gridControl1.DataSource = _bankaService.GetAll().Data;
        }
        private void FrmBankalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            Banka banka = new Banka()
            {
                BankaAd = txtAd.Text,
                HesapNo = txtHesapNo.Text,
                HesapTuru = txtHesapTuru.Text,
                Iban = txtIban.Text,
                Sube = txtSube.Text,
                Tarih = DateTime.Now,
                Yetkili = txtYetkili.Text
            };
            var result = _bankaService.Add(banka);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            Banka banka = new Banka()
            {
                Id = int.Parse(txtId.Text)
            };
            var result = _bankaService.Delete(banka);
            if (result.Success == true)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silindi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as Banka;
            txtId.Text = selectedRow.Id.ToString();
            txtAd.Text = selectedRow.BankaAd.ToString();
            txtSube.Text = selectedRow.Sube.ToString();
            txtIban.Text = selectedRow.Iban.ToString();
            txtHesapNo.Text = selectedRow.HesapNo.ToString();
            txtHesapTuru.Text = selectedRow.HesapTuru.ToString();
            txtYetkili.Text = selectedRow.Yetkili.ToString();
            dateTarih.Text = selectedRow.Tarih.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void Temizle()
        {
            txtId.Clear();
            txtAd.Clear();
            txtSube.Clear();
            txtIban.Clear();
            txtHesapNo.Clear();
            txtHesapTuru.Clear();
            txtYetkili.Clear();
            dateTarih.Clear();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            Banka banka = new Banka()
            {
                BankaAd = txtAd.Text,
                HesapNo = txtHesapNo.Text,
                HesapTuru = txtHesapTuru.Text,
                Iban = txtIban.Text,
                Sube = txtSube.Text,
                Tarih = DateTime.Parse(dateTarih.Text),
                Yetkili = txtYetkili.Text,
                Id = int.Parse(txtId.Text)
            };
            var result = _bankaService.Update(banka);
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
    }
}
