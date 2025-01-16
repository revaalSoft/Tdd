//using System;
//using System.Collections.Generic;


//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.WriteLine("Start");
//        User admin = new User("Admin", Role.Admin);
//        User regularUser = new User("ali", Role.RegularUser);



//        IDatabase proxyDatabase = new ProxyDatabase();


//        proxyDatabase.GetData(admin);
//        proxyDatabase.GetData(regularUser);



//        Console.WriteLine("End");
//    }
//}

//public interface IDatabase
//{
//    string GetData(User user);
//}

//public class RealDatabase : IDatabase
//{
//    public string GetData(User user)
//    {
//        return "";
//    }
//}


//public class ProxyDatabase : IDatabase
//{
//    private readonly RealDatabase _realDatabase = new RealDatabase();

//    public string GetData(User user)
//    {
//        if (user.Role == Role.Admin)
//        {
//            Console.WriteLine("Access All");
//            return "all";
//        }
//        else
//        {
//            Console.WriteLine("Access Public");
//            return "public";
//        }

//    }
//}


//public enum Role
//{
//    Admin,
//    RegularUser,
//}


//public class User
//{
//    public string Name { get; set; }
//    public Role Role { get; set; }

//    public User(string name, Role role)
//    {
//        Name = name;
//        Role = role;
//    }
//}



