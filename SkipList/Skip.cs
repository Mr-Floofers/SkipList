using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipList
{
    public class Skip<T> where T: IComparable<T>, ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public Node<T> head;
        int bigLevel = 1;

        public void RandomLevel(Node<T> current)
        {            
            Random rand = new Random();
            float num = rand.Next(1, 100);
            if (num >= 0.00 && num <= 50.00) current.level = 1;
            if (num >= 50.01 && num <= 75.00) current.level = 2;
            if (num >= 75.01 && num <= 87.50) current.level = 3;
            if (num >= 87.51 && num <= 93.75) current.level = 4;
            if (num >= 93.76 && num <= 96.01) current.level = 5;
            if (num >= 96.02 && num <= 100) current.level = 6;

        }
        
        public void Add(T value)
        {
            if(head == null)
            {
                head.value = value;
            }
            
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
