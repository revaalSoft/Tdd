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
//        access.ReadData(5);
//        access.ReadData(6);

//        Console.WriteLine("End");
//    }



//    public interface IFile
//    {
//        void ReadData(int id);
//    }


//    public class File : IFile
//    {
//        public void ReadData(int id)
//        {
//            Console.WriteLine("hello user With id " + id + " you have Access To Read File");
//        }
//    }

//    public class AccessFile : IFile
//    {
//        File _file;
//        public AccessFile(File file)
//        {
//            _file = file;
//        }
//        public void ReadData(int id)
//        {
//            if (HaveAccess(id))
//            {

//                _file.ReadData(id);
//            }
//            else
//            {
//                Console.WriteLine("You have not Permission user with id : " + id);
//            }
//        }

//        private bool HaveAccess(int id)
//        {
//            if (id == 6)
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



