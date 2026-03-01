using System;

namespace Module5 {     class Program
    {
        static int division(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter second number:");
            string input2 = Console.ReadLine();
            try
            {
                int num1 = Convert.ToInt32(input1);
                int num2 = Convert.ToInt32(input2);

                int divisionResult = division(num1, num2);
                Console.WriteLine("Division of both numbers is:");
                Console.WriteLine(divisionResult);
            }
            catch (FormatException formatex)
            {
                Console.WriteLine("Any of the two inputs is not a valid integer.");
            }
            catch (DivideByZeroException divideex)
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);


            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}