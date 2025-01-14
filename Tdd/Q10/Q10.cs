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

//        File file = new File();
//        AccessFile access = new AccessFile(file);
//        access.ReadData("admin");
//        access.ReadData("ali");

//        Console.WriteLine("End");
//    }



//    public interface IFile
//    {
//        void ReadData(string username);
//    }


//    public class File : IFile
//    {
//        public void ReadData(string username)
//        {
//            Console.WriteLine("hello " + username + " you have Access To Read File");
//        }
//    }

//    public class AccessFile : IFile
//    {
//        File _file;
//        public AccessFile(File file)
//        {
//            _file = file;
//        }
//        public void ReadData(string username)
//        {
//            if (HaveAccess(username))
//            {
//                _file.ReadData(username);
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



