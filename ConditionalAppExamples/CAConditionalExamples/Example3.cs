﻿using System;


namespace CAConditionalExamples
{
    class Example3
    {
        static void Main(string[] args)
        {
            bool isprime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i =2; i < 20; i++)
            {
                for (int j =2; j < 20; j++)
                {
                    if(i != j && i % j ==0)
                    {
                        isprime = false;
                        break;

                    }
                }
                if (isprime)
                {
                    Console.Write("\t" + i);
                }
                isprime = true;
            }
            Console.ReadKey();
        }

    }
}
