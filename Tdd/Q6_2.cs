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
//        Setting setting = new Setting();


//        Tv tv = new Tv(status, turn, setting);
//        tv.Turn(true);
//        tv.ChangeChannl("3");
//        tv.ChangeSetting("Zoom", "out");
//        tv.Turn(false);


//        //Status status = new Status();

//        //Turn turn = new Turn();
//        //turn.TurnOn();

//        //status.Turn(turn);
//        //status.Change("3");
//        //status.Operation();

//        //Setting setting = new Setting();
//        //setting.ChangeSetting("Zoom", "out");

//        //turn.TurnOff();

//        //status.Turn(turn);

//        Console.WriteLine("End");
//    }

//    public class Tv
//    {
//        Turn _turn;
//        Status _status;
//        Setting _setting;
//        public Tv(Status status, Turn turn, Setting setting)
//        {

//            _status = status;
//            _turn = turn;
//            _setting = setting;

//        }

//        public void Turn(bool on)
//        {

//            if (on)
//            {
//                _turn.TurnOn();
//            }
//            else
//            {
//                _turn.TurnOff();
//            }
//            _status.Turn(_turn);
//        }
//        public void ChangeChannl(string channel)
//        {
//            _status.Change(channel);
//            _status.Operation();
//        }

//        public void ChangeSetting(string name, string value)
//        {
//            _setting.ChangeSetting(name, value);

//        }


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
//            Console.WriteLine("Setting is for " + name + " \n now " + name + value);
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



