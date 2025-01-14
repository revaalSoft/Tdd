//using System;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");


//        var allpayment = new AllAlgoritms();
//        allpayment.AlgoritmA();
//        allpayment.AlgoritmB();
//        allpayment.AlgoritmC();

//        Console.WriteLine("End");
//    }


//    public class AllAlgoritms
//    {
//        Algoritm algoritm;

//        public void AlgoritmA()
//        {
//            algoritm = new AlgoritmA();
//            algoritm.CalculateAlgoritm();

//        }
//        public void AlgoritmB()
//        {
//            algoritm = new AlgoritmB();
//            algoritm.CalculateAlgoritm();
//        }
//        public void AlgoritmC()
//        {
//            algoritm = new AlgoritmC();
//            algoritm.CalculateAlgoritm();

//        }

//    }


//    public abstract class Algoritm
//    {
//        public abstract void CalculateAlgoritm();

//    }

//    public class AlgoritmA : Algoritm
//    {
//        public override void CalculateAlgoritm()
//        {
//            Console.WriteLine("AlgoritmA");
//        }

//    }
//    public class AlgoritmB : Algoritm
//    {
//        public override void CalculateAlgoritm()
//        {
//            Console.WriteLine("AlgoritmB");
//        }
//    }
//    public class AlgoritmC : Algoritm
//    {
//        public override void CalculateAlgoritm()
//        {
//            Console.WriteLine("AlgoritmC");
//        }
//    }

//}



