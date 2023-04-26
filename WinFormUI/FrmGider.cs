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
        public FrmGider()
        {
            InitializeComponent();
        }

        void GetPersonel()
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            var result = personelManager.GetAll().Data;
            lookUpEdit2.Properties.DataSource = result;
            lookUpEdit2.Properties.DisplayMember = "AdSoyad";
            lookUpEdit2.Properties.ValueMember = "Id";
        }

        void GetKasa()
        {
            KasaManager kasaManager = new KasaManager(new EfKasaDal());
            var result = kasaManager.GetDetailsDto().Data;
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
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            gridControl1.DataSource = giderManager.GetAll30DayBefore().Data;
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
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            

            KasaManager kasaManager = new KasaManager(new EfKasaDal());
            var get = kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString()));

            Kasa kasa = new Kasa
            {
                Id = int.Parse(lookUpEdit1.EditValue.ToString()),
                Bakiye = get.Data.Bakiye - decimal.Parse(txtTutar.Text),
                KasaTur = get.Data.KasaTur,

            };
            var result = giderManager.Add(gider,kasa);
            var result1 = kasaManager.UpdateMoneyGider(kasa, gider);
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
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            var result = giderManager.Update(gider);
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
                GiderManager giderManager = new GiderManager(new EfGiderDal());

                var getGider = giderManager.GetById(int.Parse(txtId.Text));

                KasaManager kasaManager = new KasaManager(new EfKasaDal());
                var get = kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString()));
                Kasa kasa = new Kasa
                {
                    Id = int.Parse(lookUpEdit1.EditValue.ToString()),
                    Bakiye = getGider.Data.Tutar + getGider.Data.Tutar,
                    KasaTur = get.Data.KasaTur
                };
                var result = giderManager.Delete(gider);
                var result1 = kasaManager.UpdateMoneyGider(kasa, gider);
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
    }
}
