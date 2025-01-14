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


//        People people = new People();

//        fillName.GetDaysFromYear(28);
//        people.AddUser(fillName);
//        fillName.GetDaysFromYear(26);
//        people.AddAdmin(fillName);

//        Console.WriteLine("End");
//    }

//    public class People
//    {
//        public void AddAdmin(FillName fillName)
//        {
//            Admin admin = new Admin(fillName);
//            admin.addField("age");
//        }

//        public void AddUser(FillName fillName)
//        {
//            User user = new User(fillName);
//            user.addField("age");
//        }

//    }


//    public interface Database
//    {
//        public void addField(string name);

//    }


//    public class FillName()
//    {
//        int days = 0;
//        public void GetDaysFromYear(int age)
//        {
//            days = age * 365;
//        }

//        public int returnDays()
//        {
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
//            int value = _fillname.returnDays();
//            Console.WriteLine(name + " added in User table and days birthday Is : " + value);
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
//            int value = _fillname.returnDays();
//            Console.WriteLine(name + " added in Admin table and days birthday Is : " + value);
//        }

//    }

//}



