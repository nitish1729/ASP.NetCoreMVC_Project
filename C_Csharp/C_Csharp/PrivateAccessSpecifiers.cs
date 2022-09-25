using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class  PrivateAccessSpecifiers : WriteDepartment
    {   
        // Variables
        private string name;
        private string city;
        private int ZipCode;

        // Property
        public string getname
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }
        public string getcity
        {
            get { return city; }
            set { city = value; }
        }
        public int getZipCode
        {
            get { return ZipCode; }
            set { ZipCode = value; }
        }
        public void AccessSpecifier()
        {
            Console.WriteLine("\nMy Nmae is " + name);
            Console.WriteLine("\nMy City Nmae is " + city);
            Console.WriteLine("\nMy Area ZipCode is " + ZipCode);
           
            Console.ReadLine();
        }
    }
    //WRITE ONLY PROPERTY
    public class WriteDepartment 
    {
        private string departname;
        public string getpartname
        {
            set { departname = value;
                Console.WriteLine("The Department is :{0}", departname);
            }

        }
    }
    //READ ONLY PROPERTY
    public class ReadDepartment
    {
        private int ATMPin;
        public int GetATMPin
        {
            get { return ATMPin; }
           
        }
        public void pin()
        {
            Console.WriteLine("The Department is :{0}", ATMPin);
        }
    }
}
