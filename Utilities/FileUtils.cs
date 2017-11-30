using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilities
{
    public class FilesUtils
    {
        public static string Read(string path)
        {
            return String.Join(Environment.NewLine, File.ReadAllLines(path));

        }

        public static void Write(string path, string str)
        {
            File.WriteAllLines(path, new string[] { str });
        }
    }
}
