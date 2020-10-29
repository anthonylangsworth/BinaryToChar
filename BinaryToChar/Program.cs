using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace BinaryToChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = 
                @"01000011 01101111 01100001 01101100
                  01110011 01100001 01100011 01101011
                  00100000 01001110 01100101 01100010
                  01110101 01101100 01100001 00101110
                  00100000 01010100 01101000 01100101

                  00100000 01110011 01110100 01101111
                  01101110 01100101 01110011 00101110
                  00100000 01001000 01100101 00100000
                  01101011 01100101 01100101 01110000
                  01110011 00100000 01110111 01100001

                  01110100 01100011 01101000 01101001
                  01101110 01100111 00100000 01110100
                  01101000 01100101 00100000 01110011
                  01110100 01101111 01101110 01100101
                  01110011 00101110 00100000";
            string[] lines = input.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] bytes = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string byteString in bytes)
                {
                    Console.Out.Write(Encoding.UTF8.GetString(new byte[] { Convert.ToByte(byteString, 2) }));
                }

                // Comment this out to get it on one line
                Console.Out.WriteLine();
            }
        }
    }
}
