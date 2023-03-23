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
    public partial class FrmBorcArti : Form
    {
        public FrmBorcArti()
        {
            InitializeComponent();
        }

        private void FrmBorcArti_Load(object sender, EventArgs e)
        {
            CariManager cariManager = new CariManager(new EfCariDal());
            gridControl2.DataSource = cariManager.GetCariOzetDtos().Data;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selectedRow = gridView2.GetFocusedRow() as CariOzetDtos;
            txtCariId.Text = selectedRow.Id.ToString();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            
        }
    }
}
