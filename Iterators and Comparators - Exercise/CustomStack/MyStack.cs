using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomStack
{
    public class MyStack<T> : IEnumerable<T>
    {
        private readonly List<T> stackList;

        public MyStack()
        {
            stackList = new List<T>();
        }

        public int Count => this.stackList.Count;
        
        public void Push(T item)
        {
            this.stackList.Add(item);
        }

        public T Pop()
        {
            T item = this.stackList[^1]; // last element

            this.stackList.RemoveAt(this.stackList.Count - 1);

            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.stackList.Count -1 ; i >= 0; i--)
            {
                yield return this.stackList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
