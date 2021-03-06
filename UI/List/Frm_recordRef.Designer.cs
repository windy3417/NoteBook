﻿namespace NoteBook.UI.List
{
    partial class Frm_recordRef
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_recordRef = new System.Windows.Forms.DataGridView();
            this.requesteDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_certain = new System.Windows.Forms.ToolStripButton();
            this.tsb_cancel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recordRef)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_recordRef
            // 
            this.dgv_recordRef.AllowUserToAddRows = false;
            this.dgv_recordRef.AllowUserToDeleteRows = false;
            this.dgv_recordRef.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_recordRef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_recordRef.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requesteDate,
            this.voucherNo,
            this.itemName,
            this.name});
            this.dgv_recordRef.Location = new System.Drawing.Point(12, 36);
            this.dgv_recordRef.Name = "dgv_recordRef";
            this.dgv_recordRef.ReadOnly = true;
            this.dgv_recordRef.RowTemplate.Height = 23;
            this.dgv_recordRef.Size = new System.Drawing.Size(776, 402);
            this.dgv_recordRef.TabIndex = 0;
            // 
            // requesteDate
            // 
            this.requesteDate.DataPropertyName = "requestDate";
            this.requesteDate.HeaderText = "申请日期";
            this.requesteDate.Name = "requesteDate";
            this.requesteDate.ReadOnly = true;
            // 
            // voucherNo
            // 
            this.voucherNo.DataPropertyName = "voucherNo";
            this.voucherNo.HeaderText = "项目编号";
            this.voucherNo.Name = "voucherNo";
            this.voucherNo.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.DataPropertyName = "itemName";
            this.itemName.HeaderText = "项目名称";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "申请人";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_certain,
            this.tsb_cancel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_certain
            // 
            this.tsb_certain.Image = global::NoteBook.Properties.Resources.effect;
            this.tsb_certain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_certain.Name = "tsb_certain";
            this.tsb_certain.Size = new System.Drawing.Size(52, 22);
            this.tsb_certain.Text = "确认";
            // 
            // tsb_cancel
            // 
            this.tsb_cancel.Image = global::NoteBook.Properties.Resources.giveUpAudit;
            this.tsb_cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_cancel.Name = "tsb_cancel";
            this.tsb_cancel.Size = new System.Drawing.Size(52, 22);
            this.tsb_cancel.Text = "取消";
            // 
            // Frm_recordRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_recordRef);
            this.Name = "Frm_recordRef";
            this.Text = "协同参照";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_recordRef)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_recordRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn requesteDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn voucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_certain;
        private System.Windows.Forms.ToolStripButton tsb_cancel;
    }
}