using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    //Qu 1. Write a program to check whether input character is vowel or not.
    public class Operator
    {
        public void vowel()
        {
            char ch;
            Console.Write("Enter a character: \t");
            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("\n\n{0} is vowel", ch);
            }
            else
            {
                Console.WriteLine("\n\n{0} is not vowel", ch);
            }
        }

        //Qu 2. Calculate area of Rectangle
        public void AreaOfRectange()
        {
            int area;
            Console.WriteLine("Enter the Length of Rectangle");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of Rectangle");
            int width = int.Parse(Console.ReadLine());

            area = length * width;
            Console.WriteLine("Earea of Rectangle is {0} ", area);
        }
        //Qu3: Write a program to check whether input number is even or odd
        public void evenorodd()
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is even");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
            }
        }
        //: Write a program to calculate power of given number by user.
        public void power()
        { 
            double number = Math.Pow(6, 2);
            Console.WriteLine("power of given number = {0}",number);

        }
    }
}
