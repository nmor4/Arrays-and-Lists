using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuSwitch;
            string reassign;
            List<string> EmptySeats = new List<string>
            { "First Class", "First Class", "First Class", "First Class", "First Class",
            "Economy","Economy","Economy","Economy","Economy",};
            List<string> AssignedSeats = new List<string> { };

        Start:
  
            Console.Clear();
            do
            
            {
                Console.Write("1 = First Class\n2 = Economy\n3 = Exit\n Please enter a number to select an option.: ");
                menuSwitch = (Console.ReadLine());

                //switch reads the menuSwitch variable
                switch (menuSwitch)
                {
                    //if "1" is entered, 
                    case "1":
                        Console.Clear();
                        
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
                            Console.Write("There are no remaining First Class seats, would you like to be placed in the Economy section? Enter 'yes' or'no' to choose: ");
                            reassign = Console.ReadLine();
                            if (reassign == "yes")
                            {
                                goto case "2";
                            }
                            else if (reassign =="no")
                            {
                                Console.Clear();
                                Console.WriteLine(");
                            }
                            else
                            {

                            }
                        }

                    case "2":




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
