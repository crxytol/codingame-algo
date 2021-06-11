using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Algorithms
{
    class PaireNumberAlgorithm
    {
        public static int Count(int n)
        {
            var rep = 0;
            for (int i = 1; i < n; i++) rep += (n - i);
            return rep;
        }
    }
}
