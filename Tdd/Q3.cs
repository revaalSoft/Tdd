//using System;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");
//        var message = new Message();
//        var viewer1 = new Viewer1();
//        var viewer2 = new Viewer2();

//        message.AddMessage(viewer1);
//        message.NotificationMesssage(0, "ali");
//        message.ShowUserName(true);

//        message.AddMessage(viewer2);
//        message.NotificationMesssage(1, "hasan");
//        message.ShowUserName(false);
//        Console.WriteLine("End");
//    }


//    public interface IViewer
//    {
//        void Update(IMessage _iMessage, int State, string username);
//    }


//    public interface IMessage
//    {
//        public void RemoveMessage(IViewer viewer);
//        public void AddMessage(IViewer viewer);
//        public void NotificationMesssage(int state, string username);
//    }

//    public class Message : IMessage
//    {
//        private List<IViewer> _viewer = new List<IViewer>();

//        string _username;
//        public void NotificationMesssage(int state, string username)
//        {
//            _username = username;
//            Console.WriteLine("Message update");

//            foreach (var viewer in _viewer)
//            {
//                viewer.Update(this, state, username);
//            }
//        }

//        public void ShowUserName(bool IsOffline)
//        {


//            if (IsOffline)
//            {

//                Console.WriteLine(_username + " isOffline ");

//            }
//            else
//            {

//                Console.WriteLine(_username + " isOnline ");

//            }

//        }

//        public void AddMessage(IViewer viewer)
//        {
//            _viewer.Add(viewer);
//        }

//        public void RemoveMessage(IViewer viewer)
//        {
//            _viewer.Remove(viewer);
//        }

//    }

//    public class Viewer1 : IViewer
//    {
//        public void Update(IMessage _iMessage, int State, string username)
//        {
//            if (State == 0)
//            {

//                Console.WriteLine("Message Remove From User = " + username);

//            }
//        }
//    }

//    public class Viewer2 : IViewer
//    {
//        public void Update(IMessage _iMessage, int State, string username)
//        {
//            Console.WriteLine("Message Add From User = " + username);
//        }
//    }

//}



