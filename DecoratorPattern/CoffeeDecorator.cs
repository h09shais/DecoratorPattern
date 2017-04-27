namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private ICoffee decoratedCoffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this.decoratedCoffee = coffee;
        }

        public virtual double GetCost()
        {
            return this.decoratedCoffee.GetCost();
        }

        public virtual string GetIngredients()
        {
            return this.decoratedCoffee.GetIngredients();
        }
    }
}
