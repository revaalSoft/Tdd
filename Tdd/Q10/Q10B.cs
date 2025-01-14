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

//        DataBase database = new DataBase();
//        AccessDatabase access = new AccessDatabase(database);
//        access.ReadData("admin");
//        access.ReadData("ali");

//        Console.WriteLine("End");
//    }



//    public interface IReadDatabase
//    {
//        void ReadData(string username);
//    }


//    public class DataBase : IReadDatabase
//    {
//        public void ReadData(string username)
//        {
//            Console.WriteLine("hello " + username + " you have Access To Read File");
//        }
//    }

//    public class AccessDatabase : IReadDatabase
//    {
//        IReadDatabase _readDatabase;
//        public AccessDatabase(IReadDatabase readDatabase)
//        {
//            _readDatabase = readDatabase;
//        }
//        public void ReadData(string username)
//        {
//            if (HaveAccess(username))
//            {
//                _readDatabase.ReadData(username);
//            }
//            else
//            {
//                Console.WriteLine("hello " + username + " you have Not Access To Read File");
//            }
//        }

//        private bool HaveAccess(string username)
//        {
//            if (username == "admin")
//            {
//                return true;
//            }
//            else
//            {

//                return false;
//            }
//        }
//    }

//}



