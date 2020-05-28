using System;

namespace P03_Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Ferrari car = new Ferrari("488-Spider", name);
            Console.WriteLine(car);
        }
    }
}
