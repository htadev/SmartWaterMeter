namespace SmartWaterMeter
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGraying = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdging = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOstu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJZ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCharactorSegment = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecongnization = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCutEdge = new System.Windows.Forms.ToolStripMenuItem();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenFile,
            this.menuCloseFile,
            this.menuSave});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // menuOpenFile
            // 
            this.menuOpenFile.Name = "menuOpenFile";
            this.menuOpenFile.Size = new System.Drawing.Size(181, 26);
            this.menuOpenFile.Text = "打开";
            this.menuOpenFile.Click += new System.EventHandler(this.menuOpenFile_Click);
            // 
            // menuCloseFile
            // 
            this.menuCloseFile.Name = "menuCloseFile";
            this.menuCloseFile.Size = new System.Drawing.Size(181, 26);
            this.menuCloseFile.Text = "关闭";
            this.menuCloseFile.Click += new System.EventHandler(this.menuCloseFile_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLocation,
            this.menuGraying,
            this.menuEdging,
            this.menuOstu,
            this.menuJZ,
            this.menuCutEdge,
            this.menuCharactorSegment,
            this.menuRecongnization});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // menuGraying
            // 
            this.menuGraying.Name = "menuGraying";
            this.menuGraying.Size = new System.Drawing.Size(181, 26);
            this.menuGraying.Text = "灰度化";
            this.menuGraying.Click += new System.EventHandler(this.menuGraying_Click);
            // 
            // menuEdging
            // 
            this.menuEdging.Name = "menuEdging";
            this.menuEdging.Size = new System.Drawing.Size(181, 26);
            this.menuEdging.Text = "边缘检测";
            this.menuEdging.Click += new System.EventHandler(this.menuEdging_Click);
            // 
            // menuOstu
            // 
            this.menuOstu.Name = "menuOstu";
            this.menuOstu.Size = new System.Drawing.Size(181, 26);
            this.menuOstu.Text = "OSTU二值化";
            this.menuOstu.Click += new System.EventHandler(this.menuOstu_Click);
            // 
            // menuLocation
            // 
            this.menuLocation.Name = "menuLocation";
            this.menuLocation.Size = new System.Drawing.Size(181, 26);
            this.menuLocation.Text = "字轮区域定位";
            this.menuLocation.Click += new System.EventHandler(this.menuLocation_Click);
            // 
            // menuJZ
            // 
            this.menuJZ.Name = "menuJZ";
            this.menuJZ.Size = new System.Drawing.Size(181, 26);
            this.menuJZ.Text = "倾斜矫正";
            this.menuJZ.Click += new System.EventHandler(this.menuJZ_Click);
            // 
            // menuCharactorSegment
            // 
            this.menuCharactorSegment.Name = "menuCharactorSegment";
            this.menuCharactorSegment.Size = new System.Drawing.Size(181, 26);
            this.menuCharactorSegment.Text = "字符分割";
            this.menuCharactorSegment.Click += new System.EventHandler(this.menuCharactorSegment_Click);
            // 
            // menuRecongnization
            // 
            this.menuRecongnization.Name = "menuRecongnization";
            this.menuRecongnization.Size = new System.Drawing.Size(181, 26);
            this.menuRecongnization.Text = "字符识别";
            this.menuRecongnization.Click += new System.EventHandler(this.menuRecongnization_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(17, 43);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(300, 400);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // menuSave
            // 
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(181, 26);
            this.menuSave.Text = "保存";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuCutEdge
            // 
            this.menuCutEdge.Name = "menuCutEdge";
            this.menuCutEdge.Size = new System.Drawing.Size(181, 26);
            this.menuCutEdge.Text = "去除边框";
            this.menuCutEdge.Click += new System.EventHandler(this.menuCutEdge_Click);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(613, 43);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(38, 44);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Location = new System.Drawing.Point(613, 335);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(38, 44);
            this.pb5.TabIndex = 3;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(613, 262);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(38, 44);
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(613, 189);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(38, 44);
            this.pb3.TabIndex = 5;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(613, 116);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(38, 44);
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 554);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Text = "字轮数字识别";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuCloseFile;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGraying;
        private System.Windows.Forms.ToolStripMenuItem menuEdging;
        private System.Windows.Forms.ToolStripMenuItem menuOstu;
        private System.Windows.Forms.ToolStripMenuItem menuLocation;
        private System.Windows.Forms.ToolStripMenuItem menuJZ;
        private System.Windows.Forms.ToolStripMenuItem menuCharactorSegment;
        private System.Windows.Forms.ToolStripMenuItem menuRecongnization;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuCutEdge;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
    }
}

