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

namespace NoteBook.UI.List
{
    public partial class Frm_recordRef : Form
    {
        public Frm_recordRef()
        {
            InitializeComponent();
            initializeControlState();
            intializeControlsDataSource();
        }

        //#region 自定义事件

        ///// <summary>
        ///// 定义事件
        ///// </summary>
        //public event EventHandler<CoordinationEventArgs> Coordination;




        ///// <summary>
        ///// 事件处理方法
        ///// 调用端实例化事件委托后就执行该方法
        ///// authorizPass?本质上相当于执行方法时的第二次判断
        ///// 引发事件是执行事件处理方法的第一次判断
        ///// </summary>
        ///// <param name="authorizationEventArgs"></param>
        //protected virtual void onCoordination(CoordinationEventArgs coordinationEventArgs)
        //{
        //    authorizPass?.Invoke(this, authorizationEventArgs);
        //}



        ///// <summary>
        ///// 引发事件
        ///// 双击元格则传送数据给协同处理表
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dgv_recordRef_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    //引发事件并传递事件包含的数据，该事件检验用户名密码是否正确
        //    CoordinationEventArgs coordinationEventArgs = new CoordinationEventArgs();
        //    authorizationEventArgs.userAndPwdRight = true;
        //    onAuthorizPass(authorizationEventArgs);

        //    this.Close();




        //}

        //#endregion


        private void initializeControlState()
        {
            dgv_recordRef.AutoGenerateColumns = false;
        }

        //void InitializeControlDataSource()
        //{
        //    List<NoteRecordModle> noteRecordList = new RecordService().GetNoteRecordList();
        //    dgv_recordRef.DataSource = noteRecordList;
            
        //}

        void intializeControlsDataSource()
        {
            using (var db = new NoteBookContext())
            {
                var query = from q in new RecordService().GetNoteRecordList()
                            join u in db.Users on q.userID equals u.userID
                            select new { q.requesteDate, q.voucherNo, q.itemName  , u.name };


                dgv_recordRef.DataSource = query.ToList();

            }
        }

    }
}
