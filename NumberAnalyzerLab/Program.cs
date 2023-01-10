Console.WriteLine("Welcome to the Number Analyzer. Please enter your name.");
string userName = Console.ReadLine();
Console.WriteLine("Hello, " + userName);

string WannaRestart;

do
{   //Get user's number
    Console.WriteLine("Please enter an integer between 1 and 100 inclusive.");
    int chosenNumber = int.Parse(Console.ReadLine());


        //Valid input
        if (chosenNumber >= 1 && chosenNumber <= 100)
        {
            if (chosenNumber < 60 && chosenNumber % 2 != 0)
            {
                Console.WriteLine(userName + ", you entered " + chosenNumber + ", which is odd and less than sixty.");
            }
            if (chosenNumber >= 2 && chosenNumber <= 24 && chosenNumber % 2 == 0)
            {
                Console.WriteLine(userName + ", you entered " + chosenNumber + ", which is even and less than 25.");
            }
            if (chosenNumber >= 26 && chosenNumber <= 60 && chosenNumber % 2 == 0)
            {
                Console.WriteLine(userName + ", you entered " + chosenNumber + ", which is even and between 26 and 60 inclusive.");
            }
            if (chosenNumber > 60 && chosenNumber % 2 == 0)
            {
                Console.WriteLine(userName + ", you entered " + chosenNumber + ", which is even and greater than 60.");
            }
            if (chosenNumber >= 60 && chosenNumber % 2 != 0)
            {
                Console.WriteLine(userName + ", you entered " + chosenNumber + ", which is odd and greater than 60.");
            }
        }

        //Invalid input
        else
        {
            Console.WriteLine("Sorry, that input is invalid.");
        }

        Console.WriteLine("Would you like to restart? Press Y to check another number.");
        WannaRestart = Console.ReadLine();

    } while (WannaRestart == "Y");

Console.WriteLine("Thank you, goodbye.");