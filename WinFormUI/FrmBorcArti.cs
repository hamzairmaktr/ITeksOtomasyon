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
    public partial class FrmBorcArti : Form
    {
        public FrmBorcArti()
        {
            InitializeComponent();
        }

        private void FrmBorcArti_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            gridControl1.DataSource = borcManager.GetBorcOzetDTOs().Data;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as BorcOzetDto;
            txtId.Text = selectedRow.Id.ToString();
            txtCariId.Text = selectedRow.CariId.ToString();
        }

        void UpdateBorc()
        {
            decimal tutar = decimal.Parse(txtTutar.Text);

            BorcManager borcManager = new BorcManager(new EfBorcDal());
            var borc = borcManager.GetById(int.Parse(txtId.Text)).Data;
            decimal borctutar = borc.Tutar + tutar;
            decimal kacodenecek = borc.KacOdenecek + tutar;
            decimal kacodendi = borctutar - kacodenecek;
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
                Tutar = borctutar,
                VerilisTarih = borc.VerilisTarih
            };
            var result = borcManager.Update(borc1);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBorc();

                MessageBox.Show("Başarı ile borç arttırıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
