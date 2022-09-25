using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public  class PublicAccessSpecifier
    {
        public string name;
        public string city;
        public int ZipCode;
        public void AccessSpecifier()
        {
            Console.WriteLine("\nMy Nmae is " + name);
            Console.WriteLine("\nMy City Nmae is " + city);
            Console.WriteLine("\nMy Area ZipCode is " + ZipCode);
            Console.WriteLine("\nPlease enter ctrl+C to exist the program");
            Console.ReadLine();
        }
    }
}
