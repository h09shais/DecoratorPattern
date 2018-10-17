namespace DecoratorPattern
{
    public class WithMilk : CoffeeDecorator
    {
        public WithMilk(ICoffee coffee)
            : base(coffee)
        {
        }

        public override double Cost => base.Cost + 0.5;
    
        public override string Ingredients => base.Ingredients + ", Milk";
    }
}
