using System;


namespace CAConditionalExamples
{
    internal class Example7
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            int i,remainder, sum = 0;

            for ( i = number; number > 0; i++)
            {

                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("Sum of digits is {0}", sum);


        }
    }
}

