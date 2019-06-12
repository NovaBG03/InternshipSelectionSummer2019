namespace AssignmentProject.Models.DiscountCards
{
    using System;

    using AssignmentProject.Models.Contracts;

    public class GoldDiscountCard : DiscountCard
    {
        private const float InitialDiscountRate = 2F;
        private const float DiscountRateGrowIndex = 1;
        private const decimal TurnoverStep = 100;
        private const float MaxDiscountRate = 10F;

        public GoldDiscountCard(IPerson owner, decimal previousMonthTurnover)
            : base(owner, previousMonthTurnover)
        {
        }

        protected override float CalculateDiscountRate()
        {
            float increasedDiscountRate = InitialDiscountRate;
            increasedDiscountRate += (int)(this.PreviousMonthTurnover / TurnoverStep) * DiscountRateGrowIndex;

            if (increasedDiscountRate > MaxDiscountRate)
            {
                increasedDiscountRate = MaxDiscountRate;
            }

            return increasedDiscountRate;
        }
    }
}
