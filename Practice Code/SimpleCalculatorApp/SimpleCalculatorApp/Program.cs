// See https://aka.ms/new-console-template for more information
Console.WriteLine("Simple Calculator");

#region variable definitions
int someNumber1 = 50;
int someNumber2 = 100;
#endregion

#region function definitions
// Function definition
// This adds 2 numbers
int Add(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

// This takes away 2 numbers
int Subtract(int num1, int num2)
{
    int difference = num1 - num2;
    return difference;
}
// This multiplies 2 numbers
int Multiply(int num1, int num2)
{
    int Product = num1 * num2;
    return Product;
}
// This divides two numbers
int Division(int num1, int num2)
{
    int Divide = num1 / num2;
    return Divide;
}
#endregion
#region Function Calls
// This displays the result of the addition
int sum = Add(someNumber1, someNumber2);
Console.WriteLine($"{someNumber1} + {someNumber2} = {sum}");

// This displays the result of the subtraction
int difference = Subtract(someNumber1, someNumber2);
Console.WriteLine($"{someNumber1} - {someNumber2} = {difference}");

// This displays the result of the Multiplication
int Product = Multiply(someNumber1, someNumber2);
Console.WriteLine($"{someNumber1} * {someNumber2} = {sum}");

// This displays the result of the division
int Divide = Division(someNumber1, someNumber2);
Console.WriteLine($"{someNumber1} / {someNumber2} = {sum}");
#endregion
