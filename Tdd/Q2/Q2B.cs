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
//            Vehcile vehicle = new Vehcile();
//            vehicle.Make(1000);
//            vehicle.Make(1800);
//            vehicle.Make(4100);
//            vehicle.Make(2900);

//            Console.WriteLine("End");
//        }
//    }

//    //Make Tire

//    public interface MakeVehcile
//    {
//        public string MakeVehcile();
//    }


//    public class MakeVehcileBicycle : MakeVehcile
//    {
//        public string MakeVehcile()
//        {
//            Console.WriteLine("Bicycle Create");
//            return "Bicycle Create";
//        }
//    }

//    public class MakeVehcileCar : MakeVehcile
//    {
//        public string MakeVehcile()
//        {
//            Console.WriteLine("Car Create");
//            return "Car Create";
//        }
//    }

//    public class MakeVehcileBus : MakeVehcile
//    {
//        public string MakeVehcile()
//        {
//            Console.WriteLine("Bus Create");
//            return "Bus Create";
//        }
//    }


//    public class MakeVehcileMotor : MakeVehcile
//    {
//        public string MakeVehcile()
//        {
//            Console.WriteLine("Motor Create");
//            return "Motor Create";
//        }
//    }


//    // Enter

//    public class Vehcile
//    {
//        private MakeVehcile _makeVehicle;
//        public Vehcile() { }

//        public void Make(int distance)
//        {
//            if (distance <= 1000)
//            {
//                _makeVehicle = new MakeVehcileBicycle();

//            }

//            else if (distance <= 2000)
//            {
//                _makeVehicle = new MakeVehcileMotor();

//            }

//            else if (distance <= 3000)
//            {
//                _makeVehicle = new MakeVehcileCar();

//            }

//            else
//            {

//                _makeVehicle = new MakeVehcileBus();

//            }
//            _makeVehicle.MakeVehcile();
//            Result();
//        }


//        public MakeVehcile Result()
//        {
//            return _makeVehicle;
//        }

//    }

//}
