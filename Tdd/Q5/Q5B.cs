//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");


//        FeatureComponent car = new BasicCar();
//        car = new Color(car, "White");
//        car = new RimCar(car, "8 Star");
//        car = new Audio(car, "Pioneer");

//        car.Add();



//        Console.WriteLine("End");
//    }

//    public class BasicCar : FeatureComponent
//    {
//        public override void Add()
//        {
//            Console.WriteLine("Basic Car");
//        }
//    }

//    public abstract class FeatureComponent
//    {
//        public abstract void Add();

//    }


//    public abstract class FeatureDecorator : FeatureComponent
//    {
//        protected FeatureComponent _featureComponent;

//        public FeatureDecorator(FeatureComponent featureComponent)
//        {
//            _featureComponent = featureComponent;
//        }

//        public override void Add()
//        {
//            _featureComponent.Add();
//        }
//    }



//    public class Color : FeatureDecorator
//    {
//        string _value;
//        public Color(FeatureComponent featureComponent, string value) : base(featureComponent)
//        {
//            this._value = value;
//        }
//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"{_value} Color");
//        }
//    }


//    public class Audio : FeatureDecorator
//    {
//        string _value;
//        public Audio(FeatureComponent featureComponent, string value) : base(featureComponent)
//        {
//            this._value = value;
//        }
//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"{_value} Audio");

//        }

//    }


//    public class RimCar : FeatureDecorator
//    {
//        string _value;
//        public RimCar(FeatureComponent featureComponent, string value) : base(featureComponent)
//        {
//            this._value = value;
//        }
//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"{_value} RimCar");
//        }
//    }

//}



