using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {   //asking the user what they want to say to the bot
            int helloCounter = 0;
            bool askedHello = false;
            bool askedSup = false;
            bool askedHelloThere = false;
            string questionInput = ""; //this allows the user to keep asking questions UNLESS the user types in "bye"
            do
            {
                Console.WriteLine("What would you like to say to the bot?");
                //geting user input and setting it to lowercase
                questionInput = Console.ReadLine().ToLower();
                Console.WriteLine(questionInput);
                //responding to hello input correctly
                if (questionInput == "hello" && askedHello == false)
                {
                    Console.WriteLine("Hi good to see you");
                    askedHello = true;
                }
                else if (questionInput == "hello" && askedHello)
                {
                    Console.WriteLine("I’m sorry but you have already said that, please try a different Input");
                }


                //bye
                else if (questionInput == "bye")
                {
                    Console.WriteLine("Good bye!");
                }

                //sup
                else if (questionInput == "sup" && askedSup == false)
                {
                    Console.WriteLine("I am good");
                    askedSup = true;
                }
                else if (questionInput == "sup" && askedSup)
                {
                    Console.WriteLine("I’m sorry but you have already said that, please try a different Input");
                }


                //Hello there
                else if (questionInput == "hello there" && askedHelloThere == false)
                {
                    Console.WriteLine("General Kenobi");
                    askedHelloThere = true;
                }
                else if (questionInput == "hello there" && askedHelloThere)
                {
                    Console.WriteLine("I’m sorry but you have already said that, please try a different Input");
                }
            } while (questionInput != "bye");

        }
    }
}
/*Deliverable 2 Task: Write a program that allows the user to carry on basic conversation
with a chat bot. The app will ask the user what they wish to say to the bot. The bot will
respond appropriately based upon the following table:

    Input           Bot Response

    hello           Hi good to see you
    bye             Good bye!
    sup             I am good
    hello there     General Kenobi

Once the app has printed the bot’s response, ask the user to say something else to the bot.
Keep looping until the user says bye. When the user says bye, respond and end the
program.
Additionally, add in the following features:
● So you don’t have to check for upper and lower case strings, find a way to make
your input string all lowercase. (BYE, byE, Bye, bye, and bYE should all get the same
response, for instance)
● If the user enters the same input twice in a row, have the bot respond “I’m sorry
but you have already said that”

    Rubric (10 points total):
    ● 1pt for asking the user what they want to say to the bot
    ● 1pt for getting user input
    ● 1pt for setting the user input to lowercase
    ● 1pt for responding to hello input correctly
    ● 1pt for responding to bye input correctly
    ● 1pt for responding to sup input correctly
    ● 1pt for responding to hello there input correctly
    ● 1pt for repeating asking for input after printing the bot’s response (unless the user
    said bye)
    ● 1pt for ending the program when the user says bye
    ● 1pt for printing “I’m sorry but you have already said that” if the user enters the
    same input twice in a row
    
Grading Scale: 8 or above: Passing
Below 8: Not Passing*/