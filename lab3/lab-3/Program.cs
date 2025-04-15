using System;
using System.Net;
using System.Text;
using System.Threading;
using ClassLibraryForTask1;
using ClassLibraryForTask2;
using ClassLibraryForTask3;
using ClassLibraryForTask4;
using ClassLibraryForTask5_6;
using static System.Net.Mime.MediaTypeNames;
namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 1");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            IFileWriter consoleWriter = new ConsoleWriter();
            var fileLoggerAdapter = new FileLoggerAdapter(consoleWriter);
            fileLoggerAdapter.Log("Це повідомлення буде залоговано");
            fileLoggerAdapter.Warn("Це повідомлення є попередженням");
            fileLoggerAdapter.Error("Це повідомлення є помилкою");

            Console.WriteLine("TASK 2");
            Hero warrior = new Warrior();
            Hero mage = new Mage();
            Hero paladin = new Paladin();
            warrior = new WeaponDecorator(warrior);
            warrior = new ClothingDecorator(warrior);
            mage = new WeaponDecorator(mage);
            mage = new ClothingDecorator(mage);
            paladin = new WeaponDecorator(paladin);
            paladin = new ClothingDecorator(paladin);
            warrior.Display();
            mage.Display();
            paladin.Display();

            Console.WriteLine("TASK 3");
            Shape circle = new Circle(new VectorRenderer());
            Shape square = new Square(new RasterRenderer());
            Shape triangle = new Triangle(new VectorRenderer());
            circle.Draw();
            square.Draw();
            triangle.Draw();

            Console.WriteLine("TASK 4");
            SmartTextChecker textChecker = new SmartTextChecker();
            char[][] text1 = textChecker.ReadText("test.txt");
            SmartTextReaderLocker readerLocker = new SmartTextReaderLocker(@"locked.*");
            char[][] lockedText1 = readerLocker.ReadText("locked.txt");

            Console.WriteLine("TASK 5");
            LightElementNode table = new LightElementNode("table", "block", "closing", new List<LightNode>
            {
                new LightElementNode("tr", "block", "closing", new List<LightNode>
                {
                    new LightElementNode("th", "block", "closing", new List<LightNode> { new LightTextNode("Заголовок 1") }, new List<string>()),
                    new LightElementNode("th", "block", "closing", new List<LightNode> { new LightTextNode("Заголовок 2") }, new List<string>())
                }),
                new LightElementNode("tr", "block", "closing", new List<LightNode>
                {
                    new LightElementNode("td", "block", "closing", new List<LightNode> { new LightTextNode("Дані 1") }, new List<string>()),
                    new LightElementNode("td", "block", "closing", new List<LightNode> { new LightTextNode("Дані 2") }, new List<string>())
                })
            }, new List<string> { "table-class" });
            Console.WriteLine("Таблиця виведена текстом HTML:");
            Console.WriteLine(table.OuterHtml);

            Console.WriteLine("TASK 6");
            string url = "https://www.gutenberg.org/cache/epub/1513/pg1513.txt";
            string text;
            using (WebClient client = new WebClient())
            {
                text = client.DownloadString(url);
            }
            List<LightNode> nodes = LightHTMLConverter.ConvertTextToHTML(text);

            foreach (var node in nodes)
            {
                Console.WriteLine(node.OuterHtml);
            }
            long totalMemoryUsage = 0;

            foreach (var node in nodes)
            {
                long nodeMemoryUsage = node.OuterHtml.Length * sizeof(char);
                totalMemoryUsage += nodeMemoryUsage;
            }

            Console.WriteLine($"Розмір у пам'яті дерева верстки: {totalMemoryUsage} bytes");
        }
    }
}