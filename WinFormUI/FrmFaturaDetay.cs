using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
        public static string secilenCari = "";
        public static int _cariId;

        public FrmFaturaDetay(string id, int cariId)
        {
            _cariId = cariId;
            secilenCari = id;
            InitializeComponent();
        }

        void Listele()
        {
            FaturaDetayManager faturaDetayManager = new FaturaDetayManager(new EfFaturaDetayDal());
            var result = faturaDetayManager.GetAllDetailsDto(int.Parse(secilenCari)).Data;
            gridControl1.DataSource = result;
            FaturaBilgiManager fat = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var tutar = fat.Get(int.Parse(secilenCari)).Data.Tutar;
            label2.Text = tutar.ToString();
        }

        private void FrmFaturaDetay_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmFaturaDetayEkle frmFaturaDetayEkle = new FrmFaturaDetayEkle(int.Parse(secilenCari));
            frmFaturaDetayEkle.ShowDialog();
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
            FrmSatis2 nakitToptanSatis = new FrmSatis2(_cariId);
            nakitToptanSatis.ShowDialog();
        }
    }
}
