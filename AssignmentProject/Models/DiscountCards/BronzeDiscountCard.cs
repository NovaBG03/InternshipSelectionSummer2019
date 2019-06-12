namespace AssignmentProject.Models.DiscountCards
{
    using System;
    using AssignmentProject.Models.Contracts;

    public class BronzeDiscountCard : DiscountCard
    {
        private const float InitialDiscountRate = 0;
        private const float SecondDiscountRate = 1F;
        private const float ThirdDiscountRate = 2.5F;
        private const int FirstUpperBound = 100;
        private const int SecondUpperBound = 300;

        public BronzeDiscountCard(IPerson owner, decimal previousMonthTurnover) 
            : base(owner, previousMonthTurnover)
        {
        }

        protected override float CalculateDiscountRate()
        {
            if (this.PreviousMonthTurnover < FirstUpperBound)
            {
                return InitialDiscountRate;
            }
            else if (this.PreviousMonthTurnover < SecondUpperBound)
            {
                return SecondDiscountRate;
            }
            
            return ThirdDiscountRate;
        }
    }
}
