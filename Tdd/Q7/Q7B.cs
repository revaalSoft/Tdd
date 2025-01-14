//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        Payment payment = new Payment();
//        IPayment paypaal = new Paypaal(payment);

//        paypaal.Pay();

//        IPayment bank = new Bank(payment);

//        bank.Pay();

//        Console.WriteLine("End");
//    }


//    public interface IPayment
//    {
//        public void Pay();

//    }


//    public class Payment
//    {
//        public string PerformPayment()
//        {
//            return "Executing Payment : ";
//        }
//    }

//    public class Paypaal : IPayment
//    {
//        public Payment _payment;
//        public Paypaal(Payment payment)
//        {
//            this._payment = payment;
//        }

//        public void Pay()
//        {
//            Console.WriteLine($"{_payment.PerformPayment()} using Paypaal.");
//        }
//    }

//    public class Bank : IPayment
//    {
//        public Payment _payment;
//        public Bank(Payment payment)
//        {
//            this._payment = payment;
//        }

//        public void Pay()
//        {
//            Console.WriteLine($"{_payment.PerformPayment()} using Bank.");
//        }
//    }
//}



