﻿
namespace Altman
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.treeView_func = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_index = new System.Windows.Forms.TabPage();
            this.label_logo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsmi_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Wizard = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Listening = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Plugins = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_showMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_productVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_index.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_func
            // 
            this.treeView_func.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_func.Location = new System.Drawing.Point(0, 0);
            this.treeView_func.Name = "treeView_func";
            this.treeView_func.Size = new System.Drawing.Size(140, 479);
            this.treeView_func.TabIndex = 0;
            this.treeView_func.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_func_NodeMouseDoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_func);
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.menuStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(821, 479);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_index);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(821, 455);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage_index
            // 
            this.tabPage_index.Controls.Add(this.label_logo);
            this.tabPage_index.Location = new System.Drawing.Point(4, 22);
            this.tabPage_index.Name = "tabPage_index";
            this.tabPage_index.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_index.Size = new System.Drawing.Size(813, 429);
            this.tabPage_index.TabIndex = 1;
            this.tabPage_index.Text = "Index";
            this.tabPage_index.UseVisualStyleBackColor = true;
            // 
            // label_logo
            // 
            this.label_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.ForeColor = System.Drawing.Color.DarkGray;
            this.label_logo.Location = new System.Drawing.Point(310, 254);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(500, 172);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "Altman";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Setting,
            this.Tsmi_Wizard,
            this.Tsmi_Listening,
            this.aboutToolStripMenuItem,
            this.Tsmi_Plugins});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsmi_Setting
            // 
            this.Tsmi_Setting.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tsmi_Setting.Name = "Tsmi_Setting";
            this.Tsmi_Setting.Size = new System.Drawing.Size(60, 24);
            this.Tsmi_Setting.Text = "Setting";
            this.Tsmi_Setting.Click += new System.EventHandler(this.Tsmi_Setting_Click);
            // 
            // Tsmi_Wizard
            // 
            this.Tsmi_Wizard.Enabled = false;
            this.Tsmi_Wizard.Name = "Tsmi_Wizard";
            this.Tsmi_Wizard.Size = new System.Drawing.Size(67, 24);
            this.Tsmi_Wizard.Text = "Wizzard";
            this.Tsmi_Wizard.Click += new System.EventHandler(this.Tsmi_Wizard_Click);
            // 
            // Tsmi_Listening
            // 
            this.Tsmi_Listening.Enabled = false;
            this.Tsmi_Listening.Name = "Tsmi_Listening";
            this.Tsmi_Listening.Size = new System.Drawing.Size(53, 24);
            this.Tsmi_Listening.Text = "Listen";
            this.Tsmi_Listening.Click += new System.EventHandler(this.Tsmi_Listening_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Tsmi_Plugins
            // 
            this.Tsmi_Plugins.Name = "Tsmi_Plugins";
            this.Tsmi_Plugins.Size = new System.Drawing.Size(61, 24);
            this.Tsmi_Plugins.Text = "Plugins";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_showMsg,
            this.toolStripStatusLabel_productVersion});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_showMsg
            // 
            this.toolStripStatusLabel_showMsg.Name = "toolStripStatusLabel_showMsg";
            this.toolStripStatusLabel_showMsg.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel_showMsg.Text = "showMsg";
            // 
            // toolStripStatusLabel_productVersion
            // 
            this.toolStripStatusLabel_productVersion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel_productVersion.Name = "toolStripStatusLabel_productVersion";
            this.toolStripStatusLabel_productVersion.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel_productVersion.Text = "productVersion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(827, 507);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 507);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altman";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_index.ResumeLayout(false);
            this.tabPage_index.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_func;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_index;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_productVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Setting;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Wizard;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Listening;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_showMsg;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Plugins;
    }
}
