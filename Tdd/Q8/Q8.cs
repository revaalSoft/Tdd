//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        File file = new File();
//        File file2 = new File();
//        file.Add("C", "test.jpg");
//        Console.WriteLine("file is = " + file.TypeFile("test.jpg"));
//        file2.Add("D", "test.txt");
//        Console.WriteLine("file is = " + file2.TypeFile("test.txt"));

//        Directory directory = new Directory();
//        directory.Add("Personal", "");
//        Console.WriteLine("File is = " + directory.TypeFile("Personal"));



//        directory.AddRange(file);
//        directory.AddRange(file2);
//        directory.AddRange(directory);


//        directory.FillList();

//        file2.Remove("D", "test.txt");

//        Console.WriteLine("End");
//    }


//    public abstract class SystemManagement
//    {
//        public SystemManagement() { }

//        public string TypeFile(string suffix)
//        {
//            if (suffix.Contains(".txt"))
//            {
//                return "text";
//            }
//            else if (suffix.Contains(".jpg"))
//            {
//                return "image";
//            }
//            else
//            {
//                return "Directory";
//            }
//        }

//        public string GetDetail()
//        {
//            return "SystemFile";
//        }

//        public abstract bool IsFile();

//        public abstract void Add(string path, string name);

//        public abstract void Remove(string path, string name);

//        public abstract void AddRange(SystemManagement systemManagement);
//    }

//    public class File : SystemManagement
//    {
//        List<SystemManagement> list = new List<SystemManagement>();
//        public override void Add(string path, string name)
//        {
//            Console.WriteLine("File : " + name + " added in this path : " + path);
//        }

//        public override void AddRange(SystemManagement systemManagement)
//        {
//            list.Add(systemManagement);
//        }

//        public override void Remove(string path, string name)
//        {
//            Console.WriteLine("File : " + name + " remove in this path : " + path);
//        }

//        public string GetName()
//        {
//            return "File";
//        }

//        public override bool IsFile()
//        {
//            return true;
//        }
//    }

//    public class Directory : SystemManagement
//    {
//        List<SystemManagement> list = new List<SystemManagement>();

//        public override void Add(string path, string name)
//        {

//        }

//        public override void AddRange(SystemManagement systemManagement)
//        {
//            list.Add(systemManagement);
//        }



//        public void FillList()
//        {

//            if (list.Count != 0)
//            {

//                string allDirectory = "";

//                foreach (SystemManagement systemManagement in list)
//                {

//                    if (allDirectory.Length == 0)
//                    {


//                        allDirectory = systemManagement.GetDetail();

//                    }
//                    else
//                    {

//                        allDirectory = allDirectory + " , " + systemManagement.GetDetail();

//                    }

//                    if (systemManagement.IsFile())
//                    {

//                        allDirectory = allDirectory + "****";

//                    }
//                    else
//                    {
//                        allDirectory = allDirectory + "----";
//                    }

//                }
//                Console.WriteLine("AllDirectory = " + allDirectory);

//            }
//        }

//        public string GetName()
//        {
//            return "Directory";
//        }

//        public override bool IsFile()
//        {
//            return false;
//        }

//        public override void Remove(string path, string name)
//        {
//            Console.WriteLine("Directory : " + name + " remove in this path : " + path);
//        }
//    }
//}



