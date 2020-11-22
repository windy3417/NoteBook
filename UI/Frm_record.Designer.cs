namespace NoteBook.UI
{
    partial class Frm_record
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_record));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_query = new System.Windows.Forms.Panel();
            this.btn_query = new System.Windows.Forms.Button();
            this.rtxt_voucherNO = new System.Windows.Forms.RichTextBox();
            this.lbl_vouchNo = new System.Windows.Forms.Label();
            this.horizonLine2 = new Utility.UControl.HorizonLine();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.dtp_makeDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_vouchNoValue = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.lbl_personCode = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_previewPrint = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbl_recordPerson = new System.Windows.Forms.Label();
            this.rtb_record = new System.Windows.Forms.RichTextBox();
            this.rtb_summary = new System.Windows.Forms.RichTextBox();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_query.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.rtb_summary);
            this.panel1.Controls.Add(this.rtb_record);
            this.panel1.Controls.Add(this.pnl_query);
            this.panel1.Controls.Add(this.lbl_summary);
            this.panel1.Controls.Add(this.lbl_vouchNo);
            this.panel1.Controls.Add(this.horizonLine2);
            this.panel1.Controls.Add(this.lbl_personCode);
            this.panel1.Controls.Add(this.horizonLine1);
            this.panel1.Controls.Add(this.dtp_makeDate);
            this.panel1.Controls.Add(this.lbl_recordPerson);
            this.panel1.Controls.Add(this.lbl_vouchNoValue);
            this.panel1.Controls.Add(this.lbl_date);
            this.panel1.Controls.Add(this.lbl_titel);
            this.panel1.Location = new System.Drawing.Point(79, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 574);
            this.panel1.TabIndex = 6;
            // 
            // pnl_query
            // 
            this.pnl_query.Controls.Add(this.btn_query);
            this.pnl_query.Controls.Add(this.rtxt_voucherNO);
            this.pnl_query.Location = new System.Drawing.Point(573, 51);
            this.pnl_query.Name = "pnl_query";
            this.pnl_query.Size = new System.Drawing.Size(200, 46);
            this.pnl_query.TabIndex = 20;
            // 
            // btn_query
            // 
            this.btn_query.BackColor = System.Drawing.Color.Transparent;
            this.btn_query.ForeColor = System.Drawing.Color.Black;
            this.btn_query.Image = ((System.Drawing.Image)(resources.GetObject("btn_query.Image")));
            this.btn_query.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_query.Location = new System.Drawing.Point(171, 18);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(21, 22);
            this.btn_query.TabIndex = 17;
            this.btn_query.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_query.UseVisualStyleBackColor = false;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // rtxt_voucherNO
            // 
            this.rtxt_voucherNO.Location = new System.Drawing.Point(47, 15);
            this.rtxt_voucherNO.Name = "rtxt_voucherNO";
            this.rtxt_voucherNO.Size = new System.Drawing.Size(150, 28);
            this.rtxt_voucherNO.TabIndex = 18;
            this.rtxt_voucherNO.Text = "";
            // 
            // lbl_vouchNo
            // 
            this.lbl_vouchNo.AutoSize = true;
            this.lbl_vouchNo.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_vouchNo.Location = new System.Drawing.Point(184, 131);
            this.lbl_vouchNo.Name = "lbl_vouchNo";
            this.lbl_vouchNo.Size = new System.Drawing.Size(70, 12);
            this.lbl_vouchNo.TabIndex = 16;
            this.lbl_vouchNo.Text = "单据编号：";
            // 
            // horizonLine2
            // 
            this.horizonLine2.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine2.LineWidth = 1;
            this.horizonLine2.Location = new System.Drawing.Point(164, 556);
            this.horizonLine2.Name = "horizonLine2";
            this.horizonLine2.Size = new System.Drawing.Size(578, 1);
            this.horizonLine2.TabIndex = 15;
            // 
            // horizonLine1
            // 
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(164, 230);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(578, 1);
            this.horizonLine1.TabIndex = 15;
            // 
            // dtp_makeDate
            // 
            this.dtp_makeDate.Location = new System.Drawing.Point(385, 66);
            this.dtp_makeDate.Name = "dtp_makeDate";
            this.dtp_makeDate.Size = new System.Drawing.Size(124, 21);
            this.dtp_makeDate.TabIndex = 14;
            // 
            // lbl_vouchNoValue
            // 
            this.lbl_vouchNoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vouchNoValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNoValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vouchNoValue.Location = new System.Drawing.Point(246, 130);
            this.lbl_vouchNoValue.Name = "lbl_vouchNoValue";
            this.lbl_vouchNoValue.Size = new System.Drawing.Size(130, 14);
            this.lbl_vouchNoValue.TabIndex = 6;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(322, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 12);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "备忘日期:";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(304, 19);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(227, 29);
            this.lbl_titel.TabIndex = 12;
            this.lbl_titel.Text = "备 忘 记 录 单";
            // 
            // lbl_personCode
            // 
            this.lbl_personCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_personCode.AutoSize = true;
            this.lbl_personCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_personCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personCode.Location = new System.Drawing.Point(519, 131);
            this.lbl_personCode.Name = "lbl_personCode";
            this.lbl_personCode.Size = new System.Drawing.Size(83, 12);
            this.lbl_personCode.TabIndex = 1;
            this.lbl_personCode.Text = "记录人姓名：";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_new,
            this.tsb_save,
            this.tsb_abandon,
            this.tsb_modify,
            this.tsb_query,
            this.tsb_previewPrint,
            this.tsb_print,
            this.tsb_delete,
            this.tsb_close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_new
            // 
            this.tsb_new.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_new.Image = ((System.Drawing.Image)(resources.GetObject("tsb_new.Image")));
            this.tsb_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_new.Name = "tsb_new";
            this.tsb_new.Size = new System.Drawing.Size(23, 22);
            this.tsb_new.Text = "新增";
            this.tsb_new.Click += new System.EventHandler(this.Tsb_new_Click);
            // 
            // tsb_save
            // 
            this.tsb_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_save.Image = ((System.Drawing.Image)(resources.GetObject("tsb_save.Image")));
            this.tsb_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_save.Name = "tsb_save";
            this.tsb_save.Size = new System.Drawing.Size(23, 22);
            this.tsb_save.Text = "保存";
            this.tsb_save.Click += new System.EventHandler(this.tsb_save_Click);
            // 
            // tsb_abandon
            // 
            this.tsb_abandon.Image = ((System.Drawing.Image)(resources.GetObject("tsb_abandon.Image")));
            this.tsb_abandon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_abandon.Name = "tsb_abandon";
            this.tsb_abandon.Size = new System.Drawing.Size(52, 22);
            this.tsb_abandon.Text = "放弃";
            this.tsb_abandon.Click += new System.EventHandler(this.tsb_abandon_Click);
            // 
            // tsb_modify
            // 
            this.tsb_modify.Image = ((System.Drawing.Image)(resources.GetObject("tsb_modify.Image")));
            this.tsb_modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_modify.Name = "tsb_modify";
            this.tsb_modify.Size = new System.Drawing.Size(52, 22);
            this.tsb_modify.Text = "修改";
            this.tsb_modify.Click += new System.EventHandler(this.tsb_modify_Click);
            // 
            // tsb_query
            // 
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(52, 22);
            this.tsb_query.Text = "查询";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // tsb_previewPrint
            // 
            this.tsb_previewPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsb_previewPrint.Image")));
            this.tsb_previewPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_previewPrint.Name = "tsb_previewPrint";
            this.tsb_previewPrint.Size = new System.Drawing.Size(52, 22);
            this.tsb_previewPrint.Text = "预览";
            this.tsb_previewPrint.Click += new System.EventHandler(this.tsb_previewPrint_Click);
            // 
            // tsb_print
            // 
            this.tsb_print.Image = ((System.Drawing.Image)(resources.GetObject("tsb_print.Image")));
            this.tsb_print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_print.Name = "tsb_print";
            this.tsb_print.Size = new System.Drawing.Size(52, 22);
            this.tsb_print.Text = "打印";
            this.tsb_print.Click += new System.EventHandler(this.Tsb_print_Click);
            // 
            // tsb_delete
            // 
            this.tsb_delete.Image = ((System.Drawing.Image)(resources.GetObject("tsb_delete.Image")));
            this.tsb_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_delete.Name = "tsb_delete";
            this.tsb_delete.Size = new System.Drawing.Size(52, 22);
            this.tsb_delete.Text = "删除";
            this.tsb_delete.Click += new System.EventHandler(this.tsb_delete_Click);
            // 
            // tsb_close
            // 
            this.tsb_close.Image = global::NoteBook.Properties.Resources.exit;
            this.tsb_close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_close.Name = "tsb_close";
            this.tsb_close.Size = new System.Drawing.Size(52, 22);
            this.tsb_close.Text = "关闭";
            this.tsb_close.Click += new System.EventHandler(this.Tsb_close_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lbl_recordPerson
            // 
            this.lbl_recordPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recordPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_recordPerson.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_recordPerson.Location = new System.Drawing.Point(596, 130);
            this.lbl_recordPerson.Name = "lbl_recordPerson";
            this.lbl_recordPerson.Size = new System.Drawing.Size(130, 14);
            this.lbl_recordPerson.TabIndex = 6;
            // 
            // rtb_record
            // 
            this.rtb_record.Location = new System.Drawing.Point(184, 246);
            this.rtb_record.Name = "rtb_record";
            this.rtb_record.Size = new System.Drawing.Size(547, 304);
            this.rtb_record.TabIndex = 21;
            this.rtb_record.Text = "";
            // 
            // rtb_summary
            // 
            this.rtb_summary.Location = new System.Drawing.Point(184, 185);
            this.rtb_summary.Name = "rtb_summary";
            this.rtb_summary.Size = new System.Drawing.Size(547, 23);
            this.rtb_summary.TabIndex = 22;
            this.rtb_summary.Text = "";
            // 
            // lbl_summary
            // 
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_summary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_summary.Location = new System.Drawing.Point(184, 165);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(44, 12);
            this.lbl_summary.TabIndex = 16;
            this.lbl_summary.Text = "概要：";
            // 
            // Frm_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 625);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_record";
            this.Text = "过磅结算单";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_weighingSettltement_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_weighingSettltement_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_query.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_makeDate;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_titel;
        private System.Windows.Forms.Label lbl_personCode;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripButton tsb_print;
        private System.Windows.Forms.ToolStripButton tsb_close;
        private Utility.UControl.HorizonLine horizonLine2;
        private Utility.UControl.HorizonLine horizonLine1;
        private System.Windows.Forms.Label lbl_vouchNo;
        private System.Windows.Forms.Label lbl_vouchNoValue;
        private System.Windows.Forms.ToolStripButton tsb_new;
        private System.Windows.Forms.ToolStripButton tsb_save;
        private System.Windows.Forms.ToolStripButton tsb_previewPrint;
        private System.Windows.Forms.Panel pnl_query;
        //穿透查询功能开放访问
        public System.Windows.Forms.Button btn_query;
        public System.Windows.Forms.RichTextBox rtxt_voucherNO;
        public System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.ToolStripButton tsb_modify;
        private System.Windows.Forms.ToolStripButton tsb_abandon;
        private System.Windows.Forms.ToolStripButton tsb_delete;
        private System.Windows.Forms.Label lbl_recordPerson;
        private System.Windows.Forms.RichTextBox rtb_record;
        private System.Windows.Forms.RichTextBox rtb_summary;
        private System.Windows.Forms.Label lbl_summary;
    }
}

