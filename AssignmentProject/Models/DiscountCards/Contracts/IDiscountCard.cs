namespace AssignmentProject.Models.DiscountCards.Contracts
{
    using AssignmentProject.Models.Contracts;

    public interface IDiscountCard
    {
        IPerson Owner { get; }

        decimal PreviousMonthTurnover { get; }

        float DiscountRate { get; }

        decimal CalculatePurchaseDiscount(decimal purchaseValue);
    }
}
