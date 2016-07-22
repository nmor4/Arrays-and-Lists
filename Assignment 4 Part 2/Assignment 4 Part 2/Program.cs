using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Nick Morin   
//Description: COMP123-Assignment 4 Part 2
//Date Last Modified: 2016-07-21
namespace Assignment_4_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables and Lists
            string menuSwitch;
            string reassign;
            List<string> EmptySeats = new List<string>
            { "First Class", "First Class", "First Class", "First Class", "First Class",
            "Economy","Economy","Economy","Economy","Economy",};
            List<string> AssignedSeats = new List<string> { };

            /*Start marks the start of the do-while loop that runs the selection menu, and functions as a 
             * point to return to when the program must redirect to the selection menu
             */ 

        Start:
  
            Console.Clear();
            do
            
            {
                Console.Write("1 = First Class\n2 = Economy\n3 = Exit\n Please enter a number to select an option: ");
                menuSwitch = (Console.ReadLine());

                //switch reads the menuSwitch variable
                switch (menuSwitch)
                {
                    /*if "1" is entered, begins if-else statement to check if there is First Class string
                     * in the EmptySeats list
                     */
                    case "1":
                        Console.Clear();

                        /*If EmptySeats list contains an First Class string, removes an First Class string  
                         * from Empty Seats and adds one to AssignedSeats list
                         */
                        if (EmptySeats.Contains("First Class"))
                        {
                        EmptySeats.Remove("First Class");
                        AssignedSeats.Add("First Class");

                        Console.WriteLine("You have been assigned to the First Class section. Press any key to return to the ticket selection menu.");
                        Console.ReadKey();
                            goto Start;
                        }
                        else
                        {
                            Console.Clear();
                            Reassign1:
                            Console.Write("There are no remaining First Class seats, would you like to be placed in the Economy section? Enter 'yes' or'no' to choose: ");
                            reassign = Console.ReadLine();

                            /*another if-else statement, reads "reassign" variable based on user input
                             * redirects to case 1, redirects to Start menu or returns to user input of "reassign variable"
                             */
                            if (reassign == "yes")
                            {
                                goto case "2";
                            }
                            else if (reassign =="no")
                            {
                                Console.Clear();
                                Console.WriteLine("The next flight leaves in 3 hours. Press any key to return to the ticket selection menu.");
                                Console.ReadKey();
                                goto Start;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Error - please enter 'yes' or 'no' to select an option\n");
                                goto Reassign1;
                            }
                        }

                    /*if "2" is entered, begins if-else statement to check if there is Economy string
                     * in the EmptySeats list
                     */
                    case "2":

                        Console.Clear();

                        /*If EmptySeats list contains an Economy string, removes an Economy string from Empty Seats
                         * and adds one to AssignedSeats list
                         */ 
                        if (EmptySeats.Contains("Economy"))
                        {
                            EmptySeats.Remove("Economy");
                            AssignedSeats.Add("Economy");

                            Console.WriteLine("You have been assigned to the Economy section. Press any key to return to the ticket selection menu.");
                            Console.ReadKey();
                            goto Start;
                        }
                        else
                        {
                            Console.Clear();
                            Reassign2:
                            Console.Write("There are no remaining Economy seats, would you like to be placed in the First Class section? Enter 'yes' or'no' to choose: ");
                            reassign = Console.ReadLine();

                            /*another if-else statement, reads "reassign" variable based on user input
                             * redirects to case 1, redirects to Start menu or returns to user input of "reassign variable"
                             */
                            if (reassign == "yes")
                            {
                                goto case "1";
                            }
                            else if (reassign == "no")
                            {
                                Console.Clear();
                                Console.WriteLine("The next flight leaves in 3 hours. Press any key to return to the ticket selection menu.");
                                Console.ReadKey();
                                goto Start;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Error - please enter 'yes' or 'no' to select an option\n");
                                goto Reassign2;
                            }
                            
                        }



                    /*default if anything but 1 or 2 is entered into the console at start of program 
                     * Clears Console, displays an error message and returns user to start
                     */
                    default:

                        Console.Clear();
                        Console.WriteLine("Error - Enter 1, 2, or 3 to select an option\n");

                        break;
                }

                //Entering 3 changes menuSwitch variable to 3, breaking the do-while loop and closing console
            } while (menuSwitch != "3");
        }
    }
}
