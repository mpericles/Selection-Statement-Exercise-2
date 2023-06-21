using static System.Formats.Asn1.AsnWriter;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for their favorite school subject & //Store their answer in a variable
            Console.WriteLine("Please input your favorite school subject");
            Console.WriteLine("Please the full name of the subject as an example: Mathematics, English, Spanish, Science, physics, Chemistry...");
            String userInput = Console.ReadLine();

            //Pass the variable as the expression in a switch statement.
            //Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.

            switch (userInput)
            {
                case "Mathematics":
                    Console.WriteLine("You chose Mathematics. Your teacher is going to be Ms. Johnson");
                    break;
                case "English":
                    Console.WriteLine("You chose English. Your teacher is going to be Ms. English");
                    break;
                case "Spanish":
                    Console.WriteLine("You chose Spanish. Your teacher is going to be Ms. Spanish");
                    break;
                case "Science":
                    Console.WriteLine("You chose Science. Your teacher is going to be Ms. Science");
                    break;
                case "Physics":
                    Console.WriteLine("You chose hysics. Your teacher is going to be Ms. hysics");
                    break;
                default:
                    // code block
                    Console.WriteLine("Interesting pick!");
                    Console.WriteLine("Call the Registrar to get your teacher name");
                    break;
            }

            //Create a default case to handle any case not handled.

        }
    }
}