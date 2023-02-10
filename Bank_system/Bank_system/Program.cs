using System;
//using System.Globalization;
//using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace BankingSystem
{
    public class BankInfo
    {
        const string Bankname = "Goa Public Bank. PVT LTD";
        const string BranchName = "Goa";

        public void BankName()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Bank Name: " + Bankname);
            Console.WriteLine("Bank Branch Name: " + BranchName);
            Console.WriteLine("------------------------------------------------\n");
        }

        public void  AccountInfo()
        {
            Console.WriteLine("1.Saving Account");
            Console.WriteLine("2.Current Account");
            Console.WriteLine("Please Enter Valid Number 1 || 2 "); 
           Console.WriteLine("------------------------------------------------\n");
        }

    }
    public class AccountType
    {
        
        string? HolderName,state,country,emailId,Location;
        int age;

        public void SavingAccount()
        {
            
            Console.WriteLine("\n#----------------Saving Account-----------------#");
            Console.WriteLine("Enter your name : ");
            HolderName = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<=68)
            {
                Console.WriteLine("\nYou are eligible");
            }
            else
            {
                Console.WriteLine("\nYou are not eligible");
                return;
            }
            Console.WriteLine("Enter your location :");
            Location = Console.ReadLine();
            Console.WriteLine("Enter your state :");
            state = Console.ReadLine();
            Console.WriteLine("Enter your country :");
            country = Console.ReadLine();
            Console.WriteLine("Enter your emailId :");
            emailId = Console.ReadLine();
            // ---------------EmailValidaten------------------

            bool isEmail = Regex.IsMatch(emailId, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if(isEmail)       
            {
                Console.WriteLine();
            }
             else
            {
                 Console.WriteLine("Invalid email address");
                 return;
            }
        
            
            Console.WriteLine("\n------------Bank holder saving account info-------------\n");
            Console.WriteLine("Bank Holder name is  : " + HolderName);
            Console.WriteLine("Bank Holder age is  : " + age);
            Console.WriteLine("Bank Holder location is  : " + Location);
            Console.WriteLine("Bank Holder state is : " + state);
            Console.WriteLine("Bank Holder country is : " + country);
            Console.WriteLine("Bank Holder emailId is  : " + emailId);
            Console.WriteLine("\n--------------------------------------------------------\n");

            Console.WriteLine("============Create Bank saving account number=============\n");

            string startWith = "04";
            Random generator = new Random();
            string saving = generator.Next(110000000, 200000000).ToString("D6");
            string AccounNumber = startWith + saving;

            Console.WriteLine("Your bank account number is: "+ "sav" + AccounNumber);

            Console.WriteLine("\n==========================================================\n");

            Console.Write("Enter Your Account Number:= ");
            string? HolderDetail=Console.ReadLine();

            if(HolderDetail == AccounNumber)
            {
                 Console.WriteLine("\n---------------Bank holder saving account info--------------\n");
                 Console.WriteLine("Bank Holder name is  : " + HolderName);
                 Console.WriteLine("Bank Holder age is  : " + age);
                 Console.WriteLine("Bank Holder location is  : " + Location);
                 Console.WriteLine("Bank Holder state is : " + state);
                 Console.WriteLine("Bank Holder country is : " + country);
                 Console.WriteLine("Bank Holder emailId is  : " + emailId);
                 Console.WriteLine("\n------------------------------------------------------------\n");
            }
            else{
                Console.WriteLine("\n========Wrong account number========\n");
                return;
            }


            int amount = 0, deposit,withdraw;
            int choice, x = 0;
            double Accnumber;

            Console.WriteLine("================Bank saving account process==============\n");
            Console.Write("Enter your Bank Account Number:=  ");
            Accnumber = Convert.ToDouble(Console.ReadLine());
            while(true) {
                Console.WriteLine("\n=========Welcome to bank Saving account process=========\n");
                Console.WriteLine("==========================================================");
                Console.Write("1. Current Balance ");
                Console.Write("2. Withdraw ");
                Console.Write(" 3. Deposit ");
                Console.WriteLine(" 4. Exit ");
                Console.WriteLine("==========================================================\n");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("\n Your Current Balance is Rs := {0} " , amount);
                            break;
                        case 2:
                            Console.Write("\n Enter the withdraw amount: ");
                            withdraw = Convert.ToInt32(Console.ReadLine());
                            if (withdraw % 100 != x){
                                Console.WriteLine("\n Please enter the amount in above 100");
                            }else if(withdraw>(amount-1000)){
                                Console.WriteLine("\n Sorry! INSUFFICENT Balance");
                            }else{
                                amount = amount - withdraw;
                                Console.WriteLine("\n Please collect your cash");
                                Console.WriteLine("\n Saving account Balance Is Rs : {0}", amount);
                            }
                        // Console.WriteLine(choice);
                            break;
                        case 3:
                            Console.Write("\n Enter the deposit amount: ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                            amount = amount + deposit;
                            Console.WriteLine("Your Amount Has Been Deposited Successfully.");
                            Console.WriteLine("Your total balance is Rs : {0}", amount);
                            //Console.WriteLine(choice);
                            break;
                        case 4:
                            Console.WriteLine("\n Thank you for visiting us.");
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    } 
                }
        }

        public void CurrentAccount()
        {
            Console.WriteLine("\n#-----------------Current Account------------------#");
            Console.WriteLine("Enter your name : ");
            HolderName = Console.ReadLine();
            Console.WriteLine("Enter your age :");
            age = Convert.ToInt32(Console.ReadLine());
            if(age<=68)
            {
                Console.WriteLine("You are eligible\n");
            }
            else
            {
                Console.WriteLine("You are not eligible\n");
                return;
            }
            Console.WriteLine("Enter your location :");
            Location = Console.ReadLine();
            Console.WriteLine("Enter your state :");
            state = Console.ReadLine();
            Console.WriteLine("Enter your country :");
            country = Console.ReadLine();
            Console.WriteLine("Enter your emailId :");
            emailId = Console.ReadLine();

            // ---------------EmailValidaten------------------

           bool isEmail = Regex.IsMatch(emailId, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if(isEmail)       
            {
                Console.WriteLine();
            }
             else
            {
                 Console.WriteLine("Invalid email address");
                 return;
            }


            Console.WriteLine("\n----------------Bank holder Current account info------------------\n");
            Console.WriteLine("Bank Holder name is  : " + HolderName);
            Console.WriteLine("Bank Holder age is  : " + age);
            Console.WriteLine("Bank Holder location is  : " + Location);
            Console.WriteLine("Bank Holder state is : " + state);
            Console.WriteLine("Bank Holder country is : " + country);
            Console.WriteLine("Bank Holder emailId is  : " + emailId);
            Console.WriteLine("\n-------------------------------------------------------------------\n");


            Console.WriteLine("=================Create Bank Current account number===================\n");

            string startWith = "Cur03";
            Random generator = new Random();
            string Current = generator.Next(000000000, 100000000).ToString("D6");
            string AccounNumber = startWith + Current;

            Console.WriteLine("Your bank account number is: " + AccounNumber);

            Console.WriteLine("=======================================================================\n");

            Console.WriteLine("Your bank account number is: " + AccounNumber);

            Console.WriteLine("=======================================================================\n");

            Console.Write("Enter Your Account Number:= ");
            string? HolderDetail=Console.ReadLine();

            if(HolderDetail == AccounNumber)
            {
                 Console.WriteLine("\n---------------Bank holder saving account info-----------------\n");
                 Console.WriteLine("Bank Holder name is  : " + HolderName);
                 Console.WriteLine("Bank Holder age is  : " + age);
                 Console.WriteLine("Bank Holder location is  : " + Location);
                 Console.WriteLine("Bank Holder state is : " + state);
                 Console.WriteLine("Bank Holder country is : " + country);
                 Console.WriteLine("Bank Holder emailId is  : " + emailId);
                 Console.WriteLine("\n---------------------------------------------------------------\n");
            }
            else{
                Console.WriteLine("\n====Wrong account number====\n");
                return;
            }
            // ==============Create Bank Account Proecces====================

            int amount = 0, deposit, withdraw;
            int choice, x = 0;
            double Accnumber;

            Console.WriteLine("================Bank current account process==============\n");
            Console.Write("Enter your current bank account number:=  ");
            Accnumber = Convert.ToDouble(Console.ReadLine());
            while(true) {
                Console.WriteLine("\n=========Welcome to bank Current account process=========\n");
                Console.WriteLine("==========================================================");
                Console.Write("1. Current Balance ");
                Console.Write("2. Withdraw ");
                Console.Write(" 3. Deposit ");
                Console.WriteLine(" 4. Exit ");
                Console.WriteLine("==========================================================\n");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n Your Current Balance is Rs := {0} " , amount);
                        break;
                    case 2:
                        Console.Write("\n Enter the withdraw amount: ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw % 100 != x){
                            Console.WriteLine("\n Please enter the amount in above 100");
                        }else if(withdraw>(amount-1000)){
                            Console.WriteLine("\n Sorry! INSUFFICENT Balance");
                        }else{
                            amount = amount - withdraw;
                            Console.WriteLine("\n Please collect your cash");
                            Console.WriteLine("\n Saving account Balance Is Rs : {0}", amount);
                        }
                    // Console.WriteLine(choice);
                        break;
                    case 3:
                        Console.Write("\n Enter the deposit amount: ");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("Your Amount Has Been Deposited Successfully.");
                        Console.WriteLine("Your total balance is Rs : {0}", amount);
                        //Console.WriteLine(choice);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you for visiting us.");
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                } 

            }
        }
    }
    class Program  
    {
        static void Main(string[] args)
        {
            BankInfo account = new BankInfo();
            account.BankName();
            account.AccountInfo();

            AccountType type = new AccountType();

            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine("\nYou have selected the Savings Account option.");
                type.SavingAccount();              
            }
            else if(option == 2)
            {
                Console.WriteLine("\nYou have selected the Current Account option.");
                type.CurrentAccount();
            }
           else
           {
                Console.WriteLine("Not Valid Number");
           }   

                    
        }
    }
}