namespace GraphicsWork
{
    partial class frmDraw
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDraw));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLine1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemLine2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPencil = new System.Windows.Forms.ToolStripButton();
            this.tsbLine = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsbEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsbEraser = new System.Windows.Forms.ToolStripButton();
            this.tsbColor = new System.Windows.Forms.ToolStripButton();
            this.tslSize = new System.Windows.Forms.ToolStripLabel();
            this.tstxtSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(778, 25);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.toolStripMenuItemLine1,
            this.OpenToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripMenuItemLine2,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.FileToolStripMenuItem.Text = "文件(&F)";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "新建(&N)";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // toolStripMenuItemLine1
            // 
            this.toolStripMenuItemLine1.Name = "toolStripMenuItemLine1";
            this.toolStripMenuItemLine1.Size = new System.Drawing.Size(149, 6);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "打开(&O)";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsToolStripMenuItem.Text = "另存为(&A)";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItemLine2
            // 
            this.toolStripMenuItemLine2.Name = "toolStripMenuItemLine2";
            this.toolStripMenuItemLine2.Size = new System.Drawing.Size(149, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "退出(&E)";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPencil,
            this.tsbLine,
            this.tsbRectangle,
            this.tsbEllipse,
            this.tsbEraser,
            this.toolStripSeparator1,
            this.tslSize,
            this.tstxtSize,
            this.toolStripSeparator2,
            this.tsbColor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(778, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPencil
            // 
            this.tsbPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPencil.Image = ((System.Drawing.Image)(resources.GetObject("tsbPencil.Image")));
            this.tsbPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPencil.Name = "tsbPencil";
            this.tsbPencil.Size = new System.Drawing.Size(36, 22);
            this.tsbPencil.Text = "画笔";
            this.tsbPencil.Click += new System.EventHandler(this.tsbPencil_Click);
            // 
            // tsbLine
            // 
            this.tsbLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLine.Image = ((System.Drawing.Image)(resources.GetObject("tsbLine.Image")));
            this.tsbLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLine.Name = "tsbLine";
            this.tsbLine.Size = new System.Drawing.Size(36, 22);
            this.tsbLine.Text = "直线";
            this.tsbLine.Click += new System.EventHandler(this.tsbLine_Click);
            // 
            // tsbRectangle
            // 
            this.tsbRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangle.Image")));
            this.tsbRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangle.Name = "tsbRectangle";
            this.tsbRectangle.Size = new System.Drawing.Size(36, 22);
            this.tsbRectangle.Text = "矩形";
            this.tsbRectangle.Click += new System.EventHandler(this.tsbRectangle_Click);
            // 
            // tsbEllipse
            // 
            this.tsbEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbEllipse.Image")));
            this.tsbEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEllipse.Name = "tsbEllipse";
            this.tsbEllipse.Size = new System.Drawing.Size(36, 22);
            this.tsbEllipse.Text = "椭圆";
            this.tsbEllipse.Click += new System.EventHandler(this.tsbEllipse_Click);
            // 
            // tsbEraser
            // 
            this.tsbEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEraser.Image = ((System.Drawing.Image)(resources.GetObject("tsbEraser.Image")));
            this.tsbEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEraser.Name = "tsbEraser";
            this.tsbEraser.Size = new System.Drawing.Size(36, 22);
            this.tsbEraser.Text = "橡皮";
            this.tsbEraser.Click += new System.EventHandler(this.tsbEraser_Click);
            // 
            // tsbColor
            // 
            this.tsbColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbColor.Image = ((System.Drawing.Image)(resources.GetObject("tsbColor.Image")));
            this.tsbColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColor.Name = "tsbColor";
            this.tsbColor.Size = new System.Drawing.Size(36, 22);
            this.tsbColor.Text = "颜色";
            this.tsbColor.Click += new System.EventHandler(this.tsbColor_Click);
            // 
            // tslSize
            // 
            this.tslSize.Name = "tslSize";
            this.tslSize.Size = new System.Drawing.Size(32, 22);
            this.tslSize.Text = "笔宽";
            // 
            // tstxtSize
            // 
            this.tstxtSize.Name = "tstxtSize";
            this.tstxtSize.Size = new System.Drawing.Size(30, 25);
            this.tstxtSize.Text = "1";
            this.tstxtSize.TextChanged += new System.EventHandler(this.tstxtSize_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // frmDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 533);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmDraw";
            this.Text = "C#自制绘图";
            this.Load += new System.EventHandler(this.frmDraw_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDraw_MouseUp);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemLine1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItemLine2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPencil;
        private System.Windows.Forms.ToolStripButton tsbLine;
        private System.Windows.Forms.ToolStripButton tsbRectangle;
        private System.Windows.Forms.ToolStripButton tsbEllipse;
        private System.Windows.Forms.ToolStripButton tsbEraser;
        private System.Windows.Forms.ToolStripButton tsbColor;
        private System.Windows.Forms.ToolStripLabel tslSize;
        private System.Windows.Forms.ToolStripTextBox tstxtSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

