// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int someRandomNumber = 59;

string BooleanPositive = "Yes, the number is 55";
string BooleanNegative = "No, the number is not 55";

if (someRandomNumber == 55) // True Boolean Value
{
    Console.WriteLine(BooleanPositive);
}
else // False Boolean Value
{
    Console.WriteLine(BooleanNegative);
}

if (someRandomNumber != 55)
{
    Console.WriteLine(BooleanNegative);
}
else
{
    Console.WriteLine(BooleanPositive);
}

// Simple for loop which counts from 1 to 10
int beginningNumber = 1;
int endingNumber = 10;

for (int i = beginningNumber; i <= endingNumber; i++)
{
    string sentence = $"I am counting at number {i}";
    Console.WriteLine(sentence);
}