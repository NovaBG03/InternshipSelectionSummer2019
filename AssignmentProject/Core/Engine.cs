namespace AssignmentProject.Core
{
    using System;

    using AssignmentProject.Core.Contracts;
    using AssignmentProject.Models.DiscountCards.Contracts;

    public class Engine : IRunnable
    {
        private IDiscountCard card;
        private decimal purchaseValue;

        public Engine(IDiscountCard card, decimal purchaseValue)
        {
            this.card = card;
            this.purchaseValue = purchaseValue;
        }

        public void Run()
        {
            Console.WriteLine($"Purchase value: ${this.purchaseValue:F2}");

            string discountRateMessage = PayDesk.GetDiscountRateMessage(this.card);
            Console.WriteLine(discountRateMessage);

            string discountMessage = PayDesk.GetDiscountMessage(this.card, this.purchaseValue);
            Console.WriteLine(discountMessage);

            string totalPurchaseValueMessage = PayDesk.GetTotalPurchaseValueMessage(this.card, this.purchaseValue);
            Console.WriteLine(totalPurchaseValueMessage);
        }
    }
}
