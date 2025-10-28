// See https://aka.ms/new-console-template for more information

using Interview.ConsoleRunner;

Console.WriteLine("Hello, World!");

var fizzBuzz = new FizzBuzz();
for (int i = 0; i < 100; i++)
{
    fizzBuzz.Run(i);
}

