using System;
using System.Windows.Forms;

namespace File2MsMq
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSend = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.rtbQueues = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoteQ = new System.Windows.Forms.Button();
            this.btnLocalQ = new System.Windows.Forms.Button();
            this.cmbxLocalQueues = new System.Windows.Forms.ComboBox();
            this.lblRemote = new System.Windows.Forms.Label();
            this.cmbxRemoteQueues = new System.Windows.Forms.ComboBox();
            this.lblQueue = new System.Windows.Forms.Label();
            this.gbQueType = new System.Windows.Forms.GroupBox();
            this.rbRemote = new System.Windows.Forms.RadioButton();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.txtBoxServerName = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSMQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findLocalPrivateQueuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbQueType.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSend,
            this.toolStripSeparator1,
            this.toolStripProgressBar1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpen
            // 
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(77, 22);
            this.btnOpen.Text = "FIle Open";
            this.btnOpen.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnSend
            // 
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(102, 22);
            this.btnSend.Text = "Send 2 MSMQ";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 22);
            // 
            // rtbQueues
            // 
            this.rtbQueues.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rtbQueues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbQueues.ForeColor = System.Drawing.Color.LawnGreen;
            this.rtbQueues.Location = new System.Drawing.Point(0, 101);
            this.rtbQueues.Name = "rtbQueues";
            this.rtbQueues.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbQueues.ShowSelectionMargin = true;
            this.rtbQueues.Size = new System.Drawing.Size(888, 323);
            this.rtbQueues.TabIndex = 1;
            this.rtbQueues.Text = "";
            this.rtbQueues.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemoteQ);
            this.panel1.Controls.Add(this.btnLocalQ);
            this.panel1.Controls.Add(this.cmbxLocalQueues);
            this.panel1.Controls.Add(this.lblRemote);
            this.panel1.Controls.Add(this.cmbxRemoteQueues);
            this.panel1.Controls.Add(this.lblQueue);
            this.panel1.Controls.Add(this.gbQueType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 52);
            this.panel1.TabIndex = 2;
            // 
            // btnRemoteQ
            // 
            this.btnRemoteQ.Location = new System.Drawing.Point(766, 27);
            this.btnRemoteQ.Name = "btnRemoteQ";
            this.btnRemoteQ.Size = new System.Drawing.Size(75, 23);
            this.btnRemoteQ.TabIndex = 9;
            this.btnRemoteQ.Text = "Find Remote";
            this.btnRemoteQ.UseVisualStyleBackColor = true;
            this.btnRemoteQ.Visible = false;
            this.btnRemoteQ.Click += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // btnLocalQ
            // 
            this.btnLocalQ.Location = new System.Drawing.Point(766, 4);
            this.btnLocalQ.Name = "btnLocalQ";
            this.btnLocalQ.Size = new System.Drawing.Size(75, 23);
            this.btnLocalQ.TabIndex = 8;
            this.btnLocalQ.Text = "Find LocalQ";
            this.btnLocalQ.UseVisualStyleBackColor = true;
            this.btnLocalQ.Click += new System.EventHandler(this.findLocalPrivateQueuesToolStripMenuItem_Click);
            // 
            // cmbxLocalQueues
            // 
            this.cmbxLocalQueues.FormattingEnabled = true;
            this.cmbxLocalQueues.Location = new System.Drawing.Point(343, 6);
            this.cmbxLocalQueues.Name = "cmbxLocalQueues";
            this.cmbxLocalQueues.Size = new System.Drawing.Size(417, 21);
            this.cmbxLocalQueues.TabIndex = 7;
            this.cmbxLocalQueues.TextChanged += new System.EventHandler(this.cmbxLocalQueues_TextChanged);
            this.cmbxLocalQueues.Leave += new System.EventHandler(this.cmbxLocalQueues_Leave);
            // 
            // lblRemote
            // 
            this.lblRemote.AutoSize = true;
            this.lblRemote.Location = new System.Drawing.Point(224, 32);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(113, 13);
            this.lblRemote.TabIndex = 6;
            this.lblRemote.Text = "Remote Queue Name:";
            this.lblRemote.Visible = false;
            // 
            // cmbxRemoteQueues
            // 
            this.cmbxRemoteQueues.FormattingEnabled = true;
            this.cmbxRemoteQueues.Location = new System.Drawing.Point(343, 29);
            this.cmbxRemoteQueues.Name = "cmbxRemoteQueues";
            this.cmbxRemoteQueues.Size = new System.Drawing.Size(417, 21);
            this.cmbxRemoteQueues.TabIndex = 5;
            this.cmbxRemoteQueues.Visible = false;
            this.cmbxRemoteQueues.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(221, 9);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(102, 13);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "Local Queue Name:";
            // 
            // gbQueType
            // 
            this.gbQueType.Controls.Add(this.rbRemote);
            this.gbQueType.Controls.Add(this.rbLocal);
            this.gbQueType.Location = new System.Drawing.Point(3, 3);
            this.gbQueType.Name = "gbQueType";
            this.gbQueType.Size = new System.Drawing.Size(215, 49);
            this.gbQueType.TabIndex = 1;
            this.gbQueType.TabStop = false;
            this.gbQueType.Text = "Private Queue Type";
            // 
            // rbRemote
            // 
            this.rbRemote.AutoSize = true;
            this.rbRemote.Location = new System.Drawing.Point(115, 16);
            this.rbRemote.Name = "rbRemote";
            this.rbRemote.Size = new System.Drawing.Size(97, 17);
            this.rbRemote.TabIndex = 1;
            this.rbRemote.Text = "Remote Queue";
            this.rbRemote.UseVisualStyleBackColor = true;
            this.rbRemote.CheckedChanged += new System.EventHandler(this.rbRemote_CheckedChanged);
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Checked = true;
            this.rbLocal.Location = new System.Drawing.Point(6, 16);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(86, 17);
            this.rbLocal.TabIndex = 0;
            this.rbLocal.TabStop = true;
            this.rbLocal.Text = "Local Queue";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.rbLocal_CheckedChanged);
            // 
            // txtBoxServerName
            // 
            this.txtBoxServerName.Location = new System.Drawing.Point(511, 25);
            this.txtBoxServerName.Name = "txtBoxServerName";
            this.txtBoxServerName.Size = new System.Drawing.Size(160, 20);
            this.txtBoxServerName.TabIndex = 4;
            this.txtBoxServerName.Leave += new System.EventHandler(this.txtBoxServerName_Leave);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(433, 28);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(72, 13);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server Name:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 24);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(180, 19);
            this.toolStripStatusLabel1.Text = "Omnicell Interface Testing Tools";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(743, 434);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 13);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version: 2.0.0.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mSMQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "&File";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openFileToolStripMenuItem.Text = "&Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saveToFileToolStripMenuItem.Text = "&Save to File";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mSMQToolStripMenuItem
            // 
            this.mSMQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendToolStripMenuItem,
            this.receiveToolStripMenuItem,
            this.findLocalPrivateQueuesToolStripMenuItem,
            this.clearContentsToolStripMenuItem});
            this.mSMQToolStripMenuItem.Name = "mSMQToolStripMenuItem";
            this.mSMQToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.mSMQToolStripMenuItem.Text = "&MSMQ";
            // 
            // sendToolStripMenuItem
            // 
            this.sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            this.sendToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sendToolStripMenuItem.Text = "&Send";
            this.sendToolStripMenuItem.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // receiveToolStripMenuItem
            // 
            this.receiveToolStripMenuItem.Name = "receiveToolStripMenuItem";
            this.receiveToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.receiveToolStripMenuItem.Text = "&Receive";
            this.receiveToolStripMenuItem.Click += new System.EventHandler(this.receiveToolStripMenuItem_Click);
            // 
            // findLocalPrivateQueuesToolStripMenuItem
            // 
            this.findLocalPrivateQueuesToolStripMenuItem.Name = "findLocalPrivateQueuesToolStripMenuItem";
            this.findLocalPrivateQueuesToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.findLocalPrivateQueuesToolStripMenuItem.Text = "&Find Local Private Queues";
            this.findLocalPrivateQueuesToolStripMenuItem.Click += new System.EventHandler(this.findLocalPrivateQueuesToolStripMenuItem_Click);
            // 
            // clearContentsToolStripMenuItem
            // 
            this.clearContentsToolStripMenuItem.Name = "clearContentsToolStripMenuItem";
            this.clearContentsToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.clearContentsToolStripMenuItem.Text = "&Clear All";
            this.clearContentsToolStripMenuItem.Click += new System.EventHandler(this.clearContentsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 448);
            this.Controls.Add(this.rtbQueues);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxServerName);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "File to MSMQ Sender";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbQueType.ResumeLayout(false);
            this.gbQueType.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSend;
        private System.Windows.Forms.RichTextBox rtbQueues;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxServerName;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.GroupBox gbQueType;
        private System.Windows.Forms.RadioButton rbRemote;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox cmbxRemoteQueues;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSMQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveToolStripMenuItem;
        private ToolStripMenuItem findLocalPrivateQueuesToolStripMenuItem;
        private ComboBox cmbxLocalQueues;
        private ToolStripMenuItem clearContentsToolStripMenuItem;
        private Button btnLocalQ;
        private Button btnRemoteQ;
    }
}

