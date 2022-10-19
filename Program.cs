using System;

//new Lesson3Insight_1stPart().StringMagic();

new Homework().Task_1();

class Homework
{
    public void Task_1()
    {
        //Do something
    }

    public void Task_2()
    {
        //Do Something
    }
}


class Lesson3Insight_1stPart
{
    #region Типы данных

    public void DataTypes()
    {
        string line = "Type {0, 8} |\t.NET {1, 8} |\tSize ={2} \t| Min = {3, 30}\t| Max = {4}";

        Console.Title = "Data types C#";

        Console.WriteLine("\n\t\t\t\t\tValue types C# \n");

        Console.WriteLine("\n\t\t\t\t\tIntegral numeric types: \n");

        Console.WriteLine(line, "byte", nameof(Byte), sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine(line, "sbyte", nameof(SByte), sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine(line, "short", nameof(Int16), sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine(line, "ushort", nameof(UInt16), sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine(line, "int", nameof(Int32), sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine(line, "uint", nameof(UInt32), sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine(line, "long", nameof(Int64), sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine(line, "ulong", nameof(UInt64), sizeof(ulong), ulong.MinValue, ulong.MaxValue);

        Console.WriteLine("\n\t\t\t\t\tFloating-point numeric types: \n");

        Console.WriteLine(line, "float", nameof(Single), sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine(line, "double", nameof(Double), sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine(line, "decimal", nameof(Decimal), sizeof(decimal), decimal.MinValue, decimal.MaxValue);

        Console.WriteLine("\n\t\t\t\t\tChar types: \n");

        Console.WriteLine(line, "char", nameof(Char), sizeof(char), char.MinValue, char.MaxValue);

        Console.WriteLine("\n\t\t\t\t\tBoolean types: \n");

        Console.WriteLine(line, "bool", nameof(Boolean), sizeof(bool), bool.FalseString, bool.TrueString);

        Console.WriteLine("\n\t\t\t\t\tReference types C# \n");

        Console.WriteLine(line, "string", nameof(String), "N/A", "N/A", "N/A");
        Console.WriteLine(line, "object", nameof(Object), "N/A", "N/A", "N/A");
        Console.WriteLine(line, "dynamic", "N/A", "N/A", "N/A", "N/A");
    }
    #endregion

    #region Переменные

    public void Variables()
    {
        var a = 5;
        var c = 6.5;
        Console.WriteLine(a);
        Console.ReadLine();
    }

    public void Compare()
    {
        int a = 5;
        int b = 5;
        bool c = a == b;
        var d = a.Equals(b);

        object a1 = 5;
        object b1 = 5;
        var c1 = a1 == b1; //сравнение по ссылке
        var d1 = a1.Equals(b1); // сравнение по значению

        Console.WriteLine($"Value for == is [{c1}]");
        Console.WriteLine($"Value for Equals is [{d1}]");
    }

    #endregion

    #region Преобразование строк

    public void StringMagic()
    {
        //string a = " - \"Hi!\"";
        //Console.WriteLine(a);

        var poem = "Cat is black";
        var newAdj = "white";

        var newPoem = poem.Replace("yellow", newAdj);
        var newPoem1 = poem.Replace('a', 'o');
        Console.WriteLine(newPoem1);

    }

    #endregion

    #region Ввод в консоль

    public void ConsoleWorkout()
    {
        Console.WriteLine("Enter your name");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");

        string b = @"kdsld
            fjdkdjfjdfjk
            dfjdlfldf
            ldfjldf";

        //string c = string.Format("Hello dear {0}. let's talk about {1}", name, product);
    }

    #endregion

    #region Бинарные операторы

    #region Арифметические операторы

    /*
    + Сложение
    - Вычитание
    * Умножение
    / Деление
    % Деление по модулю
    */

    #endregion

    #region Операторы сравнения

    /*
    == Равно
    != Не равно
    > Больше
    < Меньше
    >= Больше или равно
    <= Меньше или равно
    */

    #endregion

    #region Логические операторы

    /*
    Логические операторы

    && Сокращенное И
    || Сокращенное ИЛИ
    &  И
    |  ИЛИ
    !  НЕ
    ^  Логическое исключение ИЛИ
    */

    #endregion

    #endregion

    #region Унарные операторы

    /*
    ++a Инкремент префиксный
    a++ Инкремент постфиксный
    --a Декремент префиксный
    a-- Декремент постфиксный
    */

    #endregion
}