using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class Mage : Hero
    {
        public Mage()
        {
            Inventory.Add("- Посох");
        }

        public override void Display()
        {
            Console.WriteLine("Інвентар мага:");
            foreach (var item in Inventory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
