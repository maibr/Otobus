using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Otobus
{
    class Class1
    {
        public void YolcuKayit()
        {
            string text = "ilk satır" + Environment.NewLine;
            string mydocpath = Environment.GetFolderPath
                (Environment.SpecialFolder.MyDocuments);
            System.IO.File.WriteAllText(mydocpath + @"\WriteFile.txt", text);
            string[] lines = { "New line 1", "New line 2" };
            File.AppendAllLines(mydocpath + @"\WriteFile.txt", lines);

            // okuma bölümü

            StreamReader sr = new StreamReader(mydocpath + @"\WriteFile.txt");
            string line;
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            sr.Close();
        }
    }
}
