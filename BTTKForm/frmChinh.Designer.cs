namespace BTTKForm
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.họTênCủaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.họTênCủaSinhViênToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // họTênCủaSinhViênToolStripMenuItem
            // 
            this.họTênCủaSinhViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBai1,
            this.tsmBai2,
            this.tsmBai3});
            this.họTênCủaSinhViênToolStripMenuItem.Name = "họTênCủaSinhViênToolStripMenuItem";
            this.họTênCủaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(171, 24);
            this.họTênCủaSinhViênToolStripMenuItem.Text = "Trần Thị Phương Trang";
            // 
            // tsmBai1
            // 
            this.tsmBai1.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai1.Image")));
            this.tsmBai1.Name = "tsmBai1";
            this.tsmBai1.Size = new System.Drawing.Size(224, 26);
            this.tsmBai1.Text = "Bài 1";
            this.tsmBai1.Click += new System.EventHandler(this.tsmBai1_Click);
            // 
            // tsmBai2
            // 
            this.tsmBai2.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai2.Image")));
            this.tsmBai2.Name = "tsmBai2";
            this.tsmBai2.Size = new System.Drawing.Size(224, 26);
            this.tsmBai2.Text = "Bài 2";
            // 
            // tsmBai3
            // 
            this.tsmBai3.Image = ((System.Drawing.Image)(resources.GetObject("tsmBai3.Image")));
            this.tsmBai3.Name = "tsmBai3";
            this.tsmBai3.Size = new System.Drawing.Size(224, 26);
            this.tsmBai3.Text = "Bài 3";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmChinh";
            this.Text = "Chương trình chính";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem họTênCủaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBai1;
        private System.Windows.Forms.ToolStripMenuItem tsmBai2;
        private System.Windows.Forms.ToolStripMenuItem tsmBai3;
    }
}

