using System;
using System.Collections.Generic;
using System.Text;

namespace P04_HotelReservation
{
    public class PriceCalculator
    {
        
        public static decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, Discount discount)
        {
            int multiplier = (int)season;
            decimal discountMultiplier = (decimal)discount / 100;
            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal discountAmount = priceBeforeDiscount * discountMultiplier;
            decimal finalPrice = priceBeforeDiscount - discountAmount;

            return finalPrice;
        }
    }
}
