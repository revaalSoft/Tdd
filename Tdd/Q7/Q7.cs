//using System;
//using System.ComponentModel;
//using System.Xml.Linq;
//using static Program;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        FillName fillName = new FillName();
//        fillName.GetvaluePercent(26, "user");

//        User user = new User(fillName);
//        user.addField("age");

//        fillName.GetvaluePercent(28, "admin");
//        Admin admin = new Admin(fillName);
//        admin.addField("age");

//        Console.WriteLine("End");
//    }


//    public interface Database
//    {
//        public void addField(string name);

//    }


//    public class FillName()
//    {
//        public int GetvaluePercent(int ageYear, string nameTable)
//        {

//            int days = ageYear * 365;
//            Console.WriteLine("i want add " + days + " to age column in " + nameTable + " table Please add Age and add value");
//            return days;
//        }
//    }

//    public class User : Database
//    {
//        public FillName _fillname;
//        public string _name;
//        public User(FillName fillName)
//        {
//            this._fillname = fillName;
//        }
//        public void addField(string name)
//        {
//            this._name = name;
//            Console.WriteLine("in Table user add " + name + " column and value");
//        }


//    }


//    public class Admin : Database
//    {
//        public FillName _fillname;
//        public string _name;
//        public Admin(FillName fillName)
//        {
//            this._fillname = fillName;
//        }
//        public void addField(string name)
//        {
//            this._name = name;
//            Console.WriteLine("in Table Admin add " + name + " column ");
//        }


//    }

//}



