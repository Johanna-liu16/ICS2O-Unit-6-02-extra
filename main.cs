// Created by: Johanna Liu
// Created on: Mar 2022
//
// This program does basic math
using System;

class Program
{
    public static void Main(string[] args)
    {
        var cookie = 0;
        var reply = "";

        Console.WriteLine("Cookie Clicker!");
        Console.WriteLine("");

        while (true)
        {
            Console.Write("Would you like to add1 or quit? ");
            reply = Console.ReadLine();
            
            if (reply == "add1")
            {
                switch (reply)
                {
                    case "add1":
                        cookie = cookie + 1;
                        Console.Write("You now have " + cookie + " cookies.");
                        Console.WriteLine("");
                        continue;
                }
            }
            else if (reply == "quit")
            {
                Console.WriteLine("\nDone.");
                break;
            }
        }
    }
}
