using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace UIWinForm.Report
{
    public partial class Fatura : DevExpress.XtraReports.UI.XtraReport
    {

        public Fatura(int id)
        {
            InitializeComponent();
            faturaId.Value = id;
        }
    }
}
