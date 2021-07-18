namespace NoteBook
{
    partial class FrmMain
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("协同发起");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("协同处理");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("协同查询");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("业务协同", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("采购合同");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("合同管理", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("新增");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("用户管理", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
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
            treeNode1.Name = "NoteBook.UI.FrmRecord";
            treeNode1.Text = "协同发起";
            treeNode2.Name = "NoteBook.UI.FrmProgress";
            treeNode2.Text = "协同处理";
            treeNode3.Name = "NoteBook.UI.List.FrmRecordList";
            treeNode3.Tag = "";
            treeNode3.Text = "协同查询";
            treeNode4.Name = "noteManage";
            treeNode4.Text = "业务协同";
            treeNode5.Name = "NoteBook.UI.Contract.FrmPoList";
            treeNode5.Text = "采购合同";
            treeNode6.Name = "contract";
            treeNode6.Text = "合同管理";
            treeNode7.Name = "NoteBook.UI.FrmUser";
            treeNode7.Text = "新增";
            treeNode8.Name = "userManage";
            treeNode8.Text = "用户管理";
            this.tv_menu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode6,
            treeNode8});
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sc_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "业务协同管理";
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

