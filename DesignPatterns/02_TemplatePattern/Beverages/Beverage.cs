﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TemplatePattern.Beverages
{
    public abstract class Beverage
    {
        protected int _sugar;

        public void Prepare()
        {
            Boil();
            Brew();
            Pour();
            if (WantsCondiments)
                AddCondiments();
        }

        public bool WantsCondiments { private get; set; }

        protected abstract void Brew();

        private void Boil()
        {
            Console.WriteLine("Boling Water");
        }

        private void Pour()
        {
            Console.WriteLine("Pouring in Cup");
        }

        protected abstract void AddCondiments();

        public int AddSugar { get; set; }

        protected void Sugar() { }
    }
}
