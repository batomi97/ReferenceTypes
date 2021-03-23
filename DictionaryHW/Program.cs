using System;
using System.Collections.Generic;

namespace DictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(100, "Batuhan");
            names.Add(101, "Buğrahan");
            Console.WriteLine(names.Count);

            MyDictionary<int, string> names1 = new MyDictionary<int, string>();
            names1.Add(100, "Batuhan");
            names1.Add(101, "Buğrahan");
            Console.WriteLine(names1.Count);

            foreach(var value in names1.Values)
            {
                Console.WriteLine(value);
            }

            foreach(var key in names1.Keys)
            {
                Console.WriteLine(key);
            }
            
        }
    }

}
