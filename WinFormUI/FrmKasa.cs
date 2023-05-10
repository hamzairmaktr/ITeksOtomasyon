using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.MVVM;
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
    public partial class FrmKasa : Form
    {
        private readonly IKasaService _kasaManager;
        private readonly IKasaTurService _kasaTurManager;
        private readonly FrmKasaTur _frmKasaTur;
        public FrmKasa(IKasaService kasaManager, IKasaTurService kasaTurManager,FrmKasaTur frmKasaTur)
        {
            InitializeComponent();
            _kasaManager = kasaManager;
            _kasaTurManager = kasaTurManager;
            _frmKasaTur = frmKasaTur;
        }


        void Listele()
        {
            gridControl1.DataSource = _kasaManager.GetDetailsDto().Data;
        }

        void KasaTurGetir()
        {
            var result = _kasaTurManager;
            if (_kasaTurManager.GetAll().Data != null)
            {
                lookUpEdit1.Properties.DataSource = result.GetAll().Data;
                lookUpEdit1.Properties.DisplayMember = "Name";
                lookUpEdit1.Properties.ValueMember = "Id";
                lookUpEdit1.EditValue = 0;
            }
        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            KasaTurGetir();
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa
            {
                KasaTur = int.Parse(lookUpEdit1.EditValue.ToString()),
                Bakiye = decimal.Parse(txtBakiye.Text)
            };
            var result = _kasaManager.Add(kasa);
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
            Kasa kasa = new Kasa
            {
                Id = int.Parse(txtId.Text),
                KasaTur = int.Parse(lookUpEdit1.EditValue.ToString()),
                Bakiye = decimal.Parse(txtBakiye.Text)
            };
            var result = _kasaManager.Update(kasa);
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
            Kasa kasa = new Kasa
            {
                Id = int.Parse(txtId.Text)
            };
            var result = _kasaManager.Delete(kasa);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Listele();
        }

        private void btnKasaTur_Click(object sender, EventArgs e)
        {
            _frmKasaTur.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Listele();
            KasaTurGetir();
        }
    }
}
