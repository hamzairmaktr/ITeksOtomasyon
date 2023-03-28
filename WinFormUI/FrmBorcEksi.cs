using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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
    public partial class FrmBorcEksi : Form
    {
        public FrmBorcEksi()
        {
            InitializeComponent();
        }

        private void FrmBorcEksi_Load(object sender, EventArgs e)
        {
            BorcManager borcManager = new BorcManager(new EfBorcDal());
            gridControl1.DataSource = borcManager.GetBorcOzetDTOs().Data;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView1.GetFocusedRow() as BorcOzetDto;
            txtId.Text=selectedRow.Id.ToString();
            txtCariId.Text=selectedRow.CariId.ToString();
        }
    }
}
