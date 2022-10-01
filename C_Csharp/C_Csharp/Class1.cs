using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static C_Csharp.Class1;

namespace C_Csharp
{
    internal class Class1 
    {
        public string FirstName;
        public string LastName;
        // Private fileds not accessible outside the class.
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _coutry = string.Empty;
        public override string ToString()
        {
            return LastName + ", " + FirstName;
        }
        public void ram()
        {
            //    string s1 = "First String ";
            //    string s2 = "Second String";
            //    s1 += s2;
            //    System.Console.WriteLine(s1);
            //    string str1 = "Hello ";
            //    string str2 = str1;
            //    str1 = str1 + "C#";
            //    System.Console.WriteLine(str2); 
            //    System.Console.WriteLine(str1); 
            //    string name = "Mehta";
            //    //string name = "Nitish";
            //    int x = 4;
            //    //int x = 10;
            //    string imagepath = @"C:\Users\NITISH MEHTA\OneDrive\Desktop\.Net_Developer\C_Csharp\C_Csharp\nature3.jpg";
            //    Console.WriteLine(imagepath);
            //    try
            //    {
            //        string strr = null;
            //        Console.WriteLine(strr.Length);
            //    }
            //    catch(Exception r)
            //    {
            //        Console.WriteLine(r.Message);
            //    }
            //    string str = "One";
            //    int i = 0;
            //    if (int.TryParse(str, out i))
            //    {
            //        Console.WriteLine("Yes string contains Integer and it is " + i);
            //    }
            //    else
            //    {
            //       Console.WriteLine("string does not contain Integer");
            //    }
            label:
            Console.WriteLine("Please enter ur age");
            int age = int.Parse(Console.ReadLine());
            goto label;
        }

        // public FirstName property exposes _firstName variable
        public string firstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        // public LastName property exposes _lastName variable
        public string lastName
        {
            get { return _lastName; }
            set { _lastName = value; } 
        }
        // FullName property is readonly and computes customer full name.
        public string FullName
        {
            get { return _firstName + " "+ _lastName; }
        }
        //Country Property is Write Only
        public string coutry
        {
            get { return _coutry; }
        }
        public void setCountry(string Country)
        {
            this._coutry = Country;
            Console.WriteLine(_coutry);
        }
        public class circle
        {
            private static double _pi = 3.14;
            public static double PI
            {
                get { return _pi; }
            }
            public void print()
            {
                Console.WriteLine(circle._pi);
            }
        }
    }
    public class Customer
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        public string FirstName
        {
            set { _firstName = value; }
            get { return _firstName; }
        }
        public string LastName
        {
            set { _lastName = value; }
            get { return _lastName; }
        }
        // FullName is virtual
        public virtual string FullName  // virtual,abstract or override
        {
            get { return _firstName + " " + _lastName; }
        }
    }
    class BankCustomer : Customer
    {
        // Overriding the FullName virtual property derived from customer class
        public override string FullName
        {
            get
            {
                return "Mr. " + FirstName + " " + LastName;
            }
        }
    }
}

