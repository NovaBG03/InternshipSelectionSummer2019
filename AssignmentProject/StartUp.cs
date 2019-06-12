namespace AssignmentProject
{
    using AssignmentProject.Models;
    using AssignmentProject.Models.DiscountCards;
    using AssignmentProject.Models.DiscountCards.Contracts;
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            decimal value = 1300M;

            IDiscountCard card = new GoldDiscountCard(new Person("Georgi", "1111"), 1500);

            Console.WriteLine($"Purchase value: ${value:F2}");

            Console.WriteLine($"Discount rate: {card.DiscountRate:F1}%");

            Console.WriteLine($"Discount: ${card.CalculatePurchaseDiscount(value):F2}");

            Console.WriteLine($"Total: ${value - card.CalculatePurchaseDiscount(value):F2}");
        }
    }
}
