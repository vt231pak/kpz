﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForTask2
{
    public class Laptop : IDevice
    {
        public string GetInfo()
        {
            return "Ноутбук";
        }
    }
}
