using System;
using System.Collections.Generic;

namespace Solutions.Algorithms
{
    struct User
    {
        public int v;
    }
    public static class KnowingQuestions
    {
        public static void Run()
        {
            /*var d = new Dictionary<object, int>();
            var obj1 = new User();
            var obj2 = obj1;
            d.Add(obj1, 1);
            d.Add(obj2, 2);*/
            // error same key
            
            Console.WriteLine("**** Question dictionary structure");
            Console.WriteLine(
                @"var d = new Dictionary<object, int>();
var obj1 = new User();
var obj2 = obj1;\n
d.Add(obj1, 1);\n
d.Add(obj2, 2);\n

Result: throw exception: the same key has already been added.

            ");

            Console.WriteLine("**** Question dictionary structure");
            Console.WriteLine(
                @"var d = new Dictionary<object, int>();
var obj1 = new User();
var obj2 = obj1;\n
d.Add(obj1, 1);\n
d.Add(obj2, 2);\n

Result: throw exception: the same key has already been added.

            ");
            // Console.WriteLine("Dico: " + d[obj2]);
        }
    }
}