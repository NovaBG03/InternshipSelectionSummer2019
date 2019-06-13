namespace AssignmentProject
{
    using System;

    using AssignmentProject.Core;
    using AssignmentProject.Core.Contracts;
    using AssignmentProject.Models;
    using AssignmentProject.Models.Contracts;
    using AssignmentProject.Models.DiscountCards;
    using AssignmentProject.Models.DiscountCards.Contracts;

    public class StartUp
    {
        private const int BronzeCardTurnover = 0;
        private const int BronzeCardPurchaseValue = 150;
        private const int SilverCardTurnover = 600;
        private const int SilverCardPurchaseValue = 850;
        private const int GoldCardTurnover = 1500;
        private const int GoldCardPurchaseValue = 1300;

        public static void Main(string[] args)
        {
            IPerson owner = new Person("Georgi", "1111");
            IDiscountCard card = null;
            decimal value = -1;

            DisplayTestMessages();
            SetTestValues(owner, ref card, ref value);

            IRunnable engine = new Engine(card, value);
            engine.Run();
        }

        private static void SetTestValues(IPerson owner, ref IDiscountCard card, ref decimal value)
        {
            while (true)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        card = new BronzeDiscountCard(owner, BronzeCardTurnover);
                        value = BronzeCardPurchaseValue;
                        return;
                    case "2":
                        card = new SilverDiscountCard(owner, SilverCardTurnover);
                        value = SilverCardPurchaseValue;
                        return;
                    case "3":
                        card = new GoldDiscountCard(owner, GoldCardTurnover);
                        value = GoldCardPurchaseValue;
                        return;
                    default:
                        DisplayTestMessages();
                        break;
                }
            }
        }

        private static void DisplayTestMessages()
        {
            Console.WriteLine("Choose which discount card to be created:");
            Console.WriteLine($"1 -> Bronze (turnover ${BronzeCardTurnover}, purchase value ${BronzeCardPurchaseValue})");
            Console.WriteLine($"2 -> Silver (turnover ${SilverCardTurnover}, purchase value ${SilverCardPurchaseValue})");
            Console.WriteLine($"3 -> Gold (turnover ${GoldCardTurnover}, purchase value ${GoldCardPurchaseValue})");
        }
    }
}
