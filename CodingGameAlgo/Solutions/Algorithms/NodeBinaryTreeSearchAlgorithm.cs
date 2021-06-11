using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.Algorithms
{
    public class Node
    {
        public Node Left, Right;

        public int value;

        public Node Find(int n)
        {
            Node current = this;
            while (current != null)
            {
                if (current.value == n)
                {
                    return current;
                }
                current = n < current.value ? current.Left : current.Right;
            }
            return null;
        }
    }
}
