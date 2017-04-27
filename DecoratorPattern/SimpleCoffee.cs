namespace DecoratorPattern
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1;
        }

        public string GetIngredients()
        {
            return "Coffee";
        }
    }
}
