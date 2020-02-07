using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
    class MyText
    {
        static string serectKey = "yang";
        public static string ReadText(string path)
        {
            string file = "";
            try
            {
                 file = File.ReadAllText(path, UTF8Encoding.Default);
            }
            catch
            {
                 
            }
            
            return TextCrypt(file, serectKey);
        }

        public static void WrtieText(string file,string path)
        {
            File.WriteAllText(path, TextCrypt(file, serectKey),UTF8Encoding.Default);
        }

        public static void AppendText(string file,string path)
        {
            File.AppendAllText(path, TextCrypt(file,serectKey),UTF8Encoding.Default);
        }

        //文本加、解密
        public static string TextCrypt(string file,string secretKey)
        {
            char[] data = file.ToCharArray();
            char[] key = secretKey.ToCharArray();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] ^= key[i % key.Length];
            }
            return new string(data);
        }

    }
}
