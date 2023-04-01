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
    public partial class FrmKasaTur : Form
    {
        public FrmKasaTur()
        {
            InitializeComponent();
        }

        void Listele()
        {
            KasaTurManager kasaTurManager = new KasaTurManager(new EfKasaTurDal());
            var result = kasaTurManager.GetAllKasaTurDetails().Data;
            gridControl1.DataSource = result;
        }

        void GetListBanka()
        {
            BankaManager bankaManager = new BankaManager(new EfBankaDal());
            var result = bankaManager.GetAll().Data;
            lookUpEdit1.Properties.DataSource = result;
            lookUpEdit1.Properties.DisplayMember = "BankaAd";
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.EditValue = 0;
        }

        private void FrmKasaTur_Load(object sender, EventArgs e)
        {
            GetListBanka();
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            KasaTur kasaTur = new KasaTur
            {
                Name = txtName.Text,
                BankaId = int.Parse(lookUpEdit1.EditValue.ToString())
            };

            KasaTurManager kasaTurManager = new KasaTurManager(new EfKasaTurDal());
            var result = kasaTurManager.Add(kasaTur);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KasaTur kasaTur = new KasaTur
            {
                Id = int.Parse(txtId.Text)
            };

            KasaTurManager kasaTurManager = new KasaTurManager(new EfKasaTurDal());
            var result = kasaTurManager.Delete(kasaTur);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KasaTur kasaTur = new KasaTur
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                BankaId = int.Parse(lookUpEdit1.EditValue.ToString())
            };

            KasaTurManager kasaTurManager = new KasaTurManager(new EfKasaTurDal());
            var result = kasaTurManager.Update(kasaTur);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
        }
    }
}
