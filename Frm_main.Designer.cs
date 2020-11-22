namespace NoteBook
{
    partial class Frm_main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("记录");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("查询");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("备忘管理", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("新增");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("用户管理", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("测试");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("待定", new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.sc_main = new System.Windows.Forms.SplitContainer();
            this.tv_menu = new System.Windows.Forms.TreeView();
            this.tc_content = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).BeginInit();
            this.sc_main.Panel1.SuspendLayout();
            this.sc_main.Panel2.SuspendLayout();
            this.sc_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // sc_main
            // 
            this.sc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc_main.Location = new System.Drawing.Point(0, 0);
            this.sc_main.Name = "sc_main";
            // 
            // sc_main.Panel1
            // 
            this.sc_main.Panel1.Controls.Add(this.tv_menu);
            // 
            // sc_main.Panel2
            // 
            this.sc_main.Panel2.Controls.Add(this.tc_content);
            this.sc_main.Size = new System.Drawing.Size(800, 450);
            this.sc_main.SplitterDistance = 150;
            this.sc_main.TabIndex = 0;
            // 
            // tv_menu
            // 
            this.tv_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_menu.ItemHeight = 20;
            this.tv_menu.Location = new System.Drawing.Point(0, 0);
            this.tv_menu.Name = "tv_menu";
            treeNode1.Name = "Frm_record";
            treeNode1.Text = "记录";
            treeNode2.Name = "noetQuery";
            treeNode2.Text = "查询";
            treeNode3.Name = "noteManage";
            treeNode3.Text = "备忘管理";
            treeNode4.Name = "Frm_user";
            treeNode4.Text = "新增";
            treeNode5.Name = "userManage";
            treeNode5.Text = "用户管理";
            treeNode6.Name = "NoteBook.Frm_test";
            treeNode6.Text = "测试";
            treeNode7.Name = "waitFor";
            treeNode7.Text = "待定";
            this.tv_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5,
            treeNode7});
            this.tv_menu.Size = new System.Drawing.Size(150, 450);
            this.tv_menu.TabIndex = 0;
            this.tv_menu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_menu_AfterSelect);
            // 
            // tc_content
            // 
            this.tc_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_content.Location = new System.Drawing.Point(0, 0);
            this.tc_content.Name = "tc_content";
            this.tc_content.SelectedIndex = 0;
            this.tc_content.Size = new System.Drawing.Size(646, 450);
            this.tc_content.TabIndex = 0;
            // 
            // Frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sc_main);
            this.Name = "Frm_main";
            this.Text = "工作备忘";
            this.sc_main.Panel1.ResumeLayout(false);
            this.sc_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc_main)).EndInit();
            this.sc_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc_main;
        private System.Windows.Forms.TreeView tv_menu;
        private System.Windows.Forms.TabControl tc_content;
    }
}

