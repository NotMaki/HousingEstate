using System;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Peter = new Person("Peter", "Sovík", 50);
            Person Oliver = new Person("Oliver", "Krška", 17);
            Person Lucian = new Person("Lucián", "Švancár", 17);

            Console.WriteLine(Peter.ToString());
            Console.WriteLine(Oliver.ToString());
            Console.WriteLine(Lucian.ToString());
        }
    }
}
