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

        void Temizle()
        {
            txtId.Clear();
            txtTutar.Clear();
            dateTarih.Clear();
            txtNot.Clear();
        }

        void Listele()
        {
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            gridControl1.DataSource = giderManager.GetAll30DayBefore().Data;
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {
            Listele();
            dateTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Gider gider = new Gider
            {
                Date = DateTime.Parse(dateTarih.Text),
                Not = txtNot.Text,
                Tutar = decimal.Parse(txtTutar.Text)
            };
            GiderManager giderManager = new GiderManager(new EfGiderDal());
            var result = giderManager.Add(gider);
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
            Gider gider = new Gider
            {
                Id = int.Parse(txtId.Text),
                Date = DateTime.Parse(dateTarih.Text),
                Not = txtNot.Text,
                Tutar = decimal.Parse(txtTutar.Text)
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
                var result = giderManager.Delete(gider);
                if (result.Success)
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
            }
        }
    }
}
