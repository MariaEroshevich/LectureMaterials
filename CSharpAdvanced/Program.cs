
//var intArr = new int[] { 1, 2, 3, 4 };
//var doubleArr = new double[] { 1.2, 2.3, 4.5, 6.7 };
//var strArray = new string[] { "a", "b", "c", "d" };

//var genericsLess = new GenericsLesson();
////genericsLess.PrintArray(intArr);
////genericsLess.PrintArray(doubleArr);
//genericsLess.PrintArray(strArray);

//Console.ReadLine();

using CSharpAdvanced;
using CSharpAdvanced.Extension;

var greeting = "Hello world!";
StringHelper.CharLength(greeting, 'o');
greeting.CharLength('o');



//var pug = new Pug("Patrick");
//var puddle = new Puddle("Joseph");

//var hairdresser = new Hairdresser<Pug>();
//hairdresser.HairdressDog(pug);

//var hairdresser1 = new Hairdresser<Puddle>();
//hairdresser1.HairdressDog(puddle);

//void Bark<T>(T dog) where T : Dog
//{
//    Console.WriteLine($"Dog {dog.Name} greeting:");
//    dog.Bark();
//    Console.WriteLine(Environment.NewLine);
//}

//Bark(puddle);
//Bark(pug);

Console.ReadLine();


public class GenericsLesson
{
    //void PrintArray(int[] arr)
    //{
    //    Console.WriteLine(string.Join(',', arr));
    //}

    //void PrintArray(double[] arr)
    //{
    //    Console.WriteLine(string.Join(',', arr));
    //}

    //void PrintArray(string[] arr)
    //{
    //    Console.WriteLine(string.Join(',', arr));
    //}

    public void PrintArray<T>(T[] arr)
    {
        Console.WriteLine(string.Join(',', arr));
    }

    //public T Max<T>(T x, T y)
    //{
    //    return x > y ? x : y;
    //}

    public IComparable Max(IComparable x, IComparable y)
    {
        return x.CompareTo(y) > 0 ? x : y;
    }

    public T Max<T>(T x, T y) where T : IComparable
    {
        return x.CompareTo(y) > 0 ? x : y;
    }
}

