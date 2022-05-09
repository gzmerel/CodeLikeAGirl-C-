// This is a SAVINGS CALCULATOR CLG Activity 3, 9/5/22

Console.WriteLine("Hi, I am a Saving Calculator");
Console.WriteLine("How much saving do you have?");
double deposit = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("What's your yearly interest rate");
double interestRate = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("How many month are you planning to save?");
double numberofmonths = double.Parse(Console.ReadLine().Trim());

double saving = deposit * (Math.Pow(1+(interestRate/100),numberofmonths));

Console.WriteLine($"Your future saving will be ${saving}.");
 