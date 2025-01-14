//using System;
//using System.ComponentModel;
//using System.Transactions;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        SellingAutoSystem system = new SellingAutoSystem(new SystemSellingState());
//        system.Selling();
//        system.Open();



//        Console.WriteLine("End");
//    }



//    public class SellingAutoSystem
//    {

//        private SellingState _selling;

//        public SellingAutoSystem(SellingState selling)
//        {
//            _selling = selling;
//        }


//        public void ReadyToSell()
//        {
//            _selling.ReadyToSell();
//        }
//        public void Finish()
//        {
//            _selling.Finish();
//        }
//        public void Selling()
//        {
//            _selling.Selling();
//        }
//        public void Open()
//        {
//            _selling.Open();
//        }


//    }

//    public abstract class SellingState
//    {

//        public abstract void ReadyToSell();

//        public abstract void Finish();

//        public abstract void Selling();

//        public abstract void Open();
//    }

//    public class SystemSellingState : SellingState
//    {
//        public override void Finish()
//        {
//            Console.WriteLine("Finish");
//        }

//        public override void Open()
//        {
//            Console.WriteLine("Open");
//        }

//        public override void ReadyToSell()
//        {
//            Console.WriteLine("ReadyToSell");
//        }

//        public override void Selling()
//        {
//            Console.WriteLine("Selling");
//        }
//    }



//}



