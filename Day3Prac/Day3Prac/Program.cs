// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Type 1
// Function that does not take any parameters
// or returns any value
void FunctionTypeOne()
{
    string someString1 = "Hey guys";
    Console.WriteLine(someString1);
}

// function call
FunctionTypeOne();

// Type 2
// Function that takes a single parameter and does not return
void FunctionTypeTwo(int numberofmovies)
{
    string outputSentence = $"I have watched {numberofmovies} movies this year";
    Console.WriteLine(outputSentence);
}

int tobeSentToFunctionMovieCount = 124;
FunctionTypeTwo(tobeSentToFunctionMovieCount);

// Type 2 B
// Function with 2 parameters nad does not return
void FunctionTypeTwoB(int one, string two, bool three)
{
    string someOutput = $"The values are {one}, {two}, {three}";
    Console.WriteLine(someOutput);
}

int one = 1;
string two = "two";
bool three = true;

FunctionTypeTwoB(one, two, three);

// Type 3
// Function with parmeters and returns value
int FunctionThatAdds(int numberOne, int numberTwo)
{
    int sum = numberOne + numberTwo;
    return sum;
}

int randomnumone = 7;
int randomnumtwo = 50;

int result = FunctionThatAdds(randomnumone, randomnumtwo);
Console.WriteLine(result);

// Type 4
// Function without parameters and returns value
int FunctionThatReturnsRandomValue()
{
    Random random= new Random();
    int randomNumber = random.Next(1, 100);
    return randomNumber;
}

int FunctionWhichReturnsaRandomNumber(int lowerbound, int upperbound)
{
    Random random= new Random();
    int randomNumber = random.Next(lowerbound, upperbound);
    return randomNumber;
}

Console.WriteLine(FunctionThatReturnsRandomValue());

int randomnumber = FunctionWhichReturnsaRandomNumber(56, 100);
Console.WriteLine(randomnumber);
