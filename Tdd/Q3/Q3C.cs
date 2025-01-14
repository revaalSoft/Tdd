//using System;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");
//        var status = new StatusOrder();


//        var viewer1 = new Viewer("hasan");
//        var viewer2 = new Viewer("ali");


//        status.Attach(viewer1);
//        status.Attach(viewer2);


//        status.Processing();
//        status.Sending();
//        status.Delivery();


//        Console.WriteLine("End");
//    }


//    public interface IViewer
//    {
//        void Update(string message);
//    }


//    public interface IStatusOrder
//    {
//        public void Attach(IViewer viewer);
//        public void Detach(IViewer viewer);
//        public void Notify();
//    }

//    public class StatusOrder : IStatusOrder
//    {
//        private List<IViewer> _viewers = new List<IViewer>();
//        private string _operation = "";
//        public void Processing()
//        {
//            _operation = "processing";
//            Notify();
//        }

//        public void Sending()
//        {
//            _operation = "sending";
//            Notify();
//        }

//        public void Delivery()
//        {
//            _operation = "delivery";
//            Notify();
//        }

//        public void Attach(IViewer viewer)
//        {
//            _viewers.Add(viewer);
//        }

//        public void Detach(IViewer viewer)
//        {
//            _viewers.Remove(viewer);
//        }

//        public void Notify()
//        {
//            foreach (var viewer in _viewers)
//            {
//                viewer.Update($"Order status changed to: {_operation}");
//            }
//        }
//    }

//    public class Viewer : IViewer
//    {

//        private string _username;

//        public Viewer(string username)
//        {
//            _username = username;
//        }

//        public void Update(string message)
//        {
//            Console.WriteLine($"Notification for {_username}: {message}");
//        }


//    }


//}



