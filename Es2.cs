using System;

namespace Cryptopals
{
    class Es2
    {
        public static void Exectute()
        {
            try
            {
                string input1 = "1c0111001f010100061a024b53535009181c";
                Console.WriteLine(String.Format("Hex input 1: {0}", input1));

                string input2 = "686974207468652062756c6c277320657965";
                Console.WriteLine(String.Format("Hex input 2: {0}", input2));

                string result = XorHexStrings(input1, input2);

                Console.WriteLine(String.Format("XORed hex output: {0}", result));
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static string XorHexStrings(string s1, string s2)
        {
            byte[] b1 = Es1.StringToByteArray(s1);
            byte[] b2 = Es1.StringToByteArray(s2);
            if (b1.Length == b2.Length)
            {
                byte[] result = new byte[b1.Length];
                for (int i = 0; i < b1.Length; i++)
                {
                    result[i] = (byte)(b1[i] ^ b2[i]);
                }
                string hex = BitConverter.ToString(result).Replace("-", "");
                return hex;
            }
            else
            {
                throw new ArgumentException("Strings should be of the same length.");
            }
        }
    }
}