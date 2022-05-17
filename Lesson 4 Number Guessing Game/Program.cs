// Week 4 Assignment Number Guessing Game 16/05/2022

Console.WriteLine("Hello to Number Guessing Game!");
int luckyNumber = new Random().Next(1,11);
Console.WriteLine(luckyNumber);
int guessedNumber = 0;
Console.WriteLine("Please guess a  number from 1 to 10, you have 3 guess ");
Console.WriteLine("The game starts now: ");
for (int  guess  = 2 ; 0<=guess ; guess--)
{
    guessedNumber = int.Parse(Console.ReadLine().Trim());
    if (guessedNumber == luckyNumber)
        {
            Console.WriteLine($"You won, the number is {guessedNumber}");
            break;
        }
    else if (guessedNumber > luckyNumber)
        {
            Console.WriteLine($"{guessedNumber} is higher than luckyNumber ");
            Console.WriteLine($"you have {guess} guess left");  
            if (guess == 0) break;
            Console.WriteLine("Guess another number..." );
        }     
    else
        {
            Console.WriteLine($"{guessedNumber} is lower than luckyNumber ");
            Console.WriteLine($"you have {guess} guess left");   
            if (guess == 0) break;
            Console.WriteLine("Guess another number..." );
        }
} 
Console.WriteLine($"Your guessed are finished.The lucky number is {luckyNumber}");
   


