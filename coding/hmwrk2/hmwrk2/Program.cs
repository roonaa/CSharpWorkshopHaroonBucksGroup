// See https://aka.ms/new-console-template for more information

// This adds up all of the numbers
using System.Runtime.InteropServices;

int addthenumbers(int num1, int num2, int num3, int num4)
{
    int sum = num1 + num2 + num3 + num4;
    return sum;
}

// This calls the function
int thesumoffour = addthenumbers(21, 22, 23, 24);

// This prints the result
Console.WriteLine("21 + 22 + 23 + 24 = " + thesumoffour);