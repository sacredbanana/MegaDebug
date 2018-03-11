using System;
using System.Text;
using System.IO;
using System.IO.Ports;

namespace MegaDebug
{
    public partial class Program
    {
        private static void Debug(SerialPort port)
        {
            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Motorola 68000 Registry Contents");
            RegistryContents(port);
        }

        private static void RegistryContents(SerialPort port)
        {
            bool debugDataHeaderCaptured = false;
            while (!debugDataHeaderCaptured)
            {
                if ((char)port.ReadByte() == 'D')
                {
                    if ((char)port.ReadByte() == 'B')
                    {
                        if ((char)port.ReadByte() == 'G')
                        {
                            debugDataHeaderCaptured = true;
                        }
                    }
                }
            }

            byte[] byteArray = new byte[4];

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            UInt32 longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D0: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D1: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D2: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D3: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D4: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D5: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D6: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"D7: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A0: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A1: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A2: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A3: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A4: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A5: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A6: {longData.ToString("X")}");

            byteArray[3] = (byte)port.ReadByte();
            byteArray[2] = (byte)port.ReadByte();
            byteArray[1] = (byte)port.ReadByte();
            byteArray[0] = (byte)port.ReadByte();

            if (BitConverter.IsLittleEndian) Array.Reverse(byteArray);
            longData = BitConverter.ToUInt32(byteArray, 0);
            Console.WriteLine($"A7: {longData.ToString("X")}");
            Console.ReadKey();
        }
    }
}
