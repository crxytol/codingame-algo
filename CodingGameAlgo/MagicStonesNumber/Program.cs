using System;
using System.Collections.Generic;
using System.Linq;

namespace MagicStonesNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    /// <summary>
    /// magic stone
    /// </summary>
    /// <param name="stones"></param>
    /// <returns></returns>
    static int Magic(List<int> stones)
    {
        var level = 0;
        var levelDic = new Dictionary<int, List<int>>();
        levelDic.Add(level, stones);
        var stonesGroups = stones.GroupBy(c => c).ToList();
        while (stonesGroups.Any() && stonesGroups.Select(g => g.Count() > 1).Any(c => c == true))
        {
            level++;
            stones = stonesGroups.Select(g => g.Sum()).ToList();
            levelDic.Add(level, stones);
            stonesGroups = stones.GroupBy(c => c).ToList();
        }

        var minimal = levelDic.LastOrDefault().Value.Count;
        return minimal;
    }
}
