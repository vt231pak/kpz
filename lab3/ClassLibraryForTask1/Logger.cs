namespace ClassLibraryForTask1
{
    public class Logger
    {
        private readonly ConsoleColor _defaultColor = Console.ForegroundColor;

        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = _defaultColor;
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = _defaultColor;
        }

        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(message);
            Console.ForegroundColor = _defaultColor;
        }

    }
}
