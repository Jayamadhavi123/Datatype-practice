using System;

namespace CAConditionalExamples
{
    internal class Example10
    {
        static void Main(String[] args)
        {
            int n, r, sum = 0,temp ;
            Console.WriteLine("Enter a Number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n/ 10;
            }
            if (temp == sum)
                Console.Write("Armstrong Number.");
            else
                Console.Write("Not Armstrong Number.");
           
        }
    }
}

