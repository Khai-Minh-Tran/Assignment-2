using System;


namespace Conditional_Statements_Letter_Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your numeric grade:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 >= 90)
            {
                Console.WriteLine("Your letter grade is A.");
                Console.ReadKey(true);
            }
            else if ((n1 >= 80) && (n1 < 90))
            {
                Console.WriteLine("Your letter grade is B.");
                Console.ReadKey(true);
            }
            else if ((n1 >= 70) && (n1 < 80))
            {
                Console.WriteLine("Your letter grade is C.");
                Console.ReadKey(true);
            }
            else if ((n1 >= 60) && (n1 < 70))
            {
                Console.WriteLine("Your letter grade is D.");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("Your letter grade is F.");
                Console.ReadKey(true);
            }



            // Try catch block
            try
            {
                Console.WriteLine("Enter some number (n2):");
                string input = Console.ReadLine();
                decimal n2 = decimal.Parse(input);
                Console.WriteLine(" Input is :" + n2);
            }
            catch
            {
                Console.WriteLine("Please use a decimal data type");
                Console.ReadKey(true);

            }
            Console.WriteLine("Enter some number (n3):");
            int n3 = int.Parse(Console.ReadLine());

        }
    }
}
