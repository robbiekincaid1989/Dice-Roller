using System;

namespace Dice_Roller
{
    //This program is a simple dice rolling app for Pathfinder. Nothing too crazy to see here.
    class Program
    {
        static void Main(string[] args)
        {
            //Boolean for if the user wants to keep going
            bool roll = true;

            Console.WriteLine("Please select a die to roll.");

            //The app loop
            while (roll == true)
            {
                //Call the method to display the menu
                menu();

                //Call the method to get the user input
                selection();

                //Ask the user if they want to continue rolling
                Console.WriteLine("Do you want to roll more?");
                Console.WriteLine("Enter a 'y' for yes and an 'n' for no");
                string keepGoing = Console.ReadLine();

                //If statement to see whether or not to exit the app
                if (keepGoing == "y")
                {
                    roll = true;
                }
                else if (keepGoing == "n")
                {
                    System.Environment.Exit(0);
                    break;
                }
                else
                {
                    Console.WriteLine("You did not enter an appropriate value. Please enter a 'y' or an 'n'.");
                    Console.WriteLine(" ");
                }
            }
        }

        //This method displays the menu options for the user
        public static void menu()
        {
            Console.WriteLine("+++++++++++++++++++++");
            Console.WriteLine("+ 1. D4             +");
            Console.WriteLine("+ 2. D6             +");
            Console.WriteLine("+ 3. D8             +");
            Console.WriteLine("+ 4. D10            +");
            Console.WriteLine("+ 5. D12            +");
            Console.WriteLine("+ 6. D20            +");
            Console.WriteLine("+ 7. D100           +");
            Console.WriteLine("+++++++++++++++++++++");
        }

        //This method asks the user for input processes it
        public static void selection()
        {
            //Initiate the random number for the die rolls
            Random rand = new Random();

            //Display a message telling the user what to do, then get their input and store it in the selection variable
            Console.WriteLine("Please enter your selection. Valid input is a numeric value of 1 through 7.");
            Console.WriteLine("You will then be asked to input any multipliers.");
            int selection = Convert.ToInt32(Console.ReadLine());

            //Run the user's input against a switch staatement to select what to do next
            switch (selection)
            {
                case 1:
                    int d4 = rand.Next(1, 5);
                    selection = d4;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    string negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    string positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 2:
                    int d6 = rand.Next(1, 7);
                    selection = d6;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 3:
                    int d8 = rand.Next(1, 9);
                    selection = d8;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 4:
                    int d10 = rand.Next(1, 11);
                    selection = d10;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 5:
                    int d12 = rand.Next(1, 13);
                    selection = d12;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 6:
                    int d20 = rand.Next(1, 21);
                    selection = d20;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                case 7:
                    int d100 = rand.Next(1, 101);
                    selection = d100;
                    //Ask the user if they need to enter a negative multiplier
                    Console.WriteLine("Do you have a negative multiplier? Please enter a 'y' or 'n'.");
                    negativeUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (negativeUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int negNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Subtract the multiplier from the roll
                        selection = selection - negNum;
                    }
                    else if (negativeUser == "n")
                    {
                        Console.WriteLine("Okay, next question.");
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }

                    //Ask the user if they have a positive multiplier
                    Console.WriteLine("Do you have a positive multiplier? Please enter a 'y' or an 'n'.");
                    positiveUser = Console.ReadLine();
                    Console.WriteLine(" ");

                    //Use an if statement to enter the multiplier or skip
                    if (positiveUser == "y")
                    {
                        Console.WriteLine("Please enter the numerical value for your multiplier.");
                        int posNum = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");

                        //Add the multiplier to the roll
                        selection = selection + posNum;

                        //Display the roll to the user
                        Console.WriteLine("Your roll with multiplier is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else if (positiveUser == "n")
                    {
                        Console.WriteLine("Okay, cool. Your roll is: " + selection);
                        Console.WriteLine(" ");
                    }
                    else
                    {
                        Console.WriteLine("You didn't enter a valid answer.");
                        Console.WriteLine(" ");
                    }
                    break;
                default:
                    Console.WriteLine("You did not enter a vaild selection. Please try again!");
                    Console.WriteLine(" ");
                    break;
            }

            
        }

    }
}
