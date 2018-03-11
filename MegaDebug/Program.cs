using System;
using System.Text;
using System.IO;
using System.IO.Ports;

namespace MegaDebug
{
    public partial class Program
    {
        private const byte DATA_STREAM_MODE_ASCII = 1;
        private const byte DATA_STREAM_MODE_DECIMAL = 2;
        private const byte DATA_STREAM_MODE_HEXADECIMAL = 3;

        private static void Main(string[] args)
        {
            SerialPort port = null;

            try
            {
                string[] ports = SerialPort.GetPortNames();

                Console.WriteLine("Please enter port name or push enter to use first one.");
                Console.WriteLine("Available ports:");
                for (int i = 0; i < ports.Length; i++)
                {
                    Console.WriteLine(ports[i]);
                }
                string portSelection = Console.ReadLine();
                if (portSelection.Equals(""))
                    portSelection = ports[0];

                port = new SerialPort(portSelection);
                port.Open();

                Console.WriteLine("Connected to " + port.PortName);

                Console.WriteLine("Select operation:");
                Console.WriteLine("1. Debug");
                Console.WriteLine("2. Read data stream");

                byte operation = Convert.ToByte(Console.ReadLine());

                switch(operation)
                {
                    case 1:
                        Debug(port);
                        break;
                    case 2:
                        Console.WriteLine("Select data interpretation:");
                        Console.WriteLine("1. ASCII");
                        Console.WriteLine("2. Decimal");
                        Console.WriteLine("3. Hexadecimal");
                        bool validInterpretationMode = false;
                        byte mode = 0;
                        while (!validInterpretationMode)
                        {
                            mode = Convert.ToByte(Console.ReadLine());
                            if (mode == DATA_STREAM_MODE_ASCII || mode == DATA_STREAM_MODE_DECIMAL || mode == DATA_STREAM_MODE_HEXADECIMAL) validInterpretationMode = true;
                        }

                        ReadDataStream(port, mode);
                        break;
                }

            }
            catch (Exception x)
            {
                Console.WriteLine("ERROR: " + x.Message);
            }
        }

        private static void ReadDataStream(SerialPort port, byte mode)
        {
            while (true)
            {
                switch (mode)
                {
                    case DATA_STREAM_MODE_ASCII:
                        Console.WriteLine((char)port.ReadByte());
                        break;
                    case DATA_STREAM_MODE_DECIMAL:
                        Console.WriteLine(port.ReadByte());
                        break;
                    case DATA_STREAM_MODE_HEXADECIMAL:
                        Console.WriteLine(port.ReadByte().ToString("X"));
                        break;
                }
               
            }
        }
    }
}