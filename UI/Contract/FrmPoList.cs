using NoteBook.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NoteBook.UI.Contract
{
    public partial class FrmPoList : Form
    {
        public FrmPoList()
        {
            InitializeComponent();
            this.FormClosed += closeParentForm;
        }

        private void closeParentForm(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbQueryPO_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                using (var db=new ManageContext())
                {
                    var q = db.xm_plug_v_POList.ToList();
                    dataGridView1.DataSource = q;
                    Utility.Style.StyleDataGridView styleDataGridView = new Utility.Style.StyleDataGridView();
                    this.Cursor = Cursors.Default;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message + ex.InnerException,"订单查询出错",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Utility.Style.StyleDataGridView style = new Utility.Style.StyleDataGridView();
            style.DisplayRowNo(e, dataGridView1);
        }
    }
}
