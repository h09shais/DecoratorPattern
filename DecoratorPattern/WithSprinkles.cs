namespace DecoratorPattern
{
    public class WithSprinkles : CoffeeDecorator
    {
        public WithSprinkles(ICoffee coffee)
            : base(coffee)
        {
        }

        public override double Cost => base.Cost + 0.2;
        

        public override string Ingredients => base.Ingredients + ", Sprinkles";
    }
}
