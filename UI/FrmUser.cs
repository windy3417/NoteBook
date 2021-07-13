using NoteBook.DAL;
using NoteBook.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace NoteBook.UI
{
    public partial class FrmUser : Utility.UI.Frm_baseUser
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        #region 变量

        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<UserModle> mList = new List<UserModle>();
        #endregion

        #region 菜单事件
        /// <summary>
        /// 保存单据
        /// </summary>
        protected override void saveDate()
        {
            using (var db = new NoteBookContext())
            {

                UserModle m = new UserModle();
                m.userID = base.txt_userID.Text;
                m.name = base.txt_userName.Text;
                m.pwd = Encrypt.Encode(base.txt_pwd.Text);
                m.RegistrationDate = Convert.ToDateTime(base.tbd_effect.Text);
                if (base.tbd_failure.Text != null & base.tbd_failure.Text != "")
                {
                    m.DateOfCancellation = Convert.ToDateTime(base.tbd_failure.Text);
                }


                db.Users.Add(m);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据保存错误:" + ex.Message + ex.InnerException, "数据保存提示");
                    return;
                }

                mList.Add(m);



            }



        }

        /// <summary>
        /// 查询单据列表
        /// </summary>
        protected override void queryDate()
        {
            base.queryDate();
            bind_gv_dateSourceForQery();


                     
            if (base.dgv_person.Rows.Count > 0)
            {
                this.dgv_person.Rows[0].Selected = true;
            }

        }

        #endregion


        /// <summary>
        /// 查询数据源绑定
        /// </summary>
        private void bind_gv_dateSourceForQery()
        {
            this.dgv_person.DataSource = null;

            //查询状态的数据源


            base.dgv_person.DataSource = new NoteBookContext().Users.ToList<UserModle>();

            //新增状态的数据源


            //this.dataGridView1.DataSource = mList;



            //以下为直接使用ADO.NET 连接
            // CustomerService customerService = new CustomerService();
            //customerList= customerService.getCustomerList();
            // this.dataGridView1.DataSource = null;
            // this.dataGridView1.DataSource = customerList;

        }
    }


}

