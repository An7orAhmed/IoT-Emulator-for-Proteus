using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace IoT_Emulator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public static string authVal = "";
        public static string contentType = "application/x-www-form-urlencoded";
        string path = Path.GetDirectoryName(Application.ExecutablePath);

        private void Form1_Load(object sender, EventArgs e) {
            CheckForIllegalCrossThreadCalls = false;
            PostCTCombo.SelectedIndex = 0;
            //Tabs.TabPages.RemoveByKey("GSMTab");
            Serial.Port.DataReceived += DataReceived;
            UpdateCommandList();
            
            if (!Properties.Settings.Default.isDriverInstalled) {
                try {
                    Process.Start(path + "\\setup_nullcom64.exe");
                    Properties.Settings.Default.isDriverInstalled = true;
                    Properties.Settings.Default.Save();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e) {
            string cmd = Serial.Port.ReadLine();
            TerminalTxt.SelectionColor = Color.DarkRed;
            TerminalTxt.AppendText("DEVICE: " + cmd + '\n');
            TerminalTxt.ScrollToCaret();
            cmd = cmd.Replace("\r", "");

            if (cmd.IndexOf("URL=") != -1) {
                cmd = cmd.Remove(0, 4);
                URLTxt.Text = cmd;
                UrlSetBtn.PerformClick();
            }
            else if (cmd.IndexOf("LISTEN=") != -1) {
                cmd = cmd.Remove(0, 7);
                string[] val = cmd.Split(',');
                if (val.Length == 3) {
                    if (URLTxt.Text == "") {
                        MessageBox.Show("Please enter URL first!");
                        return;
                    }
                    if (val[1] == "") {
                        MessageBox.Show("Please enter listen to address!");
                        return;
                    }
                    ListenerList.BeginInvoke(new Action(() => {
                        ListenerList.Controls.Add(new Listener(val[0], URLTxt.Text, val[1], decimal.Parse(val[2]), LoopCheck.Checked));
                    }));
                }
            }
            else if (cmd.IndexOf("GET=") != -1) {
                cmd = cmd.Remove(0, 4);
                if (cmd[0] != '/') cmd = "/" + cmd;
                try {
                    string link = URLTxt.Text + cmd;
                    var request = WebRequest.Create(link);
                    request.Method = "GET";
                    if(authVal != "") request.Headers["Authorization"] = authVal;

                    var webResponse = request.GetResponse();
                    var webStream = webResponse.GetResponseStream();

                    var reader = new StreamReader(webStream);
                    var data = reader.ReadToEnd();

                    if (data != "") Serial.Println("RESP=" + data);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmd.IndexOf("POST=") != -1) {
                cmd = cmd.Remove(0, 5);
                if (cmd[0] != '/') cmd = "/" + cmd;
                try {
                    string[] raw = cmd.Split('?');
                    if (raw.Length == 2) {
                        string link = URLTxt.Text + raw[0];
                        var request = WebRequest.Create(link);
                        request.Method = "POST";
                        if (authVal != "") request.Headers["Authorization"] = authVal;

                        byte[] byteArray = Encoding.UTF8.GetBytes(raw[1]);
                        request.ContentType = contentType;
                        request.ContentLength = byteArray.Length;

                        var reqStream = request.GetRequestStream();
                        reqStream.Write(byteArray, 0, byteArray.Length);

                        var response = request.GetResponse();
                        var respStream = response.GetResponseStream();

                        var reader = new StreamReader(respStream);
                        string data = reader.ReadToEnd();

                        if (data != "") Serial.Println("RESP=" + data);
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (cmd.IndexOf("SMS=") != -1) {
                cmd = cmd.Remove(0, 4);
                string[] sms = cmd.Split(',');
                PhonePrint(Color.Blue, $"SMS RECEIVED\nNumber: {sms[0]}\nMessage: {sms[1]}");
            }
            else if (cmd.IndexOf("CALL=") != -1) {
                cmd = cmd.Remove(0, 5);
                string[] call = cmd.Split('#');
                PhonePrint(Color.Red, $"CALL FROM\nNumber: {call[0]}");
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e) {
            string[] ports = Serial.Ports();
            PortListCombo.Items.Clear();
            foreach (string port in ports) {
                PortListCombo.Items.Add(port);
            }
            if (PortListCombo.Items.Count > 0) PortListCombo.SelectedIndex = 0;
        }

        private void ConnectBtn_Click(object sender, EventArgs e) {
            string port = PortListCombo.Text;
            if (port != "") {
                if (!Serial.connected) {
                    if (Serial.Open(port)) ConnectBtn.Text = "Disconnect";
                }
                else {
                    if (Serial.Close()) ConnectBtn.Text = "Connect";
                }
            }

        }

        private void UrlSetBtn_Click(object sender, EventArgs e) {
            try {
                if (URLTxt.Text != "") {
                    UpdateLbl.Visible = false;
                    Browser.Url = new Uri(URLTxt.Text);
                    Browser.Refresh();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                URLTxt.Text = "";
                UpdateLbl.Visible = true;
            }
        }

        private void radioGET_CheckedChanged(object sender, EventArgs e) {
            if (radioGET.Checked) {
                radioPOST.Checked = false;
            }
        }

        private void radioPOST_CheckedChanged(object sender, EventArgs e) {
            if (radioPOST.Checked) {
                radioGET.Checked = false;
            }
        }

        private void ListenAddBtn_Click(object sender, EventArgs e) {
            if (URLTxt.Text == "") {
                MessageBox.Show("Please enter URL first!");
                return;
            }
            if (ListenToTxt.Text == "") {
                MessageBox.Show("Please enter listen to address!");
                return;
            }
            string method = radioGET.Checked ? "GET" : "POST";
            ListenerList.BeginInvoke(new Action(() => {
                ListenerList.Controls.Add(new Listener(method, URLTxt.Text, ListenToTxt.Text, ListenInterval.Value, LoopCheck.Checked));
            }));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start("https://www.facebook.com/An7orAhmed");
        }

        private void AddCmdBtn_Click(object sender, EventArgs e) {
            if(AddCmdTxt.Text == "") {
                MessageBox.Show("Empty Command!");
                return;
            }
            if(Properties.Settings.Default.savedCmd == null) {
                Properties.Settings.Default.savedCmd = new StringCollection();
            }
            Properties.Settings.Default.savedCmd.Add(AddCmdTxt.Text);
            Properties.Settings.Default.Save();
            UpdateCommandList();
        }

        private void UpdateCommandList() {
            if (Properties.Settings.Default.savedCmd != null) {
                CommandList.Controls.Clear();
                foreach (var text in Properties.Settings.Default.savedCmd) {
                    Button button = new Button {
                        Size = new Size(130, 35),
                        Text = text
                    };
                    button.Click += (sndr, ea) => Button_Click(sndr, ea, text);
                    CommandList.Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sndr, EventArgs ea, string text) {
            Serial.Println(text);
            TerminalTxt.SelectionColor = Color.DarkGreen;
            TerminalTxt.AppendText("PC: " + text + "\r\n");
            TerminalTxt.ScrollToCaret();
        }

        private void SendBtn_Click(object sender, EventArgs e) {
            if(SendTxt.Text == "") return;  
            Serial.Println(SendTxt.Text);
            TerminalTxt.SelectionColor = Color.DarkGreen;
            TerminalTxt.AppendText("PC: " + SendTxt.Text + "\r\n");
            TerminalTxt.ScrollToCaret();
            SendTxt.Text = "";
        }

        private void SendTxt_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                SendBtn.PerformClick();
            }
        }

        private void RemoveCmdBtn_Click(object sender, EventArgs e) {
            int i = Properties.Settings.Default.savedCmd.Count;
            if (i > 0) {
                Properties.Settings.Default.savedCmd.RemoveAt(i - 1);
                UpdateCommandList();
            }
        }

        private void BlynkRunBtn_Click(object sender, EventArgs e) {
            string port = PortListCombo.Text;
            if (port != "") {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.Arguments = $"/C \"{path}\\Blynk\\blynk-ser.bat\" -c {port}";
                cmd.Start();
            }
        }

        private void PostCTCombo_SelectedIndexChanged(object sender, EventArgs e) {
            contentType = PostCTCombo.Text;
        }

        private void AuthTxt_TextChanged(object sender, EventArgs e) {
            authVal = AuthTxt.Text;
        }

        private void GSMCallBtn_Click(object sender, EventArgs e) {
            if(GSMNumberTxt.Text == "") {
                MessageBox.Show("Please enter phone number!");
                return;
            }
            PhonePrint(Color.Red, $"CALL FROM\nNumber: {GSMNumberTxt.Text}");
        }

        private void GSMSMSBtn_Click(object sender, EventArgs e) {
            if (GSMNumberTxt.Text == "") {
                MessageBox.Show("Please enter phone number!");
                return;
            }
            PhonePrint(Color.Blue, $"SMS RECEIVED\nNumber: {GSMNumberTxt.Text}\nMessage: {GSMMSGTxt.Text}");
        }

        private void PhonePrint(Color color, String txt) {
            PhoneTerminalTxt.SelectionColor = color;
            PhoneTerminalTxt.AppendText(txt + "\r\n");
            PhoneTerminalTxt.AppendText("-------------------\r\n");
            PhoneTerminalTxt.ScrollToCaret();
        }
    }
}
