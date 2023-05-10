using Business.Abstract;
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
        private readonly IPersonelService _personelManager;
        private readonly INotService _notManager;

        public FrmNotlar(IPersonelService personelManager, INotService notManager)
        {
            InitializeComponent();
            _notManager = notManager;
            _personelManager = personelManager;
        }

        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            GetPersonel();
            Listele();
        }

        private void Listele()
        {
            gridControl1.DataSource = _notManager.GetAll().Data;
        }

        private void GetPersonel()
        {
            lookUpEdit1.Properties.DataSource = _personelManager.GetAll().Data;
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
                Onem = comboBoxEdit1.Text
            };
            var result = _notManager.Add(not);
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
            comboBoxEdit1.Text = selectedRow.Onem.ToString();
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
                Onem = comboBoxEdit1.Text
            };
            var result = _notManager.Update(not);
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
            var result = _notManager.Delete(not);
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
