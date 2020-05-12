namespace OTBL_SQL
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckMsMq = new System.Windows.Forms.Button();
            this.btnDataQueFile = new System.Windows.Forms.Button();
            this.btnSqlServer = new System.Windows.Forms.Button();
            this.btnGetCabData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.GbZpmType = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbLoad = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MsMqZPM = new System.Messaging.MessageQueue();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.omniCenterCPC01DataSet = new OTBL_SQL.OmniCenterCPC01DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GbZpmType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.omniCenterCPC01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnCheckMsMq);
            this.panel1.Controls.Add(this.btnDataQueFile);
            this.panel1.Controls.Add(this.btnSqlServer);
            this.panel1.Controls.Add(this.btnGetCabData);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GbZpmType);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 151);
            this.panel1.TabIndex = 0;
            // 
            // btnCheckMsMq
            // 
            this.btnCheckMsMq.Image = global::OTBL_SQL.Properties.Resources.TECH16;
            this.btnCheckMsMq.Location = new System.Drawing.Point(242, 92);
            this.btnCheckMsMq.Name = "btnCheckMsMq";
            this.btnCheckMsMq.Size = new System.Drawing.Size(25, 26);
            this.btnCheckMsMq.TabIndex = 19;
            this.btnCheckMsMq.Text = "...";
            this.btnCheckMsMq.UseVisualStyleBackColor = true;
            // 
            // btnDataQueFile
            // 
            this.btnDataQueFile.Image = global::OTBL_SQL.Properties.Resources.FILENEW1;
            this.btnDataQueFile.Location = new System.Drawing.Point(242, 68);
            this.btnDataQueFile.Name = "btnDataQueFile";
            this.btnDataQueFile.Size = new System.Drawing.Size(25, 25);
            this.btnDataQueFile.TabIndex = 18;
            this.btnDataQueFile.UseVisualStyleBackColor = true;
            // 
            // btnSqlServer
            // 
            this.btnSqlServer.Location = new System.Drawing.Point(183, 4);
            this.btnSqlServer.Name = "btnSqlServer";
            this.btnSqlServer.Size = new System.Drawing.Size(25, 21);
            this.btnSqlServer.TabIndex = 17;
            this.btnSqlServer.Text = "...";
            this.btnSqlServer.UseVisualStyleBackColor = true;
            this.btnSqlServer.Click += new System.EventHandler(this.btnSqlServer_Click);
            // 
            // btnGetCabData
            // 
            this.btnGetCabData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCabData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetCabData.Image = global::OTBL_SQL.Properties.Resources.EARTH16;
            this.btnGetCabData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetCabData.Location = new System.Drawing.Point(281, 48);
            this.btnGetCabData.Name = "btnGetCabData";
            this.btnGetCabData.Size = new System.Drawing.Size(159, 25);
            this.btnGetCabData.TabIndex = 16;
            this.btnGetCabData.Text = "   Get Cabinet Data";
            this.btnGetCabData.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(450, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 34);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Msg Transfer Type";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(52, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "MSMQ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(41, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "File";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // GbZpmType
            // 
            this.GbZpmType.Controls.Add(this.radioButton2);
            this.GbZpmType.Controls.Add(this.radioButton1);
            this.GbZpmType.Controls.Add(this.rbLoad);
            this.GbZpmType.Location = new System.Drawing.Point(213, 10);
            this.GbZpmType.Name = "GbZpmType";
            this.GbZpmType.Size = new System.Drawing.Size(227, 33);
            this.GbZpmType.TabIndex = 14;
            this.GbZpmType.TabStop = false;
            this.GbZpmType.Text = "ZPM Type";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 11);
            this.radioButton2.MinimumSize = new System.Drawing.Size(25, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "UnAssigned";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "UnLoad";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbLoad
            // 
            this.rbLoad.AutoSize = true;
            this.rbLoad.Checked = true;
            this.rbLoad.Location = new System.Drawing.Point(7, 11);
            this.rbLoad.Name = "rbLoad";
            this.rbLoad.Size = new System.Drawing.Size(49, 17);
            this.rbLoad.TabIndex = 0;
            this.rbLoad.TabStop = true;
            this.rbLoad.Text = "Load";
            this.rbLoad.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(84, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(152, 19);
            this.checkedListBox1.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 72);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(84, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Queue:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Output Data File:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cabinets:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Database:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SQL Server:";
            // 
            // MsMqZPM
            // 
            this.MsMqZPM.MessageReadPropertyFilter.LookupId = true;
            this.MsMqZPM.SynchronizingObject = this;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 466);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(644, 3);
            this.splitter1.TabIndex = 14;
            this.splitter1.TabStop = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.omniCenterCPC01DataSet;
            this.bindingSource1.Position = 0;
            // 
            // omniCenterCPC01DataSet
            // 
            this.omniCenterCPC01DataSet.DataSetName = "OmniCenterCPC01DataSet";
            this.omniCenterCPC01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripSplitButton1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 292);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 282);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(640, 10);
            this.progressBar1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 151);
            this.panel2.MinimumSize = new System.Drawing.Size(4, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 318);
            this.panel2.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "ZPMqs2ps.fl";
            this.saveFileDialog1.InitialDirectory = "..";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "C# OTBL vs. 2.0.0.1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::OTBL_SQL.Properties.Resources.TECH16;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "Version";
            this.toolStripSplitButton1.ToolTipText = "btnVersion";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 469);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "One Time Bin Load Tool - (SQL )";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbZpmType.ResumeLayout(false);
            this.GbZpmType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.omniCenterCPC01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGetCabData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox GbZpmType;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbLoad;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Messaging.MessageQueue MsMqZPM;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnCheckMsMq;
        private System.Windows.Forms.Button btnDataQueFile;
        private System.Windows.Forms.Button btnSqlServer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private OmniCenterCPC01DataSet omniCenterCPC01DataSet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
    }
}

