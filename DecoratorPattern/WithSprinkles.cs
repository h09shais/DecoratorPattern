namespace DecoratorPattern
{
    public class WithSprinkles : CoffeeDecorator
    {
        public WithSprinkles(ICoffee coffee)
            : base(coffee)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Sprinkles";
        }
    }
}
