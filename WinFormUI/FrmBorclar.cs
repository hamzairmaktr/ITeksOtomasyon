using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.Mvvm.Native;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class FrmBorclar : Form
    {
        private readonly IBorcService _borcManager;
        private readonly IServiceProvider _serviceProvider;
        public FrmBorclar(IBorcService borcManager, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _borcManager = borcManager;
            _serviceProvider = serviceProvider;
        }

        public int secilenCari = 0;


        void Geciktimi()
        {
            using(Context context = new Context())
            {
                var today = DateTime.Now.Date;
                var overdueBorclar = context.Borclar
                    .Where(borc => DateTime.Compare(today, borc.TeslimTarih) > 0)
                    .ToList();
                foreach (var borc in overdueBorclar)
                {
                    borc.Geciktimi = true;
                }
                context.SaveChanges();
            }
           
        }

        void BorcBitis()
        {
            using (Context context = new Context())
            {
                var silinecekKayitlar = context.Borclar.Where(borc => borc.KacOdenecek == 0).ToList();
                context.Borclar.RemoveRange(silinecekKayitlar);
                context.SaveChanges();
            }
        }

        //Listele
        void GetAll()
        {
            var result = _borcManager.GetBorcDetailAll();
            gridControl1.DataSource = result.Data;

            BorcBitis();
            Geciktimi();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            var frmCariSec = _serviceProvider.GetService<FrmCariSec>();
            frmCariSec.ShowDialog();
        }

        private void FrmBorclar_Load(object sender, EventArgs e)
        {

            GetAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Borc borc = new Borc
            {
                Geciktimi = false,
                VerilisTarih = DateTime.Now,
                TeslimTarih = DateTime.Parse(dateTeslimTarih.Text),
                CariId = secilenCari,
                KacOdendi = 0,
                KacOdenecek = decimal.Parse(txtTutar.Text),
                Odendimi = false,
                Tur = cmbTur.Text,
                Tutar = decimal.Parse(txtTutar.Text)
            };
            var result = _borcManager.Add(borc);
            if (result.Success == true)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAll();
            Temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var frmBorcArti = _serviceProvider.GetRequiredService<FrmBorcArti>();
            frmBorcArti.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            var frm = _serviceProvider.GetRequiredService<FrmBorcTahsil>();
            frm.ShowDialog();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                var selected = gridView1.GetFocusedRow() as BorcDetailsDto;
                txtId.Text = selected.Id.ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Borc borc = new Borc() { Id = int.Parse(txtId.Text) };
            _borcManager.Delete(borc);
            GetAll();
            Temizle();

        }
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Temizle();
            GetAll();
        }

        private void Temizle()
        {
            txtId.Text = null;
            cmbTur.Text = null;
            secilenCari = 0;
            txtTutar.Text = null;
            dateTeslimTarih.Text = null;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var frmBorcOde = _serviceProvider.GetRequiredService<FrmBorcOde>();
            frmBorcOde.ShowDialog();
        }
    }
}
