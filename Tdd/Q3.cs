//using System;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");
//        var message = new Message();
//        var viewer1 = new Viewer1(1, "ali");
//        var viewer2 = new Viewer2(0, "hasan");

//        message.AddMessage(viewer1);
//        message.AddMessage(viewer2);
//        message.NotificationMesssage();
//        //     message.ShowUserName(true);

//        Console.Write("/////////////////////////// \n");


//        //      message.ShowUserName(false);

//        Console.WriteLine("End");
//    }


//    public interface IViewer
//    {
//        void Update(IMessage _iMessage);
//        void ShowStatus();
//    }


//    public interface IMessage
//    {
//        public void RemoveMessage(IViewer viewer);
//        public void AddMessage(IViewer viewer);
//        public void NotificationMesssage();
//    }

//    public class Message : IMessage
//    {
//        private List<IViewer> _viewer = new List<IViewer>();
//        string _username;

//        public void NotificationMesssage()
//        {


//            foreach (var viewer in _viewer)
//            {
//                viewer.Update(this);
//                ShowStatus(viewer);
//            }
//        }

//        public void ShowStatus(IViewer viewer)
//        {
//            viewer.ShowStatus();
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
//        int _state;
//        string _username;
//        public Viewer1(int state, string username)
//        {
//            _state = state;
//            _username = username;
//        }
//        public void Update(IMessage _iMessage)
//        {
//            Console.WriteLine("Message update For " + _username);
//            if (_state == 0)
//            {

//                Console.WriteLine("Message Remove From User = " + _username);

//            }
//            else if (_state == 1)
//            {

//                Console.WriteLine("Message Add From User = " + _username);

//            }
//        }
//        public void ShowStatus()
//        {
//            Console.WriteLine(_username + " Message Seen");
//        }


//    }

//    public class Viewer2 : IViewer
//    {
//        int _state;
//        string _username;
//        public Viewer2(int state, string username)
//        {
//            _state = state;
//            _username = username;
//        }
//        public void Update(IMessage _iMessage)
//        {
//            Console.WriteLine("Message update For " + _username);
//            if (_state == 0)
//            {

//                Console.WriteLine("Message Remove From User = " + _username);

//            }
//            else if (_state == 1)
//            {

//                Console.WriteLine("Message Add From User = " + _username);

//            }
//        }
//        public void ShowStatus()
//        {
//            Console.WriteLine(_username + " Message Seen");
//        }
//    }

//}



