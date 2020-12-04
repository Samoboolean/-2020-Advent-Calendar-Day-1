using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Advent2020
{
    class Day2
    {
        static public string[] readAllLines(string filePath)
        {
            string[] fileArray = System.IO.File.ReadAllLines(filePath);

            return fileArray;
        }

        public static int getFileLength(string fileName)
        {
            int fileLength = System.IO.File.ReadAllLines(fileName).Length;

            return fileLength;
        }

        static public int getLineMin(string[] inputArray, int index)
        {
            string singleLine = inputArray[index];
            int occurenceNumMin = Convert.ToInt32(singleLine.Substring(0, singleLine.IndexOf("-")));

            return occurenceNumMin;
        }

        static public int getLineMax(string[] inputArray, int index)
        {
            string singleLine = inputArray[index];
            int occurenceNumMax = Convert.ToInt32(singleLine.Substring(singleLine.IndexOf("-")+1, singleLine.IndexOf(" ")-2));

            return occurenceNumMax;
        }

        static public string getLineChar(string[] inputArray, int index)
        {
            string singleLine = inputArray[index];
            string lookupChar = singleLine.Substring(singleLine.IndexOf(" ")+1, singleLine.IndexOf(":")-4);

            if (lookupChar.Contains(":"))
            {
                lookupChar = lookupChar.Replace(":", "");
            }

            lookupChar = lookupChar.Trim();

            return lookupChar;
        }

        static public string getLinePassword(string[] inputArray, int index)
        {
            string singleLine = inputArray[index];
            int colonIndex = singleLine.IndexOf(":")+2;
            string password = singleLine.Substring(colonIndex);
            return password;
        }
    }
}
