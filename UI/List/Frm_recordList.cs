using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NoteBook.UI.List
{
    public partial class Frm_recordList : ScrapSettlement.UI.Frm_voucherList
    {
        public Frm_recordList()
        {
            InitializeComponent();
            initializeControlState();
        }

        #region 初化控件 
        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initializeControlState()
        {
            //初始化dataGridView
            DataGridViewTextBoxColumn vocherNO = new DataGridViewTextBoxColumn();
            vocherNO.HeaderText = "项目编号";
            DataGridViewTextBoxColumn itemName = new DataGridViewTextBoxColumn();
            itemName.HeaderText = "项目名称";
            DataGridViewTextBoxColumn makeDate = new DataGridViewTextBoxColumn();
            makeDate.HeaderText = "记录日期";
            DataGridViewTextBoxColumn userID = new DataGridViewTextBoxColumn();
            userID.HeaderText = "记录人";
            
            DataGridViewTextBoxColumn requestePerson = new DataGridViewTextBoxColumn();
            requestePerson.HeaderText = "申请人";
            DataGridViewTextBoxColumn responsiblePerson = new DataGridViewTextBoxColumn();
            responsiblePerson.HeaderText = "责任人";
            DataGridViewTextBoxColumn requesterDate = new DataGridViewTextBoxColumn();
            requesterDate.HeaderText = "申请日期";
            DataGridViewTextBoxColumn needCompleteDate = new DataGridViewTextBoxColumn();
            needCompleteDate.HeaderText = "要求完成日期";
            DataGridViewTextBoxColumn planCompleteDate = new DataGridViewTextBoxColumn();
            planCompleteDate.HeaderText = "预计完成日期";

            base.dgv_content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {

            vocherNO,itemName,makeDate,userID,requestePerson,responsiblePerson,requesterDate,needCompleteDate,planCompleteDate

            }
            );
        }

        #endregion



    }
    
}
