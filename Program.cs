﻿using NoteBook.UI;
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
            Frm_login frm_Login = new Frm_login();

            frm_Login.ShowDialog();
            if (frm_Login.DialogResult == DialogResult.OK)
            {
                Application.Run(new Frm_main());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
