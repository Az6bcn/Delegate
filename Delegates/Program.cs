using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var p = new Program();

            Func<string, string> func = (s) => s.ToUpper();
            string[] names = { "Azeez", "Larry", "Temmy", "Micheal" };

            var result = names.SelectMany(x => p.CovertToUpper(x)).ToList();

            result.ForEach(x =>
            {
                Console.WriteLine(x);  
            });

            var result2 = names.Select(x => func.Invoke(x)).ToList();
            result2.ForEach(x =>
            {
                Console.WriteLine($"func<>: {x}");
            });
        }

        private List<string> CovertToUpper(string name)
        {
            var list = new List<string>();

            list.Add(name.ToUpper());

            return list;
        }
    }
}
