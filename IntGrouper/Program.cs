using System;
using System.Collections.Generic;
using System.IO;

namespace IntGrouper
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            foreach (string filename in args)
            {
                string s;
                using StreamReader sr = new StreamReader(filename);

                while((s=sr.ReadLine()) != null)
                {
                    int i;
                    bool isInt = int.TryParse(s, out i);
                    
                    if(!isInt)
                    {
                        Console.WriteLine("Found non Integer");
                        return;
                    }
                    
                    if(!(ints.Contains(i)))
                    {
                        ints.Add(i);
                    }
                }
            }
            ints.Sort();
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
