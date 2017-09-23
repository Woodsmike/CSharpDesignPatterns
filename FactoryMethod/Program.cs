﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactoryMethod
{
    class Program  // Singleton
    {
        static void Main(string[] args)
        {
            var policy = new Policy();
            var insuredName = Policy.Instance.GetInsuredName();

            Console.WriteLine(insuredName);            
        }

        public class Policy
        {
            //private static readonly object _lock = new object();

            private static readonly Policy _instance = new Policy();            
            public static Policy Instance {
                get
                {                   
                     return _instance;                   
                }
            }
            public Policy()
            {

            }
            private int Id { get; set; } = 1234;
            private string Insured { get; set; } = "John Roy";

            public string GetInsuredName() => Insured;
        }

        
        //class Program  //  Abstract Factory Method
        //{
        //    static void Main(string[] args)
        //    {
        //        List<string> accntNumbers = new List<string> {
        //                                    "CITI-456",
        //                                    "NATIONAL-987",
        //                                    "CHASE-222"};
        //        for (int i = 0; i < accntNumbers.Count; i++)
        //        {
        //            ICreditUnionFactory anAbstractFactory =
        //                CreditUnionFactoryProvider.
        //                GetCreditUnionFactory(accntNumbers[i]);
        //            if (anAbstractFactory == null)
        //            {
        //                Console.WriteLine("Sorry. This credit union w/ account number" +
        //                                  " ' {0} ' is invalid.", (accntNumbers[i]));
        //            }
        //            else
        //            {
        //                ILoanAccount loan = anAbstractFactory.CreateLoanAccount();
        //                ISavingsAccount savings = anAbstractFactory.CreateSavingsAccount();
        //            }
        //        }
        //        Console.ReadLine();
        //    }

        //public abstract class ICreditUnionFactory
        //{
        //    public abstract ISavingsAccount CreateSavingsAccount();
        //    public abstract ILoanAccount CreateLoanAccount();
        //}
        //public interface ILoanAccount { }

        //public interface ISavingsAccount { }

        ////first factory
        //public class CitiSavingsAccount : ISavingsAccount
        //{
        //    public CitiSavingsAccount()
        //    {
        //        Console.WriteLine("Returned Citi Savings Account");
        //    }
        //}
        //public class CitiLoanAccount : ILoanAccount
        //{
        //    public CitiLoanAccount()
        //    {
        //        Console.WriteLine("Returned Citi Loan Account");
        //    }
        //}
        //public class CitiCreditUnionFactory : ICreditUnionFactory
        //{
        //    public override ILoanAccount CreateLoanAccount()
        //    {
        //        CitiLoanAccount obj = new CitiLoanAccount();
        //        return obj;
        //    }

        //    public override ISavingsAccount CreateSavingsAccount()
        //    {
        //        CitiSavingsAccount obj = new CitiSavingsAccount();
        //        return obj;
        //    }
        //}
        ////Second factory
        //public class NationalSavingsAccount : ISavingsAccount
        //{
        //    public NationalSavingsAccount()
        //    {
        //        Console.WriteLine("Returned National Savings Account");
        //    }
        //}
        //public class NationalLoanAccount : ILoanAccount
        //{
        //    public NationalLoanAccount()
        //    {
        //        Console.WriteLine("Returned National Loan Account");
        //    }
        //}
        //public class NationalCreditUnionFactory : ICreditUnionFactory
        //{
        //    public override ILoanAccount CreateLoanAccount()
        //    {
        //        NationalLoanAccount obj = new NationalLoanAccount();
        //        return obj;
        //    }

        //    public override ISavingsAccount CreateSavingsAccount()
        //    {
        //        NationalSavingsAccount obj = new NationalSavingsAccount();
        //        return obj;
        //    }
        //}
        ////Providers
        //public class CreditUnionFactoryProvider
        //{
        //    public static ICreditUnionFactory GetCreditUnionFactory(string accountNo)
        //    {
        //        if (accountNo.Contains("CITI")) { return new CitiCreditUnionFactory(); }
        //        else
        //        if (accountNo.Contains("NATIONAL")) { return new NationalCreditUnionFactory(); }
        //        else
        //            return null;
        //    }
        //}
    }
}
//    class Program  --- Factory methods
//    {
//        static void Main(string[] args)
//        {
//            var factory = new SavingsAcctFactory() as ICreditUnionFactory;
//            var citiAcct = factory.GetSavingsAccount("CITI-321");
//            var nationalAcct = factory.GetSavingsAccount("NATIONAL-9871");

//            Console.WriteLine($"My citi balance is ${citiAcct.Balance}" +
//                $" and national balance is ${nationalAcct.Balance}");
//        }

//    }

//    // Product
//    public abstract class ParentSavingsAccount
//    {
//        public decimal Balance { get; set; }
//    }

//    // Concrete Product
//    public class CitiSavingsAcct : ParentSavingsAccount
//    {
//        public CitiSavingsAcct()
//        {
//            Balance = 5000;
//        }
//    }

//    // Concrete Product
//    public class NationalSavingsAcct : ParentSavingsAccount
//    {
//        public NationalSavingsAcct()
//        {
//            Balance = 2000;
//        }
//    }

//    // Creator
//    interface ICreditUnionFactory
//    {
//        ParentSavingsAccount GetSavingsAccount(string acctNo);
//    }

//    // Concrete Creators
//    public class SavingsAcctFactory : ICreditUnionFactory
//    {
//        public ParentSavingsAccount GetSavingsAccount(string acctNo)
//        {
//            if (acctNo.Contains("CITI")) { return new CitiSavingsAcct(); }
//            else
//            if (acctNo.Contains("NATIONAL")) { return new NationalSavingsAcct(); }
//            else
//                throw new ArgumentException("Invalid Account Number");
//        }
//    }


//}