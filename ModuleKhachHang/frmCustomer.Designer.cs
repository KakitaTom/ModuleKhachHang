
namespace ModuleKhachHang
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_del = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_Customer = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txt_getID = new System.Windows.Forms.TextBox();
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(616, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 33);
            this.label4.TabIndex = 28;
            this.label4.Text = "Khách hàng";
            // 
            // btn_edit
            // 
            this.btn_edit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_edit.ImageOptions.SvgImage")));
            this.btn_edit.Location = new System.Drawing.Point(241, 58);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(95, 43);
            this.btn_edit.TabIndex = 25;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_del
            // 
            this.btn_del.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_del.ImageOptions.SvgImage")));
            this.btn_del.Location = new System.Drawing.Point(140, 58);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(95, 43);
            this.btn_del.TabIndex = 26;
            this.btn_del.Text = "Xoá";
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_add
            // 
            this.btn_add.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_add.ImageOptions.SvgImage")));
            this.btn_add.Location = new System.Drawing.Point(39, 58);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(95, 43);
            this.btn_add.TabIndex = 27;
            this.btn_add.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(39, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1263, 2);
            this.label3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1263, 2);
            this.label1.TabIndex = 20;
            // 
            // gc_Customer
            // 
            this.gc_Customer.Location = new System.Drawing.Point(37, 109);
            this.gc_Customer.MainView = this.gridView1;
            this.gc_Customer.Name = "gc_Customer";
            this.gc_Customer.Size = new System.Drawing.Size(1265, 362);
            this.gc_Customer.TabIndex = 29;
            this.gc_Customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_Customer;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // txt_getID
            // 
            this.txt_getID.ForeColor = System.Drawing.Color.Black;
            this.txt_getID.Location = new System.Drawing.Point(689, 563);
            this.txt_getID.Name = "txt_getID";
            this.txt_getID.Size = new System.Drawing.Size(100, 21);
            this.txt_getID.TabIndex = 30;
            // 
            // btn_exit
            // 
            this.btn_exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_exit.ImageOptions.SvgImage")));
            this.btn_exit.Location = new System.Drawing.Point(342, 58);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 43);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 586);
            this.Controls.Add(this.txt_getID);
            this.Controls.Add(this.gc_Customer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton btn_del;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_Customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txt_getID;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
    }
}