namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int? favNum = 5;

            Console.WriteLine(" Please guess my Favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (favNum > userInput)
            {
                Console.WriteLine(" too low");
            }
            else if (favNum < userInput)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine(" good Try");



                // second practice to see diff results



                if (favNum == userInput)
                {
                    Console.WriteLine(" Great Guess! ");
                }

                else if (favNum < userInput)

                {
                    Console.WriteLine(" no  luck huh ? Try again !");

                }

                else if (favNum > userInput)

                {
                    Console.WriteLine(" one more try , Try again !");
                }


                else

                    Console.WriteLine(" Good try !, The answer was 5. Play again !");



            }
        }
    }
}