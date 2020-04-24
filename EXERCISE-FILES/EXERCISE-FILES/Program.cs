using System;
using System.IO;

namespace EXERCISE_FILES
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\tmp\products.csv";
            string targetPath = @"c:\tmp\out\sumary.csv";
            try
            {
                string[] line;
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine().Split(",");
                        using(StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine(line[0] + " , "+ double.Parse(line[1]) * double.Parse(line[2]));
                            //Console.Write("Result:" + double.Parse(line[1]) *double.Parse(line[2]));
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
