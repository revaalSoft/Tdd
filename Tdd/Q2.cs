//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tdd
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Start");
//            Vehcile vehcileBicycle = new Bicycle();
//            Vehcile vehcileMotor = new Motor();
//            Vehcile vehcileCar = new Car();

//            string textResult = "";

//            vehcileBicycle.MakeMethod();
//            textResult = vehcileBicycle.SomeOperation("bicycle", 3);
//            Console.WriteLine(textResult);

//            vehcileMotor.MakeMethod();
//            textResult = vehcileMotor.SomeOperation("motor", 2);
//            Console.WriteLine(textResult);

//            vehcileCar.MakeMethod();
//            textResult = vehcileCar.SomeOperation("car", 4);
//            Console.WriteLine(textResult);

//            Console.WriteLine("End");
//        }
//    }

//    //Make Tire

//    public interface MakeVehcile
//    {
//        public string MakeVehcile(int Tire);
//    }


//    public class MakeVehcileBicycle : MakeVehcile
//    {
//        public string MakeVehcile(int Tire)
//        {
//            return "Bicycle made and it has " + Tire + " Count ";
//        }
//    }

//    public class MakeVehcileCar : MakeVehcile
//    {
//        public string MakeVehcile(int Tire)
//        {
//            return "Car made and it has " + Tire + " Count ";
//        }
//    }


//    public class MakeVehcileMotor : MakeVehcile
//    {
//        public string MakeVehcile(int Tire)
//        {
//            return "Motor made and it has " + Tire + " Count ";
//        }
//    }


//    // Enter

//    public abstract class Vehcile
//    {

//        public Vehcile() { }
//        public abstract MakeVehcile MakeMethod();

//        public string SomeOperation(string name, int Tire)
//        {
//            var product = MakeMethod();
//            return name + " Is Making \n " + product.MakeVehcile(Tire);
//        }

//    }


//    public class Bicycle : Vehcile
//    {
//        public override MakeVehcile MakeMethod()
//        {
//            return new MakeVehcileBicycle();
//        }

//    }

//    public class Car : Vehcile
//    {
//        public override MakeVehcile MakeMethod()
//        {
//            return new MakeVehcileCar();
//        }
//    }

//    public class Motor : Vehcile
//    {
//        public override MakeVehcile MakeMethod()
//        {
//            return new MakeVehcileMotor();
//        }
//    }
//}
