using NoteBook.DAL;
using NoteBook.EventArguments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NoteBook.Modle;
using System.IO;

namespace NoteBook.UI.List
{
    public partial class Frm_recordRef : Form
    {
        public Frm_recordRef()
        {
            InitializeComponent();
            initializeControlState();
            
        }

        #region 初始化控件

        private void initializeControlState()
        {
            dgv_recordRef.AutoGenerateColumns = false;
            this.StartPosition = FormStartPosition.CenterScreen;

        }        


        void intializeControlsDataSource()
        {

            using (var db = new NoteBookContext())
            {

              
                var query = from q in new RecordService().GetNoteRecordRefList()
                            join u in new UserService().getUserList() on q.requesteUserID equals u.userID
                            select new
                            {
                                q.requesteDate,
                                u.name,
                                q.voucherNo,
                                q.itemName
                                
                            };

                this.ColumnRequesteDate.DataPropertyName = "requesteDate";
                this.ColumnVoucherNo.DataPropertyName = "voucherNo";
                this.ColumnReuquestName.DataPropertyName = "name";
                this.ColumnItemName.DataPropertyName = "itemName";

                dgv_recordRef.DataSource = query.ToList();

            }


        }


        #endregion

        //使用该委托进行数据传递待探究→何时触发传递？与事件写法一致
        public Action< string> ActionRecord;

        
             #region 内部方法


        private static void logWrite(List<string> lt)
        {
            string path = @"MyTest2.txt";

            //Create the file.
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (String LT in lt)

                        sw.WriteLine("{0}\t,{1}", DateTime.Now.ToString(), LT);

                }
            }
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="logString"></param>
        private static void logWrite(string logString)
        {
            string path = @"MyTest2.txt";

            //Create the file.
            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                   

                        sw.WriteLine("{0}\t,{1}", DateTime.Now.ToString(), logString);

                }
            }
        }
        #endregion

        /// <summary>
        /// 先显示窗体，再加载数据，以告诉用户程序在响应当中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_recordRef_Shown(object sender, EventArgs e)
        {
                       
            intializeControlsDataSource();
           
        }

        private void tsb_certain_Click(object sender, EventArgs e)
        {
            if (dgv_recordRef.SelectedRows.Count>=0)
            {
                if (ActionRecord!=null)
                {
                    ActionRecord.Invoke(dgv_recordRef.CurrentRow.Cells["ColumnVoucherNo"].Value.ToString());
                }

                this.Close();
               
                
            }
        }


        
    }
}
