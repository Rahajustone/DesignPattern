using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Console;

namespace DesignPattern.SOLID
{
    public class SingleResponsiblityPrinciple
    {
        public static void TestSingleResposibility()
        {
            Journal j = new Journal();
            j.AddEntry("I cried today.");
            j.AddEntry("I ate a bug.");
            WriteLine(j);

            var p = new Persistence();
            var filename = @"C:\Users\khrah\Desktop\aaa.txt";
            p.SaveToFile(j, filename);
            //Process.Start(filename);
            Process.Start(@"cmd.exe ", @"/c " + $"{filename}");
        }
    }

    public class Journal
    {
        private static List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
        
        // breaks single responsibility principle
        public void Save(string filename, bool overwrite = false)
        {
            File.WriteAllText(filename, ToString());
        }
    }

    // Handles the responsibility of persisting objects
    public class Persistence
    {
        public void SaveToFile(Journal journal, string filename, bool overwrite = false)
        {
            if (overwrite || File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
            } else
            {
                using (StreamWriter st = File.CreateText(filename)) 
                {
                    st.WriteLine(journal.ToString());
                }                
            }         
        }
    }
}
