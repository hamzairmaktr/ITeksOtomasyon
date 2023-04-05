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
    public partial class FrmSatis2 : Form
    {
        public static int _cariId, _fbId;
        public decimal kalanTutar, odenenTutar, borcaOdenen, nakitOdenen;


        void ListeleKasa()
        {
            KasaManager kasaManager = new KasaManager(new EfKasaDal());
            lookUpEdit1.Properties.DataSource = kasaManager.GetDetailsDto().Data;
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "Name";
        }

        void ListeleHesap()
        {
            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var result = faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = result.Tutar;
            txtKalan.Text = kalanTutar.ToString();
        }

        void ListeleCari()
        {
            CariManager cariManager = new CariManager(new EfCariDal());
            var result = cariManager.GetById(_cariId).Data;
            txtCariId.Text = _cariId.ToString();
            txtCari.Text = result.Ismi.ToString();
        }

        void ListeleBorc()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            lookUpEdit2.Properties.DataSource = borcManager.GetBorcOzetTahsilDTOs().Data;
            lookUpEdit2.Properties.ValueMember = "Id";
            lookUpEdit2.Properties.DisplayMember= "Cari";
        }



        public FrmSatis2(int cariID, int fbId)
        {
            _fbId = fbId;
            _cariId = cariID;
            InitializeComponent();
        }

        private void FrmSatis2_Load(object sender, EventArgs e)
        {
            ListeleKasa();
            ListeleHesap();
            ListeleCari();
            ListeleBorc();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KasaManager kasaManager = new KasaManager(new EfKasaDal());
            var result = kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            decimal kasaTutar = decimal.Parse(txtKasaTutar.Text);
            decimal bakiye = result.Bakiye + kasaTutar;
            result.Bakiye = bakiye;

            var result2 = kasaManager.Update(result);

            if (result2.Success)
            {
                MessageBox.Show(result2.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FaturaBilgiManager faturaBilgiManager = new FaturaBilgiManager(new EfFaturaBilgiDal());
            var result3 = faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = kalanTutar - decimal.Parse(txtKasaTutar.Text);
            result3.Tutar = kalanTutar;
            faturaBilgiManager.Update(result3);
            ListeleHesap();
            ListeleKasa();

            odenenTutar = odenenTutar + kasaTutar;
            nakitOdenen = nakitOdenen + kasaTutar;

            txtOdenen.Text = odenenTutar.ToString();
            txtNakit.Text = nakitOdenen.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            
        }
    }
}
