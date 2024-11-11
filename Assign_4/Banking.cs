using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Assignments
{
    class InsuffientBalanceException : ApplicationException
    {
        public InsuffientBalanceException(string msg) : base(msg) { }
    }
    class Banking_Exception
    {
        public string Transaction_type;
        public int Money;
        public int Balance = 10000;

        public Banking_Exception(string tran_type, int amount)
        {
            Transaction_type = tran_type;
            
            Money = amount;
        }
        public void Deposit_Amount(int Mon, int Bal)
        {
            
            Bal = Bal + Mon;
            
            Console.WriteLine(" ");
            
            Console.WriteLine($"Available balance is : Rs.{Bal}");
        }
        public void Withdraw_Amount(int Mon, int Bal)
        {
            try
            {
                if (Mon > Bal) throw (new InsuffientBalanceException("Insufficient Balance ,Please  Enter a Valid Amount"));
                else
                {
                    Bal = Bal - Mon;
                    Console.WriteLine(" ");
                    Console.WriteLine($"Available balance is : {Bal}");
                }
            }
            catch (InsuffientBalanceException insufficient_balance)
            {
                Console.WriteLine(insufficient_balance.Message);
                
                Console.WriteLine(insufficient_balance.StackTrace);

            }
        }


        public void Update_Balance(string Transaction_type)
        {
            switch (Transaction_type)
            {

                case "Deposit":
                case "deposit":
                    Console.WriteLine($"Deposit Amount is :{Money}");
                    Deposit_Amount(Money, Balance);
                    break;
                case "Withdraw":
                case "withdraw":
                    Console.WriteLine($"Withdraw Amount is : {Money}");
                    Withdraw_Amount(Money, Balance);
                    break;
                case "Check Balance":
                case "check balance":
                    Console.WriteLine($"Your Available balance is : {Balance}");
                    break;
                default:
                    Console.WriteLine("Invalid Statement");
                    break;
            }
        }
        public static void Main(string[]args)
        {
            Console.WriteLine(" For Balance enquiry Check Balance (or) check balance");
            Console.WriteLine("Enter the Transaction type: ");
           
            Console.WriteLine("For debit:Withdraw (or) Withdraw  And for Credit :Deposit(or) deposit");
            string trans_type = Console.ReadLine();
            
            Console.Write("Enter the Amount : ");
            int amo = Convert.ToInt32(Console.ReadLine());
            
            Banking_Exception BE = new Banking_Exception(trans_type, amo);
            BE.Update_Balance(trans_type);
           

        }
    }
}
