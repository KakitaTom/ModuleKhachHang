using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ModuleKhachHang
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pn_Main.Controls.Clear();

            var frm = new frmCustomer() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};

            pn_Main.Controls.Add(frm);
            frm.Show();
        }
    }
}
