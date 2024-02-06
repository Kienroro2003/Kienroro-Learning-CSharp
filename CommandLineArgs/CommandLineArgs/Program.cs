using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var position = 0;
            using (Stream input = File.OpenRead(args[0]))
            {
                var buffer = new byte[16];
                int bytesRead;
// Read up to the next 16 bytes from the file into a byte array
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                }

            }
        }
        }
    }