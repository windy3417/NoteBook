﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NoteBook.Modle;
using System.Data;
using System.Data.SqlClient;
using static Utility.Sql.Sqlhelper;
using Utility.Model;

namespace NoteBook.DAL
{
    class UserService
    {
        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public List<UserModle> getUserList()
        {
            List<UserModle> listUser = new List<UserModle>();
            string sql = "select  *  from  [user] where 1=@queryAll   ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@queryAll",1 )
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql,
                DataSourceType.business, sqlParameters);
            while (sqlDataReader.Read())
            {
                UserModle m = new UserModle();
                m.userID = sqlDataReader["userID"].ToString();
                m.name = sqlDataReader["name"].ToString();




                listUser.Add(m);
            }
            return listUser;
        }


        /// <summary>
        /// 检测登录密码与用户名,使用EF
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheck(string userID, string pwd)
        {
            using (var db = new NoteBookContext())
            {

                var q = db.Users.Where(s => s.userID == userID & s.pwd == pwd).ToList();
                if (q.Count > 0)
                {
                    foreach (var item in q)
                    {
                        CurrentUser.userID = item.userID;
                        CurrentUser.userName = item.name;
                    }
                 
                    return true;
                }
                else
                {
                    return false;
                }
            }


        }

        /// <summary>
        /// 使用Sqlparameters检测登录密码与用户名
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool loginCheckWithSqlparameters(string userID, string pwd)
        {
            
            string sql = "select  *  from  [user] where userID=@userID and pwd=@pwd  ";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@userID",userID ),
                new SqlParameter("@pwd",pwd ),
            };

            SqlDataReader sqlDataReader = Utility.Sql.Sqlhelper.GetSqlDataReader(sql, DataSourceType.business, sqlParameters);
            if (sqlDataReader.Read())
            {

                CurrentUser.userID = sqlDataReader["userID"].ToString();
                CurrentUser.userName = sqlDataReader["name"].ToString();
                return true;


            }
            return false;
        }

        public void updateCustomer()
        {

        }
    }
}



