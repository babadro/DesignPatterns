using _02_TemplatePattern.Beverages;
using System;

namespace _02_TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var tea = new Tea();
            var coffee = new Coffee();
            tea.WantsCondiments = true;
            tea.AddSugar = 5;
            tea.Prepare();

            Console.WriteLine();
            coffee.WantsCondiments = true;
            coffee.Prepare();

            var grenTea = new GreenTea();
            grenTea.Brew();
        }
    }
}
