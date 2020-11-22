namespace NoteBook.UI
{
    partial class Frm_record
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
            this.utoolStrip1 = new Utility.UControl.UtoolStrip();
            this.SuspendLayout();
            // 
            // utoolStrip1
            // 
            this.utoolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.utoolStrip1.Location = new System.Drawing.Point(0, 0);
            this.utoolStrip1.Name = "utoolStrip1";
            this.utoolStrip1.Size = new System.Drawing.Size(800, 21);
            this.utoolStrip1.TabIndex = 0;
            // 
            // Frm_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.utoolStrip1);
            this.Name = "Frm_record";
            this.Text = "备忘记录";
            this.ResumeLayout(false);

        }

        #endregion

        private Utility.UControl.UtoolStrip utoolStrip1;
    }
}