using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class Abstraction_Principle
    { 
        public void abst()
        {
            Console.WriteLine("Absraction Principle in C#:");
        }
    }
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalanace();
        void BankTransfer();
        void MiniStatement();
    }
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new HDFC();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }

    public class HDFC : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }

    public class AXIX : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }

        public void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }

        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }

        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }

}
