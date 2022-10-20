namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Guessing game//

            var favNumber = 25;

            Console.WriteLine("Can you guess my favorite number?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput > favNumber)
            {
                Console.WriteLine("Too High");
            }
            else if (userInput < favNumber)
            {
                Console.WriteLine("Too Low");
            }
            else
            {
                Console.WriteLine("Congratulations, you guessed it!");
            }
            
        }
    }
}
