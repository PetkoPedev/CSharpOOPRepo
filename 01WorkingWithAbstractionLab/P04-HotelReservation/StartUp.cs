using System;
using System.Linq;

namespace P04_HotelReservation
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            double pricePerDay = double.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            string season = input[2];
            string discountType = input[3];

            PriceCalculator priceCalculator = new PriceCalculator()
        }
    }
}
