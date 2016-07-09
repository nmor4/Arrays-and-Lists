using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Nick Morin - 300654901
 * Description: Assignment 4, Part 1: Dice Rolling Simulation
 * Date Last Modified: 2016-07-09
 */
namespace Assignment_4
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] count = new int[13];


            //simulates the dice rolls
            for (int index = 0; index < 36000; index++)
            {
                int dice1 = random.Next(1, 7);
                int dice2 = random.Next(1, 7);
                int combinedRoll = dice1 + dice2;
                count[combinedRoll]++;

            }

            //counts the frequency of each result, displays in console
            for (int index = 2; index < 13; index++)
            {
                Console.WriteLine("{0}: {1} ", index, count[index]);
            }



        }
    }
}
