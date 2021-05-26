using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    public class Bag
    {
        // data collectio witch stores the entity Present
        private List<Present> data;

        public Bag(string color,int capacity)
        {
            this.Color = color;
            this.Capacity = capacity;
            this.data = new List<Present>();
        }
        public string Color { get; set; }
        public int Capacity { get; set; }

        // Getter Count - return the number of presents
        public int Count => data.Count;

        // adds an entity to the data if ther is room for it
        public void Add(Present present)
        {
            if (Count < Capacity)
            {
                data.Add(present);
            }
        }

        // remove a present by given name , if such exists and return bool
        public bool Remove(string name)
        {
            // present to be with the name from our Bag
            Present present = data.FirstOrDefault(n => n.Name == name); 
            // remove method retur bool
            return data.Remove(present);
        }

        // return the heaviest present
        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = data.OrderByDescending(w => w.Weight)
                                          .FirstOrDefault();

            return heaviestPresent;
        }

        // returns the present with the given name
        public Present GetPresen(string name)
        {
            Present currPresent = data.FirstOrDefault(p => p.Name == name);
            return currPresent;
        }

        // return a string in the format ( print the presents in order of appearance )

        public string Report()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{Color} bag contains:");
            foreach (var present in data)
            {
                builder.AppendLine(present.ToString());
            }
            // trim end 
            return builder.ToString().TrimEnd();
        }
    }
}
