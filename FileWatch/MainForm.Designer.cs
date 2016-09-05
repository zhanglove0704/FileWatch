namespace FileWatch
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBrowser1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPublish1 = new System.Windows.Forms.Button();
            this.btnPublish2 = new System.Windows.Forms.Button();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.btnPublish3 = new System.Windows.Forms.Button();
            this.btnBrowser3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPath3 = new System.Windows.Forms.TextBox();
            this.btnPublish4 = new System.Windows.Forms.Button();
            this.btnBrowser4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPath4 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主面板ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(97, 34);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(259, 21);
            this.txtPath1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "项目1监视目录:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(146, 233);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "开始监视";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(287, 233);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "停止监视";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.Location = new System.Drawing.Point(355, 33);
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(42, 23);
            this.btnBrowser1.TabIndex = 4;
            this.btnBrowser1.Tag = "1";
            this.btnBrowser1.Text = "...";
            this.btnBrowser1.UseVisualStyleBackColor = true;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnPublish1
            // 
            this.btnPublish1.Location = new System.Drawing.Point(417, 33);
            this.btnPublish1.Name = "btnPublish1";
            this.btnPublish1.Size = new System.Drawing.Size(85, 23);
            this.btnPublish1.TabIndex = 5;
            this.btnPublish1.Tag = "1";
            this.btnPublish1.Text = "生成发布内容";
            this.btnPublish1.UseVisualStyleBackColor = true;
            this.btnPublish1.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnPublish2
            // 
            this.btnPublish2.Location = new System.Drawing.Point(417, 75);
            this.btnPublish2.Name = "btnPublish2";
            this.btnPublish2.Size = new System.Drawing.Size(85, 23);
            this.btnPublish2.TabIndex = 9;
            this.btnPublish2.Tag = "2";
            this.btnPublish2.Text = "生成发布内容";
            this.btnPublish2.UseVisualStyleBackColor = true;
            this.btnPublish2.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.Location = new System.Drawing.Point(355, 75);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(42, 23);
            this.btnBrowser2.TabIndex = 8;
            this.btnBrowser2.Tag = "2";
            this.btnBrowser2.Text = "...";
            this.btnBrowser2.UseVisualStyleBackColor = true;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "项目2监视目录:";
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(97, 76);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(259, 21);
            this.txtPath2.TabIndex = 6;
            // 
            // btnPublish3
            // 
            this.btnPublish3.Location = new System.Drawing.Point(417, 116);
            this.btnPublish3.Name = "btnPublish3";
            this.btnPublish3.Size = new System.Drawing.Size(85, 23);
            this.btnPublish3.TabIndex = 13;
            this.btnPublish3.Tag = "3";
            this.btnPublish3.Text = "生成发布内容";
            this.btnPublish3.UseVisualStyleBackColor = true;
            this.btnPublish3.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnBrowser3
            // 
            this.btnBrowser3.Location = new System.Drawing.Point(355, 116);
            this.btnBrowser3.Name = "btnBrowser3";
            this.btnBrowser3.Size = new System.Drawing.Size(42, 23);
            this.btnBrowser3.TabIndex = 12;
            this.btnBrowser3.Tag = "3";
            this.btnBrowser3.Text = "...";
            this.btnBrowser3.UseVisualStyleBackColor = true;
            this.btnBrowser3.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "项目3监视目录:";
            // 
            // txtPath3
            // 
            this.txtPath3.Location = new System.Drawing.Point(97, 117);
            this.txtPath3.Name = "txtPath3";
            this.txtPath3.Size = new System.Drawing.Size(259, 21);
            this.txtPath3.TabIndex = 10;
            // 
            // btnPublish4
            // 
            this.btnPublish4.Location = new System.Drawing.Point(417, 159);
            this.btnPublish4.Name = "btnPublish4";
            this.btnPublish4.Size = new System.Drawing.Size(85, 23);
            this.btnPublish4.TabIndex = 17;
            this.btnPublish4.Tag = "4";
            this.btnPublish4.Text = "生成发布内容";
            this.btnPublish4.UseVisualStyleBackColor = true;
            this.btnPublish4.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // btnBrowser4
            // 
            this.btnBrowser4.Location = new System.Drawing.Point(355, 159);
            this.btnBrowser4.Name = "btnBrowser4";
            this.btnBrowser4.Size = new System.Drawing.Size(42, 23);
            this.btnBrowser4.TabIndex = 16;
            this.btnBrowser4.Tag = "4";
            this.btnBrowser4.Text = "...";
            this.btnBrowser4.UseVisualStyleBackColor = true;
            this.btnBrowser4.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "项目4监视目录:";
            // 
            // txtPath4
            // 
            this.txtPath4.Location = new System.Drawing.Point(97, 160);
            this.txtPath4.Name = "txtPath4";
            this.txtPath4.Size = new System.Drawing.Size(259, 21);
            this.txtPath4.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主面板ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 48);
            // 
            // 主面板ToolStripMenuItem
            // 
            this.主面板ToolStripMenuItem.Name = "主面板ToolStripMenuItem";
            this.主面板ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.主面板ToolStripMenuItem.Text = "主面板";
            this.主面板ToolStripMenuItem.Click += new System.EventHandler(this.主面板ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "文件监视器";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 283);
            this.Controls.Add(this.btnPublish4);
            this.Controls.Add(this.btnBrowser4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPath4);
            this.Controls.Add(this.btnPublish3);
            this.Controls.Add(this.btnBrowser3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPath3);
            this.Controls.Add(this.btnPublish2);
            this.Controls.Add(this.btnBrowser2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath2);
            this.Controls.Add(this.btnPublish1);
            this.Controls.Add(this.btnBrowser1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "文件监视器";
            this.MinimumSizeChanged += new System.EventHandler(this.MainForm_MinimumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBrowser1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnPublish1;
        private System.Windows.Forms.Button btnPublish2;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.Button btnPublish3;
        private System.Windows.Forms.Button btnBrowser3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPath3;
        private System.Windows.Forms.Button btnPublish4;
        private System.Windows.Forms.Button btnBrowser4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主面板ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

