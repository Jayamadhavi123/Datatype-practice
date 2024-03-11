namespace CAConditionalExamples
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Five Numbers");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
                Console.WriteLine("Highest Number is {0}" , num1);
            else if(num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
                Console.WriteLine("Highest Number is {0}", num2);
            else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
                Console.WriteLine("Highest Number is {0}", num3);
            else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
                Console.WriteLine("Highest Number is {0}", num4);
            else  
                Console.WriteLine("Highest Number is {0}", num5);
            if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
                Console.WriteLine("Lowest Number is {0}", num1);
            else if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
                Console.WriteLine("Lowest Number is {0}", num2);
            else if (num3 < num1 && num3 < num2 && num3 < num4 && num3 < num5)
                Console.WriteLine("Lowest Number is {0}", num3);
            else if (num4 < num1 && num4 < num2 && num4 < num3 && num4 < num5)
                Console.WriteLine("Lowest Number is {0}", num4);
            else
                Console.WriteLine("Lowest Number is {0}", num5);


        }
    }
}
