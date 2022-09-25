using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    internal class LoopConstructs
    {
        public  void WhileLoop()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=num)
            {
                Console.WriteLine(i+ "x" + num + " = "+ i*num);
                i++;
            }
            
        }
    }
}
