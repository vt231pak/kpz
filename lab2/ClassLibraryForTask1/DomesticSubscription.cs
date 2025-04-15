using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription()
        {
            MonthlyFee = 10.99;
            MinSubscriptionPeriod = 1;
            Channels = new List<string> { "Новини", "Телешоу" };
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Деталі Домашньої Підписки:");
            Console.WriteLine($"Щомісячна плата: ${MonthlyFee}");
            Console.WriteLine($"Мінімальний Термін Підписки: {MinSubscriptionPeriod} місяць(ів)");
            Console.WriteLine("Канали:");
            foreach (var channel in Channels)
            {
                Console.WriteLine($"- {channel}");
            }
        }
    }
}
