using System;
using System.Collections.Generic;
using System.Text;

namespace _02_TemplatePattern.Beverages
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Adding tea leaves to water and boil");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon and Sugar");
            Sugar();
        }

        public new int AddSugar
        {
            set { _sugar = value; }
        }
    }
}
