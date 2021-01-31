using NoteBook.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility.UI;
using NoteBook.Modle;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace NoteBook.UI.List
{
    public partial class Frm_recordList : Utility.UI.Frm_voucherList
    {
        public Frm_recordList()
        {
            InitializeComponent();
            initializeControlState();
        }

        DataGridViewTextBoxColumn ColumnvoucherNO = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnUserName = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnitemName = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnRequestePerson = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnRequesterDate = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnRecord = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnMakeDate = new DataGridViewTextBoxColumn();


        DataGridViewTextBoxColumn ColumnResponsiblePerson = new DataGridViewTextBoxColumn();
        DataGridViewTextBoxColumn ColumnNeedCompleteDate = new DataGridViewTextBoxColumn();

        DataGridViewTextBoxColumn ColumnPlanCompleteDate = new DataGridViewTextBoxColumn();
        #region 初化控件 
        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initializeControlState()
        {
            //初始化dataGridView

            ColumnvoucherNO.HeaderText = "项目编号";

            ColumnitemName.HeaderText = "项目名称";

            ColumnRequesterDate.HeaderText = "申请日期";

            ColumnRecord.HeaderText = "需求描述";

            ColumnMakeDate.HeaderText = "记录日期";

            ColumnUserName.HeaderText = "记录人";
            ColumnRequestePerson.HeaderText = "申请人";
            ColumnResponsiblePerson.HeaderText = "责任人";
            ColumnNeedCompleteDate.HeaderText = "要求完成日期";
            ColumnPlanCompleteDate.HeaderText = "预计完成日期";

            //初始标题
            base.lbl_titel.Text = "协同单据列表";
            base.dgv_content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            { ColumnvoucherNO,ColumnitemName,ColumnMakeDate,ColumnUserName,ColumnRequestePerson,ColumnResponsiblePerson
            ,ColumnRequesterDate,ColumnNeedCompleteDate,ColumnPlanCompleteDate }); 


        }

        void InitializeControlsDataSource()
        {

        }

        #endregion

        #region 查询删除

        protected override void deleteVoucher(string voucherNO)
        {
            base.deleteVoucher(voucherNO);
        }

        /// <summary>
        /// 穿透查询
        /// </summary>
        /// <param name="voucherNo"></param>
        protected override void queryVoucher(string voucherNo)
        {
            try
            {
                using (var db = new NoteBookContext())
                {
                    //var query=from q in db.NoteRecords
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 查询单据列表
        /// </summary>
        protected override void qeuryVoucherList()
        {
            using (var db = new NoteBookContext())
            {
                //得到申请人姓名
                var query1 = from q in db.NoteRecords
                             join u in db.Users on q.requesteUserID equals u.userID
                             select new
                             {
                                 q.voucherNo,
                                 requestPersonName = u.name
                             };
                //得到责任人改名
                var query2 = from q in db.NoteRecords
                             join u in db.Users on q.responsibleUserID equals u.userID
                             select new
                             {
                                 q.voucherNo,
                                 resoponsiblePersonName = u.name
                             };
                var query = from q in db.NoteRecords
                            join u in db.Users on q.userID equals u.userID
                            join r in query1 on q.voucherNo equals r.voucherNo
                            join p in query2 on q.voucherNo equals p.voucherNo
                            select new
                            {
                                q.voucherNo,
                                q.itemName,
                                q.makeTime,
                                u.name,
                                r.requestPersonName,
                                q.requesteDate,
                                p.resoponsiblePersonName,
                                q.recorder,
                                q.needCompletedDate,
                                q.planCompletedDate
                            };

                ColumnvoucherNO.Name = "voucherNo";
                ColumnvoucherNO.DataPropertyName = "voucherNo";

                this.ColumnitemName.Name = "itemName";
                ColumnitemName.DataPropertyName = "itemName";

                this.ColumnUserName.DataPropertyName = "name";
                this.ColumnRequestePerson.DataPropertyName = "requestPersonName";
                this.ColumnResponsiblePerson.DataPropertyName = "resoponsiblePersonName";
                ColumnRecord.DataPropertyName = "recorder";
                ColumnMakeDate.DataPropertyName = "makeTime";
                ColumnRequesterDate.DataPropertyName = "requesteDate";
                ColumnNeedCompleteDate.DataPropertyName = "needCompletedDate";
                ColumnPlanCompleteDate.DataPropertyName = "planCompletedDate";

                base.dgv_content.DataSource = query.ToList();

            }
        }

        #endregion

    }

}
