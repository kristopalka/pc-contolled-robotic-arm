using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using S = RoboticArm.Properties.Settings;

namespace RoboticArm
{
    static class Arduino
    {
        static SerialPort port;
        static bool isConnected = false;

        public static bool IsConnected()
        {
            return isConnected;
        }

        public static string PortName()
        {
            return port.PortName;
        }

        public static bool Conect(string _port)
        {
            port = new SerialPort(_port, 9600, Parity.None, 8, StopBits.One);
            port.ReadTimeout = 10000;

            try
            {
                port.Open();
                Send(255, 0);

                int read = port.ReadByte();
                //MessageBox.Show(read);
                if (read != 255) return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Connection timeout in port " + _port);
                port.Close();
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access denied in port " + _port);
                return false;
            }
            catch (IOException)
            {
                MessageBox.Show("Port " + _port + " does not exist.");
                return false;
            }
            //MessageBox.Show("Connected succesfully in port " + _port);
            isConnected = true;
            return true;
        }

        public static void Send(byte head, byte data)
        {
            byte[] toSend = new byte[2];

            toSend[0] = head;
            toSend[1] = data;

            port.Write(toSend, 0, 2);

        }

        public static bool Disconnect()
        {
            if (!isConnected) return false;
            
            Send(0, 0);
            try
            {
                int read = port.ReadByte();
                //MessageBox.Show(read);
                if (read != 0) return false;
            }
            catch (TimeoutException)
            {
                MessageBox.Show("Port does not respond");
            }

            //MessageBox.Show("Disconnected succesfully");
            port.Close();
            isConnected = false;
            return true;
        }

    }
}
