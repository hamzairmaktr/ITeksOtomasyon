using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DevExpress.XtraEditors;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            GetPersonel();
            Listele();
        }

        private void Listele()
        {
            NotManager notManager = new NotManager(new EfNotDal());
            gridControl1.DataSource = notManager.GetAll().Data;
        }

        private void GetPersonel()
        {
            PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            lookUpEdit1.Properties.DataSource = personelManager.GetAll().Data;
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Not not = new Not
            {
                Baslik = txtBaslik.Text,
                Date = DateTime.Now,
                Detay = txtDetay.Text,
                Time = DateTime.Now,
                PersonelID = int.Parse(lookUpEdit1.EditValue.ToString()),
                Yapildimi = chkYapildimi.Checked,
            };
            NotManager notManager = new NotManager(new EfNotDal());
            var result = notManager.Add(not);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as NotDetailsDto;
            txtId.Text = selectedRow.Id.ToString();
            txtTarih.Text = selectedRow.Date.ToLongDateString();
            txtSaat.Text = selectedRow.Time.ToLongTimeString();
            txtBaslik.Text = selectedRow.Baslik.ToString();
            lookUpEdit1.Text = selectedRow.PersonelName.ToString();
            chkYapildimi.Checked = selectedRow.Yapildimi;
            txtDetay.Text = selectedRow.Detay.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Not not = new Not
            {
                Id = int.Parse(txtId.Text),
                Baslik = txtBaslik.Text,
                Date = DateTime.Now,
                Detay = txtDetay.Text,
                Time = DateTime.Now,
                PersonelID = int.Parse(lookUpEdit1.EditValue.ToString()),
                Yapildimi = chkYapildimi.Checked,
            };
            NotManager notManager = new NotManager(new EfNotDal());
            var result = notManager.Update(not);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Not not = new Not
            {
                Id = int.Parse(txtId.Text),
            };
            NotManager notManager = new NotManager(new EfNotDal());
            var result = notManager.Delete(not);
            if (result.Success)
            {
                MessageBox.Show(result.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Listele();
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
            Listele();
        }

        private void Temizle()
        {
            txtId.Clear();
            txtTarih.Clear();
            txtSaat.Clear();
            txtBaslik.Clear();
            lookUpEdit1.Clear();
            chkYapildimi.Checked = false;
            txtDetay.Clear();
        }
    }
}
