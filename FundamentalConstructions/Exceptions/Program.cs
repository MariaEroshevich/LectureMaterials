//try
//{
//    int firstNumber = 5;
//    int secondNumber = 0;
//    Console.WriteLine(firstNumber / secondNumber);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine("Method");

using Exceptions;

//int firstNumber;
//int secondNumber;
//int result;

//try
//{
//    Console.WriteLine("Enter first number");
//    firstNumber = int.Parse(Console.ReadLine());

//    Console.WriteLine("Enter second number");
//    secondNumber = int.Parse(Console.ReadLine());

//    result = firstNumber / secondNumber;
//    Console.WriteLine(result);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//finally
//{
//    Console.WriteLine("Message");
//}

//Console.WriteLine("Enter first number");
//firstNumber = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number");
//secondNumber = int.Parse(Console.ReadLine());

//var number = new OwnNumber();

//Console.WriteLine(number.DivideNumbers(firstNumber, secondNumber));

//try
//{
//    Console.WriteLine("Enter string value:");
//    string str = Console.ReadLine();

//    if (str == String.Empty)
//    {
//        throw new Exception("The entered number is null");
//    }
//    else
//    {
//        Console.WriteLine($"Entered string: {str}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.InnerException);
//    Console.WriteLine(ex.StackTrace.ToString());
//    Console.WriteLine(ex.TargetSite.Name);
//    Console.WriteLine(ex.Source);
//}

//try
//{
//    Console.WriteLine("Enter string value:");
//    string str = Console.ReadLine();
//    StringLength stringLength = new StringLength();
//    stringLength.CheckString(str);
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//Console.WriteLine("Success message");

try
{
    Student student = new Student();
    student.Name = "A";
}
catch(IvalidStudentInfoException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Success message");
