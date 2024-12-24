//using System;
//using System.ComponentModel;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        Tax tax = new Tax();
//        tax.AddEachElement("Price", 5000);

//        DiscountPencil discountPencil = new DiscountPencil(new Price());
//        discountPencil.AddEachElement("Sticker", 2000);

//        DiscountWatch discountWatch = new DiscountWatch(new Price());
//        discountWatch.AddEachElement("Sticker", 100000);

//        Console.WriteLine("End");
//    }


//    public abstract class FactorElements
//    {
//        public abstract void AddEachElement(string featureName, int value);
//    }


//    public class Tax() : FactorElements
//    {
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added In Tax With Value : " + value);
//        }
//    }

//    public class Price() : FactorElements
//    {
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added In Price With Value : " + value);
//        }
//    }


//    public abstract class Discount : FactorElements
//    {
//        protected FactorElements _factorElements;
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added In Discount With Value : " + value);
//        }

//        public Discount(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }

//        public void SetFactoryElement(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }
//    }


//    public class DiscountPencil : Discount
//    {
//        public DiscountPencil(FactorElements factorElements) : base(factorElements)
//        {


//        }
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine("\n Its Pencil Discount");
//            base.AddEachElement(featureName, value);
//        }
//    }


//    public class DiscountWatch : Discount
//    {
//        public DiscountWatch(FactorElements factorElements) : base(factorElements)
//        {


//        }
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine("\n Its Watch Discount");
//            base.AddEachElement(featureName, value);
//        }
//    }
//}



