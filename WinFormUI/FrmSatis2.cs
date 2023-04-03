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
        public static int _cariId;
        public FrmSatis2(int cariID)
        {
            _cariId = cariID;
            InitializeComponent();
        }

        private void FrmSatis2_Load(object sender, EventArgs e)
        {

        }
    }
}
