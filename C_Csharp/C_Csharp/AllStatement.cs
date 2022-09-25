using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    //Begin Statement
    public class AllStatement
    {// Begin Statement
        public void block()
        {// Begin Statement
            int num1, power;
            num1 = 5;
            power = num1 * num1;
            Console.WriteLine("The power of given number = {0}",power);
            Console.ReadLine();
        }// End Statement
        public bool empty()
        {
            Console.WriteLine("Steven Clark");
            return true;
        }

        public void Goto()
        {
            string name;
            label: //creating label with colon(:)
            Console.WriteLine("Enter your Name");
            name = Console.ReadLine();
            Console.WriteLine("\"Welcome {0}\"", name);
            Console.WriteLine("Press Ctrl + C for Exit\n");
            goto label; //jump to label statement    
        }
        public void break_statements()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 9)
                {
                    Console.WriteLine("breaking the current segment...");
                    break;
                }
            }
        }
        public void Continue()
        {
            int i = 2;
            while(i<=25)
            {
                if (i % 2 ==0)
                {

                }
                i++;
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
        public void THROW()
        {
            
            int num1, num2, result;
        label:
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (num2 == 0)
                {
                    throw new Exception("Can't Divide by Zero Exception\n\n");
                }
                result = num1 / num2;
               
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                goto label;
            }
            
            catch (Exception e)
            {
                Console.WriteLine("e;Error : " + e.Message);
            }
        }
        public void Unchecked_Statement()
        {
            int num;
            // assign maximum value
            num = int.MaxValue;
            try
            {
                unchecked
                //checked
                {
                    // forces stack overflow exception
                    num = num + 1;
                    Console.WriteLine(num);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Lock_Statement()
        {
            Console.WriteLine("My name is Nitish Mehta");
        }  
    }
        //C# Using Statement


} // End Statement
// End Statement
