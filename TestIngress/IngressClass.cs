using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestIngress
{
    public class IngressClass
    {
        public void Ispis()
        {
            Console.WriteLine("Ispis");
        }
    }

    public class UDPSocket
    {
        public bool SendMessage(string dns, int port, string message, out string responseMessage)
        {
            UdpClient udpClient = new UdpClient(11000);
            try
            {
                if (dns == "")
                {
                    dns = "ingress.mobilisis.com";
                }

                udpClient.Connect(dns, port);

                Byte[] sendBytes = Encoding.ASCII.GetBytes(message);
                udpClient.Send(sendBytes, sendBytes.Length);

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                string returnData = Encoding.ASCII.GetString(receiveBytes);
                responseMessage = returnData.ToString();
                udpClient.Close();

                return true;
            }
            catch (Exception e)
            {
                responseMessage = "Error";
                return false;
            }
        }
    }
}
