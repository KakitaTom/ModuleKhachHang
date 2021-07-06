using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ModuleKhachHang.Model;

namespace ModuleKhachHang
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Contact contact = new Contact();
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
