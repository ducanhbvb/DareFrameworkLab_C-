using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DareFrameworkLab
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        
        private void btn_Grid_MergeColum_Click(object sender, EventArgs e)
        {
            FrmGridviewMergeColumn frmGrid_Master = new FrmGridviewMergeColumn();
            frmGrid_Master.Show();
        }

        private void btn_Grid_Select_Option_Click(object sender, EventArgs e)
        {
            FrmGrid_Select_Option frm = new FrmGrid_Select_Option();
            frm.Show();
        }
    }
}
