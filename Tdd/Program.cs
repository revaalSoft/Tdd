using System;
using System.ComponentModel;
using System.Transactions;
using System.Xml.Linq;
using static Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start");

        System system = new System(new Tejarat());
        system.Login("tejarat");
        system.Doing();


        System system2 = new System(new Meli());
        system2.Login("meli");
        system2.Success();

        Console.WriteLine("End");
    }



    public class System
    {

        private Payment _payment;

        public System(Payment payment)
        {
            _payment = payment;
        }

        public void Login(string tranactionName)
        {
            Console.WriteLine($"{tranactionName}" + " Login ");
        }

        public void Success()
        {
            _payment.Payment_One();
        }
        public void NotSuccess()
        {
            _payment.Payment_Two();
        }
        public void Doing()
        {
            _payment.Payment_Three();
        }


    }

    public abstract class Payment
    {
        //Success
        public abstract void Payment_One();

        //not
        public abstract void Payment_Two();

        //doing
        public abstract void Payment_Three();
    }

    public class Tejarat : Payment
    {
        public override void Payment_One()
        {
            Console.WriteLine("Tejarat :  Success ");
        }

        public override void Payment_Three()
        {
            Console.WriteLine("Tejarat :  Doing ");
        }

        public override void Payment_Two()
        {
            Console.WriteLine("Tejarat :  UnSuccess ");
        }
    }

    public class Meli : Payment
    {
        public override void Payment_One()
        {
            Console.WriteLine("Meli :  Success ");
        }

        public override void Payment_Three()
        {
            Console.WriteLine("Meli :  Doing ");
        }

        public override void Payment_Two()
        {
            Console.WriteLine("Meli :  UnSuccess ");
        }
    }


}



