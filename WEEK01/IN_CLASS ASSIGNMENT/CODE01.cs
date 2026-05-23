//

namespace proj1
{
    internal class ConditionalExample
    {
        //CLASS03--CONDITIONAL STATEMENTS-MAAM GIVEN CODE


        public static void sarah1()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The largest number is: " + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num3);
            }
        }  
    }
} 


//code for program.cs file
namespace proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConditionalExample.sarah1();
        }
    }
}

