using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Nachatirky
{
    class NulevorZadanie
    {
        static void Main(string[] args)
        {
            FileStream kak = new FileStream("1.txt", FileMode.Open);
            StreamReader eto = new StreamReader(kak);
            string delat = eto.ReadToEnd();
            foreach (Match a in Regex.Matches(delat, @"(?<!\d)[0-2][0-9].[0][1-9].\d\d\d\d(?!\d)"))
            {
                Console.WriteLine(a.Value);
                StreamWriter s = File.CreateText("myfile.txt");
                s.WriteLine(a.Value);
                s.Close();
            }
            foreach (Match b in Regex.Matches(delat, @"(?<!\d)[0-2][0-9].[1][0-2].\d\d\d\d(?!\d)"))
            {
                Console.WriteLine(b.Value);
                StreamWriter sw = File.CreateText("myfile.txt");
                sw.WriteLine(b.Value);
                sw.Close();
            }
            foreach (Match c in Regex.Matches(delat, @"(?<!\d)[3][0-1].[0][1-9].\d\d\d\d(?!\d)"))
            {
                Console.WriteLine(c.Value);
                StreamWriter sw1 = File.CreateText("myfile.txt");
                sw1.WriteLine(c.Value);
                sw1.Close();
            }
            foreach (Match d in Regex.Matches(delat, @"(?<!\d)[3][0-1].[1][0-2].\d\d\d\d(?!\d)"))
            {
                Console.WriteLine(d.Value);
                File.CreateText(d.Value + "myfile.txt");
                StreamWriter sw11 = File.CreateText("myfile.txt");
                sw11.WriteLine(d.Value);
                sw11.Close();
            }

            Console.ReadKey();
        }
    }
}