﻿using System;

namespace ConsoleApp001
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Watching YouTubes: https://www.youtube.com/watch?v=M5ugY7fWydE Derek Banas
            // & https://www.youtube.com/watch?v=0QUgvfuKvWU Microsoft Developer
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            Console.WriteLine("Jumbo, Rafiki");
            //Console.WriteLine("What is your name?");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //string? userName = Console.ReadLine();
            //Console.WriteLine($"Ohayo, {userName}!");

            // Variables
            bool canIVote = true;
            Console.WriteLine("Can you vote?: {0}", canIVote);
            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiValu = 3.141592653589793284626433832M;
            decimal decBigNum = 3.000000000011000000000000009M;
            Console.WriteLine("Decimacl (DEC) : PI + bigNum = {0}", decPiValu + decBigNum);

            Console.WriteLine("Biggest Decimal : {0}", Decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", Decimal.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

        }
    }
}