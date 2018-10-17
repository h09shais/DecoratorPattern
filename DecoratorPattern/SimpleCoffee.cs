namespace DecoratorPattern
{
    public class SimpleCoffee : ICoffee
    {
        public string Ingredients => "Coffee";
    
        public double Cost => 1;
    }
}
