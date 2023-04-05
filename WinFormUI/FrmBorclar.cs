using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.Mvvm.Native;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
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

        public static int secilenCari = 0;

        public FrmBorclar(int result)
        {
            secilenCari = result;
        }

        void Geciktimi()
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Borclar set Geciktimi=1 where DateDiff(day,TeslimTarih,GetDate())>0", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        void BorcBitis()
        {
            SqlConnection con = new SqlConnection("Server=.\\SQLEXPRESS;Database=ITeksOtomasyon;Trusted_Connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Borclar where KacOdenecek=0", con);
            cmd.ExecuteNonQuery();
            con.Close();
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
            BorcBitis();
            Geciktimi();
            GetAll();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
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
            var result = borcManager.Add(borc);
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
            FrmBorcArti frmBorcArti = new FrmBorcArti();
            frmBorcArti.ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FrmBorcTahsil frm = new FrmBorcTahsil();
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
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            Borc borc = new Borc() { Id = int.Parse(txtId.Text) };
            borcManager.Delete(borc);
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
            FrmBorcOde frmBorcOde= new FrmBorcOde();
            frmBorcOde.ShowDialog();
        }
    }
}
