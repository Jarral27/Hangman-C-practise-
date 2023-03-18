﻿using System;
using System.Collections.Generic;
using static System.Random;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Program
    {
        private static void printHangman(int wrong)
        {
            if(wrong == 0)
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

        private static int PrintWord(List<char>guessedLetters, String randomWord)
        {
            int counter = 0;
            int correctLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))

                {
                    Console.Write("c" + " ");
                    correctLetters++;
                }
                else
                { 
                    Console.Write(" ");
                }
                counter++;
            }
            return correctLetters;
                
        }

        private static void PrintLines(String randomWord)
        {
            Console.Write("/r");


        }

        static void Main(string[] args)
        {
        }
    }
}