using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GetSlabReinfResult.DataCollector.Logic
{
    public static class LoadSaveFromToTextFile
    {
        public static void SaveFile(string text, string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (var tw = new StreamWriter(path))
                {
                    tw.Write(text);
                    return;
                }
            }
            using (var tw = new StreamWriter(path))
            {
                tw.Write(text);
            }

        }
        public static string ReadFile(string path)
        {
            if (!File.Exists(path)) throw new Exception("File not exists");
            if (String.IsNullOrWhiteSpace(path)) throw new Exception("no path picked");
            using (var tw = new StreamReader(path))
            {
                return tw.ReadToEnd();
            }
        }
    }
}
