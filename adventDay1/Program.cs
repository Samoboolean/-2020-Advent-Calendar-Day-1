using System;

namespace adventDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\Sam\Downloads\input.txt";

            // create a string[] and use the method to get a value
             string[] lines = getFileText(fileName);

            // printLinesText(lines);
             int fileLength = getFileLength(fileName);

            //printLinesInt(convertToIntArray(lines, fileLength));

            Console.WriteLine(getAnswerSum(convertToIntArray(lines, fileLength), fileLength));

        }

        static string[] getFileText(string fileName)
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

        static int getFileLength(string fileName)
        {
            int fileLength = System.IO.File.ReadAllLines(fileName).Length;

            return fileLength;
        }

        static int[] convertToIntArray(string[] normalArray, int arrayLength)
        {
            int[] intArray = new int[arrayLength];

            
            for (int i = 0; i < arrayLength; i++)
            {
                intArray[i] = Convert.ToInt32(normalArray[i]);
            }

            return intArray;
        }



        static string getAnswerSum(int[] intArray, int fileLength)
        {
            for (int i = 0; i < fileLength; i++)
            {
                int num1 = intArray[i];

                for (int j = fileLength-1; j > 0; j--)
                {
                    int num2 = intArray[j];

                    int num3 = num1 + num2;

                    if (num3 == 2020)
                    {
                        Console.WriteLine("num1 pos: " + Convert.ToString(i));
                        Console.WriteLine("num2 pos: " + Convert.ToString(j));
                        string printAnswer = "The answer to sum is: " + Convert.ToString(num1) + "+" + Convert.ToString(num2) ;
                        return printAnswer;
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
