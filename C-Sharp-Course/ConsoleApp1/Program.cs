using System;

class Program
{
    static void Main()
    {
        //Console.WriteLine("What is your name?");
        //string name = Console.ReadLine();
        //Console.WriteLine("Hello, " + name + "!");
        //Console.Read();

        decimal money = 52.253m;
        string moneyString = money.ToString("$#.##");
        Console.WriteLine(moneyString);
        Console.ReadLine();

    }
}