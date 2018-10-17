using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace DecoratorPattern.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CoffeeWithMilkCostlyThenSimpleCoffee()
        {
            var coffee = new Mock<ICoffee>();
            var simpleCoffee = new SimpleCoffee();
            var coffeeWithMilk = new WithMilk(simpleCoffee);
            Assert.IsTrue(coffeeWithMilk.Cost > simpleCoffee.Cost);
        }
    }
}
