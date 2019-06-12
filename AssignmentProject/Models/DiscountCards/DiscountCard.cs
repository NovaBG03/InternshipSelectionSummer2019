namespace AssignmentProject.Models.DiscountCards
{
    using System;

    using AssignmentProject.Models.Contracts;
    using AssignmentProject.Models.DiscountCards.Contracts;

    public abstract class DiscountCard : IDiscountCard
    {
        private decimal previousMonthTurnover;

        protected DiscountCard(IPerson owner, decimal previousMonthTurnover)
        {
            this.Owner = owner;
            this.PreviousMonthTurnover = previousMonthTurnover;
        }

        public IPerson Owner { get; }

        public decimal PreviousMonthTurnover
        {
            get => this.previousMonthTurnover;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The turnover for the previous month can not be negative number.");
                }

                this.previousMonthTurnover = value;
            }
        }

        public float DiscountRate
        {
            get => this.CalculateDiscountRate();
        }

        public decimal CalculatePurchaseDiscount(decimal purchaseValue)
        {
            return purchaseValue * ((decimal)this.DiscountRate / 100);
        }

        protected abstract float CalculateDiscountRate();
    }
}
