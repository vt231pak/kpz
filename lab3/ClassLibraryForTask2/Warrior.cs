using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class Warrior : Hero
    {
        public Warrior()
        {
            Inventory.Add("- Меч");
        }

        public override void Display()
        {
            Console.WriteLine("Інвентар воїна:");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
