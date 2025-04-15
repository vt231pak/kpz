﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class WeaponDecorator : InventoryDecorator
    {
        public WeaponDecorator(Hero hero) : base(hero) { }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("- Додаткова зброя");
        }
    }
}
