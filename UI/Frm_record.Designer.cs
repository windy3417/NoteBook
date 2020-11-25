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
            this.pnl_first = new System.Windows.Forms.Panel();
            this.tlp_content = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_itmeName = new System.Windows.Forms.Label();
            this.lbl_requestDate = new System.Windows.Forms.Label();
            this.lbl_requestPerson = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.cmb_requestPerson = new System.Windows.Forms.ComboBox();
            this.dtp_requestDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_needComplishedDate = new System.Windows.Forms.Label();
            this.dtp_needCompletedDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_planCompletedDate = new System.Windows.Forms.Label();
            this.lbl_reponsiblePerson = new System.Windows.Forms.Label();
            this.cmb_reponsiblePerson = new System.Windows.Forms.ComboBox();
            this.dtp_planCompletedDate = new System.Windows.Forms.DateTimePicker();
            this.rtb_memo = new System.Windows.Forms.RichTextBox();
            this.rtb_progress = new System.Windows.Forms.RichTextBox();
            this.rtb_summary = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.pnl_query = new System.Windows.Forms.Panel();
            this.rtxt_voucherNO = new System.Windows.Forms.RichTextBox();
            this.lbl_vouchNo = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_personCode = new System.Windows.Forms.Label();
            this.dtp_makeDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_statusValue = new System.Windows.Forms.Label();
            this.lbl_personCodeValue = new System.Windows.Forms.Label();
            this.lbl_vouchNoValue = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_titel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tsb_new = new System.Windows.Forms.ToolStripButton();
            this.tsb_save = new System.Windows.Forms.ToolStripButton();
            this.tsb_abandon = new System.Windows.Forms.ToolStripButton();
            this.tsb_modify = new System.Windows.Forms.ToolStripButton();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.tsb_previewPrint = new System.Windows.Forms.ToolStripButton();
            this.tsb_print = new System.Windows.Forms.ToolStripButton();
            this.tsb_delete = new System.Windows.Forms.ToolStripButton();
            this.tsb_close = new System.Windows.Forms.ToolStripButton();
            this.btn_query = new System.Windows.Forms.Button();
            this.horizonLine1 = new Utility.UControl.HorizonLine();
            this.pnl_first.SuspendLayout();
            this.tlp_content.SuspendLayout();
            this.pnl_query.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_first
            // 
            this.pnl_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnl_first.Controls.Add(this.tlp_content);
            this.pnl_first.Controls.Add(this.rtb_memo);
            this.pnl_first.Controls.Add(this.rtb_progress);
            this.pnl_first.Controls.Add(this.rtb_summary);
            this.pnl_first.Controls.Add(this.label6);
            this.pnl_first.Controls.Add(this.lbl_progress);
            this.pnl_first.Controls.Add(this.lbl_summary);
            this.pnl_first.Controls.Add(this.pnl_query);
            this.pnl_first.Controls.Add(this.lbl_vouchNo);
            this.pnl_first.Controls.Add(this.lbl_status);
            this.pnl_first.Controls.Add(this.lbl_personCode);
            this.pnl_first.Controls.Add(this.horizonLine1);
            this.pnl_first.Controls.Add(this.dtp_makeDate);
            this.pnl_first.Controls.Add(this.lbl_statusValue);
            this.pnl_first.Controls.Add(this.lbl_personCodeValue);
            this.pnl_first.Controls.Add(this.lbl_vouchNoValue);
            this.pnl_first.Controls.Add(this.lbl_date);
            this.pnl_first.Controls.Add(this.lbl_titel);
            this.pnl_first.Location = new System.Drawing.Point(28, 28);
            this.pnl_first.Name = "pnl_first";
            this.pnl_first.Size = new System.Drawing.Size(977, 702);
            this.pnl_first.TabIndex = 6;
            // 
            // tlp_content
            // 
            this.tlp_content.ColumnCount = 6;
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.188F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.26182F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57209F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.22261F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.49481F));
            this.tlp_content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.02999F));
            this.tlp_content.Controls.Add(this.lbl_itmeName, 0, 0);
            this.tlp_content.Controls.Add(this.lbl_requestDate, 2, 0);
            this.tlp_content.Controls.Add(this.lbl_requestPerson, 0, 1);
            this.tlp_content.Controls.Add(this.txt_itemName, 1, 0);
            this.tlp_content.Controls.Add(this.cmb_requestPerson, 1, 1);
            this.tlp_content.Controls.Add(this.dtp_requestDate, 3, 0);
            this.tlp_content.Controls.Add(this.lbl_needComplishedDate, 4, 0);
            this.tlp_content.Controls.Add(this.dtp_needCompletedDate, 5, 0);
            this.tlp_content.Controls.Add(this.lbl_planCompletedDate, 4, 1);
            this.tlp_content.Controls.Add(this.lbl_reponsiblePerson, 2, 1);
            this.tlp_content.Controls.Add(this.cmb_reponsiblePerson, 3, 1);
            this.tlp_content.Controls.Add(this.dtp_planCompletedDate, 5, 1);
            this.tlp_content.Location = new System.Drawing.Point(28, 168);
            this.tlp_content.Name = "tlp_content";
            this.tlp_content.RowCount = 2;
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_content.Size = new System.Drawing.Size(867, 67);
            this.tlp_content.TabIndex = 25;
            // 
            // lbl_itmeName
            // 
            this.lbl_itmeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_itmeName.AutoSize = true;
            this.lbl_itmeName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_itmeName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_itmeName.Location = new System.Drawing.Point(3, 10);
            this.lbl_itmeName.Name = "lbl_itmeName";
            this.lbl_itmeName.Size = new System.Drawing.Size(70, 12);
            this.lbl_itmeName.TabIndex = 17;
            this.lbl_itmeName.Text = "项目名称：";
            // 
            // lbl_requestDate
            // 
            this.lbl_requestDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_requestDate.AutoSize = true;
            this.lbl_requestDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_requestDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_requestDate.Location = new System.Drawing.Point(267, 10);
            this.lbl_requestDate.Name = "lbl_requestDate";
            this.lbl_requestDate.Size = new System.Drawing.Size(96, 12);
            this.lbl_requestDate.TabIndex = 17;
            this.lbl_requestDate.Text = "需求提出日期：";
            // 
            // lbl_requestPerson
            // 
            this.lbl_requestPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_requestPerson.AutoSize = true;
            this.lbl_requestPerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_requestPerson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_requestPerson.Location = new System.Drawing.Point(3, 44);
            this.lbl_requestPerson.Name = "lbl_requestPerson";
            this.lbl_requestPerson.Size = new System.Drawing.Size(57, 12);
            this.lbl_requestPerson.TabIndex = 17;
            this.lbl_requestPerson.Text = "申请人：";
            // 
            // txt_itemName
            // 
            this.txt_itemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_itemName.Location = new System.Drawing.Point(100, 6);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(161, 21);
            this.txt_itemName.TabIndex = 18;
            // 
            // cmb_requestPerson
            // 
            this.cmb_requestPerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_requestPerson.FormattingEnabled = true;
            this.cmb_requestPerson.Location = new System.Drawing.Point(100, 40);
            this.cmb_requestPerson.Name = "cmb_requestPerson";
            this.cmb_requestPerson.Size = new System.Drawing.Size(161, 20);
            this.cmb_requestPerson.TabIndex = 19;
            // 
            // dtp_requestDate
            // 
            this.dtp_requestDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_requestDate.Location = new System.Drawing.Point(376, 6);
            this.dtp_requestDate.Name = "dtp_requestDate";
            this.dtp_requestDate.Size = new System.Drawing.Size(178, 21);
            this.dtp_requestDate.TabIndex = 20;
            // 
            // lbl_needComplishedDate
            // 
            this.lbl_needComplishedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_needComplishedDate.AutoSize = true;
            this.lbl_needComplishedDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_needComplishedDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_needComplishedDate.Location = new System.Drawing.Point(560, 10);
            this.lbl_needComplishedDate.Name = "lbl_needComplishedDate";
            this.lbl_needComplishedDate.Size = new System.Drawing.Size(83, 12);
            this.lbl_needComplishedDate.TabIndex = 17;
            this.lbl_needComplishedDate.Text = "要求完日期：";
            // 
            // dtp_needCompletedDate
            // 
            this.dtp_needCompletedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_needCompletedDate.Location = new System.Drawing.Point(677, 6);
            this.dtp_needCompletedDate.Name = "dtp_needCompletedDate";
            this.dtp_needCompletedDate.Size = new System.Drawing.Size(187, 21);
            this.dtp_needCompletedDate.TabIndex = 20;
            // 
            // lbl_planCompletedDate
            // 
            this.lbl_planCompletedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_planCompletedDate.AutoSize = true;
            this.lbl_planCompletedDate.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_planCompletedDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_planCompletedDate.Location = new System.Drawing.Point(560, 44);
            this.lbl_planCompletedDate.Name = "lbl_planCompletedDate";
            this.lbl_planCompletedDate.Size = new System.Drawing.Size(96, 12);
            this.lbl_planCompletedDate.TabIndex = 17;
            this.lbl_planCompletedDate.Text = "预计完成日期：";
            // 
            // lbl_reponsiblePerson
            // 
            this.lbl_reponsiblePerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_reponsiblePerson.AutoSize = true;
            this.lbl_reponsiblePerson.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_reponsiblePerson.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_reponsiblePerson.Location = new System.Drawing.Point(267, 44);
            this.lbl_reponsiblePerson.Name = "lbl_reponsiblePerson";
            this.lbl_reponsiblePerson.Size = new System.Drawing.Size(57, 12);
            this.lbl_reponsiblePerson.TabIndex = 17;
            this.lbl_reponsiblePerson.Text = "责任人：";
            // 
            // cmb_reponsiblePerson
            // 
            this.cmb_reponsiblePerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmb_reponsiblePerson.FormattingEnabled = true;
            this.cmb_reponsiblePerson.Location = new System.Drawing.Point(376, 40);
            this.cmb_reponsiblePerson.Name = "cmb_reponsiblePerson";
            this.cmb_reponsiblePerson.Size = new System.Drawing.Size(178, 20);
            this.cmb_reponsiblePerson.TabIndex = 19;
            // 
            // dtp_planCompletedDate
            // 
            this.dtp_planCompletedDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtp_planCompletedDate.Location = new System.Drawing.Point(677, 39);
            this.dtp_planCompletedDate.Name = "dtp_planCompletedDate";
            this.dtp_planCompletedDate.Size = new System.Drawing.Size(187, 21);
            this.dtp_planCompletedDate.TabIndex = 20;
            // 
            // rtb_memo
            // 
            this.rtb_memo.Location = new System.Drawing.Point(28, 383);
            this.rtb_memo.Name = "rtb_memo";
            this.rtb_memo.Size = new System.Drawing.Size(864, 28);
            this.rtb_memo.TabIndex = 5;
            this.rtb_memo.Text = "";
            // 
            // rtb_progress
            // 
            this.rtb_progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rtb_progress.Location = new System.Drawing.Point(28, 452);
            this.rtb_progress.Name = "rtb_progress";
            this.rtb_progress.Size = new System.Drawing.Size(864, 236);
            this.rtb_progress.TabIndex = 6;
            this.rtb_progress.Text = "";
            // 
            // rtb_summary
            // 
            this.rtb_summary.Location = new System.Drawing.Point(28, 255);
            this.rtb_summary.Name = "rtb_summary";
            this.rtb_summary.Size = new System.Drawing.Size(864, 96);
            this.rtb_summary.TabIndex = 4;
            this.rtb_summary.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(28, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "备注：";
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_progress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_progress.Location = new System.Drawing.Point(28, 427);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(70, 12);
            this.lbl_progress.TabIndex = 23;
            this.lbl_progress.Text = "业务进度：";
            // 
            // lbl_summary
            // 
            this.lbl_summary.AutoSize = true;
            this.lbl_summary.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_summary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_summary.Location = new System.Drawing.Point(28, 240);
            this.lbl_summary.Name = "lbl_summary";
            this.lbl_summary.Size = new System.Drawing.Size(70, 12);
            this.lbl_summary.TabIndex = 23;
            this.lbl_summary.Text = "需求描述：";
            // 
            // pnl_query
            // 
            this.pnl_query.Controls.Add(this.btn_query);
            this.pnl_query.Controls.Add(this.rtxt_voucherNO);
            this.pnl_query.Location = new System.Drawing.Point(710, 51);
            this.pnl_query.Name = "pnl_query";
            this.pnl_query.Size = new System.Drawing.Size(200, 46);
            this.pnl_query.TabIndex = 20;
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
            this.lbl_vouchNo.Location = new System.Drawing.Point(28, 114);
            this.lbl_vouchNo.Name = "lbl_vouchNo";
            this.lbl_vouchNo.Size = new System.Drawing.Size(70, 12);
            this.lbl_vouchNo.TabIndex = 16;
            this.lbl_vouchNo.Text = "项目编号：";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_status.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_status.Location = new System.Drawing.Point(797, 26);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(44, 12);
            this.lbl_status.TabIndex = 1;
            this.lbl_status.Text = "状态：";
            // 
            // lbl_personCode
            // 
            this.lbl_personCode.AutoSize = true;
            this.lbl_personCode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_personCode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_personCode.Location = new System.Drawing.Point(349, 114);
            this.lbl_personCode.Name = "lbl_personCode";
            this.lbl_personCode.Size = new System.Drawing.Size(83, 12);
            this.lbl_personCode.TabIndex = 1;
            this.lbl_personCode.Text = "记录人姓名：";
            // 
            // dtp_makeDate
            // 
            this.dtp_makeDate.Location = new System.Drawing.Point(385, 66);
            this.dtp_makeDate.Name = "dtp_makeDate";
            this.dtp_makeDate.Size = new System.Drawing.Size(124, 21);
            this.dtp_makeDate.TabIndex = 14;
            // 
            // lbl_statusValue
            // 
            this.lbl_statusValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_statusValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_statusValue.ForeColor = System.Drawing.Color.Red;
            this.lbl_statusValue.Location = new System.Drawing.Point(838, 25);
            this.lbl_statusValue.Name = "lbl_statusValue";
            this.lbl_statusValue.Size = new System.Drawing.Size(69, 14);
            this.lbl_statusValue.TabIndex = 6;
            // 
            // lbl_personCodeValue
            // 
            this.lbl_personCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_personCodeValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_personCodeValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_personCodeValue.Location = new System.Drawing.Point(438, 113);
            this.lbl_personCodeValue.Name = "lbl_personCodeValue";
            this.lbl_personCodeValue.Size = new System.Drawing.Size(130, 14);
            this.lbl_personCodeValue.TabIndex = 6;
            // 
            // lbl_vouchNoValue
            // 
            this.lbl_vouchNoValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_vouchNoValue.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_vouchNoValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_vouchNoValue.Location = new System.Drawing.Point(110, 113);
            this.lbl_vouchNoValue.Name = "lbl_vouchNoValue";
            this.lbl_vouchNoValue.Size = new System.Drawing.Size(160, 14);
            this.lbl_vouchNoValue.TabIndex = 6;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(322, 70);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(59, 12);
            this.lbl_date.TabIndex = 7;
            this.lbl_date.Text = "记录日期:";
            // 
            // lbl_titel
            // 
            this.lbl_titel.AutoSize = true;
            this.lbl_titel.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_titel.Location = new System.Drawing.Point(329, 19);
            this.lbl_titel.Name = "lbl_titel";
            this.lbl_titel.Size = new System.Drawing.Size(181, 29);
            this.lbl_titel.TabIndex = 12;
            this.lbl_titel.Text = "协 同 发 起";
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
            // horizonLine1
            // 
            this.horizonLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.horizonLine1.LineColor = System.Drawing.SystemColors.ControlText;
            this.horizonLine1.LineWidth = 1;
            this.horizonLine1.Location = new System.Drawing.Point(15, 133);
            this.horizonLine1.Name = "horizonLine1";
            this.horizonLine1.Size = new System.Drawing.Size(900, 1);
            this.horizonLine1.TabIndex = 15;
            // 
            // Frm_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 742);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnl_first);
            this.KeyPreview = true;
            this.Name = "Frm_record";
            this.Text = "业务跟踪单";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_weighingSettltement_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_weighingSettltement_KeyPress);
            this.pnl_first.ResumeLayout(false);
            this.pnl_first.PerformLayout();
            this.tlp_content.ResumeLayout(false);
            this.tlp_content.PerformLayout();
            this.pnl_query.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_first;
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
        private System.Windows.Forms.Label lbl_personCodeValue;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_statusValue;
        private System.Windows.Forms.TableLayoutPanel tlp_content;
        private System.Windows.Forms.Label lbl_itmeName;
        private System.Windows.Forms.Label lbl_requestDate;
        private System.Windows.Forms.RichTextBox rtb_summary;
        private System.Windows.Forms.Label lbl_summary;
        private System.Windows.Forms.Label lbl_needComplishedDate;
        private System.Windows.Forms.Label lbl_planCompletedDate;
        private System.Windows.Forms.Label lbl_requestPerson;
        private System.Windows.Forms.Label lbl_reponsiblePerson;
        private System.Windows.Forms.RichTextBox rtb_memo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.ComboBox cmb_requestPerson;
        private System.Windows.Forms.ComboBox cmb_reponsiblePerson;
        private System.Windows.Forms.DateTimePicker dtp_requestDate;
        private System.Windows.Forms.DateTimePicker dtp_needCompletedDate;
        private System.Windows.Forms.DateTimePicker dtp_planCompletedDate;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.RichTextBox rtb_progress;
    }
}

