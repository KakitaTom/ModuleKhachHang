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
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        private Contact contact = new Contact();
        private akabiz_contactEntities db = new akabiz_contactEntities();

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void BindingGC()
        {
            gc_Customer.DataSource = db.Contacts.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (var frm = new frmCreateCustomer())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    contact.Name = frm.contact.Name;
                    contact.Uid = frm.contact.Uid;
                    contact.Phone = frm.contact.Phone;
                    contact.Email = frm.contact.Email;
                    contact.AccountId = frm.contact.AccountId;

                    db.Contacts.Add(contact);
                    int result = db.SaveChanges();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại");
                    }
                }
                BindingGC();
                BindingID();
            }
        }


        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindingGC();
            BindingID();
        }

        private void BindingID()
        {
            txt_getID.DataBindings.Clear();
            txt_getID.DataBindings.Add("text", gc_Customer.DataSource, "Id");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txt_getID.Text);

            var contactInDb = db.Contacts.SingleOrDefault(c => c.Id == id);

            if (contactInDb != null)
            {
                db.Contacts.Remove(contactInDb);
                db.SaveChanges();

                MessageBox.Show("Xoa thành công");
                BindingGC();
                BindingID();
                return;
            }

            MessageBox.Show("Xoa thất bại");

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txt_getID.Text);

            var contactInDb = db.Contacts.SingleOrDefault(c => c.Id == id);

            if (contactInDb != null)
            {
                Program.contact = contactInDb;

                using (var frm = new frmEditCustomer())
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        contactInDb.Name = frm.contact.Name;
                        contactInDb.Uid = frm.contact.Uid;
                        contactInDb.Phone = frm.contact.Phone;
                        contactInDb.Email = frm.contact.Email;
                        contactInDb.AccountId = frm.contact.AccountId;

                        int result = db.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }
                }
            }
            BindingGC();
            BindingID();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}