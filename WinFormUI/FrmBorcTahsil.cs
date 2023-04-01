using AnaMenu;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class FrmBorcTahsil : Form
    {
        public FrmBorcTahsil()
        {
            InitializeComponent();
        }

        private void FrmBorcEksi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            gridControl1.DataSource = borcManager.GetBorcOzetTahsilDTOs().Data;
            MessageBox.Show(borcManager.GetBorcOzetTahsilDTOs().Message);

            KasaManager kasaManager = new KasaManager(new EfKasaDal());
            gridControl3.DataSource = kasaManager.GetDetailsDto().Data;
        }

        void UpdateBorc()
        {
            decimal tutar = decimal.Parse(txtTutar.Text);

            BorcManager borcManager = new BorcManager(new EfBorcDal());
            var borc = borcManager.GetById(int.Parse(txtId.Text)).Data;
            decimal kacodendi = borc.KacOdendi + tutar;
            decimal kacodenecek = borc.Tutar - kacodendi;
            Borc borc1 = new Borc
            {
                Id = int.Parse(txtId.Text),
                KacOdendi = kacodendi,
                KacOdenecek = kacodenecek,
                CariId = int.Parse(txtCariId.Text),
                Geciktimi = false,
                Odendimi = false,
                TeslimTarih = borc.TeslimTarih,
                Tur = borc.Tur,
                Tutar = borc.Tutar,
                VerilisTarih = borc.VerilisTarih
            };
            var result = borcManager.Update(borc1);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void UpdateKasa()
        {
            decimal tutar = decimal.Parse(txtTutar.Text);
            KasaManager kasaManager = new KasaManager(new EfKasaDal());

            var kasa = kasaManager.GetById(int.Parse(txtKasaId.Text));
            decimal b = kasa.Data.Bakiye;
            decimal bakiye = b + tutar;

            Kasa kasa1 = new Kasa
            {
                Id = int.Parse(txtKasaId.Text),
                Bakiye = bakiye,
                KasaTur = kasa.Data.KasaTur
            };
            var result = kasaManager.Update(kasa1);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as BorcOzetDto;
            txtId.Text = selectedRow.Id.ToString();
            txtCariId.Text = selectedRow.CariId.ToString();
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView3.GetFocusedRow() as KasaDetailsDto;
            txtKasaId.Text = selectedRow.Id.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBorc();
                UpdateKasa();

                MessageBox.Show("Başarı ile borç eksiltildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu" + ex, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Listele();
            }
        }
    }
}
