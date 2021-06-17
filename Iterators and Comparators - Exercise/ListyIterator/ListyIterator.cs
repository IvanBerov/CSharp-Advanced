using System;
using System.Collections;
using System.Collections.Generic;

namespace ListyIterator
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private int currIndex;

        private List<T> listItems;

        public ListyIterator(List<T> initialItems)
        {
            this.currIndex = 0;
            this.listItems = initialItems;
        }

        public int Count => this.listItems.Count;

        public bool HasNext()
        {
            if (this.currIndex < this.Count -1)
            {
                return true;
            }

            return false;
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                this.currIndex++;
                return true;
            }

            return false;
        }

        public void Print()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.listItems[currIndex]);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in listItems)
            {
                yield return item;
            }

            //while (this.currIndex < this.Count)
            //{
            //    yield return this.listItems[this.currIndex];
            //    if (!this.Move())
            //    {
            //        yield break;
            //    }
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
