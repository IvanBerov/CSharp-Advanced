using System;

namespace Christmas
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Present one = new Present("Doll", 100, "girl");
            Present two = new Present("Truck", 200, "boy");

            Bag bag = new Bag("blue", 5);

            bag.Add(one);
            bag.Add(two);
            
            
            Console.WriteLine(bag.GetPresen("Truck").ToString());
        }
    }
}
