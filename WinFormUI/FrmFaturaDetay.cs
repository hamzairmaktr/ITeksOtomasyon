using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class FrmFaturaDetay : Form
    {
        private readonly IFaturaDetayService _faturaDetayManager;
        private readonly IFaturaBilgiService _faturaBilgiManager;
        private readonly IServiceProvider _serviceProvider;

        public string secilenCari;
        public int _cariId;
        public int _fbId;

        public FrmFaturaDetay(IFaturaBilgiService faturaBilgiService, IFaturaDetayService faturaDetayService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _faturaDetayManager = faturaDetayService;
            _faturaBilgiManager = faturaBilgiService;
            _serviceProvider = serviceProvider;
        }

        void Listele()
        {
            if (_faturaBilgiManager.Get(_fbId).Data.Tutar > 0)
            {
                var result = _faturaDetayManager.GetAllDetailsDto(_fbId).Data;
                gridControl1.DataSource = result;
                var tutar = _faturaBilgiManager.Get(_fbId).Data.Tutar;
                label2.Text = tutar.ToString();
                var kalanTutar = _faturaBilgiManager.Get(_fbId).Data.KacOdenecek;
                lblOdenecekTutar.Text = kalanTutar.ToString();
            }

        }

        private void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var a = _serviceProvider.GetService<FrmFaturaDetayEkle>();
            a._id = _fbId;
            a.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var result = _serviceProvider.GetRequiredService<FrmSatis2>();
            result._cariId = _cariId;
            result._fbId = _fbId;
            result.ShowDialog();

            FrmSatis2 nakitToptanSatis = new FrmSatis2(_cariId, _fbId);
            nakitToptanSatis.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var result = _faturaDetayManager.GetAllDetailsDto(int.Parse(secilenCari)).Data;
            printDocument1.Print();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
