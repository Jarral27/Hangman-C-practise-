using System;
using System.Collections.Generic;
using static System.Random;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman
{
    internal class Program
    {
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("    |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine(" |   |");
                Console.WriteLine("     |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine("/|   |");
                Console.WriteLine("     |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("     |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/    |");
                Console.WriteLine("   ==== ");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" 0 |");
                Console.WriteLine("/|\\ |");
                Console.WriteLine("/ \\ |");
                Console.WriteLine("   ==== ");
            }
        }

        private static int PrintWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int correctLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))

                {
                    Console.Write(c + " ");
                    correctLetters++;
                }
                else
                {
                    Console.Write("_ ");
                }
                counter++;
            }
            return correctLetters;

        }

        private static void PrintLines(String randomWord)
        {
            Console.WriteLine();
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("_ ");
            }



        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Hangman game :D");
            Console.WriteLine("--------------------------------------------------------");

            var randomWord = GetWord();
            PrintLines(randomWord);
            UserInput(randomWord);
            Console.ReadLine();

        }
        private static bool UserInput(string randomWord)
        {
            int incorrect = 0;
            bool correctWord = false;
            char input = '\0';
            List<char> guessedLetters = new List<char>();

            while (incorrect < 6 && correctWord == false)
            {
                Console.WriteLine("Please enter a letter!");
                input = Console.ReadKey().KeyChar;
                guessedLetters.Add(input);
                if (!randomWord.Contains(input))
                {
                    incorrect++;
                    printHangman(incorrect);
                }
                if (randomWord.All(c => guessedLetters.Contains(c)))
                {
                    correctWord = true;
                }

                PrintWord(guessedLetters, randomWord);

            }
            if (incorrect == 6)
            {
                Console.WriteLine("You Lose! :("); 
            }
            if (correctWord)
            {
                Console.WriteLine("You Win! :)");
            }
            return true;



        }

        private static string GetWord()
        {
            // Default folder
            string rootFolder = "C:\\Users\\jARRAL\\source\\repos\\Hangman\\Hangman\\Themes\\";
            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE
            string textFile = "C:\\Users\\jARRAL\\source\\repos\\Hangman\\Hangman\\Themes\\animals.txt";




            if (File.Exists(textFile))
            {
                // Read a text file line by line.
                string[] lines = File.ReadAllLines(textFile);


                Random randomGenerator = new Random();
                int selectedNum = randomGenerator.Next(0, lines.Length - 1);
                return lines[selectedNum];
            }
            return null;


        }
    }
}
