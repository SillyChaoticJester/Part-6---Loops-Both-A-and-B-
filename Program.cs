namespace Part_6___Loops__Both_A_and_B_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 6a - Counted Loops

            for (int i = 0; i < 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            //Counted For Statements have three different elements

            //1. Initialization (i = 0): Starts the counter, goes through once before loop begins
            //2. Termination (i <= 10): Loop continues if True, stops when False.
            //3. Increment (i++): Adds up/Counts down from the counter.

            //Changing <= to < will make it so it doesn't add the extra loop. 


        }
    }
}
