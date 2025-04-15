using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public abstract class InventoryDecorator : Hero
    {
        protected Hero _hero;

        public InventoryDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override void Display()
        {
            _hero.Display();
        }
    }
}
