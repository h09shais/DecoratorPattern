namespace DecoratorPattern
{
    public class WithMilk : CoffeeDecorator
    {
        public WithMilk(ICoffee coffee)
            : base(coffee)
        {
        }

        public override double GetCost()
        { 
            return base.GetCost() + 0.5;
        }

        public override string GetIngredients()
        {
            return base.GetIngredients() + ", Milk";
        }
    }
}
