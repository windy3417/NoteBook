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
            //子节点个数为零，则为末节点
            if (e.Node.GetNodeCount(true)==0)
            {
               // 动态实例化窗体
                ObjectHandle objectHandle = Activator.CreateInstance(null, e.Node.Name);
                
                Form f = (Form)objectHandle.Unwrap();
                string tabPageText = f.Text;
                //实例化窗体后，嵌入主窗体
                EmbedForm embedForm = new EmbedForm();
                embedForm.openForm(f, tabPageText, tc_content, sc_main.Panel2);
                //释放选择节点，否则第二次选中时无法触发afterSelect事件
                tv_menu.SelectedNode = null;
            }
            
        }
    }
}
