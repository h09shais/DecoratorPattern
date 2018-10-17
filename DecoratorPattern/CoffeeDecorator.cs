namespace DecoratorPattern
{
    public abstract class CoffeeDecorator : ICoffee
    {
        private readonly ICoffee _decoratedCoffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            this._decoratedCoffee = coffee;
        }

        public virtual double Cost => this._decoratedCoffee.Cost;

        public virtual string Ingredients => this._decoratedCoffee.Ingredients;
        
    }
}
