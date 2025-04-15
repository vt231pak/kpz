using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public class WebSite : SubscriptionMethod
    {
        public override Subscription CreateSubscription(int level)
        {
            SubscriptionLevel = level;
            if (level == 1)
            {
                return new DomesticSubscription();
            }
            else if (level == 2)
            {
                return new EducationalSubscription();
            }
            else if (level == 3)
            {
                return new PremiumSubscription();
            }
            else
            {
                return null;
            }
        }
    }
}
