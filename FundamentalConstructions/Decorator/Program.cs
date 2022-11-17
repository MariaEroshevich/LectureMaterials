using Decorator;

IPizza american = new AmericanPizza("American");
american = new TomatoPizza(american);

Console.WriteLine(american.GetCost());