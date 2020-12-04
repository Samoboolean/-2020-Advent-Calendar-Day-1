using System;

namespace Advent2020
{
    class Day1
    {

        public static string[] getFileText(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);

            return lines;
        }

        static int getSingleLineInt(string fileName, int index)
        {
            int singleInt;
            using (System.IO.StreamReader inputFile = new System.IO.StreamReader(fileName))
            {
                for (int i = 1; i < index; i++)
                {
                    inputFile.ReadLine();
                }
                singleInt = Convert.ToInt32(inputFile.ReadLine());
            }

            return singleInt;
        }

        public static int getFileLength(string fileName)
        {
            int fileLength = System.IO.File.ReadAllLines(fileName).Length;

            return fileLength;
        }

        public static int[] convertToIntArray(string[] normalArray, int arrayLength)
        {
            int[] intArray = new int[arrayLength];

            
            for (int i = 0; i < arrayLength; i++)
            {
                intArray[i] = Convert.ToInt32(normalArray[i]);
            }

            return intArray;
        }



        public static string getAnswerSum(int[] intArray, int fileLength)
        {
            for (int i = 0; i < fileLength; i++)
            {
                int num1 = intArray[i];

                for (int j = fileLength-1; j > 0; j--)
                {
                    int num2 = intArray[j];

                    for (int x = 0; x < fileLength; x++)
                    {
                        int num3 = intArray[x];

                        int answer = num1 + num2 + num3;

                        if (answer == 2020)
                        {
                            Console.WriteLine("num1 pos: " + Convert.ToString(i));
                            Console.WriteLine("num2 pos: " + Convert.ToString(j));
                            Console.WriteLine("num3 pos: " + Convert.ToString(x));
                            int multiply = num1 * num2 * num3;
                            string printAnswer = "The answer to sum is: " + Convert.ToString(num1) + "+" + Convert.ToString(num2) + "+" + Convert.ToString(num3) + "\n" + "The answer to the question is: " + Convert.ToString(multiply);
                            return printAnswer;
                        }
                    }
                }
            }
            return null;
        }

        static void printLinesText(string[] lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        static void printLinesInt(int[] Intlines)
        {
            foreach (int line in Intlines)
            {
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }
    }
}
