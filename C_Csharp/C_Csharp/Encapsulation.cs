using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class Encapsulation
    {

    }
    public class Bank
    {
        //Hiding class data by declaring the variable as private
        private double balance;

        //Creating public Setter and Getter methods
        //Public Getter Method
        //This method is used to return the data stored in the balance variable
        public double getbalance
        {
            get { return balance; }

        }
        public double setbalance
        {
            set { balance = value; }
        }
        //Creating public Setter and Getter methods
        //Public Getter Method
        //This method is used to return the data stored in the balance variable
        public double GetBalance()
        {
            //add validation logic if needed
            return balance;
        }
        //Public Setter Method
        //This method is used to stored the data  in the balance variable
        public void SetBalance(double balance)
        {
            // add validation logic to check whether data is correct or not
            this.balance = balance;
        }
        public long AccountNumber;
        public string Name;
        public int Balance;
        public void GettBalance()
        {
            Console.WriteLine(Balance);
        }
        public void WithdrawAmount()
        {
        }
        public void Deposit()
        {
        }
    }

}
