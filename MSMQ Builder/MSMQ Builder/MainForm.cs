using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Messaging;


namespace MSMQ_Builder
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DateTime now = DateTime.Now;
            string sNow = now.ToString("yyyy-MM-ddTHH:mm:ss.fff");
            rtbLogs.Text += "Closing Application at " + sNow + (char)(13) + (char)(10);
            SaveLogFile();

        }
        public void SaveLogFile()
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.FileName = "MSMQ-Builder.log";

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.log";
            saveFile1.Filter = "Log Files|*.log";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                rtbLogs.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.txt";
            openFile1.Filter = "Text Files|*.txt";

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                rtbQueues.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Read through the list of Queues and Build them.
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            // List<string> NewQueueList = new List<string>;

            for (int i = 0; i <= rtbQueues.Lines.Count()-1; i++)
            {
                // MessageQueue msgQ = new MessageQueue(".\\Private$\\billpay");
                string S = "";
                S = rtbQueues.Lines[i];
                if (S.Length < 1) break;
                rtbLogs.Text += "Adding Queue: " + S + (char)(13) + (char)(10);
                try
                {
                    string QueName = S;
                    int iLength = S.Length;
                    int index = S.LastIndexOf("\\");
                    if (index > 0) QueName = S.Substring(10, iLength-index);
                    rtbLogs.Text += "Label Name:" + QueName + (char)(13) + (char)(10); 
                    int newindex = QueName.LastIndexOf("\\");
                    if (newindex > 0) QueName = QueName.Substring(1,newindex);
                    QueName = QueName.Substring(1, QueName.Length - 1);
                    string SvrName = System.Environment.MachineName + "$";
                    MessageQueue msgQ = new MessageQueue(S);

                    if (!MessageQueue.Exists(S))
                    {
                        // Create the queue if it does not exist.  
                        rtbLogs.Text += "Creating New Queue: " + S + (char)(13) + (char)(10);
                        rtbLogs.Text += "Setting the permissions on the queue: " + S + (char)(13) + (char)(10);
                        msgQ = MessageQueue.Create(S, false);
                        msgQ.Label = QueName;
                        msgQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                        msgQ.SetPermissions("ANONYMOUS LOGON", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                        msgQ.SetPermissions(SvrName, MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                    }
                    else
                    {
                        rtbLogs.Text += "Queue already exists! : " + S + (char)(13) + (char)(10);
                        rtbLogs.Text += "Setting the permissions for Everyone on the queue: " + S + (char)(13) + (char)(10);
                        // using the same message queue reference
                        msgQ.Label = QueName;
                        try
                        { 
                        msgQ.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                        rtbLogs.Text += "Setting the permissions for Anonymous Logon on the queue: " + S + (char)(13) + (char)(10);
                        msgQ.SetPermissions("ANONYMOUS LOGON", MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                        msgQ.SetPermissions(SvrName, MessageQueueAccessRights.FullControl, AccessControlEntryType.Allow);
                        }
                        catch(IOException ex)
                        {
                            rtbLogs.Text += ex.ToString() + (char)(13) + (char)(10);
                        }
                    }

                }
                catch (IOException ex)
                {

                    rtbLogs.Text += ex.ToString() + (char)(13) + (char)(10);
                }
                tabControl1.SelectTab(1);
                tabControl1.Focus();

                
            }
           
        }

       
    }
}
