using System;
using System.Collections.Generic;

namespace Solutions.Algorithms
{
    
    public static class OptimizeChange
    {
        
        public static void Run()
        {
            long s = 23; // Change this value to perform other tests
            var money = OptimalChange2(s);
           
            Console.WriteLine("Coin(s)  2€: " + money.Coin2);
            Console.WriteLine("Bill(s)  5€: " + money.Bill5);
            Console.WriteLine("Bill(s) 10€: " + money.Bill10);

            var result = money.Coin2 * 2 + money.Bill5 * 5 + money.Bill10 * 10;
            Console.WriteLine("\nChange given = " + result);
        }
        
        private static Change OptimalChange(long s) 
        {
            // Donnée entière, strictement positive inférieure ou égale à 263
            if(s < 0 || s > 263)
                return null;

            var mChange = new Change();
            if (s >= 10)
            {
                mChange.Bill10 = s / 10;
                s %= 10;
            }
            if (s >= 5)
            {
                mChange.Bill5 = s / 5;
                s %= 5;
            }
            if (s >= 2)
            {
                mChange.Coin2 = s / 2;
                s %= 2;
            }

            return s == 1 ? null : mChange;
        }
        
        private static Change OptimalChange2(long s) 
        {
            // Donnée entière, strictement positive inférieure ou égale à 263
            if(s < 0 || s > 263)
                return null;

            var mChange = new Change();
            var changes = new List<int>(){ 2, 5, 10 };
            for(var i = changes.Count - 1; i >= 0; i--)
            {
                
                // Find denominations 
                while (s >= changes[i]) 
                {
                    //s -= changes[i];
                    
                    switch (changes[i])
                    {
                        case 10: 
                            mChange.Bill10 = s / 10;
                            s %= 10;
                            break;
                        case 5:
                            mChange.Bill5 = s / 5;
                            s %= 5;
                            break;
                        case 2:
                            mChange.Coin2 = s /2 ;
                            s %= 2;
                            break;
                        default:
                            return null;
                    }
                }
            }
            return s <= 1 ? null : mChange;
        }
    }

    internal class Change
    {
        public long Coin2 = 0;
        public long Bill5 = 0;
        public long Bill10 = 0;
    }
}
