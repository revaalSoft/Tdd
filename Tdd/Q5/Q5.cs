//using System;
//using System.ComponentModel;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        FactorElements factor = new Factor();

//        factor = new Tax(factor);
//        factor.AddEachElement("Tax", 50000);
//        factor = new Price(factor);
//        factor.AddEachElement("Price", 40000);
//        factor = new Tranportation(factor);
//        factor.AddEachElement("Tranportation", 60000);
//        factor.Description();
//        Console.WriteLine("End");
//    }


//    public abstract class FactorElements
//    {
//        public abstract void AddEachElement(string featureName, int value);
//        public abstract string Description();
//    }


//    public class Factor : FactorElements
//    {
//        public override void AddEachElement(string featureName, int value)
//        {

//        }

//        public override string Description()
//        {
//            return "Factor :";
//        }

//    }


//    public abstract class FactorElementsDecorator : FactorElements
//    {
//        protected FactorElements _factorElements;
//        public FactorElementsDecorator(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }
//    }


//    public class Tax : FactorElementsDecorator
//    {
//        public Tax(FactorElements factorElements) : base(factorElements) { }
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added With Value : " + value);

//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Tax ";
//            Console.WriteLine(desc);
//            return desc;
//        }
//    }

//    public class Price : FactorElementsDecorator
//    {
//        public Price(FactorElements factorElements) : base(factorElements) { }
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added With Value : " + value);
//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Price ";
//            Console.WriteLine(desc);
//            return desc;

//        }
//    }

//    public class Tranportation : FactorElementsDecorator
//    {
//        public Tranportation(FactorElements factorElements) : base(factorElements) { }
//        public override void AddEachElement(string featureName, int value)
//        {
//            Console.WriteLine($"{featureName} Added  With Value : " + value);
//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Transportation ";
//            Console.WriteLine(desc);
//            return desc;
//        }
//    }


//}



