using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TextSecurity
{
    class VigenereCoding : ICryptography
    {
        private List<char> key = null;

        public VigenereCoding() : this(new List<char>())
        {
        }

        public VigenereCoding(List<char> key)
        {
            this.key = key;
        }

        public string Decrypt()
        {
            string way = FileManager.OpenFile();
            string resultPath = null;
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(way, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    byte[] currentKey = ASCIIEncoding.Default.GetBytes(key.ToArray());
                    resultPath = new FileInfo(way).Directory + "\\DecVigenere.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultPath, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentLine = string.Empty;
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            int index = 0;
                            byte[] entryRow = ASCIIEncoding.Default.GetBytes(currentLine);
                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                int x = entryRow[i] - 32 + 224 - currentKey[index];
                                entryRow[i] = x < 0 ? (byte)(x + 256) : (byte)(x % 224 + 32);
                                index = index == currentKey.Length - 1 ? 0 : index += 1;
                            }
                            sw.WriteLine(Encoding.GetEncoding(1251).GetString(entryRow));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultPath;
        }

        public string Encrypt()
        {
            string path = FileManager.OpenFile();
            string resultFile = null;
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    resultFile = new FileInfo(path).Directory + "\\Vigenere.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        byte[] currentKey = ASCIIEncoding.Default.GetBytes(key.ToArray());
                        string currentLine = null;
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            int index = 0;
                            byte[] entryRow = ASCIIEncoding.Default.GetBytes(currentLine);
                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                entryRow[i] = (byte)((entryRow[i] - 32 + currentKey[index]) % 224 + 32);
                                index = index == currentKey.Length - 1 ? 0 : index += 1;
                            }
                            sw.WriteLine(Encoding.GetEncoding(1251).GetString(entryRow));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultFile;
        }
    }
}
