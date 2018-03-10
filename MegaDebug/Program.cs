using System;
using System.Text;
using System.IO;
using System.IO.Ports;


namespace usb_test
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort port = null;

            try
            {
                string[] ports = SerialPort.GetPortNames();

                Console.WriteLine("Please enter port name");
                Console.WriteLine("Available ports:");
                for (int i = 0; i < ports.Length; i++)
                {
                    Console.WriteLine(ports[i]);
                }

                port = new SerialPort(Console.ReadLine());
                port.Open();

                Console.WriteLine("Connected to " + port.PortName);

                for (; ; )
                {
                    Console.Write("" + (char)port.ReadByte());
                }

            }
            catch (Exception x)
            {
                Console.WriteLine("ERROR: " + x.Message);
            }
        }
    }
}