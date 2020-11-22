using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteBook.UI
{
    public partial class Frm_record : Form
    {
        public Frm_record()
        {
            InitializeComponent();
        }

        void initalizeControlState()
        {
            this.FormClosed +=new FormClosedEventHandler( Frm_record_FormClosed);
        }

        private void Frm_record_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }
    }
}
