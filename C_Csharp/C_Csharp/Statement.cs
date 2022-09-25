using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    internal class Statement
    {
        public void Switch()
        {
            int opt, num1, num2;
            float result;

        label:

            Console.WriteLine("\n\t\tMenu");
            Console.WriteLine("\nPress 1 for add");
            Console.WriteLine("Press 2 for subtraction");
            Console.WriteLine("Press 3 for multiplication");
            Console.WriteLine("Press 4 for Division");
            Console.WriteLine("Press 5 for Square");

            Console.Write("\n\nEnter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter your option:\t");
            opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("\n{0} + {1} = {2}", num1, num2, result);
                    break;

                case 2:
                    result = num1 - num2;
                    Console.WriteLine("\n{0} - {1} = {2}", num1, num2, result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
                    break;
                case 4:
                    result = (float)num1 / num2;
                    Console.WriteLine("\n{0} / {1} = {2}", num1, num2, result);
                    break;
                //case 5:
                //    result = (float)num1 * num2;
                //    Console.WriteLine("\n{0}  {1} = {2}", num1, num2, result);
                //    break;
                default:
                    Console.WriteLine("\nInvalid option. Please try again.");
                    goto label;
            }
           
        }
        public void days()
        {
            int opt;
        label:
            Console.WriteLine("\n\nEnter your option (1-7) for days. 1 for Monday:\t");
            opt = Convert.ToInt32(Console.ReadLine());
            switch (opt)
            {
               case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again\n");
                    goto label;
            }
        }
    }
    
}
