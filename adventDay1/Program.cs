using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
            Console.WriteLine("(3) - Day 2 Part 2" + "\n");

            short choice = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                startDay1(); // executing method
            }

            if (choice == 2)
            {
                Console.WriteLine("Beginning:::");
                startDay2();
            }

            if (choice == 3)
            {
                Console.WriteLine("Beginning:::");
                startDay2Part2();
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

        public static void startDay2()
        {
            int validPasswordsCount = 0;

            string filePath = @"C:\Users\Sam\Downloads\input2.txt";
            string[] day2Array = Day2.readAllLines(filePath);
            int fileLength = Day2.getFileLength(filePath);
            int index = 1;
            Console.WriteLine("Password ({0}) is ({1}) to ({2}) long and we are looking for the character ({3}) and the password is ({4})", index, Day2.getLineMin(day2Array, index), Day2.getLineMax(day2Array, index), Day2.getLineChar(day2Array, index), Day2.getLinePassword(day2Array, index));

            for (int i = 0; i < day2Array.Length; i++)
            {
                string password = Day2.getLinePassword(day2Array, i);
                int minOccurence = Day2.getLineMin(day2Array, i);
                int maxOccurence = Day2.getLineMax(day2Array, i);
                char lookupChar = Convert.ToChar(Day2.getLineChar(day2Array, i));

                int charFreq = password.Count(f => (f == lookupChar));
                if (charFreq >= minOccurence && charFreq <= maxOccurence)
                {
                    validPasswordsCount++;
                }
            }

            Console.WriteLine(validPasswordsCount);

            //Console.WriteLine(Day2.getLineMax(day2Array, 1));

        }

        public static void startDay2Part2()
        {
            int validPasswordsCount = 0;
            string filePath = @"C:\Users\Sam\Downloads\input2.txt";
            string[] day2Array = Day2.readAllLines(filePath);

            for (int i = 0; i < day2Array.Length; i++)
            {
                string password = Day2.getLinePassword(day2Array, i);
                int posOfChar = Day2.getLineMin(day2Array, i);
                int endPosNotChar = Day2.getLineMax(day2Array, i);
                char lookupChar = Convert.ToChar(Day2.getLineChar(day2Array, i));

                char[] charArray = password.ToCharArray();

                int charArrayLength = charArray.Length;

                char space = (char)32;

                List<char> tempList = charArray.ToList();
                tempList.Add(space);
                charArray = tempList.ToArray();

                if (!(charArray[posOfChar - 1] == lookupChar && charArray[endPosNotChar - 1] == lookupChar))
                {
                    if (!(charArray[posOfChar - 1] != lookupChar && charArray[endPosNotChar - 1] != lookupChar))
                    {
                        if (charArray[posOfChar - 1] == lookupChar && charArray[endPosNotChar - 1] != lookupChar || charArray[posOfChar - 1] != lookupChar && charArray[endPosNotChar - 1] == lookupChar)
                        {
                            validPasswordsCount++;
                        }
                    }
                }
            }

            Console.WriteLine(validPasswordsCount);
        }
    }
}
