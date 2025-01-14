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

//            var tranaction = new Transaction();

//            ICommand depost = new DepositCommand(tranaction);
//            ICommand pick = new PickedCommand(tranaction);
//            ICommand move = new MovedCommand(tranaction);


//            var remoteControl = new RemoteControl();

//            remoteControl.ExecuteCommand(depost);
//            remoteControl.ExecuteCommand(pick);
//            remoteControl.ExecuteCommand(move);


//            remoteControl.UndoLastCommand();
//            remoteControl.UndoLastCommand();
//            remoteControl.UndoLastCommand();


//            Console.WriteLine("End");
//        }
//    }
//    public interface ICommand
//    {
//        void Execute();
//        void Cancel();
//    }




//    public class Transaction
//    {
//        public void Deposit()
//        {

//            Console.WriteLine("Transaction is Deposit");

//        }
//        public void Picked()
//        {

//            Console.WriteLine("Transaction is Picked");
//        }

//        public void Moved()
//        {

//            Console.WriteLine("Transaction is Moved");
//        }

//    }

//    public class DepositCommand : ICommand
//    {
//        private readonly Transaction _transaction;

//        public DepositCommand(Transaction transaction)
//        {
//            _transaction = transaction;
//        }

//        public void Execute()
//        {
//            _transaction.Deposit();
//        }

//        public void Cancel()
//        {
//            Console.WriteLine("Undo Command = Cancel");
//        }
//    }


//    public class PickedCommand : ICommand
//    {
//        private readonly Transaction _transaction;

//        public PickedCommand(Transaction transaction)
//        {
//            _transaction = transaction;
//        }

//        public void Execute()
//        {
//            _transaction.Picked();
//        }

//        public void Cancel()
//        {
//            Console.WriteLine("Undo Command = Cancel");
//        }
//    }


//    public class MovedCommand : ICommand
//    {
//        private readonly Transaction _transaction;

//        public MovedCommand(Transaction transaction)
//        {
//            _transaction = transaction;
//        }

//        public void Execute()
//        {
//            _transaction.Moved();
//        }

//        public void Cancel()
//        {
//            Console.WriteLine("Undo Command = Cancel");
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
//                Console.WriteLine("index = " + ((_commandList.Count - 1) - countUndo));
//                _commandList[(_commandList.Count - 1) - countUndo].Cancel();
//                countUndo++;

//            }
//            else
//            {
//                Console.WriteLine("No commands to undo.");
//            }
//        }
//    }



//}
