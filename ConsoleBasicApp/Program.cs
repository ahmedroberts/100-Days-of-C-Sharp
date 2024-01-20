using System;

namespace ConsoleApp001
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Watching YouTubes: https://www.youtube.com/watch?v=M5ugY7fWydE Derek Banas
            // & https://www.youtube.com/watch?v=0QUgvfuKvWU Microsoft Developer
            // $ https://www.youtube.com/watch?v=wxznTygnRfQ Bro Code
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
        }
    }
}