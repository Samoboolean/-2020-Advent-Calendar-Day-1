using System;
using System.Collections.Generic;
using System.Text;

namespace Advent2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //MENU
            Console.WriteLine("Welcome to the menu");
            Console.WriteLine("--------------------");
            Console.WriteLine("choose where to go: " + "\n");
            Console.WriteLine("(1) - Day 1");
            Console.WriteLine("(2) - Day 2");
            Console.WriteLine("\n");

            short choice = Convert.ToInt16(Console.ReadLine());

            if (choice == 1)
            {
                startDay1(); // executing method
            }

            if (choice == 2)
            {
                Console.WriteLine("there is no day 2");
            }
            
        }

        public static void startDay1()
        {
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            string filePath = @"C:\Users\Sam\Downloads\input.txt";

            // create a string[] and use the method to get a value
            string[] lines = Day1.getFileText(filePath);

            // printLinesText(lines);
            int fileLength = Day1.getFileLength(filePath);

            //printLinesInt(convertToIntArray(lines, fileLength));

            Console.WriteLine(Day1.getAnswerSum(Day1.convertToIntArray(lines, fileLength), fileLength));
        }
    }
}
