//using System;
//using System.ComponentModel;
//using System.Xml.Linq;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Start");

//        Status status = new Status();
//        Turn turn = new Turn();
//        turn.TurnOn();
//        status.Turn(turn);
//        status.Change("3");
//        status.Operation();

//        Setting setting = new Setting();
//        setting.ChangeSetting("Zoom", "out");

//        status.Turn(new Turn());

//        Console.WriteLine("End");
//    }



//    public interface IStatus
//    {
//        void Turn(Turn turn);
//        void Change(string command);
//    }

//    public interface ISetting
//    {
//        void ChangeSetting(string name, string value);
//    }


//    public class Status : IStatus
//    {
//        public string _command;
//        public Turn _turn;

//        public void Change(string command)
//        {
//            this._command = command;
//            Console.WriteLine("We Want Go to channel " + command);
//        }

//        public void Turn(Turn turn)
//        {
//            this._turn = turn;

//        }

//        public void Operation()
//        {
//            Console.WriteLine("now We in chanel " + _command);
//        }

//    }

//    public class Setting : ISetting
//    {
//        public void ChangeSetting(string name, string value)
//        {
//            Console.WriteLine("Setting is for : " + name + " and is value is " + value);
//        }
//    }


//    public class Turn
//    {

//        public void TurnOn()
//        {
//            Console.WriteLine(" Tv is turn on ");
//        }

//        public void TurnOff()
//        {
//            Console.WriteLine(" Tv is turn off ");
//        }

//    }


//}



