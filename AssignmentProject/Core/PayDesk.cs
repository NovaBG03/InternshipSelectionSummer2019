namespace AssignmentProject.Core
{
    using AssignmentProject.Models.DiscountCards.Contracts;

    public class PayDesk
    {
        public static string GetDiscountRateMessage(IDiscountCard card)
        {
            return $"Discount rate: {card.DiscountRate:F1}%";
        }

        public static string GetDiscountMessage(IDiscountCard card, decimal purchaseValue)
        {
            return $"Discount: ${card.CalculatePurchaseDiscount(purchaseValue):F2}";
        }

        public static string GetTotalPurchaseValueMessage(IDiscountCard card, decimal purchaseValue)
        {
            return $"Total: ${purchaseValue - card.CalculatePurchaseDiscount(purchaseValue):F2}";
        }
    }
}
