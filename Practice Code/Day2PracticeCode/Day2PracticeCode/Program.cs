/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");

// two variables that hold two numbers
int num1 = 5;
int num2 = 10;

// use the additon operator on these two numbers
int sum = num1+ num2;

// print the sum to the console
Console.WriteLine(sum);
string fancyoutput = $"{num1} + {num2} = {sum}";
Console.WriteLine(fancyoutput);

// use the subtraction operator on two numbers
int sum2 = num2 - num1;
string fancyoutput2 = $"{num1} - {num1} = {sum2}";
Console.WriteLine(fancyoutput2);

// use the multiplication operator on two numbers
int sum3 = num2 * num1;
string fancyoutput3 = $"{num1} * {num1} = {sum2}";
Console.WriteLine(fancyoutput3);

// use the division operator on two numbers
int sum4 = num2 / num1;
string fancyoutput4 = $"{num1} / {num1} = {sum2}";
Console.WriteLine(fancyoutput4);*/

// functions
int numberOneforFunction = 5;
int numberTwoforFunction = 10;

// Function Definition
int AddTwoNumbers(int num1, int num2)
{
    int sum = num1 + num2;
    return sum;
}

// Function Call
int storeResultOfAddTwoNumbersFunctionCall = AddTwoNumbers(numberOneforFunction, numberTwoforFunction);
Console.WriteLine(storeResultOfAddTwoNumbersFunctionCall);

string fancyoutputfunction = $"{numberOneforFunction} + {numberTwoforFunction} = {storeResultOfAddTwoNumbersFunctionCall}";