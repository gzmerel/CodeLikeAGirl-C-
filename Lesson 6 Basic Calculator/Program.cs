var firstNumber = 0.0;
var secondNumber = 0.0;
var operation = new List<string> {"+","-","/","*","^"};
var userOperation = "";
var userInput = " ";
Console.WriteLine("This is a basic calculator");

while (true)
{ 
Console.WriteLine("Please enter the first number:");
firstNumber = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("Please enter operator (+  -  /  *  ^)");
userOperation = Console.ReadLine().Trim().ToString();
Console.WriteLine("Please enter the second number:");
secondNumber = double.Parse(Console.ReadLine().Trim());
Console.WriteLine("If you want to exit press X");
userInput= Console.ReadLine().Trim();
    if (userInput == "X")
    {
        break;
    }
    switch (userOperation)
    {
        case "+":
        var result = Add(firstNumber , secondNumber);
        Console.WriteLine($"The answer is {result}");
        break;

        case "-":
        Substraction(firstNumber , secondNumber);
        break;
        
        case "/":
        Divided(firstNumber , secondNumber);
        break;
        
        case "*":
        Multiply(firstNumber , secondNumber);
        break;
        
        case "^":
        Power(firstNumber , secondNumber);
        break;

        default:
        Console.WriteLine("Please try again");
        break;
    } 

}

double Add( double firstNumber, double secondNumber)
    {
        var add = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber}+{secondNumber}={add}");
        return add;
    }
double Substraction(double firstNumber, double secondNumber)
    {
        var substract = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber}-{secondNumber}={substract}");
        return substract;
    }
double Divided (double firstNumber, double secondNumber)
    {
        var divided = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber}/{secondNumber}={divided}");
        return divided;
    }
double Multiply(double firstNumber, double secondNumber)
    {
        var multiply = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber}*{secondNumber}={multiply}");
        return multiply;
    }
double Power(double firstNumber, double secondNumber)
    {
        var power = Math.Pow(firstNumber,secondNumber);
        Console.WriteLine($"{firstNumber}^{secondNumber}={power}");
        return power;
    }