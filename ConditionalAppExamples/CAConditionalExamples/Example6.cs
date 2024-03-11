using System;


namespace CAConditionalExamples
{
    internal class Example6
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder, sum = 0;

            while (number > 0)
            {
           
                remainder = number % 10;
                sum = sum + remainder;
                number = number / 10;
            }
            Console.WriteLine("Sum of digits is {0}", sum);

        }
    }
}
