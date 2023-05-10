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
    public partial class FrmGider : Form
    {
        private readonly IGiderService _giderManager;
        private readonly IKasaService _kasaManager;
        private readonly IPersonelService _personelManager;

        public FrmGider(IGiderService giderManager, IKasaService kasaManager, IPersonelService personelManager)
        {
            InitializeComponent();
            _giderManager = giderManager;
            _kasaManager = kasaManager;
            _personelManager = personelManager;

        }



        void GetPersonel()
        {
            var result = _personelManager.GetAll().Data;
            lookUpEdit2.Properties.DataSource = result;
            lookUpEdit2.Properties.DisplayMember = "AdSoyad";
            lookUpEdit2.Properties.ValueMember = "Id";
        }

        void GetKasa()
        {
            var result = _kasaManager.GetDetailsDto().Data;
            lookUpEdit1.Properties.DataSource = result;
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.ValueMember = "Id";
        }

        void Temizle()
        {
            txtId.Clear();
            txtTutar.Clear();
            dateTarih.Clear();
            txtNot.Clear();
            txtTutar.Clear();
            lookUpEdit1.Clear();
            lookUpEdit2.Clear();
            
        }

        void Listele()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = _giderManager.GetAll30DayBefore().Data.OrderByDescending(p=>p.Id);
        }

        void TarihAralıgaGoreListele()
        {
            gridControl1.DataSource = null;

            string tarihAralıgı = cmbTarihAraligi.Text;
            switch (tarihAralıgı)
            {
                case "7 Gün":
                    gridControl1.DataSource = _giderManager.GetAll7DayBefore().Data.OrderByDescending(p => p.Id);
                    break;
                case "30 Gün":
                    gridControl1.DataSource = _giderManager.GetAll30DayBefore().Data.OrderByDescending(p => p.Id);
                    break;
                case "365 Gün":
                    gridControl1.DataSource = _giderManager.GetAll365DayBefore().Data.OrderByDescending(p => p.Id);
                    break;
            }
        }

        void TariheGoreListele()
        {
            gridControl1.DataSource = null;

            DateTime date = dateFiltre.DateTime;
            gridControl1.DataSource = _giderManager.GetAllDay(date).Data.OrderByDescending(p => p.Id);
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {
            Listele();
            GetKasa();
            GetPersonel();
            dateTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            GetPersonel();
            GetKasa();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider
            {
                Date = DateTime.Parse(dateTarih.Text),
                Not = txtNot.Text,
                Tutar = decimal.Parse(txtTutar.Text),
                Tur = txtTur.Text,
                PersonelId = int.Parse(lookUpEdit2.EditValue.ToString())
            };


            var get = _kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString()));

            Kasa kasa = new Kasa
            {
                Id = int.Parse(lookUpEdit1.EditValue.ToString()),
                Bakiye = get.Data.Bakiye - decimal.Parse(txtTutar.Text),
                KasaTur = get.Data.KasaTur,

            };
            var result = _giderManager.Add(gider, kasa);
            var result1 = _kasaManager.UpdateMoneyGider(kasa, gider);
            if (result.Success && result1.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            GetKasa();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider
            {
                Id = int.Parse(txtId.Text),
                Date = DateTime.Parse(dateTarih.Text),
                Not = txtNot.Text,
                Tutar = decimal.Parse(txtTutar.Text),
                Tur = txtTur.Text,
                PersonelId = int.Parse(lookUpEdit2.EditValue.ToString())
            };
            var result = _giderManager.Update(gider);
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
            try
            {
                Gider gider = new Gider
                {
                    Id = int.Parse(txtId.Text),
                };

                var getGider = _giderManager.GetById(int.Parse(txtId.Text));

                var get = _kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString()));
                Kasa kasa = new Kasa
                {
                    Id = int.Parse(lookUpEdit1.EditValue.ToString()),
                    Bakiye = getGider.Data.Tutar + getGider.Data.Tutar,
                    KasaTur = get.Data.KasaTur
                };
                var result = _giderManager.Delete(gider);
                var result1 = _kasaManager.UpdateMoneyGider(kasa, gider);
                if (result.Success && result.Success)
                {
                    MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Temizle();
                Listele();
                GetKasa();
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            string filtreTur = cmbFiltreTuru.Text;
            switch (filtreTur)
            {
                case "Belirli Bir Tarih":
                    TariheGoreListele();
                    break;
                case "Tarih Aralığı":
                    TarihAralıgaGoreListele();
                    break;
            }
        }
    }
}
