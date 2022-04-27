using System;
using System.Collections.Generic;

namespace Solutions.Algorithms
{
    public static class DancerForNPosition
    {
        public static void Run()
        {
            
           
            Console.WriteLine("Position " + GetPosition(3));
            Console.WriteLine("Position " + GetPosition(100000));
            Console.WriteLine("Position " + GetPosition(2147483647));
        }
        public static int GetPosition(int n)
        {
            var initialStepData = new Dictionary<int,int>()
            {
                {0, 0}, 
                {1, 1}, 
                {2, -1}, 
                {3, -4}, 
                {4, -5},
                {5, -3},
                {6, 0}
            };
            var step = n % 6;
            return initialStepData.TryGetValue(step, out var val) ? val : 0;
        }

       
    }
}