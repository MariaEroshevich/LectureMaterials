
using System.Security.AccessControl;
using CSharpAdvanced;

//dynamic variable = 3;
//Console.WriteLine(variable);

//variable = "hello world";
//Console.WriteLine(variable);

//variable = true;
//Console.WriteLine(variable);

//object obj = 24;
//dynamic dyn = new Puddle("Jenny");

//dyn += 10;
//obj += 4;


dynamic vaccinationStatus = true;
var puddle = new Puddle("Bonny");

puddle.SetVaccinationStatus(vaccinationStatus);
Console.WriteLine(puddle.IsVaccinated);

vaccinationStatus = "No";
puddle.SetVaccinationStatus(vaccinationStatus);
Console.WriteLine(puddle.IsVaccinated);

puddle.SetVaccinationStatus("da");
Console.WriteLine(puddle.IsVaccinated);


#region Delegates

//int Add(int x, int y)
//{
//    return x + y;
//}

//int Substract(int x, int y)
//{
//    return x - y;
//}

//int Multiply(int x, int y)
//{
//    return x * y;
//}

//int Divide(int x, int y)
//{
//    return x / y;
//}


////MathOperation operation = Multiply;
////operation += Multiply;
////operation += Divide;
////operation += Substract;
////operation += Add;

////var operationResult = operation(4, 6);
////Console.WriteLine(operationResult);

////delegate int MathOperation(int x, int y);

////using CSharpAdvanced;
////using CSharpAdvanced.Generic;

////var pug = new Pug("Arny");
////var command1 = pug.SelectCommand(CommandType.Bark);
////var command2 = pug.SelectCommand(CommandType.GiveAPaw);

////var command3 = command1 + command2;
////command3.Invoke();




////Command command = pug.Bark;
////command += pug.GiveAPaw;
////command += pug.SitDown;
////command.Invoke();
////command -= pug.Bark;
////command.Invoke();

////delegate void Command();


//#region Action

//void WriteAddResult(int x, int y)
//{
//    Console.WriteLine(x + y);
//}

//void WriteSubstractResult(int x, int y)
//{
//    Console.WriteLine(x - y);
//}

//void Operate(int x, int y, Action<int, int> del) => del(x, y);
//Operate(10, 10, WriteSubstractResult);
//Operate(10, 10, WriteAddResult);

//#endregion

//#region Predicate

//Predicate<int> isPositive = (int x) => x > 0;

//isPositive(20);

//#endregion

//#region Func

//Func<int, int, string> join = (x, y) => $"{x} {y}";
//join(1, 4);

//void WriteJoinResult(int x, int y, Func<int, int, string> func, int timeout = 10000)
//{
//    var result = func(x, y);
//    if (result.Length > 3)
//    {
//        Console.WriteLine("Length is > 3");
//    }
//    else
//    {
//        Console.WriteLine("Length is < 3");

//    }
//}

//WriteJoinResult(5, 12, join);

//#endregion


#endregion

#region Generics

////var intArr = new int[] { 1, 2, 3, 4 };
////var doubleArr = new double[] { 1.2, 2.3, 4.5, 6.7 };
////var strArray = new string[] { "a", "b", "c", "d" };

////var genericsLess = new GenericsLesson();
//////genericsLess.PrintArray(intArr);
//////genericsLess.PrintArray(doubleArr);
////genericsLess.PrintArray(strArray);

////Console.ReadLine();

//using CSharpAdvanced;
//using CSharpAdvanced.Extension;

//var greeting = "Hello world!";
//StringHelper.CharLength(greeting, 'o');
//greeting.CharLength('o');



////var pug = new Pug("Patrick");
////var puddle = new Puddle("Joseph");

////var hairdresser = new Hairdresser<Pug>();
////hairdresser.HairdressDog(pug);

////var hairdresser1 = new Hairdresser<Puddle>();
////hairdresser1.HairdressDog(puddle);

////void Bark<T>(T dog) where T : Dog
////{
////    Console.WriteLine($"Dog {dog.Name} greeting:");
////    dog.Bark();
////    Console.WriteLine(Environment.NewLine);
////}

////Bark(puddle);
////Bark(pug);

//Console.ReadLine();

////void Method<T>(T someParam)
////{
////    Console.WriteLine(someParam);
////}


////MyClass exm = new MyClass();
////exm.GetLenght(somestring);
////MyClass.GetLenght(somestring);
////somestring.GetLenght();

#endregion

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

