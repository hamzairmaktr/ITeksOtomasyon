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
            txtTAlan.Clear();
            lookCari.Clear();
            lookPersonel.Clear();
            txtSeriNo.Clear();

            txtAlisId.Clear();
            txtAlisSaat.Clear();
            txtAlisTarih.Clear();
            txtAlisTVeren.Clear();
            lookAlisCari.Clear();
            lookAlisPersonel.Clear();
            txtAlisSeriNo.Clear();
        }

        void GetAllFaturaBilgi()
        {
            gridControl1.DataSource = _faturaBilgiManager.GetAllDetailsDto().Data
                .Where(f => f.FaturaTuru == "Satış")
                .OrderByDescending(f => f.Id);

            gridControl2.DataSource = _faturaBilgiManager.GetAllDetailsDto().Data
                .Where(f => f.FaturaTuru == "Alış")
                .OrderByDescending(f => f.Id);
        }

        void GetCariOzet()
        {
            lookCari.Properties.DataSource = _cariManager.GetCariOzetDtos().Data;
            lookCari.Properties.DisplayMember = "Name";
            lookCari.Properties.ValueMember = "Id";

            lookAlisCari.Properties.DataSource = _cariManager.GetCariOzetDtos().Data;
            lookAlisCari.Properties.DisplayMember = "Name";
            lookAlisCari.Properties.ValueMember = "Id";
        }

        void GetPersonelOzet()
        {
            lookPersonel.Properties.DataSource = _personelManager.GetAll().Data;
            lookPersonel.Properties.DisplayMember = "AdSoyad";
            lookPersonel.Properties.ValueMember = "Id";

            lookAlisPersonel.Properties.DataSource = _personelManager.GetAll().Data;
            lookAlisPersonel.Properties.DisplayMember = "AdSoyad";
            lookAlisPersonel.Properties.ValueMember = "Id";
        }

        void GetSeriNo()
        {
            if (_faturaBilgiManager.GetAllDetailsDto().Data.Count > 0)
            {
                var result = _faturaBilgiManager.GetAllDetailsDto().Data.MaxBy(f => f.SeriNo).SeriNo;
                int parseResult = int.Parse(result) + 1;
                var seriNo = "A-";
                for (int i = 0; i < 6 - parseResult.ToString().Length; i++)
                {
                    seriNo += "0";
                }
                seriNo += parseResult.ToString();

                txtSeriNo.Text = seriNo.ToString();
            }
            else
            {
                txtSeriNo.Text = "A-000001";
            }
        }

        private void FrmFaturalar_Load(object sender, EventArgs e)
        {
            GetAllFaturaBilgi();
            GetCariOzet();
            GetPersonelOzet();
            GetSeriNo();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                CariId = int.Parse(lookCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookPersonel.EditValue.ToString()),
                //SiraNo = int.Parse(txtSiraNo.Text),
                TeslimAlan = txtTAlan.Text,
                Tutar = 0,
                KacOdenecek = 0,
                KacOdendi = 0,
                FaturaTuru = "Satış",
                FaturaKesildimi = false,
                Odendimi = false,
                SeriNo = txtSeriNo.Text,
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
            var get = _faturaBilgiManager.Get(int.Parse(txtId.Text));
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = int.Parse(txtId.Text),
                CariId = int.Parse(lookCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookPersonel.EditValue.ToString()),
                //SiraNo = int.Parse(txtSiraNo.Text),
                TeslimAlan = txtTAlan.Text,
                Tutar = get.Data.Tutar,
                FaturaTuru = "Satış",
                SeriNo = txtSeriNo.Text,
                FaturaKesildimi = get.Data.FaturaKesildimi,
                KacOdendi = get.Data.KacOdendi,
                KacOdenecek = get.Data.KacOdenecek,
                Odendimi = get.Data.Odendimi
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
            txtSeriNo.Text = selectedRow.SeriNo.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            GetSeriNo();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var a = _serviceProvider.GetService<FrmFaturaDetay>();
            a.secilenCari = lookCari.EditValue.ToString();
            a._cariId = int.Parse(lookCari.EditValue.ToString());
            a._fbId = int.Parse(txtId.Text);
            a.ShowDialog();
        }

        private void tablePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlisKaydet_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                CariId = int.Parse(lookAlisCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookAlisPersonel.EditValue.ToString()),
                //SiraNo = int.Parse(txtAlisSiraNo.Text),
                TeslimAlan = txtAlisTVeren.Text,
                Tutar = 0,
                KacOdenecek = 0,
                KacOdendi = 0,
                FaturaTuru = "Alış",
                SeriNo = txtAlisSeriNo.Text,
                FaturaKesildimi = false,
                Odendimi = false
            };
            var result = _faturaBilgiManager.Add(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void btnAlisGuncelle_Click(object sender, EventArgs e)
        {
            var get = _faturaBilgiManager.Get(int.Parse(txtAlisId.Text));
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = int.Parse(txtAlisId.Text),
                CariId = int.Parse(lookAlisCari.EditValue.ToString()),
                Date = DateTime.Now,
                Time = DateTime.Now,
                PersonelId = int.Parse(lookAlisPersonel.EditValue.ToString()),
                //SiraNo = int.Parse(txtAlisSiraNo.Text),
                TeslimAlan = txtAlisTVeren.Text,
                Tutar = get.Data.Tutar,
                FaturaTuru = "Alış",
                SeriNo = txtAlisSeriNo.Text,
                FaturaKesildimi = get.Data.FaturaKesildimi,
                KacOdendi = get.Data.KacOdendi,
                KacOdenecek = get.Data.KacOdenecek,
                Odendimi = get.Data.Odendimi
            };
            var result = _faturaBilgiManager.Update(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void btnAlisSil_Click(object sender, EventArgs e)
        {
            FaturaBilgi faturaBilgi = new FaturaBilgi
            {
                Id = int.Parse(txtAlisId.Text),
            };
            var result = _faturaBilgiManager.Delete(faturaBilgi);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetAllFaturaBilgi();
            Temizle();
        }

        private void btnAlisTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView2.GetFocusedRow() as FaturaBilgiDetailsDto;
            txtAlisId.Text = selectedRow.Id.ToString();
            txtAlisSaat.Text = selectedRow.Tarih.ToShortTimeString();
            txtAlisTarih.Text = selectedRow.Tarih.ToLongDateString();
            txtAlisTVeren.Text = selectedRow.TeslimAlan;
            lookAlisCari.Text = selectedRow.CariName;
            lookAlisPersonel.Text = selectedRow.PersonelName;
            txtAlisSeriNo.Text = selectedRow.SeriNo.ToString();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            var a = _serviceProvider.GetService<FrmUrunAl>();
            a.secilenCari = lookCari.EditValue.ToString();
            a._cariId = int.Parse(lookCari.EditValue.ToString());
            a._fbId = int.Parse(txtId.Text);
            a.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            GetAllFaturaBilgi();
            GetCariOzet();
            GetPersonelOzet();
            GetSeriNo();
        }
    }
}
