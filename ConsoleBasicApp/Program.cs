﻿using System;

namespace ConsoleApp001
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Watching YouTubes: https://www.youtube.com/watch?v=M5ugY7fWydE Derek Banas
            // & https://www.youtube.com/watch?v=0QUgvfuKvWU Microsoft Developer
            // $ https://www.youtube.com/watch?v=wxznTygnRfQ Bro Code
            // Also Microsoft C# New Year | New Certification C#
            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            Console.WriteLine("\n***********************************\n");
            Console.WriteLine("    Jumbo, Rafiki\n    Raikage Training");
            Console.WriteLine("\n***********************************\n");

            string project1Name = "First-Project";
            Console.WriteLine($@"C:\Output\{project1Name}\Data");

            //Console.WriteLine("What is your name?");
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //string? userName = Console.ReadLine();
            //Console.WriteLine($"Ohayo, {userName}!");

            Console.WriteLine("c:\\source\\repos");
            Console.WriteLine(@"    c:\source\repos    
                    (this is where your code goes)");
            // Kon'nichiwa World
            // **Nihongo**
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.WriteLine("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");

            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            // **Nihongo**
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            string firstName = "Bob";
            string message = $"Hello {firstName}!";
            Console.WriteLine(message);

            string projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

            // Variables
            /*
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

            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);
            double dblPiValu = 3.14159265358979;
            double dblBigNum = 3.00000000001109;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiValu + dblBigNum);

            Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            double fltPiValu = 3.141592F;
            double fltBigNum = 3.000009F;
            Console.WriteLine("FLT : PI + bigNum = {0}", fltPiValu + fltBigNum);

            // 21:39 Derek Banas

            Console.WriteLine("\n\nAhmed's Big Giveaway");
            Console.WriteLine("Choose a door: 1, 2, or 3: ");
            string? userValue = Console.ReadLine();

            string? prizeMessage = "";
            if (userValue == "1")
                prizeMessage = "You won a cupcake!";
            else if (userValue == "2")
                prizeMessage = "You won ice cream!";
            else if (userValue == "3")
                prizeMessage = "You won a watch!";
            else
                prizeMessage = "Apologies. That's not the game.";
            Console.WriteLine(prizeMessage);
            Console.ReadLine();
            */

            Console.WriteLine("\nRaikage's Big Give Away");
            Console.Write("Choose a door: 1, 2, or 3: ");
            string? userValue = Console.ReadLine();

            string prizeMessage = (userValue == "1") ? "cupcake" : "ice cream";
            Console.Write("You won a ");
            Console.Write(prizeMessage);
            Console.Write("!");
            Console.ReadLine();

        }
    }
}