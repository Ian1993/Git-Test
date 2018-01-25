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

            int x = 0;

            int y = 0;

            Random num = new Random();

            Console.WriteLine("Please enter your first bound");

            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second bound");

            y = Convert.ToInt32(Console.ReadLine());

            int randomNum = num.Next(x, y + 1);

            Console.WriteLine("I am thinking of a random number between" + x + " and " + y);

            Console.WriteLine("Type your guess");

            userNum = Convert.ToInt32(Console.ReadLine());

            if(userNum < y && userNum >= x)
            {

                numberGame(randomNum, userNum, count, x, y);

            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            

            

        }

        static void numberGame(int randomNum, int userNum, int count, int x, int y)
        {
            
            if(userNum < randomNum)
            {
                Console.WriteLine("Too low");
                Console.WriteLine("Try again, enter another Number");
                count = count + 1;
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum < y && userNum >= x)
                {

                    numberGame(randomNum, userNum, count, x, y);

                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    count = count - 1;
                }



                numberGame(randomNum, userNum, count, x ,y);
            }

            else if(userNum > randomNum)
            {
                Console.WriteLine("Too High");
                Console.WriteLine("Try again, enter another Number");
                count = count + 1;
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum < y && userNum >= x)
                {

                    numberGame(randomNum, userNum, count, x ,y);

                }
                else
                {
                    Console.WriteLine("Invalid Number");
                    count = count - 1;
                }





                numberGame(randomNum, userNum, count, x, y);

            }

            else
            {
                Console.WriteLine("Correct!");

                count = count + 1;

                Console.WriteLine("Tries: " + count);

                Console.WriteLine("Press any number to exit");

                userNum = Convert.ToInt32(Console.ReadLine());


            }

        }
    }
}
