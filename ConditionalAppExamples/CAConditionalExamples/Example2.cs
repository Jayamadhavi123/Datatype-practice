using System;


namespace CAConditionalExamples
{
     class Example2
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20;
            Console.WriteLine("value of x is : " + x);
            Console.WriteLine("value of y is : " + y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After Swapping");
            Console.WriteLine("value of x is : " + x);
            Console.WriteLine("value of y is : " + y);
            Console.ReadLine();
        }

    }
}
