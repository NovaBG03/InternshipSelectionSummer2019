namespace AssignmentProject.Models.DiscountCards
{
    using System;

    using AssignmentProject.Models.Contracts;

    public class SilverDiscountCard : DiscountCard
    {
        private const float InitialDiscountRate = 2F;
        private const float SecondDiscountRate = 3.5F;
        private const int FirstUpperBound = 300;

        public SilverDiscountCard(IPerson owner, decimal previousMonthTurnover)
            : base(owner, previousMonthTurnover)
        {
        }

        protected override float CalculateDiscountRate()
        {
            if (this.PreviousMonthTurnover > FirstUpperBound)
            {
                return SecondDiscountRate;
            }

            return InitialDiscountRate;
        }
    }
}
