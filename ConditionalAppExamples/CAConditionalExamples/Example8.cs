using System;


namespace CAConditionalExamples
{
    internal class Example8
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter any number");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder, reverse = 0;
            while (number>0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;

            }
            Console.WriteLine("Reverse number is {0}", reverse);
        }
    }
}
