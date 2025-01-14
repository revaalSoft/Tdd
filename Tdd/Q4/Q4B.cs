//using System;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");


//        var allpayment = new AllPayment();
//        allpayment.ManualConnect(10000, "ali");
//        allpayment.CardConnect(30000, "mamad");
//        allpayment.MyketConnect(20000, "hasan");


//        Console.WriteLine("End");
//    }


//    public class AllPayment
//    {
//        Payment payment;
//        public void ManualConnect(int priceWithOutTax, string username)
//        {
//            payment = new Paypaal();
//            int totalPrice = payment.returnPrice(priceWithOutTax);
//            payment.Connect();
//            payment.PurchaseDone(username, totalPrice);
//        }
//        public void MyketConnect(int priceWithOutTax, string username)
//        {
//            payment = new Manual();
//            int totalPrice = payment.returnPrice(priceWithOutTax);
//            payment.Connect();
//            payment.PurchaseDone(username, totalPrice);
//        }
//        public void CardConnect(int priceWithOutTax, string username)
//        {
//            payment = new Card();
//            int totalPrice = payment.returnPrice(priceWithOutTax);
//            payment.Connect();
//            payment.PurchaseDone(username, totalPrice);
//        }

//    }


//    public abstract class Payment
//    {
//        public int returnPrice(int priceWithOutTax)
//        {

//            Console.WriteLine("priceWithOutTax = " + priceWithOutTax);
//            int total = priceWithOutTax - (priceWithOutTax / 5);

//            return total;
//        }
//        public abstract void Connect();

//        public void PurchaseDone(string username, int totalPrice)
//        {
//            Console.WriteLine(username + " purchase in " + totalPrice + " rial ");
//        }

//    }

//    public class Paypaal : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to Paypaal");
//        }

//    }
//    public class Manual : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to Manual");
//        }
//    }
//    public class Card : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to Card");
//        }
//    }

//}



