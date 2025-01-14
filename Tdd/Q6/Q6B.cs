//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tdd
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Start");

//            var light = new Light();

//            ICommand lightOnCommand = new LightOnCommand(light);
//            ICommand lightOffCommand = new LightOffCommand(light);

//            var remoteControl = new RemoteControl();

//            remoteControl.ExecuteCommand(lightOnCommand);
//            remoteControl.ExecuteCommand(lightOffCommand);


//            remoteControl.UndoLastCommand();
//            remoteControl.UndoLastCommand();


//            Console.WriteLine("End");
//        }
//    }
//    public interface ICommand
//    {
//        void Execute();
//        void Undo();
//    }

//    public class Light
//    {
//        public void TurnOn()
//        {

//            Console.WriteLine("Light is ON");

//        }
//        public void TurnOff()
//        {

//            Console.WriteLine("Light is OFF");
//        }
//    }

//    public class LightOnCommand : ICommand
//    {
//        private readonly Light _light;

//        public LightOnCommand(Light light)
//        {
//            _light = light;
//        }

//        public void Execute()
//        {
//            _light.TurnOn();
//        }

//        public void Undo()
//        {
//            Console.WriteLine("Undo LightOn Command = ");
//            _light.TurnOff();
//        }
//    }

//    public class LightOffCommand : ICommand
//    {
//        private readonly Light _light;

//        public LightOffCommand(Light light)
//        {
//            _light = light;
//        }

//        public void Execute()
//        {
//            _light.TurnOff();
//        }

//        public void Undo()
//        {
//            Console.WriteLine("Undo LightOff Command = ");
//            _light.TurnOn();
//        }
//    }
//    public class RemoteControl
//    {
//        private readonly List<ICommand> _commandList = new();
//        int countUndo = 0;

//        public void ExecuteCommand(ICommand command)
//        {
//            command.Execute();
//            _commandList.Add(command);
//        }

//        public void UndoLastCommand()
//        {

//            if (_commandList.Count > 0)
//            {

//                _commandList[(_commandList.Count - 1) - countUndo].Undo();
//                countUndo++;

//            }
//            else
//            {
//                Console.WriteLine("No commands to undo.");
//            }
//        }
//    }



//}
