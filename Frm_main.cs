using NoteBook.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;
using Utility.UI;

namespace NoteBook
{
    public partial class Frm_main : Form
    {
        public Frm_main()
        {
            InitializeComponent();
        }

        private void tv_menu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Frm_record v = new Frm_record();
            string tabPageText = v.Text;
            EmbedForm embedForm = new EmbedForm();
            embedForm.openForm(v, tabPageText, tc_content, sc_main.Panel2);
        }
    }
}
