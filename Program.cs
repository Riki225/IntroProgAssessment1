using System;
using System.Collections.Generic;

namespace liststask3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
    string answer;
    List<int> numList = new List<int>();
    Console.WriteLine("Rolling a dice...");
    Random rand1 = new Random();
    int diceNum1 = rand1.Next(1, 7);
    numList.Add(diceNum1);
    Console.WriteLine("You rolled a " + diceNum1);
    if (diceNum1 < 7)
    Console.WriteLine("Continue to roll a dice? (y/n)");
    answer = Console.ReadLine();
    while (answer != "n")
    {
        Random rand2 = new Random();
        int diceNum2 = rand1.Next(1, 7);
        Console.WriteLine("You rolled a " + diceNum2);
        Console.WriteLine("Continue to roll the dice? (y/n)");
        numList.Add(diceNum2);
        answer = Console.ReadLine();
    }
    Console.WriteLine("Enter amount of rolls to examine:"); 
    int rolls = int.Parse(Console.ReadLine()); 

    foreach(int i in numList)
    {
        int total = 0;
        total += i;
        Console.Write(total);
        Console.Write("Average: " + total / rolls);
        Console.Write("List of rolls: " + numList.Count);
    }
            }
        }
    }
}