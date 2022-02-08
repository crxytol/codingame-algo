using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Algorithms
{
    public static class MagicStonesNumber
    {
        public static void  Run()
        {
            var stones = new List<int>(new int[] { 1, 2, 1 });
            Console.WriteLine(Magic(stones));
            stones = new List<int>(new int[] { 1, 1, 5 });
            Console.WriteLine(Magic(stones));
            stones = new List<int>(new int[] { 1, 1, 3, 2, 3, 2 });
            Console.WriteLine(Magic(stones));
        }
        /// <summary>
        /// magic stone
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        private static int Magic(List<int> stones)
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

}

