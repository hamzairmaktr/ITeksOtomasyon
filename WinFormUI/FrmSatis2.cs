using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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

        private readonly IKasaService _kasaManager;
        private readonly IBorcService _borcManager;
        private readonly IFaturaBilgiService _faturaBilgiManager;
        private readonly ICariService _cariManager;
        public int _cariId, _fbId;

        public FrmSatis2(IKasaService kasaManager, IBorcService borcManager, IFaturaBilgiService faturaBilgiManager, ICariService cariManager)
        {
            _borcManager = borcManager;
            _faturaBilgiManager = faturaBilgiManager;
            _kasaManager = kasaManager;
            _cariManager = cariManager;

        }


       
        public decimal kalanTutar, odenenTutar, borcaOdenen, nakitOdenen;
        private bool borcVarmi = false;

        void YeniBorcEkle()
        {
            var result3 = _faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = kalanTutar - decimal.Parse(txtTutar.Text);
            result3.KacOdenecek = kalanTutar;
            result3.KacOdendi = result3.Tutar - result3.KacOdenecek;
            var result4 = _faturaBilgiManager.Update(result3);

            decimal kacOdenecek = decimal.Parse(txtTutar.Text);
            var result = _borcManager.AddBorcFatura(new Borc
            {
                CariId = _cariId,
                Geciktimi = false,
                KacOdendi = 0,
                KacOdenecek = kacOdenecek,
                Odendimi = false,
                TeslimTarih = dateEdit2.DateTime,
                Tur = "Alacak",
                Tutar = kacOdenecek,
                VerilisTarih = DateTime.Now,
            },result3);
            if (result.Success && result4.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                borcaOdenen = borcaOdenen + kacOdenecek;

                txtBorc.Text = borcaOdenen.ToString();
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        void BorcaEkle()
        {
            var result3 = _faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = kalanTutar - decimal.Parse(txtTutar.Text);
            result3.KacOdenecek = kalanTutar;
            result3.KacOdendi = result3.Tutar - result3.KacOdenecek;
            var result4 = _faturaBilgiManager.Update(result3);

            var result = _borcManager.GetByCariId(_cariId).Data;
            decimal kacOdenecek = decimal.Parse(txtTutar.Text) + result.KacOdenecek;
            var result2 = _borcManager.UpdateMoney(new Borc
            {
                Id = result.Id,
                CariId = _cariId,
                Geciktimi = false,
                KacOdendi = result.KacOdendi,
                KacOdenecek = kacOdenecek,
                Odendimi = false,
                TeslimTarih = dateEdit2.DateTime,
                Tur = "Alacak",
                Tutar = decimal.Parse(txtTutar.Text) + result.Tutar,
                VerilisTarih = DateTime.Now,
            },result3);
            if (result2.Success && result4.Success)
            {
                MessageBox.Show(result2.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                borcaOdenen = borcaOdenen + decimal.Parse(txtTutar.Text);

                txtBorc.Text = borcaOdenen.ToString();
            }
            else
            {
                MessageBox.Show(result2.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ListeleKasa()
        {
            lookUpEdit1.Properties.DataSource = _kasaManager.GetDetailsDto().Data;
            lookUpEdit1.Properties.ValueMember = "Id";
            lookUpEdit1.Properties.DisplayMember = "Name";
        }

        void ListeleHesap()
        {
            var result = _faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = result.KacOdenecek;
            txtKalan.Text = kalanTutar.ToString();
            txtOdenen.Text = result.KacOdendi.ToString();
        }

        void ListeleCari()
        {
            var result = _cariManager.GetById(_cariId).Data;
            txtCariId.Text = _cariId.ToString();
            txtCari.Text = result.Ismi.ToString();

        }

        void ListeleBorc()
        {
            var result = _borcManager.GetByCariId(_cariId).Data;
            if (result != null)
            {
                var result2 = _borcManager.GetById(result.Id).Data;

                MessageBox.Show("Seçilen carinin hali hazırda borcu var", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                borcVarmi = true;
                lblBorc.Text = result.KacOdenecek.ToString();
                lblBorcTur.Text = result.Tur;
                dateEdit2.Text = result2.TeslimTarih.ToShortDateString();
            }
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

        //Nakit satış
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var result = _kasaManager.GetById(int.Parse(lookUpEdit1.EditValue.ToString())).Data;
            decimal kasaTutar = decimal.Parse(txtKasaTutar.Text);
            decimal bakiye = result.Bakiye + kasaTutar;
            result.Bakiye = bakiye;



            var result3 = _faturaBilgiManager.Get(_fbId).Data;
            kalanTutar = kalanTutar - decimal.Parse(txtKasaTutar.Text);
            result3.KacOdenecek = kalanTutar;
            result3.KacOdendi = result3.Tutar - result3.KacOdenecek;

            var result2 = _kasaManager.UpdateMoney(result, result3);
            var result4 = _faturaBilgiManager.Update(result3);

            if (result2.Success && result4.Success)
            {
                MessageBox.Show(result2.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(result4.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                nakitOdenen = nakitOdenen + kasaTutar;

                
                txtNakit.Text = nakitOdenen.ToString();
            }
            else
            {
                MessageBox.Show(result4.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListeleHesap();
            ListeleKasa();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (borcVarmi == true)
            {
                BorcaEkle();
            }
            else
            {
                YeniBorcEkle();
            }
            ListeleHesap();
            ListeleBorc();
        }
    }
}
