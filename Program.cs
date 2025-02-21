namespace Part_6___Loops__Both_A_and_B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            int i = 10;
            while (i >= 2)
            {
                Console.WriteLine(i);
                i = i - 2;
            }

            int number;
            string answer;

            Console.WriteLine("Please enter an integer:");
            while (!Int32.TryParse(Console.ReadLine(), out number))
                Console.WriteLine("Invalid Integer, please try again!");
            Console.WriteLine($"Thans for {number}");
            Console.WriteLine();
            
            while (answer != "batman")
            {
                Console.WriteLine("What is Bruce Wayne's alter ego?");
                answer = Console.ReadLine().ToLower();
            }

        }
    }
}
