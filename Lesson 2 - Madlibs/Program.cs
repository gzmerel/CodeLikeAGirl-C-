
// This is a Madlib application created for CLG Lesson 2 C# 7/5/22
string name;
string firstAnimal;
string secondAnimal;
string firstCharacter;
string secondCharacter;

Console.WriteLine("What's your name?");
name = Console.ReadLine();
Console.WriteLine ("What's your favourite animal?");
firstAnimal = Console.ReadLine().Trim().ToLower();
Console.WriteLine($"Tell us 3 things about {firstAnimal}");
firstCharacter = Console.ReadLine().Trim().ToLower();
Console.WriteLine("What's your second favourite animal?");
secondAnimal = Console.ReadLine().Trim().ToLower();
Console.WriteLine($"Tell us 3 things about {secondAnimal}");
secondCharacter = Console.ReadLine().Trim().ToLower();

Console.WriteLine($"Hi {name}, thanks for your answers. I'll explain you why we asked you this questions.");
Console.WriteLine($"The first animal describes your character. You are {firstCharacter}.");
Console.WriteLine($"The second animal describes your ideal partner's character.");
Console.WriteLine($"Your ideal partner should be {secondCharacter}.");
Console.WriteLine("We are not sure this test is working but it just for fun.");
Console.ReadKey();







