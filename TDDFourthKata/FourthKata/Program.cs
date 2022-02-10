using System;

namespace FourthKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var searcher = new CitySearcher();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Insert a search parameter:");
                searcher.CitySearch(Console.ReadLine()).ForEach(x=>Console.WriteLine(x));
                Console.WriteLine(Environment.NewLine + "Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
