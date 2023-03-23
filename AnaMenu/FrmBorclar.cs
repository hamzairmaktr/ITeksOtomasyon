using Business.Concrete;
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
    public partial class FrmBorclar : Form
    {
        public FrmBorclar()
        {
            InitializeComponent();
        }

        public static int secilenCari=0;

        public FrmBorclar(int result)
        {
            secilenCari = result;
        }

        void Geciktimi()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
        }

        //Listele
        void GetAll()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            var result = borcManager.GetBorcDetailAll();
            gridControl1.DataSource = result.Data;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            FrmCariSec frmCariSec = new FrmCariSec();
            frmCariSec.ShowDialog();
        }

        private void FrmBorclar_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BorcManager borcManager=new BorcManager(new EfBorcDal());
            Borc borc = new Borc
            {
                Geciktimi = false,
                VerilisTarih = DateTime.Now,
                TeslimTarih = DateTime.Now.AddDays(14),
                CariId = secilenCari,
                KacOdendi = 0,
                KacOdenecek=decimal.Parse(txtTutar.Text),
                Odendimi=false,
                Tur=cmbTur.Text,
                Tutar=decimal.Parse(txtTutar.Text)
            };
            var result=borcManager.Add(borc);
            if (result.Success == true)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetAll();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmBorcArti frmBorcArti = new FrmBorcArti();
            frmBorcArti.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FrmBorcEksi frm = new FrmBorcEksi();
            frm.ShowDialog();
        }
    }
}
