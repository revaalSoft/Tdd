//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");


//        OrderComponent order = new BasicOrder();


//        order = new Warranty(order, "2-Year Warranty");
//        order = new GiftWrap(order, "Luxury Gift Wrap");
//        order = new ExpressDelivery(order, "Same-Day Delivery");


//        order.Add();

//        Console.WriteLine("End");
//    }


//    public class BasicOrder : OrderComponent
//    {
//        public override void Add()
//        {
//            Console.WriteLine("Basic Order");
//        }
//    }


//    public abstract class OrderComponent
//    {
//        public abstract void Add();
//    }


//    public abstract class OrderDecorator : OrderComponent
//    {
//        protected OrderComponent _orderComponent;

//        public OrderDecorator(OrderComponent orderComponent)
//        {
//            _orderComponent = orderComponent;
//        }

//        public override void Add()
//        {
//            _orderComponent.Add();
//        }
//    }


//    public class Warranty : OrderDecorator
//    {
//        string _value;
//        public Warranty(OrderComponent orderComponent, string value) : base(orderComponent)
//        {
//            _value = value;
//        }

//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"Added: {_value}");
//        }
//    }


//    public class GiftWrap : OrderDecorator
//    {
//        string _value;
//        public GiftWrap(OrderComponent orderComponent, string value) : base(orderComponent)
//        {
//            _value = value;
//        }

//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"Added: {_value}");
//        }
//    }


//    public class ExpressDelivery : OrderDecorator
//    {
//        string _value;
//        public ExpressDelivery(OrderComponent orderComponent, string value) : base(orderComponent)
//        {
//            _value = value;
//        }

//        public override void Add()
//        {
//            base.Add();
//            Console.WriteLine($"Added: {_value}");
//        }
//    }
//}
