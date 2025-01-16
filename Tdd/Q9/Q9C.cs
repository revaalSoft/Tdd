//using System;

//namespace SmartDeviceStatePattern
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Start");
//            SmartDevice lamp = new SmartDevice();


//            lamp.TurnOn();
//            lamp.WaitForCommand();
//            lamp.TurnOff();
//            lamp.TurnOn();
//            lamp.TurnOff();

//            Console.WriteLine("End");
//        }
//    }


//    public interface IDeviceState
//    {
//        void TurnOn();
//        void TurnOff();
//        void WaitForCommand();
//    }


//    public class OnState : IDeviceState
//    {
//        private readonly SmartDevice _device;

//        public OnState(SmartDevice device)
//        {
//            _device = device;
//        }

//        public void TurnOn()
//        {
//            Console.WriteLine("Device is already ON.");
//        }

//        public void TurnOff()
//        {
//            Console.WriteLine("Turning OFF the device...");
//            _device.SetState(_device.OffState);
//        }

//        public void WaitForCommand()
//        {
//            Console.WriteLine("Switching to WAITING state...");
//            _device.SetState(_device.WaitingState);
//        }
//    }


//    public class OffState : IDeviceState
//    {
//        private readonly SmartDevice _device;

//        public OffState(SmartDevice device)
//        {
//            _device = device;
//        }

//        public void TurnOn()
//        {
//            Console.WriteLine("Turning ON the device...");
//            _device.SetState(_device.OnState);
//        }

//        public void TurnOff()
//        {
//            Console.WriteLine("Device is already OFF.");
//        }

//        public void WaitForCommand()
//        {
//            Console.WriteLine("Cannot switch to WAITING state while the device is OFF.");
//        }
//    }


//    public class WaitingState : IDeviceState
//    {
//        private readonly SmartDevice _device;

//        public WaitingState(SmartDevice device)
//        {
//            _device = device;
//        }

//        public void TurnOn()
//        {
//            Console.WriteLine("Cannot turn ON while waiting for a command. Switching to ON state...");
//            _device.SetState(_device.OnState);
//        }

//        public void TurnOff()
//        {
//            Console.WriteLine("Turning OFF the device from WAITING state...");
//            _device.SetState(_device.OffState);
//        }

//        public void WaitForCommand()
//        {
//            Console.WriteLine("Device is already in WAITING state.");
//        }
//    }


//    public class SmartDevice
//    {
//        public IDeviceState OnState { get; }
//        public IDeviceState OffState { get; }
//        public IDeviceState WaitingState { get; }

//        private IDeviceState _currentState;

//        public SmartDevice()
//        {
//            OnState = new OnState(this);
//            OffState = new OffState(this);
//            WaitingState = new WaitingState(this);

//            _currentState = OffState;
//        }

//        public void SetState(IDeviceState state)
//        {
//            _currentState = state;
//        }

//        public void TurnOn()
//        {
//            _currentState.TurnOn();
//        }

//        public void TurnOff()
//        {
//            _currentState.TurnOff();
//        }

//        public void WaitForCommand()
//        {
//            _currentState.WaitForCommand();
//        }
//    }



//}
