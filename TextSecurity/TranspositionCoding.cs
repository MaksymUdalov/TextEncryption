using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TextSecurity
{
    public class TranspositionCoding : ICryptography
    {

        private List<byte> key = null;
        public TranspositionCoding() : this(new List<byte>())
        {
        }
        public TranspositionCoding(List<byte> key)
        {
            this.key = key;
        }

        public string Encrypt()
        {
            string path = string.Empty,
                 resultFile = string.Empty;
            path = FileManager.OpenFile();
            try
            {
                using (var sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    resultFile = new FileInfo(path).Directory + "\\Permation.txt";
                    using (var sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        string currentLine = string.Empty;
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            byte[] entryRow = Encoding.GetEncoding(1251).GetBytes(currentLine);
                            byte[] currentSegment = new byte[(currentLine.Length / key.Count) * key.Count + key.Count];

                            int counter = 0;
                            for (int i = 0, j = 0; i < currentLine.Length; i++, j++)
                            {
                                currentSegment[key[j] + counter] = entryRow[i];
                                if (j == key.Count - 1)
                                {
                                    j = -1;
                                    counter += key.Count;
                                }
                            }
                            for (int i = 0; i < currentSegment.Length; i++)
                                currentSegment[i] = currentSegment[i] == 0 ? (byte)32 : currentSegment[i];

                            char[] newStr = Encoding.GetEncoding(1251).GetChars(currentSegment);
                            sw.WriteLine(newStr);
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

        public string Decrypt()
        {
            string path = string.Empty,
             resultFile = string.Empty;
            try
            {
                path = FileManager.OpenFile();
                using (StreamReader sr = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read), Encoding.GetEncoding(1251)))
                {
                    string currentLine = string.Empty;
                    char[] rowUp = null;
                    resultFile = new FileInfo(path).Directory + "\\DecPermation.txt";
                    using (StreamWriter sw = new StreamWriter(new FileStream(resultFile, FileMode.OpenOrCreate, FileAccess.Write), Encoding.GetEncoding(1251)))
                    {
                        while ((currentLine = sr.ReadLine()) != null)
                        {
                            rowUp = new char[(int)(currentLine.Length / key.Count) * key.Count + key.Count];
                            int counter = 0;
                            for (int i = 0, j = 0; i < currentLine.Length; i++, j++)
                            {
                                rowUp[key.IndexOf((byte)j) + counter] = currentLine[i];
                                if (j == key.Count - 1)
                                {
                                    j = -1;
                                    counter += key.Count;
                                }
                            }
                            sw.WriteLine(new string(rowUp).Replace('\0', ' '));
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
