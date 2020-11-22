using NoteBook.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
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

            if (e.Node.Level==1)
            {
                ObjectHandle objectHandle = Activator.CreateInstance(null, e.Node.Name);

                Form f = (Form)objectHandle.Unwrap();
                string tabPageText = f.Text;
                EmbedForm embedForm = new EmbedForm();
                embedForm.openForm(f, tabPageText, tc_content, sc_main.Panel2);
            }
            
        }
    }
}
