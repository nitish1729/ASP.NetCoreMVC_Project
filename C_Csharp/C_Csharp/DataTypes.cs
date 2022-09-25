using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class DataTypes
    {

        //Declering the static method
        public static void datatype()
        {
            string name; //Variable for storing string value

             //Displaying message for entring value
            Console.WriteLine("Enter your Name");

            //Accepting and holding values in name variable
            name = Console.ReadLine();

            //Displaying Output
            Console.WriteLine("Welcome {0}",name+" in your first csharp");

            //Holding console screen
            Console.ReadLine();
        }
        public int Value_Type(int num)
        {
            return num * num * num;
        }
        public string Value_Type( string name)
        {
            return name;
        }
        public void Value_Type(int num, string name)
        {
            Console.WriteLine(num+ " "+name);
            Console.WriteLine(".....................");
            Console.WriteLine(name);
        }
        //Qu 1: Write a program in which accepts user’s details as name, city, age and pin number.
        //Then store all the values in the appropriate variable and then print all the information in correct format.
        public void excercise()
        {
            Console.WriteLine("Enter your Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter your City Name");
            string CityName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Area Pin Number");
            int PinNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Name is {0} ",Name);
            Console.WriteLine("Your City Name is {0} ", CityName);
            Console.WriteLine("Your age is {0} ", Age);
            Console.WriteLine("Your Area Pin Number is {0} ",PinNum);
            Console.ReadLine();
        }
        //Qu2: Write a program to display student information.
        //Accept Student’s name, Roll no, Age, class, and university name and display it on console.
        public void student(string name, int Roll_No, int Age, int standard, string universityName)
        {
            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("Roll_No = {0}", Roll_No);
            Console.WriteLine("Age = {0}", Age);
            Console.WriteLine("Class = {0}", standard);
            Console.WriteLine("UniversityName = {0}", universityName);
        }
    }
}
