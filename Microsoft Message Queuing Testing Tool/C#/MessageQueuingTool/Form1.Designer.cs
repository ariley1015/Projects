namespace MessageQueuingTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.importFileTxt = new System.Windows.Forms.TextBox();
            this.msgTXT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.queueTXT = new System.Windows.Forms.TextBox();
            this.errorTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.msgLabelTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(238, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message Queue:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(238, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Import Message File:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message:";
            // 
            // importFileTxt
            // 
            this.importFileTxt.Enabled = false;
            this.importFileTxt.Location = new System.Drawing.Point(414, 149);
            this.importFileTxt.Name = "importFileTxt";
            this.importFileTxt.Size = new System.Drawing.Size(412, 26);
            this.importFileTxt.TabIndex = 5;
            // 
            // msgTXT
            // 
            this.msgTXT.Location = new System.Drawing.Point(19, 222);
            this.msgTXT.Multiline = true;
            this.msgTXT.Name = "msgTXT";
            this.msgTXT.Size = new System.Drawing.Size(923, 247);
            this.msgTXT.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(776, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 58);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send Msg to Queue";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(835, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Browse";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MessageQueuingTool.Properties.Resources.wrench_128;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 192);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // queueTXT
            // 
            this.queueTXT.Location = new System.Drawing.Point(416, 25);
            this.queueTXT.Name = "queueTXT";
            this.queueTXT.Size = new System.Drawing.Size(526, 26);
            this.queueTXT.TabIndex = 12;
            this.queueTXT.Text = ".\\PRIVATE$\\QUEUENAME";
            // 
            // errorTXT
            // 
            this.errorTXT.Enabled = false;
            this.errorTXT.Location = new System.Drawing.Point(96, 481);
            this.errorTXT.Multiline = true;
            this.errorTXT.Name = "errorTXT";
            this.errorTXT.Size = new System.Drawing.Size(670, 58);
            this.errorTXT.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "Result:";
            // 
            // msgLabelTXT
            // 
            this.msgLabelTXT.Location = new System.Drawing.Point(414, 63);
            this.msgLabelTXT.Name = "msgLabelTXT";
            this.msgLabelTXT.Size = new System.Drawing.Size(528, 26);
            this.msgLabelTXT.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(238, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Message Label:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(238, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Queue Transaction Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Single",
            "None",
            "Automatic"});
            this.comboBox1.Location = new System.Drawing.Point(442, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 28);
            this.comboBox1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(238, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 26);
            this.label7.TabIndex = 19;
            this.label7.Text = "Code Page Identifier:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "iso-8859-1",
            "iso-8859-2",
            "iso-8859-3",
            "iso-8859-4",
            "iso-8859-5",
            "iso-8859-6",
            "iso-8859-7",
            "iso-8859-8",
            "iso-8859-9",
            "iso-8859-13",
            "iso-8859-15",
            "us-ascii",
            "utf-8",
            "utf-16",
            "IBM037",
            "IBM437",
            "IBM500",
            "ASMO-708",
            "DOS-720",
            "ibm737",
            "ibm775",
            "ibm850",
            "ibm852",
            "IBM855",
            "ibm857",
            "IBM00858",
            "IBM860",
            "ibm861",
            "DOS-862",
            "IBM863",
            "IBM864",
            "IBM865",
            "cp866",
            "ibm869",
            "IBM870",
            "windows-874",
            "cp875",
            "shift_jis",
            "gb2312",
            "ks_c_5601-1987",
            "big5",
            "IBM1026",
            "IBM01047",
            "IBM01140",
            "IBM01141",
            "IBM01142",
            "IBM01143",
            "IBM01144",
            "IBM01145",
            "IBM01146",
            "IBM01147",
            "IBM01148",
            "IBM01149",
            "utf-16",
            "unicodeFFFE",
            "windows-1250",
            "windows-1251",
            "Windows-1252",
            "windows-1253",
            "windows-1254",
            "windows-1255",
            "windows-1256",
            "windows-1257",
            "windows-1258",
            "Johab",
            "macintosh",
            "x-mac-japanese",
            "x-mac-chinesetrad",
            "x-mac-korean",
            "x-mac-arabic",
            "x-mac-hebrew",
            "x-mac-greek",
            "x-mac-cyrillic",
            "x-mac-chinesesimp",
            "x-mac-romanian",
            "x-mac-ukrainian",
            "x-mac-thai",
            "x-mac-ce",
            "x-mac-icelandic",
            "x-mac-turkish",
            "x-mac-croatian",
            "utf-32",
            "utf-32BE",
            "x-Chinese-CNS",
            "x-cp20001",
            "x-Chinese-Eten",
            "x-cp20003",
            "x-cp20004",
            "x-cp20005",
            "x-IA5",
            "x-IA5-German",
            "x-IA5-Swedish",
            "x-IA5-Norwegian",
            "x-cp20261",
            "x-cp20269",
            "IBM273",
            "IBM277",
            "IBM278",
            "IBM280",
            "IBM284",
            "IBM285",
            "IBM290",
            "IBM297",
            "IBM420",
            "IBM423",
            "IBM424",
            "x-EBCDIC-KoreanExtended",
            "IBM-Thai",
            "koi8-r",
            "IBM871",
            "IBM880",
            "IBM905",
            "IBM00924",
            "EUC-JP",
            "x-cp20936",
            "x-cp20949",
            "cp1025",
            "koi8-u",
            "x-Europa",
            "iso-8859-8-i",
            "iso-2022-jp",
            "csISO2022JP",
            "iso-2022-jp",
            "iso-2022-kr",
            "x-cp50227",
            "euc-jp",
            "EUC-CN",
            "euc-kr",
            "hz-gb-2312",
            "GB18030",
            "x-iscii-de",
            "x-iscii-be",
            "x-iscii-ta",
            "x-iscii-te",
            "x-iscii-as",
            "x-iscii-or",
            "x-iscii-ka",
            "x-iscii-ma",
            "x-iscii-gu",
            "x-iscii-pa",
            "utf-7"});
            this.comboBox2.Location = new System.Drawing.Point(414, 183);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(271, 28);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
            this.ClientSize = new System.Drawing.Size(1004, 611);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.msgLabelTXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.errorTXT);
            this.Controls.Add(this.queueTXT);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.msgTXT);
            this.Controls.Add(this.importFileTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Microsoft Message Queuing Testing Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox queueTXT;
        private System.Windows.Forms.TextBox errorTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox msgLabelTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

