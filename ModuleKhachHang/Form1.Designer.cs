
namespace ModuleKhachHang
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Customer = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.rbCustomer = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pn_Main = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Customer
            // 
            this.btn_Customer.ExpandCollapseItem.Id = 0;
            this.btn_Customer.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Customer.ExpandCollapseItem,
            this.btn_Customer.SearchEditItem,
            this.btnCustomer});
            this.btn_Customer.Location = new System.Drawing.Point(0, 0);
            this.btn_Customer.MaxItemId = 3;
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbCustomer});
            this.btn_Customer.Size = new System.Drawing.Size(758, 158);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Caption = "Khách hàng";
            this.btnCustomer.Id = 2;
            this.btnCustomer.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCustomer.ImageOptions.SvgImage")));
            this.btnCustomer.LargeWidth = 100;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomer_ItemClick);
            // 
            // rbCustomer
            // 
            this.rbCustomer.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Text = "Customer";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCustomer);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // pn_Main
            // 
            this.pn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Main.Location = new System.Drawing.Point(0, 158);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(758, 202);
            this.pn_Main.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 360);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.btn_Customer);
            this.Name = "Form1";
            this.Ribbon = this.btn_Customer;
            this.Text = "Module Customer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pn_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl btn_Customer;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbCustomer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl pn_Main;
        private DevExpress.XtraBars.BarButtonItem btnCustomer;
    }
}

