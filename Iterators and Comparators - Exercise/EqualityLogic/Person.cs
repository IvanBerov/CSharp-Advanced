using System;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            if (Name != other.Name)
            {
                return Name.CompareTo(other.Name);
            }

            if (Age != other.Age)
            {
                return Age.CompareTo(other.Age);
            }

            return 0;
        }

        public override bool Equals(object? obj)
        {
            if (this.GetHashCode() == obj.GetHashCode())
            {
                return true;
            }

            return false;

            //return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            int nameHash = this.Name.GetHashCode();
            int ageHash = this.Age.GetHashCode();

            return nameHash + ageHash;

            //return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
