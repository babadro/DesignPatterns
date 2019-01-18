﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TemplatePattern.Beverages
{
    class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Add Coffee Grounds to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Add Milk and Sugar");
        }
    }
}
