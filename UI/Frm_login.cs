
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
using Utility.Modle;

namespace NoteBook.UI
{
    public partial class Frm_login : Utility.UI.Frm_login
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 覆写用户名与密码检验方法
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        protected override bool checkPwd(string user, string pwd)
        {
            if (new UserService().loginCheckWithSqlparameters(user, pwd))
            {
               
                return true;
            }

            return false;

        }

        /// <summary>
        /// 管理员信息设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        protected override void adminSetup(object sender, EventArgs eventArgs)
        {
            base.adminSetup(sender,eventArgs);
            using (var db = new NoteBookContext())
            {

                UserModle m = new UserModle();
                m.userID = CurrentUser.userID;
                m.name = CurrentUser.userName;
                m.pwd = Encrypt.Encode(CurrentUser.pwd);
                m.RegistrationDate = DateTime.Now;


                db.Users.Add(m);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                    MessageBox.Show("数据保存错误:" + e.Message + e.InnerException, "数据保存提示");
                    return;
                }
            }
        }
    }
}
