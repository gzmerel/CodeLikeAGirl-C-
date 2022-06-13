// This is a SAVINGS CALCULATOR CLG Activity 3, 9/5/22

Console.WriteLine("Hi, I am a Saving Calculator");
Console.WriteLine("How much saving do you have?");
double deposit = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("What's your yearly interest rate");
double interestRate = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("How many month are you planning to save?");
double numberofmonths = double.Parse(Console.ReadLine().Trim());

double saving = deposit * (Math.Pow(1+(interestRate/1200),numberofmonths));
Console.WriteLine($"Your future saving will be ${saving}.");

Console.WriteLine("Do you want to add extra monthly deposit?(Y/N)");
string userInput= Console.ReadLine().Trim().ToUpper();

switch (userInput)
{
    case "Y":
    Console.WriteLine("How much money do you want to add monthly?");
    double extraDeposit =double.Parse(Console.ReadLine());
    Console.WriteLine("What's your yearly interest rate");
    double extraInterestRate = double.Parse(Console.ReadLine().Trim());
    Console.WriteLine("How many year are you planning to save?");
    double extraNumberOfMonths = double.Parse(Console.ReadLine().Trim());
    Console.WriteLine($"Present Value:{saving}, rate : {extraInterestRate}% for extra months");
    double extraSaving = extraDeposit*((Math.Pow((1+(extraInterestRate/1200)),extraNumberOfMonths*12)-1)/(extraInterestRate/1200));
    Console.WriteLine($"Your extra saving will be {extraSaving}");
    break;
    case"N":
    break;
    default:
    break;
}

    

