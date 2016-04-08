using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSecurity
{
    class CaeserCoding : ICryptography
    {
        private int shift;

        public CaeserCoding()
        {
            shift = 0;
        }
        public CaeserCoding(int shift) : this()
        {
            this.shift = shift;
        }
        public string Decrypt()
        {
            string way = FileManager.OpenFile();
            string resultFile = null;
            try
            {
                using (StreamReader sr = new StreamReader(new FileStream(way, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    byte[] entryRow = null;
                    resultFile = new FileInfo(way).Directory + "\\DeCaeser.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentRow = null;
                        while ((currentRow = sr.ReadLine()) != null)
                        {
                            entryRow = ASCIIEncoding.Default.GetBytes(currentRow);
                            for (int i = 0; i < entryRow.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                int x = entryRow[i] - 32 + 224 - shift;
                                entryRow[i] = x < 0 ? (byte)(x + 256) : (byte)(x % 224 + 32);
                            }
                            sw.WriteLine(Encoding.GetEncoding(1251).GetChars(entryRow));
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
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    byte[] entryRow = null;
                    resultFile = new FileInfo(path).Directory + "\\Caeser.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentRow = null;
                        while ((currentRow = sr.ReadLine()) != null)
                        {
                            entryRow = ASCIIEncoding.Default.GetBytes(currentRow);
                            for (int i = 0; i < entryRow.Length; i++)
                            {
                                if (entryRow[i] >= 0 && entryRow[i] < 32)
                                    continue;
                                entryRow[i] = (byte)((entryRow[i] - 32 + shift) % 224 + 32);
                            }
                            sw.WriteLine(Encoding.GetEncoding(1251).GetChars(entryRow));
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
