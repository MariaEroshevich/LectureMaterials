//int[] array = new int[5];

//array[0] = 202;
//array[1] = 2;
//array[2] = 3;
//array[3] = 5;
//array[4] = 6;

//for (int i = 0; i <= array.Length - 1; i++)
//{
//    Console.WriteLine(array[i]);
//}

//string[] array1 = new string[3] { "Mother", "Father", "Sister" };

//Console.WriteLine(array1[^1]);
//foreach (var x in array1)
//{
//    Console.WriteLine(x);
//}

//int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 } };
//int row = numbers.GetUpperBound(0) + 1;
//int colmns = numbers.Length / row;

//for (int i = 0; i < row; i++)
//{
//    for (int j = 0; j < colmns; j++)
//    {
//        Console.WriteLine(numbers[i, j]);
//    }
//}

//int[][] array = new int[4][];
//array[0] = new int[3] {1, 2, 3};
//array[1] = new int[3] { 1, 2, 3 };
//array[2] = new int[3] { 1, 2, 3 };
//array[3] = new int[3] { 1, 2, 3 };


//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.WriteLine(array[i][j]);
//    } 
//}

//Array array = Array.CreateInstance(typeof(int), 5);
//array.SetValue(1, 0);
//array.SetValue(2, 1);
//array.SetValue(3, 2);
//array.SetValue(4, 3);
//array.SetValue(5, 4);   

////for (int i = 0; i <= array.Length - 1; i++)
////{
////    Console.WriteLine(array.GetValue(i));

////}
//Console.WriteLine(Array.IndexOf(array, 2));

//string[] array1 = new string[3] { "Mother", "Father", "Sister" };
//Array.Sort(array1);
//for (int i = 0; i <= array1.Length - 1; i++)
//{
//    Console.WriteLine(array1[i]);
//}

using System.Collections;
using System.Collections.Generic;

//ArrayList array = new ArrayList();
//array.Add(2);
//array.Add("apple");
//array.Add(true);
//array.Insert(array.Count - 1, "juice");
//array.Sort();
//foreach (var i in array)
//{
//    Console.WriteLine(i);
//}

//List<string> list = new List<string>() { "orange" };
//list.Add("apple");
//list.Add("potato");

//foreach (var i in list)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(list.IndexOf("apple"));

//var people = new Dictionary<string, string>();

//people.Add("name", "Tom");
//people.Add("age", "56");
//people.Remove(people.Keys.First());

//foreach (var person in people)
//{
//    Console.WriteLine($"{person.Key} {person.Value}");
//    people.TryGetValue(person.Key, out string information);
//    Console.WriteLine(information);
//}

var names = new List<string> { "Petya", "Vasya", "Olya", "Vova" };
var filteredNames = names.Where(x => x.ToUpper().Contains('O')).ToList();
var upperNames = filteredNames.Select(x => x.ToUpper()).ToList();
upperNames.ForEach(x => Console.WriteLine(x));
Console.WriteLine(upperNames.All(x => x.Contains('O')));

