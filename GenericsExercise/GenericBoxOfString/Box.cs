using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T>
    {

        public Box(T value)
        {
            this.Value = value;
        }
        public T Value { get; private set; }
        public override string ToString()
        {
            Type valueType = this.Value.GetType();
            string valueTypeFulName = valueType.FullName;

            return $"{valueTypeFulName}: {this.Value}"; 
        }
    }
}
