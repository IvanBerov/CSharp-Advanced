using System;
using System.Collections.Generic;
using System.Text;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        private T first;
        private T second;
        public EqualityScale(T firs,T second)
        {
            this.first = firs;
            this.second = second;
        }
        public bool AreEquals()
        {
            return first.Equals(second);
        }
    }
}
