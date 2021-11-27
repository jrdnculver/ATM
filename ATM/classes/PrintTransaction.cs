using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace ATM.classes
{
    public class PrintTransaction
    {
        public static StringBuilder print = new StringBuilder();

        public void getPrintSummary()
        {
            print.Append(primary.Primary.atmTxtBx.Text);

            string fileName = getDirectory("atmReceipt");

            File.WriteAllText(fileName, print.ToString());
        }

        public string getDirectory(string fileName)
        {
            string exeDir = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            string[] DirSplit = exeDir.Split('\\');

            DirSplit = DirSplit.Where(x => x != "bin" && x != "Debug" && x != "netcoreapp3.1").ToArray();

            string exeDirMod = string.Join("\\", DirSplit);

            string finalPath = $@"{exeDirMod}\{fileName}.txt";

            return finalPath;
        }
    }
}
