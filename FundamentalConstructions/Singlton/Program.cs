using Singlton;

Computer computer = new Computer();
computer.Launch("Linux");
Console.WriteLine(computer.OperationSystem.Name);
