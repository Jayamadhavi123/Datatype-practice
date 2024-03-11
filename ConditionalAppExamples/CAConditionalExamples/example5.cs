
namespace CAConditionalExamples
{
    class Assignment

    {
        static void Main(string[] args)
    {
        Console.WriteLine("Enter TWO Numbers");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine("Highest Number is {0},{1}", num1,num2);
        else
            Console.WriteLine("Highest Number is {0}", num2);
    }
}

}



