//using System;

//namespace Tdd
//{
//    public sealed class Database
//    {
//        string _name, _lastName;
//        private Database() { }

//        public static Database _database;

//        public static Database DefineDatabase()
//        {
//            if (_database == null)
//            {
//                Console.WriteLine("Database does not exist; now creating it.");
//                _database = new Database();
//            }
//            else
//            {
//                Console.WriteLine("Database already exists.");
//            }

//            return _database;
//        }

//        public string AddDatabase(string name, string lastName)
//        {
//            Console.WriteLine($"{name} {lastName} added.");
//            return name;
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            string name1 = "Ali";
//            string lastName1 = "Gholami";

//            string name2 = "Mamad";
//            string lastName2 = "Hasani";

//            string name3 = "Josef";
//            string lastName3 = "Oohh";

//            Database database = Database.DefineDatabase();
//            Database database2 = Database.DefineDatabase();

//            database.AddDatabase(name1, lastName1);
//            database.AddDatabase(name2, lastName2);
//            database2.AddDatabase(name3, lastName3);
//        }
//    }
//}
