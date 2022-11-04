using CSharpOOP;

Pumpkin pumpkinGreg = new Pumpkin { Name = "Greg", Age = 55, Color = "Orange", HasTail = true };
Pumpkin pumpkinHarry = new Pumpkin { Name = "Harry", Age = 13, Color = "Green", HasTail = false };
Pumpkin pumpkinJane = new Pumpkin { Name = "Jane", Age = 23, Color = "Yellow", HasTail = true };

var pumpkins = new List<Pumpkin> { pumpkinGreg, pumpkinHarry, pumpkinJane };
//var sortedPumpkin = pumpkins.OrderBy(p => p.HasTail).ThenByDescending(p => p.Age);
//var pumpkin = pumpkins.First(p => p.Name.Equals("Selena"));
var pumpkin1 = pumpkins.FirstOrDefault(p => p.Name.Equals("Selena"));

pumpkins.ForEach(p => p = new Pumpkin
{
    Name = p.Name + "1",
});

pumpkins.ForEach(p => Console.WriteLine(p.Name));

var numbers = new List<int> { 12, 13, 45, 34, 89 };
var maxNumber = numbers.Max();
var secondItem = numbers.ElementAt(1);// numbers[1]
if (numbers.Any(n => n == 12))
{
    Console.WriteLine("Any!");
}
else if (numbers.All(n => n == 12))
{
    Console.WriteLine("All!");
}
else
{
    Console.WriteLine("Please learn more about LINQ");
}

//var pumpkinsNames = pumpkins.Where(p => p.Age < 18).Select(p => new Pumpkin(p.Name, p.Age + 1, p.Color, p.HasTail)).ToList();

//var tailessPumpkinsQuery = pumpkins.Where(p => !p.HasTail);
//var tailessPumpkins = pumpkins.Where(p => p.Age < 18).ToList();

var allAnimals = new List<string> { "Zebra", "Elephant", "Cat", "Dog", "Lion", "Giraffe", "Parrot" };
var domesticAnimals = new List<string> { "Cat", "Dog", "Parrot" };
var wildAnimals = new List<string> { "Zebra", "Elephant", "Lion", "Giraffe", "Parrot" };
var unitedAnimals = domesticAnimals.Union(wildAnimals).ToList();

var sortedAnimals = new LinqHelper().SortAnimals(allAnimals);
var sortedAnimalsLinq = allAnimals.Where(name => name.Contains('a')).Select(name => name.Replace('a', 'o')).ToList();

var sortedAnimalsQuery = from animal in allAnimals
    where animal.Contains('a')
    select animal.Replace('a', 'o');

//sortedAnimals.SortAnimals()
//LinqExtension.SortAnimals();
Console.WriteLine(string.Join(',', sortedAnimals));

public class LinqHelper
{
    public List<string> SortAnimals(List<string> initialAnimals, char initialSymbol = 'a', char newSymbol = 'o')
    {
        var sortedAnimals = new List<string>();

        foreach (var animal in initialAnimals)
        {
            if (animal.Contains(initialSymbol))
            {
                //var newAnimal = animal.Replace(initialSymbol, newSymbol);
                sortedAnimals.Add(animal);
            }
        }

        foreach (var animal in sortedAnimals)
        {
            animal.Replace(initialSymbol, newSymbol);
        }

        return sortedAnimals;
    }
}

//public static class LinqExtension
//{
//    public static List<string> SortAnimals(this List<string> initialAnimals, char initialSymbol = 'a', char newSymbol = 'o')
//    {
//        var sortedAnimals = new List<string>();

//        foreach (var animal in initialAnimals)
//        {
//            if (animal.Contains(initialSymbol))
//            {
//                var newAnimal = animal.Replace(initialSymbol, newSymbol);
//                sortedAnimals.Add(newAnimal);
//            }
//        }

//        return sortedAnimals;
//    }
//}