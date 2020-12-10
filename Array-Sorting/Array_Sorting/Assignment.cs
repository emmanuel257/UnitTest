using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessGame
{
    public class Assignment
    {
        public static void Work()
        {
            //TODO: Write your code here
            //Display the Array 
            var input = GenerateArray();

            DisplayInts(input);

            //Implementation
            Counts(input);

            //TODO: Count total number of times a user selected number from 1 - 10 occurs in the array

        }

        public static void Counts(int[] values)
        {
            int[] nums = new int[10];
            foreach (var number in values)
            {
                for(int i = 0; i < 10; i++)
                {
                    if(number == i)
                    {
                        nums[i]++;
                    }
                }
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Number {i} are {nums[i]}");
            }
            Console.ReadLine();
        }


        #region Hidden
        static void DisplayInts(int[] values)
        {
            
            var strValues = values.Select(v => v.ToString());
            var stringlist = String.Join(", ", strValues);
            var sum = stringlist;
            Console.WriteLine($"Numbers: [ {stringlist} ]");
            
        }
        static int[] GenerateArray()
        {
            int Min = 1;
            int Max = 11;
            Random randNum = new Random();
            int[] values = Enumerable
                .Repeat(0, 50)
                .Select(i => randNum.Next(Min, Max) - 1)
                .ToArray();

            return values;
        }

        #endregion
    }
}
