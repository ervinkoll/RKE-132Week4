﻿
Random rnd = new Random();
int cpuRandom;

bool loopActive = true;

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter a number 1-4");
    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false;
    }
    else
    {
        Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a nice day!");