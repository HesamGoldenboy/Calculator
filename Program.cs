 using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            string answer;
            int result = 1;


            Console.WriteLine("salam, be mashin hesab man khosh oomadi");
            Console.WriteLine("Lotfan avalin addad ro vared kon:");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lotfan dovomin addad ro vared kon:");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Doost dari che amali rooshoon anjam beshe? ");
            Console.WriteLine("age mikhai jam beshe +, age mikhai tafrigh beshe -, age mikhai zarb beshe * va age mikhai taghsim beshe /");

            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = num1 + num2;
            }
            else if (answer == "-")
            {
                result = num1 - num2;
            }
            else if (answer == "*")
            {
                result = num1 * num2;
            }
            else if (answer == "/")
            {
                result = num1 / num2;
            }

            Console.WriteLine("Natige barabare ba " + result);
            Console.WriteLine("Mamnoon ke az barname man estefade kardi!");
            Console.WriteLine("Programmer: Hesam Badamchi");
        }
    }
}
