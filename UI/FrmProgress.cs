using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;
using Utility.Model;
using System.Drawing.Printing;
using NoteBook.DAL;
using NoteBook.Modle;
using NoteBook.Properties;
using static NoteBook.Modle.EnumModle;
using System.Runtime.Remoting;
using Utility.UI;
using NoteBook.UI.List;

namespace NoteBook.UI
{
    public partial class FrmProgress : Form
    {
        public FrmProgress()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(this.closeParent);
            initalizeControlState();

        }

        #region 变量或枚举

        //新增后保存与修改后保存枚举值
        enum addOrChangeMolde
        {
            add,
            change,
            query

        }

        //新增修改标记

        string addOrChangeFlag;

        #endregion

        #region 初始化操作

        /// <summary>
        /// 初始化控件数据源
        /// </summary>
        private void initializeDatasource()
        {
            


         


        }

        /// <summary>
        /// 初始化控件状态
        /// </summary>
        private void initalizeControlState()
        {
            tsb_save.Enabled = false;
            tsb_modify.Enabled = false;
            tsb_delete.Enabled = false;
            tsb_abandon.Enabled = false;
            tsb_previewPrint.Enabled = false;
            tsb_print.Enabled = false;

            pnl_query.Visible = false;

         
          
        }
        #endregion

        #region 窗体操作

        private void Tsb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeParent(object sender, FormClosedEventArgs e)
        {
            this.Parent.Dispose();
        }

        private void clearDate()
        {
          



            
        }

        #endregion

        #region 单据增删改查

        /// <summary>
        /// 参照数据源，新增单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tsb_ref_Click(object sender, EventArgs e)
        {
            //调整事件触发状态
            //该事件查询时已经解绑
            if (addOrChangeFlag==addOrChangeMolde.query.ToString())
            {
                
            }
                                              
            
            //设定菜单状态


            tsb_save.Enabled = true;
            tsb_abandon.Enabled = true;
            tsb_query.Enabled = false;
            tsb_print.Enabled = false;
            tsb_previewPrint.Enabled = false;
            tsb_modify.Enabled = false;

            //设定控件与变量状态

            pnl_query.Visible = false;
            //调整单据修改时的控件状态
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
               
               

            }
            addOrChangeFlag = addOrChangeMolde.add.ToString();

            //清空已填制的数据
            rtb_summary.Text = "";
            rtb_memo.Text = "";
            
            //设定控件值
            this.lbl_vouchNoValue.Text = DateTime.Now.ToString("yyyyMMddHHmmss");
         
            lbl_personCodeValue.Text = CurrentUser.userName;

            initializeDatasource();


            Frm_recordRef f = new Frm_recordRef();

            //显示等待光标，提示加载数据
            this.Cursor = Cursors.WaitCursor;
            f.ActionRecord += this.RefRecord;
                                   
            f.ShowDialog();

            this.Cursor = Cursors.Default;
            
           
           

        }

    

        /// <summary>
        /// 保存单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_save_Click(object sender, EventArgs e)
        {
            if (addOrChangeFlag == addOrChangeMolde.add.ToString())
            {
                using (var db = new NoteBookContext())
                {
                    NoteRecordModle w = new NoteRecordModle();
                    saveData(db, w);

                }
            }
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                using (var db = new NoteBookContext())
                {
                    NoteRecordModle w = db.NoteRecords.Where(s => s.voucherNo == lbl_vouchNoValue.Text).FirstOrDefault();
                    saveData(db, w);
                }
            }

        }

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="db"></param>
        /// <param name="w"></param>
        private void saveData(NoteBookContext db, NoteRecordModle w)
        {

           


            //修改数据保存准备
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                //w.recorder = Convert.ToDouble(txt_webUnitPrice.Text);
              
            }

            //新增数据保存准备
            if (addOrChangeFlag == addOrChangeMolde.add.ToString())
            {

                w.makeTime = DateTime.Now;
                w.userID = lbl_personCode.Text;

                w.voucherNo = CurrentUser.userID;
             
                db.NoteRecords.Add(w);
            }


            //数据保存
            try
            {
                db.SaveChanges();
                tsb_save.Enabled = false;
                tsb_print.Enabled = true;
                tsb_previewPrint.Enabled = true;
          
                if (addOrChangeFlag == addOrChangeMolde.change.ToString())
                {
                    tsb_new.Enabled = true;

                }
                if (addOrChangeFlag == addOrChangeMolde.add.ToString())
                {
                    tsb_modify.Enabled = true;
                    tsb_delete.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.InnerException, "保存错误提示");
            }
        }

        /// <summary>
        /// 单据修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_modify_Click(object sender, EventArgs e)
        {
           

            addOrChangeFlag = addOrChangeMolde.change.ToString();
            //改变控件状态
            tsb_abandon.Enabled = true;
            tsb_new.Enabled = false;
            tsb_save.Enabled = true;
           
            //限定可修改范围，只能修改价格信息
            dtp_makeDate.Enabled = false;
         
           


        }

        /// <summary>
        /// 单据查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_query_Click(object sender, EventArgs e)
        {
            pnl_query.Visible = true;
            using (var db = new NoteBookContext())
            {
                var q = from w in db.NoteRecords
                        //where (w.vocherNO.Max())
                        select new {  w.voucherNo };
                //赋值时注意对类型q进行转换， 不能直接写成rtxt_voucherNO.Text = q
                rtxt_voucherNO.Text = (q.Select(s => s.voucherNo)).Max().ToString();
                btn_query.PerformClick();
                tsb_previewPrint.Enabled = true;
                tsb_print.Enabled = true;
            }


        }

        /// <summary>
        /// 查询一张单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_query_Click(object sender, EventArgs e)
        {
                     
                     
            addOrChangeFlag = addOrChangeMolde.query.ToString();

                      
            using (var db = new NoteBookContext())
            {
                var query = from q in db.NoteRecords
                           
                            join p in db.Users on q.userID equals p.userID.ToString()
                          

                            where q.voucherNo == rtxt_voucherNO.Text

                            select new
                            {
                                q.makeTime,
                               
                                q.voucherNo,
                               
                                p.userID,
                                p.name,
                                q.recorder
                            };
                foreach (var item in query)
                {
                    lbl_vouchNoValue.Text = item.voucherNo;
                    //如果查询有结果，则启用修改菜单与删除菜单
                    if (lbl_vouchNoValue.Text != "" & lbl_vouchNoValue.Text != null)
                    {
                        tsb_modify.Enabled = Enabled;
                        tsb_delete.Enabled = Enabled;
                    }


                    //实践表明，不初始化combox控件的数据源，则无法对SelectedValue进行赋值
                    //因为赋值后赋值等式右边虽然有值，但SelectedValue确仍为空，具体什么原因不明？
                    initializeDatasource();

                    dtp_makeDate.Text = item.makeTime.ToString();
                                                                        
                                       
                 

                    

                                    



                }
            }
        }

        /// <summary>
        /// 删除单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_delete_Click(object sender, EventArgs e)
        {
            if (lbl_vouchNoValue.Text != "" & lbl_vouchNoValue.Text != null)
            {
                if (DialogResult.Yes == MessageBox.Show("是否确定删除", "删除提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    try
                    {
                        using (var db = new NoteBookContext())
                        {
                            var del = (from d in db.NoteRecords
                                       where (d.voucherNo == lbl_vouchNoValue.Text)
                                       select d).ToList(); ;
                            //移除数据库的数据
                            db.NoteRecords.Remove(del[0]);
                            db.SaveChanges();
                            clearDate();
                            lbl_vouchNoValue.Text = "";
                            dtp_makeDate.Text = "";
                            rtxt_voucherNO.Text = "";
                            //修改单据功能状态
                            tsb_delete.Enabled = false;
                            tsb_modify.Enabled = false;
                            tsb_previewPrint.Enabled = false;
                            tsb_print.Enabled = false;

                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("数据删除出错" + ex.Message + ex.InnerException, "数据删除提示");
                    }
                }

            }







        }

        /// <summary>
        /// 放弃新增与修改的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_abandon_Click(object sender, EventArgs e)
        {
            //if (addOrChangeFlag==addOrChangeMolde.add.ToString())
            //{

            //    tsb_save.Enabled = false;

            //}
            if (addOrChangeFlag == addOrChangeMolde.change.ToString())
            {
                tsb_modify.Enabled = false;

            }
            clearDate();
            tsb_save.Enabled = false;
     
            tsb_abandon.Enabled = false;
        }
        #endregion


        #region 内部方法

        /// <summary>
        /// 参照记录单，生成处理单
        /// </summary>
        /// <param name="voucherNo"></param>
        private void RefRecord (string voucherNo)
        {
            using (var db=new NoteBookContext())
            {
                List<NoteRecordModle> recordModle 
                    = db.NoteRecords.Where(s => s.voucherNo == voucherNo).ToList();
                //窗体控件赋值

                foreach (var item in recordModle)
                {
                    this.rtxt_voucherNO.Text = item.voucherNo.ToString();
                    this.txt_itemName.Text = item.itemName;
                    this.rtb_memo.Text = item.memo;
                }
               
            }
        }

        #endregion



























        #region 打印


        private void tsb_previewPrint_Click(object sender, EventArgs e)
        {


            printPreviewDialog1.Document = printDocument1;
           
            printPreviewDialog1.ShowDialog();

        }

        private void Tsb_print_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            printDialog1.AllowSomePages = true;

            DialogResult result = printDialog1.ShowDialog();

            // If the result is OK then print the document.
            //打印预览时只要printPreviewDialog1.Document = printDocument1关联后就可的打印
            //直接打印则需要调用PrintDocumnt.Print()方可打印，否按在对话框中点【打印】但不会有反应
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        /// <summary>
        /// 传递打印数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            //初始纵向距离后,根据文字占位即时更新
            int y = 50;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            //logo
            e.Graphics.DrawImage(Resources.logo, new Rectangle(100, y, 150, 40));


            //标题
            e.Graphics.DrawString(lbl_titel.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(330, y));
            //单据编号
            e.Graphics.DrawString("单据编号：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 525, y + 50);
            e.Graphics.DrawString(lbl_vouchNoValue.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(600, y + 50));


            //单据联次
            Rectangle rectangleCopy = new Rectangle(720, y + 135, 20, 100);
            e.Graphics.DrawString("第一联：记账联", new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleCopy, stringFormat);

            //更新纵坐标
            y = y + 10;
            Pen blackpenContent = new Pen(Color.Black, 1);



            //待打印数据集
            String[] head = new string[5] { "记录日期", "记录单号", "记录人", "概要", "正文" };
            string[] content = new string[5] {  dtp_makeDate.Value.Date.ToString("yyyy-MM-dd"),
                                                lbl_vouchNoValue.Text,
                                                lbl_personCodeValue.Text,
                                                rtb_summary.Text, rtb_memo.Text,
                                                 };


            for (int i = 0; i < head.Count(); i++)
            {


                //使用事件数据类PrintPageEventArgs中Graphics属性获取打印数据

                //打印表头

                Rectangle rectangleHead = new Rectangle(100, y + 70 + i * 30, 100, 30);


                e.Graphics.DrawRectangle(blackpenContent, rectangleHead);
                e.Graphics.DrawString(head[i], new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleHead, stringFormat);

                //打印内容
                Rectangle rectangleContent = new Rectangle(200, y + 70 + i * 30, 500, 30);
                e.Graphics.DrawRectangle(blackpenContent, rectangleContent);
                e.Graphics.DrawString(content[i], DefaultFont, Brushes.Black, rectangleContent, stringFormat);



            }

            y = y + 70 + head.Count() * 30;

            //打印签名
            e.Graphics.DrawString("监磅人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 30);
            e.Graphics.DrawString("经办人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 60);
            e.Graphics.DrawString("预付款余额：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 30);
            e.Graphics.DrawString("销售单位盖章：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 60);



            y = y + 300;

            // Draw line to screen.
            //Pen blackPenLine = new Pen(Color.Black, 1);
            //Point point1 = new Point(50, y + 100);
            //Point point2 = new Point(750, y + 100);

            //e.Graphics.DrawLine(blackPenLine, point1, point2);


            //重复打印
            //logo
            e.Graphics.DrawImage(Resources.logo, new Rectangle(100, y, 150, 40));
            //标题
            e.Graphics.DrawString(lbl_titel.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(330, y));
            //单据编号
            e.Graphics.DrawString("单据编号：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 525, y + 50);
            e.Graphics.DrawString(lbl_vouchNoValue.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(600, y + 50));


            //单据联次
            Rectangle rectangleCopy2 = new Rectangle(720, y + 135, 20, 100);
            e.Graphics.DrawString("第二联：结算联", new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleCopy2, stringFormat);

            //更新纵坐标
            y = y + 10;



            for (int i = 0; i < head.Count(); i++)
            {


                //使用事件数据类PrintPageEventArgs中Graphics属性获取打印数据

                //打印表头

                Rectangle rectangleHead = new Rectangle(100, y + 70 + i * 30, 100, 30);


                e.Graphics.DrawRectangle(blackpenContent, rectangleHead);
                e.Graphics.DrawString(head[i], new Font(DefaultFont, FontStyle.Bold), Brushes.Black, rectangleHead, stringFormat);

                //打印内容
                Rectangle rectangleContent = new Rectangle(200, y + 70 + i * 30, 500, 30);
                e.Graphics.DrawRectangle(blackpenContent, rectangleContent);
                e.Graphics.DrawString(content[i], DefaultFont, Brushes.Black, rectangleContent, stringFormat);



            }

            y = y + 70 + head.Count() * 30;

            //打印签名
            e.Graphics.DrawString("监磅人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 30);
            e.Graphics.DrawString("经办人：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 120, y + 60);
            e.Graphics.DrawString("预付款余额：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 30);
            e.Graphics.DrawString("销售单位盖章：", new Font("宋体", 10, FontStyle.Regular), Brushes.Black, 520, y + 60);














        }



        #endregion

        #region 快捷键

        /// <summary>
        /// 回车代替TAB键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_weighingSettltement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.Convert.ToInt32(e.KeyChar) == 13)
            {
                System.Windows.Forms.SendKeys.Send("{tab}");
            }
        }


        private void Frm_weighingSettltement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S & e.Control)
            {
                tsb_save.PerformClick();
            }
        }






        #endregion

    
    }
}


