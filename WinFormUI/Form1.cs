using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UIWinForm;

namespace AnaMenu
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly IServiceProvider _serviceProvider;

        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            var frmPersoneller = _serviceProvider.GetService<FrmPersoneller>();
            frmPersoneller.MdiParent = this;
            frmPersoneller.Show();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBankalar = _serviceProvider.GetService<FrmBankalar>();
            frmBankalar.MdiParent = this;
            frmBankalar.Show();
        }

        FrmGider frmGider;
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmGider == null)
            {
                frmGider = new FrmGider();
                frmGider.MdiParent = this;
                frmGider.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmBorclar = _serviceProvider.GetService<FrmBorclar>();
            frmBorclar.MdiParent = this;
            frmBorclar.Show();

        }


        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmCariler = _serviceProvider.GetService<FrmCariler>();
            frmCariler.MdiParent = this;
            frmCariler.Show();

        }

        FrmKasa frmKasa;
        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmKasa == null)
            {
                frmKasa = new FrmKasa();
                frmKasa.MdiParent = this;
                frmKasa.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmUrunler = _serviceProvider.GetService<FrmUrunler>();
            frmUrunler.MdiParent = this;
            frmUrunler.Show();

        }

        FrmNotlar frmNotlar;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmNotlar == null)
            {
                frmNotlar = new FrmNotlar();
                frmNotlar.MdiParent = this;
                frmNotlar.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmFaturalar = _serviceProvider.GetService<FrmFaturalar>();
            frmFaturalar.MdiParent = this;
            frmFaturalar.Show();

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
