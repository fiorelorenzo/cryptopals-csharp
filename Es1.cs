using System;

namespace Cryptopals
{
    class Es1
    {
        public static void Exectute()
        {
            string input = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            Console.WriteLine(String.Format("Hex input: {0}", input));
            byte[] bytes = StringToByteArray(input);
            string b64 = Convert.ToBase64String(bytes);
            Console.WriteLine(String.Format("Base64 output: {0}", b64));
            Console.WriteLine();
        }

        public static byte[] StringToByteArray(String hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
    }
}