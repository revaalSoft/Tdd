//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        Vegetables veg = new Vegetables();

//        veg.Add("vegetable one");
//        veg.Add("vegetable two");


//        Fruits fruit = new Fruits();
//        fruit.Add("apple");



//        fruit.AddRange(veg);
//        fruit.AddRange(veg);
//        fruit.AddRange(fruit);


//        fruit.FillList();


//        Console.WriteLine("End");
//    }


//    public abstract class StoreManagement
//    {
//        string _type;
//        public StoreManagement() { }

//        public string TypeFile(string type)
//        {
//            this._type = type;
//            if (type.Contains("veg"))
//            {
//                return "Vegetables";
//            }
//            else
//            {
//                return "Fruit";
//            }
//        }

//        public abstract string GetDetail();

//        public abstract bool IsVegetables();

//        public abstract void Add(string name);

//        public abstract void Remove(string name);

//        public abstract void AddRange(StoreManagement storeManagement);
//    }

//    public class Vegetables : StoreManagement
//    {
//        List<StoreManagement> list = new List<StoreManagement>();
//        public override void Add(string name)
//        {
//            Console.WriteLine(name + " : Is Vegetables added in store");
//        }

//        public override void AddRange(StoreManagement storeManagement)
//        {
//            list.Add(storeManagement);

//        }

//        public override void Remove(string name)
//        {
//            Console.WriteLine(name + " : Is Vegetables remove in store");
//        }

//        public string GetName()
//        {
//            return "Vegetables";
//        }

//        public override bool IsVegetables()
//        {
//            return true;
//        }

//        public override string GetDetail()
//        {
//            return "Vegetables";
//        }
//    }

//    public class Fruits : StoreManagement
//    {
//        List<StoreManagement> list = new List<StoreManagement>();

//        public override void Add(string name)
//        {
//            Console.WriteLine(name + " : Is Fruits added in store");
//        }

//        public override void AddRange(StoreManagement storeManagement)
//        {
//            list.Add(storeManagement);
//        }



//        public void FillList()
//        {

//            if (list.Count != 0)
//            {

//                string inputs = "";

//                foreach (StoreManagement store in list)
//                {

//                    if (inputs.Length == 0)
//                    {

//                        inputs = store.GetDetail();

//                    }
//                    else
//                    {

//                        inputs = inputs + " , " + store.GetDetail();

//                    }

//                    if (store.IsVegetables())
//                    {

//                        inputs = inputs + " *** , ";

//                    }
//                    else
//                    {
//                        inputs = inputs + " --- , ";
//                    }

//                }
//                Console.WriteLine("All  = " + inputs);

//            }
//        }

//        public override string GetDetail()
//        {
//            return "Fruits";
//        }

//        public override bool IsVegetables()
//        {
//            return false;
//        }

//        public override void Remove(string name)
//        {
//            Console.WriteLine(name + " : Is Fruits remove in store");
//        }
//    }
//}



