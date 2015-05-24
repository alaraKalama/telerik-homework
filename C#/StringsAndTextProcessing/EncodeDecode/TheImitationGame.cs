using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with
//the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
namespace EncodeDecode
{
    class TheImitationGame
    {
        static void Main()
        {
            Console.WriteLine("Enter message:");
            string message = Console.ReadLine();
            Console.WriteLine("Enter cypher:");
            string cypher = Console.ReadLine();

            string encoded = Encode(message, cypher);
            string decoded = Encode(encoded, cypher);

            Console.WriteLine("Encode: {0}", encoded);
            Console.WriteLine("Decode: {0}", decoded);
        }

        private static string Encode(string message, string cypher)
        {
            StringBuilder encrypted = new StringBuilder();

            int messageChar;
            int cypherChar;
            for (int i = 0; i < message.Length; i++)
            {
                messageChar = (int)message[i];
                cypherChar = (int)cypher[i % cypher.Length];
                encrypted.Append((char)(messageChar ^ cypherChar));
            }
            
            
            return encrypted.ToString();
        }
    }
}
