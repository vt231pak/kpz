using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription()
        {
            MonthlyFee = 19.99;
            MinSubscriptionPeriod = 3;
            Channels = new List<string> { "Освітні відео", "Документальні фільми" };
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("Деталі Освітньої Підписки:");
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
