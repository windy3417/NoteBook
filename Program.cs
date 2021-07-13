using NoteBook.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NoteBook
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin frm_Login = new FrmLogin();

            frm_Login.ShowDialog();
            if (frm_Login.DialogResult == DialogResult.OK)
            {
                Application.Run(new FrmMain());
            }
            else
            {
                Application.Exit();
            }

            //FrmMain frmMain = new FrmMain();
            //frmMain.Show();

            //Application.Run(new FrmMain());

        }
    }
}
