using Solutions.Algorithms;
using System;
using System.Collections.Generic;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 4, 5, 10000 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number} ==> {PaireNumberAlgorithm.Count2(number)}");
            }
            // Magic stones Number
            Console.WriteLine(PaireNumberAlgorithm.Count(4));

            Console.ReadLine();
        }
    }
}
