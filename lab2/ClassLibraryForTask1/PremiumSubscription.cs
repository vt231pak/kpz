using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
        {
            MonthlyFee = 29.99;
            MinSubscriptionPeriod = 6;
            Channels = new List<string> { "Преміум контент", "Ексклюзивний доступ" };
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Деталі Преміум Підписки:");
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
