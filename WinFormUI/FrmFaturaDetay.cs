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
        public static int _fbId;

        public FrmFaturaDetay(string id, int cariId, int fbId)
        {
            _cariId = cariId;
            secilenCari = id;
            _fbId = fbId;
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
            var kalanTutar = fat.Get(int.Parse(secilenCari)).Data.KacOdenecek;
            lblOdenecekTutar.Text = kalanTutar.ToString();
            
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
            FrmSatis2 nakitToptanSatis = new FrmSatis2(_cariId, _fbId);
            nakitToptanSatis.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FaturaDetayManager faturaDetayManager = new FaturaDetayManager(new EfFaturaDetayDal());
            var result = faturaDetayManager.GetAllDetailsDto(int.Parse(secilenCari)).Data;
            printDocument1.Print();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
