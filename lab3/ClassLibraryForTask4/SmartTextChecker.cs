using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask4
{
    public class SmartTextChecker : SmartTextReader
    {
        public new char[][] ReadText(string filePath)
        {
            Console.WriteLine("Відкриваємо файл: " + filePath);

            char[][] result = base.ReadText(filePath);

            if (result != null)
            {
                Console.WriteLine($"Файл {filePath} успішно прочитано.");
                Console.WriteLine($"Загальна кількість рядків: {result.Length}, загальна кількість символів: {TotalCharacters(result)}");
            }

            Console.WriteLine("Закриваємо файл: " + filePath);
            return result;
        }

        private int TotalCharacters(char[][] text)
        {
            int total = 0;
            foreach (var line in text)
            {
                total += line.Length;
            }
            return total;
        }
    }
}
