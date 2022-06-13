var firstNumber = 0.0;
var secondNumber = 0.0;
var operation = new List<string> {"+","-","/","*","^"};
var userOperator = "";
var userInput = " ";
Console.WriteLine("This is a basic calculator");
Console.WriteLine("============================");
while (true)
{ 
firstNumber = AskFirstNumber(firstNumber);
userOperator = AskForOperator(userOperator);
secondNumber = AskSecondNumber(secondNumber);
switch (userOperator)
    {
        case "+":
        var sum = Add(firstNumber , secondNumber);
        Console.WriteLine($"The answer is {sum}");
        break;

        case "-":
        var difference = Subtraction(firstNumber , secondNumber);
        Console.WriteLine($"The answer is {difference}");
        break;
        
        case "/":
        Division(firstNumber , secondNumber);
        var quotient = Division(firstNumber , secondNumber);
        Console.WriteLine($"The answer is {quotient}");
        break;
        
        case "*":
        var product = Multiplication(firstNumber , secondNumber);
        Console.WriteLine($"The answer is {product}");
        break;
        
        case "^":
        var power = Power(firstNumber , secondNumber);
        Console.WriteLine($"{firstNumber} to the power of {secondNumber} = {power}");
        break;

        default:
        Console.WriteLine("Please try again");
        break;
    } 

    Console.WriteLine("If you want to exit press X");
    userInput= Console.ReadLine().Trim();
    if (userInput == "X" | userInput=="x")
    {
        break;
    }
}
double AskFirstNumber(double firstNumber)
    {
        Console.WriteLine("Please enter the first number:");
        firstNumber = double.Parse(Console.ReadLine().Trim());
        return firstNumber;
    }
string AskForOperator(string userOperator)
    {
        Console.WriteLine("Please enter operator (+  -  /  *  ^)");
        userOperator = Console.ReadLine().Trim().ToString();
        return userOperator;
    }
double AskSecondNumber(double secondNumber)
    {
        Console.WriteLine("Please enter the second number:");
        secondNumber = double.Parse(Console.ReadLine().Trim());
        return secondNumber;
    }
double Add( double firstNumber, double secondNumber)
    {
        var sum = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber}+{secondNumber}={sum}");
        return sum;
    }
double Subtraction(double firstNumber, double secondNumber)
    {
        var difference = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber}-{secondNumber}={difference}");
        return difference;
    }
double Division (double firstNumber, double secondNumber)
    {
        var quotient = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber}/{secondNumber}={quotient}");
        return quotient;
    }
double Multiplication(double firstNumber, double secondNumber)
    {
        var product = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber}*{secondNumber}={product}");
        return product;
    }
double Power(double firstNumber, double secondNumber)
    {
        var power = Math.Pow(firstNumber,secondNumber);
        Console.WriteLine($"{firstNumber}^{secondNumber}={power}");
        return power;
    }