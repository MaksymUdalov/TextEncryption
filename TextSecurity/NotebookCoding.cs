using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TextSecurity
{
    class NotebookCoding : ICryptography
    {
        private string keyPath;

        public NotebookCoding(string keyPath)
        {
            this.keyPath = keyPath;
        }

        public string Decrypt()
        {
            string path = FileManager.OpenFile();
            string resultFile = null;
            try
            {
                using (StreamReader srk = new StreamReader(new FileStream(keyPath, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)),
                         srf = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    resultFile = new FileInfo(path).Directory + "\\DeOneTimePad.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        byte[] entryRow = null;
                        string currentLine = string.Empty;
                        while ((currentLine = srf.ReadLine()) != null)
                        {
                            byte[] key = ASCIIEncoding.Default.GetBytes(srk.ReadLine().ToArray());
                            entryRow = ASCIIEncoding.Default.GetBytes(currentLine.ToArray());
                            for (int i = 0; i < entryRow.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                int x = entryRow[i] - 32 + 224 - key[i];
                                entryRow[i] = x < 0 ? (byte)(x + 256) : (byte)(x % 224 + 32);
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

        public string Encrypt()
        {
            string path = FileManager.OpenFile();
            string resultFile = null;
            try
            {
                using (StreamReader srk = new StreamReader(new FileStream(keyPath, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)),
                         srf = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    resultFile = new FileInfo(path).Directory + "\\OneTimePad.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        byte[] entryRow = null;
                        string currentLine = string.Empty;
                        while ((currentLine = srf.ReadLine()) != null)
                        {
                            byte[] key = ASCIIEncoding.Default.GetBytes(srk.ReadLine().ToArray());
                            entryRow = ASCIIEncoding.Default.GetBytes(currentLine.ToArray());
                            for (int i = 0; i < entryRow.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                entryRow[i] = (byte)((entryRow[i] - 32 + key[i]) % 224 + 32);
                            }
                            sw.WriteLine(Encoding.GetEncoding(1251).GetString(entryRow));
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return resultFile;
        }
    }
}
