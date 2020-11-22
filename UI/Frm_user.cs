using NoteBook.DAL;
using NoteBook.Modle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;

namespace NoteBook.UI
{
    public partial class Frm_user : Utility.UI.Frm_baseUser
    {
        public Frm_user()
        {
            InitializeComponent();
        }

        #region 变量

        //新增时,dataGridview绑定的数据源，以体现新增的结果
        List<UserModle> mList = new List<UserModle>();
        #endregion

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
    }


}

