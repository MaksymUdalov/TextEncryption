using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextSecurity
{
    class XORCoding : ICryptography
    {
        private string keyPath;

        public string KeyPath { set { keyPath = value; } }

        public string Decrypt()
        {
            string path = FileManager.OpenFile();
            string resultFile = new FileInfo(path).Directory + "\\DecXOR.txt";
            try
            {
                using (StreamReader srf = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)),
                     srk = new StreamReader(new FileStream(keyPath, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    using (StreamWriter swf = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentLine = string.Empty;
                        while ((currentLine = srf.ReadLine()) != null)
                        {
                            byte[] entryRow = ASCIIEncoding.Default.GetBytes(currentLine.ToArray());
                            byte[] keysArray = ASCIIEncoding.Default.GetBytes(srk.ReadLine());

                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                int x = entryRow[i] - 32 + 224 - keysArray[i];
                                entryRow[i] = x < 0 ? (byte)(x + 256) : (byte)(x % 224 + 32);
                            }
                            swf.WriteLine(Encoding.GetEncoding(1251).GetString(entryRow));
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

        public string Encrypt()
        {
            
            string path = FileManager.OpenFile();
            string resultFile = string.Empty;

            resultFile = new FileInfo(path).Directory + "\\XOR.txt";
            string keyPath = resultFile.Insert(resultFile.LastIndexOf('.'), "Key");
            try
            {
                using (StreamReader srf = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.Default))
                {
                    using (StreamWriter swk = new StreamWriter(new FileStream(keyPath, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)),
                        swf = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentLine = string.Empty;
                        Random random = new Random();
                        while ((currentLine = srf.ReadLine()) != null)
                        {
                            byte[] entryRow = ASCIIEncoding.Default.GetBytes(currentLine.ToArray());
                            byte[] key = new byte[currentLine.Length];

                            for (int i = 0; i < currentLine.Length; i++)
                            {
                                key[i] = (byte)random.Next(32, 255);
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                entryRow[i] = (byte)((entryRow[i] - 32 + key[i]) % 224 + 32);
                            }
                            swf.WriteLine(Encoding.GetEncoding(1251).GetString(entryRow));
                            swk.WriteLine(Encoding.GetEncoding(1251).GetString(key));
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
