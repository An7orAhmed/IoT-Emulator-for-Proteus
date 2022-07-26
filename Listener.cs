using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT_Emulator {
    public partial class Listener : UserControl {

        string url = "";
        string prevData = "";
        string responseStr = "";

        public Listener(string _method, string _url, string _listenTo, decimal _interval) {
            InitializeComponent();
            url = _url;
            MethodLbl.Text = _method;
            ListenToTxt.Text = _listenTo;
            if (_listenTo[0] != '/') ListenToTxt.Text = "/" + _listenTo;
            timer1.Interval = (int)_interval * 1000;
            IntervalTxt.Text = _interval.ToString();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void CloseBtn_Click(object sender, EventArgs e) {
            Dispose();
        }

        private async void Timer1_Tick(object sender, EventArgs e) {
            try {
                await Task.Run(() => {
                    if (MethodLbl.Text == "GET") {
                        string link = url + ListenToTxt.Text;
                        var request = WebRequest.Create(link);
                        request.Method = MethodLbl.Text;
                        if (Form1.authVal != "") request.Headers["Authorization"] = Form1.authVal;

                        var webResponse = request.GetResponse();
                        var webStream = webResponse.GetResponseStream();

                        var reader = new StreamReader(webStream);
                        var data = reader.ReadToEnd();

                        responseStr = data;
                        ShowRespBtn.BackColor = System.Drawing.Color.Lime;
                        if (prevData != data) {
                            Serial.Println("RESP=" + data);
                            prevData = data;
                        }
                    }
                    else if (MethodLbl.Text == "POST") {
                        string[] raw = ListenToTxt.Text.Split('?');
                        if (raw.Length == 2) {
                            string link = url + raw[0];
                            var request = WebRequest.Create(link);
                            request.Method = MethodLbl.Text;
                            if (Form1.authVal != "") request.Headers["Authorization"] = Form1.authVal;

                            byte[] byteArray = Encoding.UTF8.GetBytes(raw[1]);
                            request.ContentType = Form1.contentType;
                            request.ContentLength = byteArray.Length;

                            var reqStream = request.GetRequestStream();
                            reqStream.Write(byteArray, 0, byteArray.Length);

                            var response = request.GetResponse();
                            var respStream = response.GetResponseStream();

                            var reader = new StreamReader(respStream);
                            string data = reader.ReadToEnd();

                            responseStr = data;
                            ShowRespBtn.BackColor = System.Drawing.Color.Lime;
                            if (prevData != data) {
                                Serial.Println("RESP=" + data);
                                prevData = data;
                            }
                        }
                    }
                });     
            }
            catch (Exception ex) {
                ShowRespBtn.BackColor = System.Drawing.Color.Yellow;
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void ShowRespBtn_Click(object sender, EventArgs e) {
            MessageBox.Show(responseStr);
        }
    }
}
