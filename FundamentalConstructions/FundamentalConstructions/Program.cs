//Console.WriteLine("Enter student grade:");
//var numberFromConsole = Console.ReadLine();
//int grade = int.Parse(numberFromConsole);
//if (grade == 4 || grade == 5)
//{
//    Console.WriteLine("Exam passed satifactorily!");
//}
//else if (grade == 6 || grade == 7)
//{
//    Console.WriteLine("Exam passed good!");
//}
//else if (grade == 8 || grade == 9 || grade == 10)
//{
//    Console.WriteLine("Exam passed excellent!");
//}
//else
//{
//    Console.WriteLine("Exam failed");
//}
//switch (grade)
//{
//    case 4:
//        Console.WriteLine("Exam passed satifactorily!");
//        break;
//    case 6:
//        Console.WriteLine("Exam passed good!");
//        break;
//    case 9:
//        Console.WriteLine("Exam passed excellent!");
//        break;
//    default:
//        Console.WriteLine("Exam failed");
//        break;
//}

//Console.WriteLine("Do you have a headache?");
//var answer = Console.ReadLine();
//if (answer == "Yes")
//{
//    Console.WriteLine("Have you taken a pill?");
//    var answer2 = Console.ReadLine();
//    if (answer2 == "Yes")
//    {
//        Console.WriteLine("Did the pill help?");
//        var answer3= Console.ReadLine();
//        if (answer3 == "Yes")
//        {
//            Console.WriteLine("With recovery!");
//        }
//        else
//        {
//            Console.WriteLine("Take another pill");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Take a pill");
//    }
//}
//else
//{
//    Console.WriteLine("You are healthy");
//}

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0, j = 1; i + j < 10; i++, j++)
//{
//    Console.WriteLine($"i = {i} and j = {j}");
//}

//int i = 0;
//while (i <= 10)
//{
//    Console.WriteLine(i);
//    i++;
//}
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i >=

//int[] massive = new int[2] {0,1};
//foreach (var i in massive)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 4)
//    {
//        continue;
//    }
//    Console.WriteLine(i);
//}

//var grade = 4;
//var passedMessage = grade > 4 ? "Exam passed!" : "Exam failed!";
//Console.WriteLine(message);

//int p = 6; // p++ = 7
//int l = 5; // --l = 4
//int i = p++ + l; // i = 7 + 4  = 11
//int u = --l * p;  // u = 4 * 7 =28
//Console.WriteLine($" {i}");
//Console.WriteLine($" {p}, {l}, {i}, {u}");
//Console.ReadLine();

//int fullNum = 888;
//int firstPart = fullNum / 10;
//int secondPart = fullNum % 10;
//Console.WriteLine(firstPart + secondPart);
//Console.ReadLine();

//Console.WriteLine("Enter the first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//if (num1 > num2)
//{
//    Console.WriteLine("The first number is greater than the second");
//}
//else if (num1 < num2)
//{
//    Console.WriteLine("The first number is less than the second");
//}
//else if (num1 == num2)
//{
//    Console.WriteLine("Both numbers are equal");
//}
//else
//{
//    Console.WriteLine("");
//}


//Console.WriteLine("Enter number");
//string number = Console.ReadLine();
//int sum = 0;
//var n = 
//while (number != null)
//{
//    sum += number % 10;
//    number /= 10;
//}
//Console.WriteLine(sum);

//int number = 123;
//int sum = 0;
//string line = number.ToString();
//for (int i = 0; i <= line.Length; i++)
//{
//    string newLine = Convert.ToString(line[i]);
//    int num = Convert.ToInt32(newLine);
//    sum += num;
//}
//Console.WriteLine(sum);]

//void Task_3()
//{
//    int firstNum = Convert.ToInt32(Console.ReadLine());
//    int secondNum = Convert.ToInt32(Console.ReadLine());

//    if (firstNum > secondNum)
//    {
//        Console.WriteLine($"{firstNum} is bigger");

//        for (int i = secondNum; i <= firstNum; i++)
//        {
//            if (i % 2 == 0 && i % 5 == 0)
//            {
//                Console.WriteLine("TuttiFrutti");
//            }
//            else if (i % 5 == 0)
//            {
//                Console.WriteLine("Frutti");
//            }
//            else if (i % 2 == 0)
//            {
//                Console.WriteLine("Tutti");
//            }
//            else
//            {
//                Console.WriteLine("Сan’t be divided on 2 or 5");
//            }
//        }
//    }
//    else if (secondNum > firstNum)
//    {
//        Console.WriteLine($"{secondNum} is bigger");

//        for (int i = firstNum; i <= secondNum; i++)
//        {
//            if (i % 2 == 0 && i % 5 == 0)
//            {
//                Console.WriteLine("TuttiFrutti");
//            }
//            else if (i % 5 == 0)
//            {
//                Console.WriteLine("Frutti");
//            }
//            else if (i % 2 == 0)
//            {
//                Console.WriteLine("Tutti");
//            }
//            else
//            {
//                Console.WriteLine("Сan’t be divided on 2 or 5");
//            }
//        }

//    }
//    else
//    {
//        Console.WriteLine("Tne entered numbers are equal ог there were not numbers");
//    }

//    Console.ReadLine();
//}

//Console.WriteLine("Enter number");
//string firstNumber = Console.ReadLine();
//int number = int.Parse(firstNumber);
//Console.WriteLine("Enter next number");
//string newNumber = Console.ReadLine();
//int nextNumber = int.Parse(newNumber);
//int min = Math.Min(number, nextNumber);
//int max = Math.Max(number, nextNumber);
//while (min <= max)
//{

//    if (min % 2 == 0 && min % 5 == 0)
//    {
//        Console.WriteLine("tutti-frutti");
//    }
//    else if (min % 2 == 0)
//    {
//        Console.WriteLine("tutti");
//    }
//    else if (min % 5 == 0)
//    {
//        Console.WriteLine("frutti");
//    }
//    else
//    {
//        Console.WriteLine($"Number {min} can’t be divided on 2 or 5");
//    }
//    min++;
//}

using Inheritance;

Transport transport = new Transport("Audi", "X6");
