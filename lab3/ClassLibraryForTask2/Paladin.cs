using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class Paladin : Hero
    {
        public Paladin()
        {
            Inventory.Add("- Щит");
        }

        public override void Display()
        {
            Console.WriteLine("Інвентар паладіна:");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
