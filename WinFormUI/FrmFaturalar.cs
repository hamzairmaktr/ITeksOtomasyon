using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly ICariService _cariManager;
        private readonly IFaturaBilgiService _faturaBilgiManager;
        private readonly IPersonelService _personelManager;
        private readonly IServiceProvider _serviceProvider;

        public FrmFaturalar(ICariService cariManager, IFaturaBilgiService faturaBilgiManager, IPersonelService personelManager, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _cariManager = cariManager;
            _faturaBilgiManager = faturaBilgiManager;
            _personelManager = personelManager;
            _serviceProvider = serviceProvider;

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
            gridControl1.DataSource = _faturaBilgiManager.GetAllDetailsDto().Data;
        }

        void GetCariOzet()
        {
            lookCari.Properties.DataSource = _cariManager.GetCariOzetDtos().Data;
            lookCari.Properties.DisplayMember = "Name";
            lookCari.Properties.ValueMember = "Id";
        }

        void GetPersonelOzet()
        {
            lookPersonel.Properties.DataSource = _personelManager.GetAll().Data;
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
                Tutar = 0,
                KacOdenecek = 0,
                KacOdendi = 0
            };
            var result = _faturaBilgiManager.Add(faturaBilgi);
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
            var result = _faturaBilgiManager.Update(faturaBilgi);
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
            var result = _faturaBilgiManager.Delete(faturaBilgi);
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
            var a = _serviceProvider.GetService<FrmFaturaDetay>();
            a.secilenCari = lookCari.EditValue.ToString();
            a._cariId = int.Parse(lookCari.EditValue.ToString());
            a._fbId = int.Parse(txtId.Text);
            a.ShowDialog();
        }
    }
}
