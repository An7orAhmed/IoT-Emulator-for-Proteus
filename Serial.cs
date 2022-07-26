using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace IoT_Emulator {
    static class Serial {
        public static SerialPort Port = new SerialPort();
        public static bool connected;

        public static bool Open(string port) {
            if (connected == false) {
                try {
                    Port.PortName = port;
                    Port.BaudRate = 9600;
                    Port.DataBits = 8;
                    Port.Parity = Parity.None;
                    Port.StopBits = StopBits.One;
                    Port.DiscardNull = true;
                    Port.Open();
                    Port.DiscardInBuffer();
                    connected = true;
                    return true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public static bool Close() {
            if (connected) {
                try {
                    Port.Close();
                    connected = false;
                    return true;
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }

        public static void Print(string cmd) {
            if(connected) Port.Write(cmd);
        }

        public static void Println(string cmd) {
            if (connected) Port.WriteLine(cmd);
        }

        public static string[] Ports() {
            return SerialPort.GetPortNames();
        }
    }
}
