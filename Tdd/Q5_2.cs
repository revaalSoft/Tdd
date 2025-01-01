//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        FactorElements factor = new Factor();

//        CollectFactor collectFactor = new CollectFactor(factor);

//        collectFactor.DefineTax(50000);
//        collectFactor.DefinePrice(40000);
//        collectFactor.DefineTransportation(60000);
//        collectFactor.ShowDescription();
//        Console.WriteLine("End");
//    }

//    public class CollectFactor
//    {
//        FactorElements _factorElements;
//        public CollectFactor(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }

//        public void DefineTax(int value)
//        {
//            _factorElements = new Tax(_factorElements);
//            _factorElements.AddEachElement(value);
//        }

//        public void DefineTransportation(int value)
//        {
//            _factorElements = new Tranportation(_factorElements);
//            _factorElements.AddEachElement(value);
//        }

//        public void DefinePrice(int value)
//        {
//            _factorElements = new Price(_factorElements);
//            _factorElements.AddEachElement(value);
//        }


//        public void ShowDescription()
//        {
//            _factorElements.Description();
//        }

//    }

//    public abstract class FactorElements
//    {
//        public abstract void AddEachElement(int value);
//        public abstract string Description();
//    }



//    public class Factor : FactorElements
//    {
//        public override void AddEachElement(int value)
//        {

//        }

//        public override string Description()
//        {
//            return "Factor :";
//        }

//    }

//    public class Tax : FactorElements
//    {
//        FactorElements _factorElements;
//        public Tax(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }
//        public override void AddEachElement(int value)
//        {
//            Console.WriteLine($" Tax Added With Value : " + value);

//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Tax ";
//            Console.WriteLine(desc);
//            return desc;
//        }
//    }

//    public class Price : FactorElements
//    {
//        FactorElements _factorElements;
//        public Price(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }
//        public override void AddEachElement(int value)
//        {
//            Console.WriteLine($"Price Added With Value : " + value);
//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Price ";
//            Console.WriteLine(desc);
//            return desc;

//        }
//    }

//    public class Tranportation : FactorElements
//    {
//        FactorElements _factorElements;
//        public Tranportation(FactorElements factorElements)
//        {
//            this._factorElements = factorElements;
//        }
//        public override void AddEachElement(int value)
//        {
//            Console.WriteLine($"Transportation Added  With Value : " + value);
//        }

//        public override string Description()
//        {
//            string desc = _factorElements.Description() + " Transportation ";
//            Console.WriteLine(desc);
//            return desc;
//        }
//    }





//}



