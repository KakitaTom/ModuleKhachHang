using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuleKhachHang.Model;

namespace ModuleKhachHang
{
    public partial class frmCreateCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCreateCustomer()
        {
            InitializeComponent();
        }

        public Contact contact = new Contact();

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            contact.Name = txt_Name.Text;
            contact.Uid = txt_UID.Text;
            contact.Phone = txt_Phone.Text;
            contact.Email = txt_Email.Text;
            contact.AccountId = int.Parse(txt_AccountID.Text);
        }
    }
}