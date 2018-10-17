namespace DecoratorPattern
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();
            PrintInfo(coffee);

            coffee = new WithMilk(coffee);
            PrintInfo(coffee);

            coffee = new WithSprinkles(coffee);
            PrintInfo(coffee);

            Console.ReadLine();
        }

        private static void PrintInfo(ICoffee coffee)
        {
            Console.WriteLine("Cost: " + coffee.Cost + "; Ingredients: " + coffee.Ingredients);
        }
    }
}
