using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Csharp
{
    public class AbstractionClass
    {
    }
    public abstract class ABank
    {
        public abstract void ValidateCard();
        public abstract void WithdrawMoney();
        public abstract void CheckBalanace();
        public abstract void BankTransfer();
        public abstract void MiniStatement();
    }
    public class BankFeature
    {
        public static IBank GetBankObject(string bankType)
        {
            IBank BankObject = null;
            if (bankType == "SBI")
            {
                BankObject = new SBI();
            }
            else if (bankType == "AXIX")
            {
                BankObject = new AXIX();
            }
            return BankObject;
        }
    }
    public class HDFC : ABank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("SBI Bank Bank Transfer");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }
    public class YES : ABank
    {
        public override void BankTransfer()
        {
            Console.WriteLine("AXIX Bank Bank Transfer");
        }
        public override void CheckBalanace()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }
        public override void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public override void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public override void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}

