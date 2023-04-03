using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
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
    public partial class FrmFaturalar : Form
    {
        public FrmFaturalar()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtId.Clear();
            txtSaat.Clear();
            txtTarih.Clear();
            txtTVeren.Clear();
            txtTAlan.Clear();
            lookCari.Clear();
            lookPersonel.Clear();
            txtSiraNo.Clear();
            GetAllFaturaBilgi();
        }

        void GetAllFaturaBilgi()
        {
            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            gridControl1.DataSource = faturaBilgiManager.GetAllDetailsDto().Data;
        }

        void GetCariOzet()
        {
            CariManager cariManager = new CariManager(new EfCariDal());
            lookCari.Properties.DataSource = cariManager.GetCariOzetDtos().Data;
            lookCari.Properties.DisplayMember = "Name";
            lookCari.Properties.ValueMember = "Id";
        }

        void GetPersonelOzet()
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            lookPersonel.Properties.DataSource = personelManager.GetAll().Data;
            lookPersonel.Properties.DisplayMember = "AdSoyad";
            lookPersonel.Properties.ValueMember = "Id";
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            GetAllFaturaBilgi();
            GetCariOzet();
            GetPersonelOzet();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                CariId = int.Parse(lookCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookPersonel.EditValue.ToString()),
                SiraNo = txtSiraNo.Text.ToString(),
                TeslimAlan = txtTAlan.Text,
                Tutar = 0
            };
            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var result = faturaBilgiManager.Add(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = int.Parse(txtId.Text),
                CariId = int.Parse(lookCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookPersonel.EditValue.ToString()),
                SiraNo = txtSiraNo.Text.ToString(),
                TeslimAlan = txtTAlan.Text,
                Tutar = 0
            };
            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var result = faturaBilgiManager.Update(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = int.Parse(txtId.Text),
            };
            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var result = faturaBilgiManager.Delete(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as FaturaBilgiDetailsDto;
            txtId.Text = selectedRow.Id.ToString();
            txtSaat.Text = selectedRow.Tarih.ToShortTimeString();
            txtTarih.Text = selectedRow.Tarih.ToLongDateString();
            txtTAlan.Text = selectedRow.TeslimAlan;
            lookCari.Text = selectedRow.CariName;
            lookPersonel.Text = selectedRow.PersonelName;
            txtSiraNo.Text = selectedRow.SiraNo;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaDetay frmFaturaDetay = new FrmFaturaDetay(txtId.Text,int.Parse(lookCari.EditValue.ToString()));
            frmFaturaDetay.ShowDialog();
        }
    }
}
