namespace Part_6___Loops__Both_A_and_B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To remember: Crtl + K + C to comment out things

            //Part 6a - Counted Loops

            //for (int i = 0; i < 10; i = i + 2)
            //{
            //   Console.WriteLine(i);
            //}

            //Counted For Statements have three different elements

            //1. Initialization (i = 0): Starts the counter, goes through once before loop begins
            //2. Termination (i <= 10): Loop continues if True, stops when False.
            //3. Increment (i++): Adds up/Counts down from the counter.

            //Changing <= to < will make it so it doesn't add the extra loop. 

            //Practice:

            //int count;
            //count = 5;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i);
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int j = 5; j <= 50; j = j + 5)
            //{
            //    Console.WriteLine(j);
            //}

            //Console.WriteLine();

            //for (int k = 0; k < 10; k++)
            //{
            //    Console.WriteLine(count);
            //    count = count + 5;
            //}

            //Console.WriteLine();

            //for (int m = 99; m >= 55; m = m - 11)
            //{
            //    Console.WriteLine(m);
            //}

            //Part 6b. Conditonal While Loops

            //int i = 10;
            //while (i >= 2)
            //{
            //    Console.WriteLine(i);
            //    i = i - 2;
            //}

            //int number;
            //string answer;

            //Console.WriteLine("Please enter an integer:");
            //while (!Int32.TryParse(Console.ReadLine(), out number))
            //    Console.WriteLine("Invalid Integer, please try again!");
            //Console.WriteLine($"Thanks for {number}");
            //Console.WriteLine();

            //while (answer != "batman")
            //{
            //    Console.WriteLine("What is Bruce Wayne's alter ego?");
            //    answer = Console.ReadLine().ToLower();
            //}

            //int guesses, secretNum, userGuess;
            //secretNum = 4;
            //guesses = 0;
            //bool done = false;
            //while (!done)
            //{
            //    Console.WriteLine("Guess a Number from 1-10, or -1 to Quit");
            //    while (!Int32.TryParse(Console.ReadLine(), out userGuess))
            //        Console.WriteLine("Invalid integer, please try again.");
            //    guesses++;
            //    if (userGuess == secretNum)
            //    {
            //        done = true;
            //        Console.WriteLine("You Win!");
            //    }
            //    else if (userGuess == -1)
            //    {
            //        done = true;
            //        Console.WriteLine("Alright, bye bye!");
            //    }
            //    else if (guesses >= 5)
            //    {
            //        done = true;
            //        Console.WriteLine("Oops! You ran out of Guesses! You lose!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorrect! Try Again!");
            //    }
            //}

            //int bet, wallet = 100;
            //bet = 0;
            //Console.WriteLine("How much do you want to bet? You have $" + wallet);
            //while (!Int32.TryParse(Console.ReadLine(), out bet))
            //    Console.WriteLine("Invalid integer, please try again.");
            //while (bet > wallet)
            //{
            //    Console.WriteLine("That is more than what you have, please enter a valid amount:");
            //    while (!Int32.TryParse(Console.ReadLine(), out bet))
            //        Console.WriteLine("Invalid integer, please try again.");
            //}
            //while (bet < 0)
            //{
            //    Console.WriteLine("That's not a real amount of money, please enter a valid amount:");
            //    while (!Int32.TryParse(Console.ReadLine(), out bet))
            //        Console.WriteLine("Invalid integer, please try again.");
            //}

            string selection;
            do
            {
                Console.WriteLine("Who is the better captain?");
                Console.WriteLine("a - Captain Picard");
                Console.WriteLine("b - Captain Kirk");
                selection = Console.ReadLine();
            } while (selection != "a");
            Console.WriteLine("Correct!");

        }
    }
}
