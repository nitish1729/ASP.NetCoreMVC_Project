using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class Encapsulations
    {
        private int id;
        public string name;
        private int age;
        public void display()
        {
            Console.WriteLine(name);
            
        }
        // Accessing private filed by using property
        public int AGE
        {
            get 
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        // Accessing private filed by using method
        public void setID(int id)
        {
            this.id =  id;
        }
        public void getID()
        {
            Console.WriteLine("Your EmpID {0}",this.id );
        }
    }
}
