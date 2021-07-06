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
    public partial class frmEditCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmEditCustomer()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            txt_Name.Text = Program.contact.Name;
            txt_UID.Text = Program.contact.Uid; 
            txt_Phone.Text = Program.contact.Phone;
            txt_Email.Text = Program.contact.Email; 
            txt_AccountID.Text = Program.contact.AccountId.ToString(); 
        }
    }
}