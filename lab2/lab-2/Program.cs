using System;
using System.Reflection.Emit;
using System.Text;
using ClassLibraryForTask1;
using ClassLibraryForTask2;
using ClassLibraryForTask3_4;
using ClassLibraryForTask5;

namespace lb2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Оберіть номер завдання:");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Виберіть рівень підписки:");
                    Console.WriteLine("1. Базовий");
                    Console.WriteLine("2. Освітній");
                    Console.WriteLine("3. Преміум");
                    Console.Write("Ваш вибір: ");
                    int subscriptionLevelChoice = int.Parse(Console.ReadLine());

                    Console.WriteLine("Виберіть спосіб покупки підписки:");
                    Console.WriteLine("1. Веб-сайт");
                    Console.WriteLine("2. Мобільний додаток");
                    Console.WriteLine("3. Кол-центр");
                    Console.Write("Ваш вибір: ");
                    int purchaseMethodChoice = int.Parse(Console.ReadLine());
                    SubscriptionMethod method = null;
                    Subscription subscription = null;
                    if (purchaseMethodChoice == 1)
                    {
                        Console.Write("Ви обрали спосіб покупки через веб-сайт:\n");
                        method = new WebSite();
                        if (subscriptionLevelChoice == 1)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 2)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 3)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else
                        {
                            Console.WriteLine("Неіснуючий варіант підписки!");
                        }
                    }
                    else if (purchaseMethodChoice == 2)
                    {
                        Console.Write("Ви обрали спосіб покупки через мобільний додаток:\n");
                        method = new MobileApp();
                        if (subscriptionLevelChoice == 1)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 2)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 3)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else
                        {
                            Console.WriteLine("Неіснуючий варіант підписки!");
                        }
                    }
                    else if (purchaseMethodChoice == 3)
                    {
                        Console.Write("Ви обрали спосіб покупки через кол-центр:\n");
                        method = new ManagerCall();
                        if (subscriptionLevelChoice == 1)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 2)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else if (subscriptionLevelChoice == 3)
                        {
                            subscription = method.CreateSubscription(subscriptionLevelChoice);
                        }
                        else
                        {
                            Console.WriteLine("Неіснуючий варіант підписки!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неіснуючий метод покупки!");
                    }
                    subscription.DisplayDetails();
                    break;
                case 2:
                    Console.WriteLine("Оберіть, що виготовити:");
                    Console.WriteLine("1. Ноутбук");
                    Console.WriteLine("2. Смартфон");
                    Console.WriteLine("3. Нетбук");
                    Console.WriteLine("4. Електрона книга");
                    int choice = int.Parse(Console.ReadLine());
                    IDeviceFactory factory = null;
                    switch (choice)
                    {
                        case 1:
                            factory = new LeblovoFactory();
                            break;
                        case 2:
                            factory = new IProneFactory();
                            break;
                        case 3:
                            factory = new BalaxyFactory();
                            break;
                        case 4:
                            factory = new BooksFactory();
                            break;
                        default:
                            Console.WriteLine("Невідомий бренд.");
                            return;
                    }
                    Console.WriteLine("Виготовлення девайсу...");
                    IDevice device = factory.CreateDevice();
                    Thread.Sleep(2000);
                    Console.WriteLine("Девайс успішно виготовлений:");
                    Console.WriteLine($"Тип: {device.GetInfo()}");
                    Console.WriteLine($"Бренд: {(factory is IProneFactory ? "IProne" : (factory is LeblovoFactory ? "Leblovo" : (factory is BalaxyFactory ? "Balaxy" : "Books")))}");
                    break;
                case 3:
                    Authenticator authenticator1 = Authenticator.Instance;
                    Authenticator authenticator2 = Authenticator.Instance;

                    Console.WriteLine(object.ReferenceEquals(authenticator1, authenticator2));

                    authenticator1.Authenticate("admin", "admin123");
                    break;
                case 4:
                    Virus grandparent = new Virus(10.5, 5, "Дідусь", "Грип");
                    Virus parent1 = new Virus(8.2, 3, "Батько1", "Коронавірус");
                    Virus parent2 = new Virus(7.9, 4, "Батько2", "Ебола");
                    Virus child1 = new Virus(4.5, 1, "Дитина1", "SARS");
                    Virus child2 = new Virus(3.8, 2, "Дитина2", "HIV");
                    Virus grandchild1 = new Virus(2.1, 0, "Онук1", "Зіка");
                    Virus grandchild2 = new Virus(1.7, 0, "Онук2", "Сказ");
                    grandparent.AddChild(parent1);
                    grandparent.AddChild(parent2);
                    parent1.AddChild(child1);
                    parent1.AddChild(child2);
                    child1.AddChild(grandchild1);
                    child1.AddChild(grandchild2);
                    Virus clone = (Virus)grandparent.Clone();
                    Console.WriteLine("Оригінальний Virus:");
                    grandparent.Display();
                    Console.WriteLine("\nVirus клон:");
                    clone.Display();
                    break;
                case 5:
                    var rapunzelBuilder = new HeroBuilder()
                        .SetHeight(170)
                        .SetStature("Худа")
                        .SetHairColor("Золоте")
                        .SetEyeColor("Зелені")
                        .SetClothing("Довга рожева сукня")
                        .SetInventory(new List<string> { "Розчіска", "Дзеркальце" });

                    var witchBuilder = new EnemyBuilder()
                        .SetHeight(160)
                        .SetStature("Худа")
                        .SetHairColor("Чорні")
                        .SetEyeColor("Червоні")
                        .SetClothing("Розкішна червона сукня")
                        .SetInventory(new List<string> { "Отрута", "Магічна книга" });
                    

                    Console.WriteLine("Рапунцель:");
                    rapunzelBuilder.DisplayInfo();

                    Console.WriteLine("\nВідьма:");
                    witchBuilder.DisplayInfo();
                    break;
            }

        }

    }
}