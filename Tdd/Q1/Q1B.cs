//using System;

//namespace Tdd

//{

//    public sealed class Printer
//    {
//        private Printer() { }

//        public static Printer _printer;
//        public static Printer DefinePrinter()
//        {

//            if (_printer == null)
//            {

//                Console.WriteLine("Printer Now Connect");
//                _printer = new Printer();

//            }
//            else
//            {
//                Console.WriteLine("Printer Is Busy Please Wait");
//            }

//            return _printer;
//        }

//        public void PrintA4(string text)
//        {
//            Console.WriteLine(text + "is Printing");
//        }



//    }




//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            Printer printer1 = Printer.DefinePrinter();
//            printer1.PrintA4("Document 1");

//            Printer printer2 = Printer.DefinePrinter();
//            printer2.PrintA4("Document 2");



//        }
//    }
//}
