using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask1
{
    public abstract class SubscriptionMethod
    {
        protected int SubscriptionLevel;
        public abstract Subscription CreateSubscription(int level);
    }
}
