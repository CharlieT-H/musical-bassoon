// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Interview.ConsoleRunner;

Console.WriteLine("Hello, World!");

int start = 0;
int end = 100;

var fizzBuzz = new FizzBuzz();

if(start <= end)
{
    for (int i = start; i < end; i++)
    {
        Console.WriteLine(fizzBuzz.Run(i));

    }
}


