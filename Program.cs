using System;
using System.Linq;

namespace mssa_10._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.Write("Input starting character for the string : ");
            char startChar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            Console.Write("Input ending character for the string : ");
            char endChar = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            var city = cities.FirstOrDefault(c => c.StartsWith(startChar) && c.EndsWith(endChar));

            if (city != null)
            {
                Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is : {city}");
            }
            else
            {
                Console.WriteLine($"No city found starting with {startChar} and ending with {endChar}.");
            }
        }
    }
}
