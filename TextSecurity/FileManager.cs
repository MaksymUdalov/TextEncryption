using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TextSecurity
{
    class FileManager
    {
        public static string OpenFile()
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "txt|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
                return open.FileName;
            throw new NotImplementedException();
        }

        public static bool ShowFile(string path)
        {
            try
            {
                Process.Start(path);
                return true;
            }
            catch { }
            return false;
        }
    }
}
