using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Messaging;


namespace File2MsMq
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public enum MessageType
        {
            MESSAGE_TYPE_PLAIN_TEXT = 0,
            MESSAGE_TYPE_HELLO_WORLD = 1
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to request a file to open.
            OpenFileDialog openFile1 = new OpenFileDialog();

            // Initialize the OpenFileDialog to look for RTF files.
            openFile1.DefaultExt = "*.fl";
            openFile1.Filter = "Flat Files|*.fl";
            //need to add other filters to the file open dialog.

            openFile1.FileName = Globals.sFileName;
            

            // Determine whether the user selected a file from the OpenFileDialog.
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                // Load the contents of the file into the RichTextBox.
                rtbQueues.Clear();
                rtbQueues.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        public static class Globals
        {

            public static String sFileName = "D:\\Omnicell\\His\\ZPMqs2ps.fl";

            public static String sMsMq = "";

        }

        private string StringJoin(string v, Func<int> count)
        {
            throw new NotImplementedException();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string S = "";
            if (rbLocal.Checked == true)  { S = cmbxLocalQueues.Text; }
              else { S = cmbxRemoteQueues.Text; }
            //S = Contains either the remote or local queue value
            if (S.Length < 1)
            {
                MessageBox.Show("MSMQ value cannot be empty!");
            }
            else
            {
                string QueName = S;
                int iLength = S.Length;
                int index = S.LastIndexOf("\\");
                if (index > 0) QueName = S.Substring(10, iLength - index);
                // 
                int newindex = QueName.LastIndexOf("\\");
                if (newindex > 0) QueName = QueName.Substring(1, newindex);
                QueName = QueName.Substring(1, QueName.Length - 1);
                try
                {                  
                    
                    if (rbLocal.Checked == true & rbRemote.Checked == false)
                    {
                        MessageQueue msgQ = new MessageQueue(S);
                        msgQ.MessageReadPropertyFilter.AppSpecific = true;
                        msgQ.Formatter = new ActiveXMessageFormatter();
                        string sLine = "";                       
                        
                        toolStripProgressBar1.Step = 1;
                        toolStripProgressBar1.Maximum = rtbQueues.Lines.Count();
                        string sCount = "";
                        for (int i = 0; i < rtbQueues.Lines.Count(); i++)
                        {
                            sLine = rtbQueues.Lines[i];
                            if (sLine.Length > 1)
                            {                                
                                msgQ.Send(sLine);
                                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;
                            }
                        }
                        //As the progress bar advances, I keep track of the value for final display of what was sent.
                        sCount = toolStripProgressBar1.Value.ToString();
                        toolStripProgressBar1.Value = rtbQueues.Lines.Count();
                        toolStripStatusLabel1.Text = "Finished Sending " + sCount + " messages.";
                        MessageBox.Show("Finished Sending " + sCount + " messages.");
                        // Application.Exit();
                        toolStripProgressBar1.Value = 0;
                        rtbQueues.Clear();
                        msgQ.Close();
                    }

                    if (rbRemote.Checked ==true & rbLocal.Checked == false)
                    {
                        MessageQueue msgRemoteQ = new MessageQueue(S);
                        msgRemoteQ.MessageReadPropertyFilter.AppSpecific = true;
                        msgRemoteQ.Formatter = new ActiveXMessageFormatter();
                        string sLine = "";

                        toolStripProgressBar1.Step = 1;
                        toolStripProgressBar1.Maximum = rtbQueues.Lines.Count();
                        string sCount = "";
                        for (int i = 0; i < rtbQueues.Lines.Count(); i++)
                        {
                            sLine = rtbQueues.Lines[i];
                            if (sLine.Length > 1)
                            {
                                msgRemoteQ.Send(sLine);
                                toolStripProgressBar1.Value = toolStripProgressBar1.Value + 1;
                            }
                        }
                        //As the progress bar advances, I keep track of the value for final display of what was sent.
                        sCount = toolStripProgressBar1.Value.ToString();
                        toolStripProgressBar1.Value = rtbQueues.Lines.Count();
                        toolStripStatusLabel1.Text = "Finished Sending " + sCount + " messages.";
                        MessageBox.Show("Finished Sending " + sCount + " messages.");
                        // Application.Exit();
                        toolStripProgressBar1.Value = 0;
                        rtbQueues.Clear();
                        msgRemoteQ.Close();
                    }
                }



                catch (IOException ex)
                {
                    MessageBox.Show(ex.ToString() + (char)(13) + (char)(10));
                }


            }

        }



        private void rbRemote_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRemote.Checked == true)
            {
                lblRemote.Visible = true;
                cmbxRemoteQueues.Visible = true;
                btnRemoteQ.Visible = true;
            }
            else
            {
                lblRemote.Visible = false;
                cmbxRemoteQueues.Visible = false;
                btnRemoteQ.Visible = false;
            }
            try
            {
                long X = 0;
                if (txtBoxServerName.Text == "")
                {
                     MessageBox.Show("Please fill out the Server Name of the remote queue.");
                    rbLocal.Checked = true;
                }
                 else
                 {
                  MessageQueue[] QueueList = MessageQueue.GetPrivateQueuesByMachine(txtBoxServerName.Text);

                       // Display the paths of the queues in the list.
                     foreach (MessageQueue queueItem in QueueList)
                     {                        
                          X++;
                          rtbQueues.AppendText( Convert.ToString(X) + " - "+ queueItem.Path + Environment.NewLine);
                          cmbxRemoteQueues.Items.Add( queueItem.Path );
                     }
                   toolStripStatusLabel1.Text = "Queues on remote machine: " + Convert.ToString(X);                
                 }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString() + (char)(13) + (char)(10));
            }
            return;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            rtbQueues.Clear();   
        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLocal.Checked==true)
            {
                lblRemote.Visible = false;
                cmbxRemoteQueues.Visible = false;
                btnRemoteQ.Visible = false;
            }
            else
            {
                lblRemote.Visible = true;
                cmbxRemoteQueues.Visible = true;
                btnRemoteQ.Visible = true;
            }
        }


        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(rtbQueues.Text);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                int X = 0;
                string S = "";
                rtbQueues.Clear();
                if (rbLocal.Checked == true) { S = cmbxLocalQueues.Text; }
                else
                {
                   S = cmbxRemoteQueues.Text;  //Not going to use the Remote Option for reading the queue.
                   MessageBox.Show("The option to read a remote queue does not Exists. Do you want to leave?", "Leave?", MessageBoxButtons.YesNo);
                  
                        var queue = new MessageQueue(S);
                        try
                        {
                            queue.Peek(new TimeSpan(0, 0, 5));
                            MessageBox.Show("Found the queue: " + S);
                        }
                        catch (MessageQueueException ex)
                        {
                            if(ex is ArgumentException)
                            {
                                MessageBox.Show("The provided Queue name is wrong.  ==> " + S);
                            }
                            else if (ex is MessageQueueException)
                            {
                                MessageBox.Show("Either the Queue does not exist, has no messages, or you do not have proper access.");
                            }
                            else MessageBox.Show(ex.Message.StartsWith("Timeout").ToString());
                        queue.Close();
                    }
                   
                }
               // rtbQueues.Text = S;
                List<string> lstMessages = new List<string>();
                if (S!="")
                {
                    toolStripStatusLabel1.Text = S;
                    if (!MessageQueue.Exists(@S))
                    {
                        toolStripStatusLabel1.Text = S + " <==  Does not Exists!?!?";
                    }
                    else
                    {
                        toolStripStatusLabel1.Text = S + " <==  Queue Exists!";
                        MessageQueue RxMsgQueue = new MessageQueue(S);
                        try
                        {
                            RxMsgQueue.Peek(new TimeSpan(0, 0, 5));
                            System.Messaging.Message[] messages = RxMsgQueue.GetAllMessages();
                            if (messages.Length <= 0) return;
                            else
                                foreach (System.Messaging.Message message in messages)
                                {
                                    RxMsgQueue.Formatter = new ActiveXMessageFormatter();
                                    System.Messaging.Message newMsg = RxMsgQueue.Receive();
                                    // Convert the messages with New Line characters
                                    string msgBody = (string)newMsg.Body + Environment.NewLine;
                                    lstMessages.Add(msgBody);
                                    X++;
                                    rtbQueues.AppendText(msgBody);
                                }
                        }
                        catch (MessageQueueException ex)
                        {
                            MessageBox.Show(ex.Message.StartsWith("Timeout").ToString());
                        }
                        RxMsgQueue.Close();
                    }
                }               
              
                toolStripStatusLabel1.Text = "Messages in Queue:  " + S + " ["+ Convert.ToString(X)+"]";
            }
        }

        private void findLocalPrivateQueuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string SvrName = Environment.MachineName;
            Int32 X = 0;
            MessageQueue[] QueueList = MessageQueue.GetPrivateQueuesByMachine(SvrName);

            // Display the paths of the queues in the list.
            foreach (MessageQueue queueItem in QueueList)
            {
                X++;
                rtbQueues.AppendText(Convert.ToString(X) + " - " + queueItem.Path + Environment.NewLine);
                cmbxLocalQueues.Items.Add(queueItem.Path);
                rtbQueues.AppendText(queueItem.Path);
            }
            toolStripStatusLabel1.Text = "Queues on local machine: " + Convert.ToString(X);
            findLocalPrivateQueuesToolStripMenuItem.Enabled = false;
            if (X > 0)
            {
                MessageBox.Show("Local Queue can now be selected.  You have " + Convert.ToString(X) + " private queues.");
                btnLocalQ.Enabled = false;
            }
        }

        private void cmbxLocalQueues_Leave(object sender, EventArgs e)
        {
            string S = "";
            S = cmbxLocalQueues.Text;
            if (S.Length < 1)
            {
                MessageBox.Show("Local MSMQ value cannot be empty!");
            }
            else
            {
                string QueName = S.ToLower();

                if (QueName.Contains("\\private$\\") == false)
                {
                    toolStripStatusLabel1.Text = "Queue Name: " + cmbxLocalQueues.Text;
                    MessageBox.Show("Queue name must contain '\\private$\\'  because this only works with local queues.", QueName);
                }
                else
                { 
                    int Y = S.IndexOf('\\');
                    string S2 = "." + S.Substring(Y);
                    cmbxLocalQueues.Text = S2;
                }


            }
        }

        private void cmbxLocalQueues_TextChanged(object sender, EventArgs e)
        {
            rtbQueues.Clear();
        }

        private void clearContentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbQueues.Clear();
            cmbxLocalQueues.Items.Clear();
            findLocalPrivateQueuesToolStripMenuItem.Enabled = true;
        }

        private void txtBoxServerName_Leave(object sender, EventArgs e)
        {

        }
    }
        
}

