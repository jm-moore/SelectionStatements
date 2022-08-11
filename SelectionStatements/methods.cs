using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class methods
    {
        public static void NumberGame()
        {
            var r = new Random();
            var favNumber = r.Next(1, 100);
            var userInput = 0;

            do
            {
                Console.WriteLine("Try to guess my random number between 1 - 100:");
                Console.WriteLine();
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("too low");
                    Console.WriteLine();
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("too high");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("You got it right!");
                    Console.WriteLine();
                }
            } while (userInput != favNumber);
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject? " +
            "Enter - math, science, history, language arts, pe, music, or other below: ");
            Console.WriteLine();
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine();
                    Console.WriteLine("Math is my favorite subject. It's the" +
                        " \nuniversal language. I like the fact that wherever" +
                        " \nyou go in the whole world, two plus two will still" +
                        " \nbe four. - Dakota Blue");
                    break;
                case "science":
                    Console.WriteLine();
                    Console.WriteLine("We live in a society exquisitely" +
                        "\ndepedendent on science and technology, in which" +
                        "\nhardly anyone knows anything about science and " +
                        "\ntechnology. - Carl Sagan.");
                    break;
                case "history":
                    Console.WriteLine();
                    Console.WriteLine("History is not the past but a map" +
                        "\nof the past, drawn from a particular point of " +
                        "\nview, to be useful to the modern traveller.");
                    break;
                case "language arts":
                    Console.WriteLine();
                    Console.WriteLine("Words are, in my not-so-humble opinion" +
                        "\nour most inexhaustible source of magic. Capable" +
                        "\nof both inflicting injury, and redemyiing it. - Albus Dumbledore");
                    break;
                case "pe":
                    Console.WriteLine();
                    Console.WriteLine("Intelligence and skill can only function" +
                        "\nat the peak of their capacity when the body is healthy" +
                        "\nand strong. - John F. Kennedy");
                    break;
                case "music":
                    Console.WriteLine();
                    Console.WriteLine("Music,\nonce admitted to the soul," +
                        "\nbecomes a sort of spirit, and never dies. - Edward " +
                        "Bulwer-Lytton");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Let yourself be silently drawn" +
                        "\nby the strange pull of what you really love." +
                        "\nIt will not lead you astray. - Rumi");
                    break;
            }
        }
    }
}
