using AnaMenu;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class FrmCariSec : Form
    {
        private readonly ICariService _cariManager;
        private readonly IServiceProvider _serviceProvider;
        public FrmCariSec(ICariService cariManager, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _cariManager = cariManager;
            _serviceProvider = serviceProvider;
        }

        private void FrmCariSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = _cariManager.GetCariOzetDtos().Data;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {




        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var selected = gridView1.GetFocusedRow() as CariOzetDtos;
            label1.Text = selected.Id.ToString();
        }

        private void FrmCariSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Form1 form1 = new Form1();
            FrmBorclar frmBorclar = new FrmBorclar();
            frmBorclar.MdiParent = form1;
            frmBorclar.Show();
            this.Close();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = int.Parse(label1.Text);
            label2.Text = result.ToString();
            //FrmBorclar frmBorclar = new FrmBorclar(result);
            var frmBorclar = _serviceProvider.GetRequiredService<FrmBorclar>();
            frmBorclar.secilenCari = result;

        }
    }
}
