﻿// See https://aka.ms/new-console-template for more information

using System.Text;

var position = 0;
using (Stream input = File.OpenRead("binarydata.dat"))
{
    var buffer = new byte[16];
    while (position < input.Length)
    {
// Read up to the next 16 bytes from the file into a byte array
        var bytesRead = input.Read(buffer, 0, buffer.Length);
// Write the position (or offset) in hex, followed by a colon and space
        Console.Write("{0:x4}: ", position);
        position += bytesRead;
// Write the hex value of each character in the byte array
        for (var i = 0; i < 16; i++)
        {
            if (i < bytesRead)
                Console.Write("{0:x2} ", (byte)buffer[i]);
            else
                Console.Write(" ");
            if (i == 7) Console.Write("-- ");
            if (buffer[i] < 0x20 || buffer[i] > 0x7F) buffer[i] = (byte)'.';
        }
// Write the actual characters in the byte array
        // var bufferContents = new string(buffer);
        // Write the actual characters in the byte array
        var bufferContents = Encoding.UTF8.GetString(buffer);
        Console.WriteLine(" {0}", bufferContents.Substring(0, bytesRead));
    }
}

