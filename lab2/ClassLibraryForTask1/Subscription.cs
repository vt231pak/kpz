namespace ClassLibraryForTask1
{
    public abstract class Subscription
    {
        public double MonthlyFee { get; protected set; }
        public int MinSubscriptionPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }

        public abstract void DisplayDetails();
    }
}
