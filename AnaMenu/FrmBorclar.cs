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

        //Listele
        void GetAll()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            var result = borcManager.GetBorcDetailAll();
            gridControl1.DataSource = result.Data;
        }

        //Ekle
        void Add()
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            Borc borc = new Borc()
            {

            };
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

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FrmBorcArti frmBorcArti = new FrmBorcArti();
            frmBorcArti.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FrmBorcEksi frm=new FrmBorcEksi();
            frm.ShowDialog();
        }
    }
}
