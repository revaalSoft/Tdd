//using System;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");


//        var allpayment = new AllPayment();
//        allpayment.BazarConnect(10000, "ali");
//        allpayment.ZarinConnect(30000, "mamad");
//        allpayment.MyketConnect(20000, "hasan");


//        //Payment bazar = new Bazar();

//        //int totalPrice = bazar.returnPrice(6500);
//        //bazar.Connect();
//        //bazar.AddData(1, "ali", totalPrice);

//        //Payment myket = new Myket();

//        //totalPrice = myket.returnPrice(8000);
//        //myket.Connect();
//        //myket.AddData(2, "hasan", totalPrice);

//        //Payment zarin = new Zarinpal();

//        //totalPrice = zarin.returnPrice(8000);
//        //zarin.Connect();
//        //zarin.AddData(3, "mamad", totalPrice);




//        Console.WriteLine("End");
//    }


//    public class AllPayment
//    {

//        public void BazarConnect(int priceWithOutTax, string username)
//        {
//            Payment bazar = new Bazar();
//            bazar.Connect();
//            int totalPrice = bazar.returnPrice(priceWithOutTax);
//            bazar.AddData(username, totalPrice);
//        }
//        public void MyketConnect(int priceWithOutTax, string username)
//        {
//            Myket myket = new Myket();
//            myket.Connect();
//            int totalPrice = myket.returnPrice(priceWithOutTax);
//            myket.AddData(username, totalPrice);
//        }
//        public void ZarinConnect(int priceWithOutTax, string username)
//        {
//            Zarinpal zarin = new Zarinpal();
//            zarin.Connect();
//            int totalPrice = zarin.returnPrice(priceWithOutTax);
//            zarin.AddData(username, totalPrice);
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

//        public void AddData(string username, int totalPrice)
//        {
//            Console.WriteLine(username + " purchase this in " + totalPrice + " rial ");
//        }

//    }

//    public class Bazar : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to bazar");
//        }

//    }
//    public class Myket : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to myket");
//        }
//    }
//    public class Zarinpal : Payment
//    {
//        public override void Connect()
//        {
//            Console.WriteLine("Connect to zarinpal");
//        }
//    }

//}



