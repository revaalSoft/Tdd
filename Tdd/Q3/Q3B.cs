//using System;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");
//        var message = new Message();


//        message.AddMessage();
//        IViewer admin = new Admin(message);
//        IViewer manager = new Manager(message);
//        admin.NotificationMesssage();
//        manager.NotificationMesssage();

//        message.RemoveMessage();
//        manager.NotificationMesssage();


//        Console.WriteLine("End");
//    }


//    public interface IViewer
//    {
//        public void NotificationMesssage();
//    }


//    public interface IMessage
//    {
//        public void RemoveMessage();
//        public void AddMessage();

//    }

//    public class Message : IMessage
//    {
//        string operation = "";

//        public void AddMessage()
//        {
//            operation = "Add";
//            Console.WriteLine("Add Message");
//        }

//        public void RemoveMessage()
//        {
//            operation = "remove";
//            Console.WriteLine("Remove Message");
//        }

//        public string Result()
//        {

//            return operation;

//        }
//    }

//    public class Admin : IViewer
//    {
//        Message _message;
//        public Admin(Message message)
//        {
//            this._message = message;
//        }


//        void IViewer.NotificationMesssage()
//        {
//            string operation = _message.Result();
//            Console.WriteLine("admin Give " + operation + " message Notif ");
//        }

//    }



//    public class Manager : IViewer
//    {
//        Message _message;
//        public Manager(Message message)
//        {
//            this._message = message;
//        }


//        void IViewer.NotificationMesssage()
//        {
//            string operation = _message.Result();
//            Console.WriteLine("Manager Give " + operation + " message Notif ");
//        }

//    }


//}



