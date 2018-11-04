using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    public class Node<T>
    {
        public int level;
        public T value;

        public Node(T value, T level = 0)
        {
            this.value = value;
            this.level = level;
        }
    }
}
