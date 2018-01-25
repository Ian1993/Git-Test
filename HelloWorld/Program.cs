using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = 0;

            int count = 0;

            Random num = new Random();

            int randomNum = num.Next(0, 101);

            Console.WriteLine("I am thinking of a random number between 0 and 100 (100 included");

            Console.WriteLine("Type your guess");

            userNum = Convert.ToInt32(Console.ReadLine());

            numberGame(randomNum, userNum, count);

            

        }

        static void numberGame(int randomNum, int userNum, int count)
        {
            
            if(userNum < randomNum)
            {
                Console.WriteLine("Too low");
                Console.WriteLine("Try again, enter another Number");

                userNum = Convert.ToInt32(Console.ReadLine());

                count = count + 1;

                numberGame(randomNum, userNum, count);
            }

            else if(userNum > randomNum)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Try again, enter another Number");

                userNum = Convert.ToInt32(Console.ReadLine());

                count = count + 1;

                numberGame(randomNum, userNum, count);

            }

            else
            {
                Console.WriteLine("Correct!");

                count = count + 1;

                Console.WriteLine("Tries: " + count);

                Console.WriteLine("Press any number to exit");

                userNum = Convert.ToInt32(Console.ReadLine());
                //press a number to avoid error

            }

        }
    }
}
